import pandas as pd
import glob
from fpdf import FPDF
from pathlib import Path

filepaths = glob.glob("Text_Files/*.txt")

pdf = FPDF(orientation="P", unit="mm", format="A4")

for filepath in filepaths:
    pdf.add_page()
    filename = Path(filepath).stem  # extracts name
    name = filename.title()
    pdf.set_font(family="Times", size=24, style="B")
    pdf.cell(w=50, h=12, txt=name, ln=1)

    # Add text to files
    with open(filepath, "r") as file:
        content = file.read()
    pdf.set_font(family="Times", size=12)
    pdf.multi_cell(w=0, h=6, txt=content)

# output to pdf
pdf.output("Animals.pdf")



