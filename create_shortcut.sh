#!/bin/bash

# Usage: ./create_shortcut.sh "Shortcut Name" "/full/path/to/executable" "/full/path/to/icon.png"

NAME="$1"
EXEC="$2"
ICON="$3"

if [ -z "$NAME" ] || [ -z "$EXEC" ]; then
    echo "Usage: $0 \"Shortcut Name\" \"/full/path/to/executable\" \"/full/path/to/icon.png (optional)\""
    exit 1
fi

DESKTOP_FILE="$HOME/.local/share/applications/${NAME// /_}.desktop"

echo "[Desktop Entry]" > "$DESKTOP_FILE"
echo "Version=1.0" >> "$DESKTOP_FILE"
echo "Name=$NAME" >> "$DESKTOP_FILE"
echo "Exec=$EXEC" >> "$DESKTOP_FILE"
if [ -n "$ICON" ]; then
    echo "Icon=$ICON" >> "$DESKTOP_FILE"
fi
echo "Terminal=false" >> "$DESKTOP_FILE"
echo "Type=Application" >> "$DESKTOP_FILE"
echo "Categories=Utility;" >> "$DESKTOP_FILE"

chmod +x "$DESKTOP_FILE"

echo "Shortcut created at $DESKTOP_FILE"
