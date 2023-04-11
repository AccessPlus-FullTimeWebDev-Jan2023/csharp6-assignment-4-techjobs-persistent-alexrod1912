-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
--Id, Name, and Employer ID are the columns and their respective data types are Int, long text, int. 

--Part 2: Write a query to list the names of the employers in St. Louis City.
--SELECT * FROM techjobs.Employers WHERE Location = 'st. louis';

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.
    --SELECT * FROM techjobs.JobSkills JOIN techjobs.Jobs ON techjobs.JobSkills.JobsId = techjobs.Jobs.Id JOIN techjobs.Skills ON techjobs.JobSkills.SkillsId = techjobs.Skills.Id ORDER BY techjobs.Jobs.EmployerId ASC, techjobs.Skills.SkillName ASC;