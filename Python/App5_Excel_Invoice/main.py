import pandas as pd
import glob
from fpdf import FPDF
from pathlib import Path  # for extraction of names from filepaths

filepaths = glob.glob("invoices/*.xlsx")
# print(filepaths)

for filepath in filepaths:
    df = pd.read_excel(filepath, sheet_name="Sheet 1")
    # print(df)
    pdf = FPDF(orientation="P", unit="mm", format="A4")
    pdf.add_page()
    filename = Path(filepath).stem  # extracts name of file from filepath
    invoice_nr = filename.split("-")[0]  # extracts nr from name (only first split from list)
    pdf.set_font(family="Times", size=16, style="B")
    pdf.cell(w=50, h=8, txt=f"Invoice nr. {invoice_nr}")
    pdf.output(f"PDFs/{filename}.pdf")
