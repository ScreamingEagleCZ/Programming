from fpdf import FPDF
import pandas as pd

pdf = FPDF(orientation="P", unit="mm", format="A4")
pdf.set_auto_page_break(auto=False, margin=0)

df = pd.read_csv("topics.csv")

total = 0
actual = 1
for index, row in df.iterrows():
    total = total + row["Pages"]

for index, row in df.iterrows():
    pdf.add_page()
    pdf.set_font(family="Times", style="B", size=24)
    pdf.set_text_color(100, 100, 100)
    pdf.cell(w=0, h=12, txt=row["Topic"], align="L", ln=1, border=0)
    pdf.line(x1=10, y1=20, x2=80, y2=20)

    # lines on master page
    for i in range(30, 290, 10):
        pdf.line(x1=10, y1=i, x2=200, y2=i)

    # footer for master page
    pdf.ln(260)
    pdf.set_font(family="Times", style="I", size=10)
    pdf.cell(w=0, h=10, txt=f"{actual} / {total}", align="R")
    actual = actual + 1
    for i in range(row["Pages"] - 1):
        pdf.add_page()

        # lines on auxiliary pages
        for i in range(10, 290, 10):
            pdf.line(x1=10, y1=i, x2=200, y2=i)

        # footer for auxiliary pages
        pdf.ln(272)
        pdf.set_font(family="Times", style="I", size=10)
        pdf.cell(w=0, h=10, txt=f"{actual} / {total}", align="R")
        actual = actual + 1


pdf.output("output.pdf")
