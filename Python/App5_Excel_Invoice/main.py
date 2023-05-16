import pandas as pd
import glob
from fpdf import FPDF
from pathlib import Path  # for extraction of names from filepaths

filepaths = glob.glob("invoices/*.xlsx")
# print(filepaths)

for filepath in filepaths:
    df = pd.read_excel(filepath, sheet_name="Sheet 1")

    pdf = FPDF(orientation="P", unit="mm", format="A4")
    pdf.add_page()

    filename = Path(filepath).stem  # extracts name of file from filepath
    invoice_nr, date = filename.split("-")  # extracts nr from name and date in 2 separate strings from list

    # nr of invoice
    pdf.set_font(family="Times", size=24, style="B")
    pdf.cell(w=50, h=12, txt=f"Invoice nr. {invoice_nr}", ln=1)

    # date of invoice
    pdf.set_font(family="Times", size=20, style="B")
    pdf.cell(w=50, h=12, txt=f"Date {date}", ln=1)



    pdf.output(f"PDFs/{filename}.pdf")
