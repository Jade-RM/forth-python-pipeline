# analyze.py - reads numbers.txt and calculates sum and average

with open("numbers.txt") as f:
	numbers = [int(line.strip()) for line in f if line.strip().isdigit()]

total = sum(numbers)
average = total / len(numbers)

print("Numbers:", numbers)
print("Sum:", total)
print("Average:", average)

