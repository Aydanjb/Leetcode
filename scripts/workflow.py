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

url = f"{LEETCODE_API_URL}{problem_slug}"
response = requests.get(url, timeout=60)
response.raise_for_status()
problem_metadata = response.json()

html_converter = html2text.HTML2Text()
problem_description = html_converter.handle(problem_metadata['question'])

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

# -------------

