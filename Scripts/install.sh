#!/bin/bash

if [ ! -d "$HOME/cache" ]; then

    mkdir -p -m 777 "$HOME/cache"

fi

echo "Installing pandoc"
make docs-tools

URL="https://download.unity3d.com/download_unity/b5bd171ee9ba/MacEditorInstaller/Unity-2017.4.0f1.pkg"
FILENAME=`basename "$URL"`

if [ ! -f "$HOME/cache/$FILENAME" ]; then

    echo "Downloading Unity"
    curl --retry 5 -o "$HOME/cache/$FILENAME" "$URL"

fi

echo "Installing Unity"
sudo installer -dumplog -package "$HOME/cache/$FILENAME" -target /
