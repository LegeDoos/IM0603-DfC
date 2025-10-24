# Design Patterns in C#

Kleine C#-experimenten om veelgebruikte design patterns te verkennen. Elk patroon staat in een eigen solution met een minimale console-app en (waar relevant) een UMLet-diagram.

## Structuur

- [BridgePattern/](BridgePattern)
- [CompositePattern/](CompositePattern)
- [CompositePatternWithIterator/](CompositePatternWithIterator)
- [DelegationExample/](DelegationExample)
- [IteratorPattern/](IteratorPattern)

## Vereisten

- .NET SDK 9.0
- Optioneel: Visual Studio 2022 of VS Code

## Bouwen en draaien (CLI)

Je kunt elk `.sln`-bestand openen in Visual Studio en F5 gebruiken.

---

## Patronen

### Iterator Pattern
Laat zien hoe je een eigen iterabele collectie en enumerator maakt.

- Collectie: [`IteratorPattern.Models.MyCollection`](IteratorPattern/IteratorPattern/Models/MyCollection.cs) implementeert `IEnumerable` via `GetEnumerator()`.
- Enumerator: [`IteratorPattern.Models.MyEnumerator`](IteratorPattern/IteratorPattern/Models/MyEnumerator.cs) implementeert `IEnumerator` met `Current`, `MoveNext()` en `Reset()`.
- Demo: [`IteratorPattern.Program`](IteratorPattern/IteratorPattern/Program.cs) toont expliciet en impliciet itereren met `foreach`.
- UML: [IteratorPattern/ClassDiagramSimpleIterator.uxf](IteratorPattern/ClassDiagramSimpleIterator.uxf)

Verwachte console-output (ingekort):
- “Hello, World! This is my basic iterator pattern!”
- “Expliciet” gevolgd door item1..item3
- “Impliciet” gevolgd door item1..item3

### Composite Pattern
Toont een hiërarchie van slideshow-onderdelen met uniforme interface (leafs en composites).

- Basiscomponent: [`CompositePattern.Models.SlideshowComponent`](CompositePattern/CompositePattern/Models/SlideshowComponent.cs) met `Show()` en `AddPart(...)`.
- Composite basistypen:
  - [`CompositePattern.Models.SlideshowComposite`](CompositePattern/CompositePattern/Models/SlideshowComposite.cs)
- Leaf basistypen:
  - [`CompositePattern.Models.SlideshowLeaf`](CompositePattern/CompositePattern/Models/SlideshowLeaf.cs)
- Concreet:
  - [`CompositePattern.Models.Slideshow`](CompositePattern/CompositePattern/Models/Slideshow.cs)
  - [`CompositePattern.Models.Slide`](CompositePattern/CompositePattern/Models/Slide.cs)
  - [`CompositePattern.Models.Item`](CompositePattern/CompositePattern/Models/Item.cs)
  - [`CompositePattern.Models.List`](CompositePattern/CompositePattern/Models/List.cs)
  - [`CompositePattern.Models.Text`](CompositePattern/CompositePattern/Models/Text.cs)
  - [`CompositePattern.Models.Figure`](CompositePattern/CompositePattern/Models/Figure.cs)
  - Exceptions: [`CompositePattern.Exceptions.InvalidItemException`](CompositePattern/CompositePattern/Exceptions/InvalidItemException.cs)
- Demo: [`CompositePattern.Program`](CompositePattern/CompositePattern/Program.cs)
- UML: [CompositePattern/ClassDiagramComposite.uxf](CompositePattern/ClassDiagramComposite.uxf)

Belangrijke regels (afgedwongen in `AddPart`):
- Slideshow → alleen `Slide`
- Slide → `Item` of `List`
- Item → maximaal één child: `Text`, `Figure` of `List`
- List → alleen `Item`

`Show()` loopt over children en toont zichzelf + onderliggende structuur.

### Composite Pattern (with Iterator)
Zelfde compositie-structuur, voorbereid om iterators toe te voegen/onderzoeken.

- Basistypen: 
  - [`CompositePattern.Models.SlideshowComponent`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowComponent.cs)
  - [`CompositePattern.Models.SlideshowComposite`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowComposite.cs)
  - [`CompositePattern.Models.SlideshowLeaf`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowLeaf.cs)
- Concreet:
  - [`CompositePattern.Models.Slideshow`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Slideshow.cs)
  - [`CompositePattern.Models.Slide`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Slide.cs)
  - [`CompositePattern.Models.Item`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Item.cs)
  - [`CompositePattern.Models.List`](CompositePatternWithIterator/CompositePatternWithIterator/Models/List.cs)
  - [`CompositePattern.Models.Text`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Text.cs)
  - [`CompositePattern.Models.Figure`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Figure.cs)
  - Exceptions: [`CompositePattern.Exceptions.InvalidItemException`](CompositePatternWithIterator/CompositePatternWithIterator/Exceptions/InvalidItemException.cs)
- Demo: [`CompositePattern.Program`](CompositePatternWithIterator/CompositePatternWithIterator/Program.cs)
- UML: [CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf](CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf)

