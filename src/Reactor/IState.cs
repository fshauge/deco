﻿namespace Reactor {
    public interface IState<T> : IBinding {
        T Value { get; set; }
    }
}
