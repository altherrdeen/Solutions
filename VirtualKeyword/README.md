Eine Virtuelle Methode beinhaltet code welcher ausgeführt wird, wenn die Methode über eine Childklasse aufgerufen wird. Childklassen können diese Methode allerdings auch überschreiben.

In diesem Beispiel kosten Produkte normalerweise 1$ weil der Shop ein 1$-Store ist. Der Katalog ist aber kostenlos und überschreibt deshalb die Methode, welche den Preis ausgibt.


Unterschied zu Abstract:
Abstrakte Methoden müssen immer in Childklassen implementiert werden. Virtuelle Methoden hingegen können implementiert werden, haben aber auch code welcher ausgeführt wird, wenn sie nicht implementiert werden.