### Bridge Pattern
Scheiding tussen abstractie en implementatie: een collectie abstraheert over de onderliggende lijstimplementatie.

- Implementatie-interface: [`BridgePattern.Models.iRobList<T>`](BridgePattern/BridgePattern/Models/iRobList.cs) met `Insert`, `Remove`, `ElementAtPos`, `Size`.
- Linked-list implementatie:
  - [`BridgePattern.Models.RobLinkedList<T>`](BridgePattern/BridgePattern/Models/RobLinkedList.cs)
  - [`BridgePattern.Models.RobLinkedListNode<T>`](BridgePattern/BridgePattern/Models/RobLinkedListNode.cs)
- Demo: [`BridgePattern.Program`](BridgePattern/BridgePattern/Program.cs) voegt items toe, leest ze, en verwijdert een item.

Opmerking:
- De demo gebruikt direct `RobLinkedList<T>`; in een volledige Bridge zou een aparte abstractieklasse boven `iRobList<T>` zitten om meerdere implementaties uitwisselbaar te maken.

### Delegation (Strategy-achtig)
Toont delegatie van gedrag via een interface.

- Gedragsinterface: [`DelegationExample.Models.ICanMove`](DelegationExample/DelegationExample/Models/ICanMove.cs)
- Context/hiërarchie:
  - [`DelegationExample.Models.Animal`](DelegationExample/DelegationExample/Models/Animal.cs)
  - [`DelegationExample.Models.Cat`](DelegationExample/DelegationExample/Models/Cat.cs) die een `ICanMove`-implementatie gebruikt
- Concreet gedrag:
  - [`DelegationExample.Models.Run`](DelegationExample/DelegationExample/Models/Run.cs)
  - [`DelegationExample.Models.Swim`](DelegationExample/DelegationExample/Models/Swim.cs)
  - [`DelegationExample.Models.Fly`](DelegationExample/DelegationExample/Models/Fly.cs)
- Demo: [`DelegationExample.Program`](DelegationExample/DelegationExample/Program.cs)

Opmerking in code:
- Objectcreatie in `Cat` gebeurt inline; in productie zou injectie/factory de voorkeur hebben.

---

## UML-diagrammen

De `.uxf`-bestanden zijn UMLet-diagrammen:
- [BridgePattern/BridgePattern.uxf](BridgePattern/BridgePattern.uxf)
- [CompositePattern/ClassDiagramComposite.uxf](CompositePattern/ClassDiagramComposite.uxf)
- [CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf](CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf)
- [IteratorPattern/ClassDiagramSimpleIterator.uxf](IteratorPattern/ClassDiagramSimpleIterator.uxf)

