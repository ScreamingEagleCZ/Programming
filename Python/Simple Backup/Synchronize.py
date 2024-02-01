from dirsync import sync
# in command line use "py -3 -m pip install dirsync" to install package to
# instll required package to windows

source_path = 'C:\W'
target_path = 'D:\W'

print("Starting synchronization...\nPlease Wait...\n")

sync(source_path, target_path, 'sync', verbose=True) #for syncing one way
# sync(target_path, source_path, 'sync') #for syncing the opposite way

print("Done!!!\n")
input("Press Enter")
