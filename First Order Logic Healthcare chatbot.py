Python 3.10.11 (tags/v3.10.11:7d4cc5a, Apr  5 2023, 00:38:17) [MSC v.1929 64 bit (AMD64)] on win32
Type "help", "copyright", "credits" or "license()" for more information.
Knowledge_base = {}
HELP
Traceback (most recent call last):
  File "<pyshell#1>", line 1, in <module>
    HELP
NameError: name 'HELP' is not defined
help
Type help() for interactive help, or help(object) for help about object.
help()

Welcome to Python 3.10's help utility!

If this is your first time using Python, you should definitely check out
the tutorial on the internet at https://docs.python.org/3.10/tutorial/.

Enter the name of any module, keyword, or topic to get help on writing
Python programs and using Python modules.  To quit this help utility and
return to the interpreter, just type "quit".

To get a list of available modules, keywords, symbols, or topics, type
"modules", "keywords", "symbols", or "topics".  Each module also comes
with a one-line summary of what it does; to list the modules whose name
or summary contain a given string such as "spam", type "modules spam".

help> 

You are now leaving help and returning to the Python interpreter.
If you want to ask for help on a particular object directly from the
interpreter, you can type "help(object)".  Executing "help('string')"
has the same effect as typing a particular string at the help> prompt.
knowledge_base = {
    'flu': ['fever', 'cough','sore throught'],
    'common_cold': ['sneezing', 'runny_nose', 'mild_fever'],
    'malaria': ['fever', 'chills', 'sweating', 'headache'],
    'covid19': ['fever', 'cough', 'shortness_of_breath', 'loss_of_taste'],
    'strep_throat': ['sore_throat', 'swollen_lymph_node', 'fever']
    }
advice_base = {
    'flu': ['Drink plenty of fluids', 'Get rest', 'Consider over-the-couter medications for fever and cough'],
    'common_cold': ['Use a nebulizer', 'Rest', 'Blow your nose often'],
    'malaria': ['Take doses of vitamin C', 'Avoid mosquito invested areas', 'Go see a doctor'],
    'covid19': ['Wear a mask', 'Avoid human interaction', 'Measure you breathing regularly'],
    'strep_throat': ['Have Strepsils on hand', 'Put the cigarettes down', 'Drink some water']
    }
def diagnose(symptomes_input):
    sympyoms = [s.strip90.lower.replace(" ","_") for i in symptomes_input]
    for disease, disease_symptoms in knowledge_base.items():
        if all(symptom in symptoms for symptom in disease_symptoms)
        
SyntaxError: incomplete input
def diagnose(symptomes_input):
    sympyoms = [s.strip90.lower.replace(" ","_") for i in symptomes_input]
    for disease, disease_symptoms in knowledge_base.items():
        if all(symptom in symptoms for symptom in disease_symptoms):
            return disease
    return None

def give_advise(disease):
    if disease in advice_base:
        print(f"\nAdvice for {disease.replace('_',' ').title()}:")
        for item in advice_base[disease]:
            print(f"- {item}")
    else:
        print("No advice available.")

        
def main():
    print("Welcome to the HealthBot!")
    print("Please enter your symptoms (seperated by commas):")
    user_input = input("Symptoms: ").split(",")

    
diagnosis = diagnose(user_input)
Traceback (most recent call last):
  File "<pyshell#36>", line 1, in <module>
    diagnosis = diagnose(user_input)
