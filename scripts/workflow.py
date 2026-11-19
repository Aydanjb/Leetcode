import sys
from pathlib import Path
from urllib.parse import urlparse
import json
import requests
from datetime import date
import html2text

SCRIPTS_DIR = Path(__file__).resolve().parent
SOLUTIONS_DIR = SCRIPTS_DIR.parent / "Solutions"
LEETCODE_API_URL = "https://alfa-leetcode-api.onrender.com/select?titleSlug="

ARGS = sys.argv[1:]
problem_url = ARGS[0]

# Parse the Leetcode URL from args and extract the problem slug
parts = urlparse(problem_url).path.strip("/").split("/")
problem_slug = parts[parts.index("problems") + 1]

# Convert problem name to PascalCase and create a new directory in Solutions/ for that problem
problem_name = "".join(word.capitalize() for word in problem_slug.split("-"))
problem_dir = SOLUTIONS_DIR / problem_name
problem_dir.mkdir(parents=True, exist_ok=True)

# Create the solution file
solution_file = problem_dir / f"{problem_name}.cs"
solution_file.touch()

# Get problem metadata from the Leetcode API
url = f"{LEETCODE_API_URL}{problem_slug}"
response = requests.get(url, timeout=60)
response.raise_for_status()
problem_metadata = response.json()

header_comment = f"""// Source: {problem_metadata['link']}
// Author: Aydan Bondurant
// Date: {date.today()}

// Leetcode {problem_metadata['questionFrontendId']}. {problem_metadata['questionTitle']}
// Difficulty: {problem_metadata['difficulty']}
"""

template = f"""namespace Solutions.{problem_name};

{header_comment}
public class Solution {{

}}"""
solution_file.write_text(template, encoding="utf-8")

# Read the README and find the rows of the solutions table (skipping the header and separator)
readme_file = SCRIPTS_DIR.parent / "README.md"
readme_lines = readme_file.read_text(encoding="utf-8").splitlines()

solutions_heading = readme_lines.index("## Solutions")
table_start = next(i for i in range(solutions_heading, len(readme_lines)) if readme_lines[i].startswith("|"))
table_end = table_start
while table_end < len(readme_lines) and readme_lines[table_end].startswith("|"):
    table_end += 1
rows = readme_lines[table_start + 2:table_end]

# Add the new problem, and sort by problem number
problem_number = int(problem_metadata['questionFrontendId'])
solution_path = solution_file.relative_to(SCRIPTS_DIR.parent).as_posix()
new_row = (f"| {problem_number} | [{problem_metadata['questionTitle']}]({problem_metadata['link']}) "
           f"| {problem_metadata['difficulty']} | [C#]({solution_path}) |")

rows = [row for row in rows if int(row.split("|")[1]) != problem_number]
rows.append(new_row)
rows.sort(key=lambda row: int(row.split("|")[1]))
readme_lines[table_start + 2:table_end] = rows

# Update the progress table from the solutions table
difficulties = [row.split("|")[3].strip() for row in rows]
progress_heading = readme_lines.index("## Progress")
progress_row = next(i for i in range(progress_heading, len(readme_lines)) if readme_lines[i].startswith("|")) + 2
readme_lines[progress_row] = (f"| {difficulties.count('Easy')} | {difficulties.count('Medium')} "
                              f"| {difficulties.count('Hard')} | {len(rows)} |")

readme_file.write_text("\n".join(readme_lines) + "\n", encoding="utf-8")
