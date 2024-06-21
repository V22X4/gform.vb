import express from 'express';
import bodyParser from 'body-parser';
// import cors from 'cors';
import { generateFormId } from './utils';

const app = express();
const port = 3000;

app.use(bodyParser.json());
// app.use(cors());

const forms: { [key: string]: string[] } = {};
const submissions: { [key: string]: string[][] } = {}; // Change to store list of answer lists

app.post('/create', (req, res) => {
    const questions: string[] = req.body.questions;
    if (!questions || !Array.isArray(questions)) {
        return res.status(400).send('Invalid questions');
    }

    const formId = generateFormId();
    forms[formId] = questions;
    submissions[formId] = []; // Initialize empty submissions list
    res.json({ formId });
});

app.post('/submit/:formId', (req, res) => {
    const formId = req.params.formId;
    const answers: string[] = req.body.answers;

    if (!forms[formId]) {
        return res.status(404).send('Form not found');
    }

    if (!answers || !Array.isArray(answers)) {
        return res.status(400).send('Invalid answers');
    }

    // Save answers
    submissions[formId].push(answers);

    res.send('Form submitted successfully');
});

app.get('/form/:formId', (req, res) => {
    const formId = req.params.formId;

    if (!forms[formId]) {
        return res.status(404).send('Form not found');
    }

    res.json({ questions: forms[formId] });
});

app.get('/submissions/:formId', (req, res) => {
    const formId = req.params.formId;
    if (submissions[formId]) {
        res.status(200).json({ submissions: submissions[formId] });
    } else {
        res.status(404).json({ message: 'Form not found or no submissions yet' });
    }
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