NameError: name 'user_input' is not defined
[DEBUG ON]
[DEBUG OFF]
>>> #Knowledge database
... knowledge_base = {
...     'flu': ['fever', 'cough', 'sore_throat'],
...     'common_cold': ['sneezing', 'runny_nose', 'mild_fever'],
...     'malaria': ['fever', 'chills', 'sweating', 'headache'],
...     'covid19': ['fever', 'cough', 'shortness_of_breath', 'loss_of_taste'],
...     'strep_throat': ['sore_throat', 'swollen_lymph_nodes', 'fever']
... }
... 
... # Advice base
... advice_base = {
...     'flu': ['Drink plenty of fluids', 'Get rest', 'Consider over-the-counter medications for fever and cough'],
...     'common_cold': ['Use a nebulizer', 'Rest', 'Blow your nose often'],
...     'malaria': ['Take doses of vitamin C', 'Avoid mosquito-infested areas', 'Go see a doctor'],
...     'covid19': ['Wear a mask', 'Avoid human interaction', 'Monitor your breathing regularly'],
...     'strep_throat': ['Have Strepsils on hand', 'Put the cigarettes down', 'Drink some water']
... }
... 
... # Makes a diagnosis
... def diagnose(symptoms_input):
...     symptoms = [s.strip().lower().replace(" ", "_") for s in symptoms_input]
...     for disease, disease_symptoms in knowledge_base.items():
...         if all(symptom in symptoms for symptom in disease_symptoms):
...             return disease
...     return None
... 
... # Gives advice
... def give_advice(disease):
...     if disease in advice_base:
...         print(f"\nAdvice for {disease.replace('_',' ').title()}:")
...         for item in advice_base[disease]:
...             print(f"- {item}")
...     else:
...         print("No advice available.")
... 
... # Main 
... def main():
...     print("Welcome to the HealthBot!")
...     print("Please enter your symptoms (separated by commas):")
...     user_input = input("Symptoms: ").split(",")
...     
...     diagnosis = diagnose(user_input)
...     
SyntaxError: multiple statements found while compiling a single statement
[DEBUG ON]
[DEBUG OFF]
#Knowledge database
knowledge_base = {
    'flu': ['fever', 'cough', 'sore_throat'],
    'common_cold': ['sneezing', 'runny_nose', 'mild_fever'],
    'malaria': ['fever', 'chills', 'sweating', 'headache'],
    'covid19': ['fever', 'cough', 'shortness_of_breath', 'loss_of_taste'],
    'strep_throat': ['sore_throat', 'swollen_lymph_nodes', 'fever']
}
# Advice base
advice_base = {
    'flu': ['Drink plenty of fluids', 'Get rest', 'Consider over-the-counter medications for fever and cough'],
    'common_cold': ['Use a nebulizer', 'Rest', 'Blow your nose often'],
    'malaria': ['Take doses of vitamin C', 'Avoid mosquito-infested areas', 'Go see a doctor'],
    'covid19': ['Wear a mask', 'Avoid human interaction', 'Monitor your breathing regularly'],
    'strep_throat': ['Have Strepsils on hand', 'Put the cigarettes down', 'Drink some water']
}
# Makes a diagnosis
def diagnose(symptoms_input):
    symptoms = [s.strip().lower().replace(" ", "_") for s in symptoms_input]
    for disease, disease_symptoms in knowledge_base.items():
        if all(symptom in symptoms for symptom in disease_symptoms):
            return disease
    return None

# Gives advice
def give_advice(disease):
    if disease in advice_base:
        print(f"\nAdvice for {disease.replace('_',' ').title()}:")
        for item in advice_base[disease]:
            print(f"- {item}")
    else:
        print("No advice available.")

        
# Main 
def main():
    print("Welcome to the HealthBot!")
    print("Please enter your symptoms (separated by commas):")
    user_input = input("Symptoms: ").split(",")
    
    diagnosis = diagnose(user_input)

    
    if dignosis:
        
SyntaxError: unexpected indent
# Main 
def main():
    print("Welcome to the HealthBot!")
    print("Please enter your symptoms (separated by commas):")
    user_input = input("Symptoms: ").split(",")
    
    diagnosis = diagnose(user_input)
    if diagnosis:
        print(f"\nBased on your symptoms, you might have: {diagnosis.replace('_',' ').title()}")
        give_advice(diagnosis)
    else:
        print("No diagnosis found in our database.Talk to a human to resolve")

        
if __name__ == "__main__":
    main()

    
Welcome to the HealthBot!
Please enter your symptoms (separated by commas):
Symptoms: fever, sore throat
No diagnosis found in our database.Talk to a human to resolve

if __name__ == "__main__":
    main()

    
Welcome to the HealthBot!
Please enter your symptoms (separated by commas):
Symptoms: sore trhoat, fever, cough
No diagnosis found in our database.Talk to a human to resolve

if __name__ == "__main__":
    main()

    
Welcome to the HealthBot!
Please enter your symptoms (separated by commas):
Symptoms: sore throat, fever, cough

Based on your symptoms, you might have: Flu

Advice for Flu:
- Drink plenty of fluids
- Get rest
- Consider over-the-counter medications for fever and cough

if __name__ == "__main__":
    main()

    
Welcome to the HealthBot!
Please enter your symptoms (separated by commas):
Symptoms: fever
No diagnosis found in our database.Talk to a human to resolve
