import zipfile
import pathlib


def make_archive(filepaths, dest_dir):
    """Makes a zip file from multiple files to desired directory..."""
    dest_path = pathlib.Path(dest_dir, "compressed.zip")
    with zipfile.ZipFile(dest_path, 'w') as archive:
        # with 'w' we are making the archive
        for filepath in filepaths:
            filepath = pathlib.Path(filepath)
            # converts long path to more usable pathlib object which can be better accessed
            archive.write(filepath, arcname=filepath.name)


if __name__ == "__main__":
    make_archive(filepaths=["while loop.py", "type_webbrowser.py"], dest_dir="dest")
