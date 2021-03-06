# Deco
Declarative and component based UI library for C#

```csharp
public class App : Component {
    private readonly State<int> _count = 0;

    public override IView Render() =>
        new VStack {
            new HStack {
                new Button(" - ", () => _count.Value--),
                new Button(" + ", () => _count.Value++)
            },
            new Text($"Count: {_count.Value}")
        };
}
```

Deco uses the [MVU](https://thomasbandt.com/model-view-update) pattern known from Elm and React, and is built on the idea that ["UI is a function of state"](https://www.kn8.lt/blog/ui-is-a-function-of-data/).

Rendering architecture is heavily inspired by [Comet](https://github.com/Clancey/Comet).
