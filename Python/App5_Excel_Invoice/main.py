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

    df = pd.read_excel(filepath, sheet_name="Sheet 1")

    # Add a header
    columns = list(df.columns)
    columns = [item.replace("_", " ").title() for item in columns]  # list comprehension / replace "_" and capital.
    pdf.set_font(family="Times", size=10, style="B")
    pdf.set_text_color(30, 30, 30)
    pdf.cell(w=25, h=8, txt=columns[0], border=1)
    pdf.cell(w=70, h=8, txt=columns[1], border=1)
    pdf.cell(w=35, h=8, txt=columns[2], border=1)
    pdf.cell(w=25, h=8, txt=columns[3], border=1)
    pdf.cell(w=25, h=8, txt=columns[4], border=1, ln=1)

    # Add rows to the table
    for index, row in df.iterrows():
        pdf.set_font(family="Times", size=10)
        pdf.set_text_color(80, 80, 80)
        pdf.cell(w=25, h=8, txt=str(row["product_id"]), border=1)
        pdf.cell(w=70, h=8, txt=str(row["product_name"]), border=1)
        pdf.cell(w=35, h=8, txt=str(row["amount_purchased"]), border=1)
        pdf.cell(w=25, h=8, txt=str(row["price_per_unit"]), border=1)
        pdf.cell(w=25, h=8, txt=str(row["total_price"]), border=1, ln=1)


    pdf.output(f"PDFs/{filename}.pdf")