Open met UMLet (https://www.umlet.com) of importeer in een compatibele tool.

---

## Patronen

### Iterator Pattern
Laat zien hoe je een eigen iterabele collectie en enumerator maakt.

- Collectie: [`IteratorPattern.Models.MyCollection`](IteratorPattern/IteratorPattern/Models/MyCollection.cs) implementeert `IEnumerable` via `GetEnumerator()`.
- Enumerator: [`IteratorPattern.Models.MyEnumerator`](IteratorPattern/IteratorPattern/Models/MyEnumerator.cs) implementeert `IEnumerator` met `Current`, `MoveNext()` en `Reset()`.
- Demo: [`IteratorPattern.Program`](IteratorPattern/IteratorPattern/Program.cs) toont expliciet en impliciet itereren met `foreach`.
- UML: [IteratorPattern/ClassDiagramSimpleIterator.uxf](IteratorPattern/ClassDiagramSimpleIterator.uxf)

Verwachte console-output (ingekort):
- “Hello, World! This is my basic iterator pattern!”
- “Expliciet” gevolgd door item1..item3
- “Impliciet” gevolgd door item1..item3

### Composite Pattern
Toont een hiërarchie van slideshow-onderdelen met uniforme interface (leafs en composites).

- Basiscomponent: [`CompositePattern.Models.SlideshowComponent`](CompositePattern/CompositePattern/Models/SlideshowComponent.cs) met `Show()` en `AddPart(...)`.
- Composite basistypen:
  - [`CompositePattern.Models.SlideshowComposite`](CompositePattern/CompositePattern/Models/SlideshowComposite.cs)
- Leaf basistypen:
  - [`CompositePattern.Models.SlideshowLeaf`](CompositePattern/CompositePattern/Models/SlideshowLeaf.cs)
- Concreet:
  - [`CompositePattern.Models.Slideshow`](CompositePattern/CompositePattern/Models/Slideshow.cs)
  - [`CompositePattern.Models.Slide`](CompositePattern/CompositePattern/Models/Slide.cs)
  - [`CompositePattern.Models.Item`](CompositePattern/CompositePattern/Models/Item.cs)
  - [`CompositePattern.Models.List`](CompositePattern/CompositePattern/Models/List.cs)
  - [`CompositePattern.Models.Text`](CompositePattern/CompositePattern/Models/Text.cs)
  - [`CompositePattern.Models.Figure`](CompositePattern/CompositePattern/Models/Figure.cs)
  - Exceptions: [`CompositePattern.Exceptions.InvalidItemException`](CompositePattern/CompositePattern/Exceptions/InvalidItemException.cs)
- Demo: [`CompositePattern.Program`](CompositePattern/CompositePattern/Program.cs)
- UML: [CompositePattern/ClassDiagramComposite.uxf](CompositePattern/ClassDiagramComposite.uxf)

Belangrijke regels (afgedwongen in `AddPart`):
- Slideshow → alleen `Slide`
- Slide → `Item` of `List`
- Item → maximaal één child: `Text`, `Figure` of `List`
- List → alleen `Item`

`Show()` loopt over children en toont zichzelf + onderliggende structuur.

### Composite Pattern (with Iterator)
Zelfde compositie-structuur, voorbereid om iterators toe te voegen/onderzoeken.

- Basistypen: 
  - [`CompositePattern.Models.SlideshowComponent`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowComponent.cs)
  - [`CompositePattern.Models.SlideshowComposite`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowComposite.cs)
  - [`CompositePattern.Models.SlideshowLeaf`](CompositePatternWithIterator/CompositePatternWithIterator/Models/SlideshowLeaf.cs)
- Concreet:
  - [`CompositePattern.Models.Slideshow`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Slideshow.cs)
  - [`CompositePattern.Models.Slide`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Slide.cs)
  - [`CompositePattern.Models.Item`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Item.cs)
  - [`CompositePattern.Models.List`](CompositePatternWithIterator/CompositePatternWithIterator/Models/List.cs)
  - [`CompositePattern.Models.Text`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Text.cs)
  - [`CompositePattern.Models.Figure`](CompositePatternWithIterator/CompositePatternWithIterator/Models/Figure.cs)
  - Exceptions: [`CompositePattern.Exceptions.InvalidItemException`](CompositePatternWithIterator/CompositePatternWithIterator/Exceptions/InvalidItemException.cs)
- Demo: [`CompositePattern.Program`](CompositePatternWithIterator/CompositePatternWithIterator/Program.cs)
- UML: [CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf](CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf)

### Bridge Pattern
Scheiding tussen abstractie en implementatie: een collectie abstraheert over de onderliggende lijstimplementatie.

- Implementatie-interface: [`BridgePattern.Models.iRobList<T>`](BridgePattern/BridgePattern/Models/iRobList.cs) met `Insert`, `Remove`, `ElementAtPos`, `Size`.
- Linked-list implementatie:
  - [`BridgePattern.Models.RobLinkedList<T>`](BridgePattern/BridgePattern/Models/RobLinkedList.cs)
  - [`BridgePattern.Models.RobLinkedListNode<T>`](BridgePattern/BridgePattern/Models/RobLinkedListNode.cs)
- Demo: [`BridgePattern.Program`](BridgePattern/BridgePattern/Program.cs) voegt items toe, leest ze, en verwijdert een item.

Opmerking:
- De demo gebruikt direct `RobLinkedList<T>`; in een volledige Bridge zou een aparte abstractieklasse boven `iRobList<T>` zitten om meerdere implementaties uitwisselbaar te maken.

### Delegation (Strategy-achtig)
Toont delegatie van gedrag via een interface.

- Gedragsinterface: [`DelegationExample.Models.ICanMove`](DelegationExample/DelegationExample/Models/ICanMove.cs)
- Context/hiërarchie:
  - [`DelegationExample.Models.Animal`](DelegationExample/DelegationExample/Models/Animal.cs)
  - [`DelegationExample.Models.Cat`](DelegationExample/DelegationExample/Models/Cat.cs) die een `ICanMove`-implementatie gebruikt
- Concreet gedrag:
  - [`DelegationExample.Models.Run`](DelegationExample/DelegationExample/Models/Run.cs)
  - [`DelegationExample.Models.Swim`](DelegationExample/DelegationExample/Models/Swim.cs)
  - [`DelegationExample.Models.Fly`](DelegationExample/DelegationExample/Models/Fly.cs)
- Demo: [`DelegationExample.Program`](DelegationExample/DelegationExample/Program.cs)

Opmerking in code:
- Objectcreatie in `Cat` gebeurt inline; in productie zou injectie/factory de voorkeur hebben.

---

## UML-diagrammen

De `.uxf`-bestanden zijn UMLet-diagrammen:
- [BridgePattern/BridgePattern.uxf](BridgePattern/BridgePattern.uxf)
- [CompositePattern/ClassDiagramComposite.uxf](CompositePattern/ClassDiagramComposite.uxf)
- [CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf](CompositePatternWithIterator/ClassDiagramCompositeIterator.uxf)
- [IteratorPattern/ClassDiagramSimpleIterator.uxf](IteratorPattern/ClassDiagramSimpleIterator.uxf)

Open met UMLet (https://www.umlet.com) of importeer in een compatibele tool.

---

