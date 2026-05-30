# Projet MediaTek86

## Contexte
Application de gestion administrative pour le réseau des médiathèques de la Vienne, développée dans le cadre d'une intervention pour InfoTech Services 86. Elle permet de gérer le personnel, les affectations aux services et le suivi des absences.

## But de l'application
Centraliser la gestion du personnel, faciliter l'affectation aux services et automatiser le suivi des indisponibilités avec une gestion intelligente des chevauchements.

## Architecture
* **Modèle Conceptuel de Données (MCD) :**
  ![MCD](Documents/cned/atelierproeval2/mediatek86/basededonnée.png)

* **Architecture technique :**
  L'application suit une structure MVC/DAL (Vues, Modèles, Accès aux données).
  ![Diagramme de paquetages](Documents/cned/atelierproeval2/mediatek86/planMVC.png)

## Fonctionnalités
* Authentification sécurisée (Login/Mot de passe).login=admin mdp= 1234
* Gestion complète du personnel (CRUD : Créer, Lire, Mettre à jour).
