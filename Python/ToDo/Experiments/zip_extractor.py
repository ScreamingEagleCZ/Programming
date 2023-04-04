import zipfile
import pathlib


def extract_archive(archivepath, dest_dir):
    """Extract an Archive to destination directory..."""
    with zipfile.ZipFile(archivepath, 'r') as archive:
        # with 'r' we are reading the archive
        archive.extractall(dest_dir)


if __name__ == "__main__":
    extract_archive(archivepath="C:\\Users\\jakub\\OneDrive\\Documents\\GitHub\\Programming\\Python\\ToDo\\Experiments\\compressed.zip",
                    dest_dir="C:\\Users\\jakub\\OneDrive\\Documents\\GitHub\\Programming\\Python\\ToDo\\Experiments\\Files")

