#!/bin/bash

PROJECT_DIR="$HOME/projects/forth-python"

if [! -d "$PROJECT_DIR"]; then
    echo "Error: Project directory not found at $PROJECT_DIR"
    exit 1
fi

cd "$PROJECT_DIR" || { echo "Error: Failed to change to project directory."; exit 1; }

echo "Running gforth generate-numbers.fs..."
gforth generate-numbers.fs

echo "Running python analyze.py..."
python analyze.py

echo "Pipeline complete."
