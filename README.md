# ValheimBackup
A very simple utility to backup Valheim save Data in C#.

## System Classes Used
**Environment**
- Used to capture the current user to set up proper directory paths.


**DateTime**
- Used to create timestamp on backups.


## Other Namespaces Used

**System.IO**
  - Path
    - Used to extract the current directory the executable is running from.
  - Compression
    - Used for compressing the directory of files.

**System.Reflection**
  - Assembly
    - Also used to help capture where the current executable is running from.

## TODO
- Add Backup Folder location
- Better error handling
- Logging
