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
    if diagnosis:
        print(f"\nBased on your symptoms, you might have: {diagnosis.replace('_',' ').title()}")
        give_advice(diagnosis)
    else:
        print("No diagnosis found in our database.Talk to a human to resolve")
        
#Makes the program run the main()
if __name__ == "__main__":
    main()        