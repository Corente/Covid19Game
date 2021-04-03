#Covid-19 Simulator :
Savior Of The World Edition
Corentin Ourvoy

Un jeu parodique qui redonne le sourire en se basant plus ou moins sur l’actualité.
Le but de ce jeu était de faire un jeu sans prise de tête basé sur l’actualité. Ainsi l’idée de base était d’être un employé municipal chargé de nettoyer la ville durant le confinement avec son pistolet à eau. Mais devant la difficulté de faire un pistolet à eau plus ou moins réaliste (physique, effets, gestions des particules), j’ai décidé de passer de pistolet à eau à pistolet à seringue.

#Boucle de gameplay :
Avancer vers un bâtiment infecté (le bâtiment est de couleur verte), lui tirer des seringues dessus, il devient de moins en moins vers jusqu’à ne plus être infecté et redevient de couleur normale, et pour signifier cela au joueur un effet de particule se déclenche et le nombre d’infectés baisse.


#Etapes de construction du jeu : 
* Trouver un asset de ville et le modifier pour : 
* Avoir le script de changement de couleur, en modifiant progressivement le material.
* Mettre des mesh collider sur tous les prefabs afin que le player ne passe pas à travers les bâtiments. (C’est pour cela que les projectiles on tendances à « flotter » au-dessus de la route car le mesh collider est un peu trop haut).
* Créer le Player et faire ses mouvements (je n’ai malheureusement pas trouvé d’asset de scientifique fou gratuit et donc laissé la capsule de base, mais cela n’est pas trop dérangeant car c’est un fps).
* Trouver un asset de pistolet assez cartoon et un asset pour les projectiles soumis à la gravité (finalement un model 3D de fléchette fais très bien le travail) et trouver et implémenter le système de particules.
* Ajouter la musique parfaite pour le thème du jeu (I Will Survive - Gloria Gaynor)
* Ajouter un Hud, et son système de timer et de score (le highscore est stocké dans un fichier afin de le retrouver au fur et à mesure des parties)
* Ajouter les menus de début et de fin.
* Ajout d’une sky box afin de rendre le tout un peu plus jolie

J’ai aussi ajouté le bruit des pistolets des tontons flingueurs (le « pop ») mais cela ne rendait pas très bien, du coup il est juste inactif.
Le système de coroutine est implémenté pour la destruction des projectiles. Ils sont automatiquement détruits après 5s d’existence, afin de ne pas remplir la mémoire d’objets inutiles.
Je n’ai cependant pas fait de Shader Graph, car je n’ai malheureusement pas vu l’intérêt ni l’endroit ou en implémenté un dans mon jeu.

#Pour les inputs : 
Zqsd / haut, gauche, bas, droite : pour les déplacements
Clique gauche : tirer
Déplacement de la souris : Déplacements de la caméra
