--Part 1

SELECT column_name, data_type
FROM information_schema.columns
WHERE table_name='jobs';

--Part 2

SELECT * 
FROM techjobs.employers 
WHERE Location = 'St. Louis City';

--Part 3

