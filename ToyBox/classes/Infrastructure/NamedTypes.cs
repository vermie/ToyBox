﻿// Copyright < 2021 > Narria(github user Cabarius) - License: MIT
using UnityEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ToyBox {
    public class NamedAction {
        public String name { get; }
        public Action action { get; }
        public Func<bool> canPerform { get; }
        public NamedAction(String name, Action action, Func<bool> canPerform = null) {
            this.name = name;
            this.action = action;
            this.canPerform = canPerform != null ? canPerform : () => { return true; };
        }
    }
    public class NamedAction<T> {
        public String name { get; }
        public Action<T> action { get; }
        public Func<T, bool> canPerform { get; }
        public NamedAction(String name, Action<T> action, Func<T, bool> canPerform = null) {
            this.name = name;
            this.action = action;
            this.canPerform = canPerform != null ? canPerform : (T) => { return true; };
        }
    }

    public class NamedFunc<T> {
        public String name { get; }
        public Func<T> func { get; }
        public Func<bool> canPerform { get; }
        public NamedFunc(String name, Func<T> func, Func<bool> canPerform = null) {
            this.name = name;
            this.func = func;
            this.canPerform = canPerform != null ? canPerform : () => { return true; };
        }
    }

    public class NamedMutator<Target, T> {
        public String name { get; }
        public Action<Target, T, int> action { get; }
        public Func<Target, T, bool> canPerform { get; }
        public bool isRepeatable { get; }
        public NamedMutator(
            String name,
            Action<Target, T, int> action,
            Func<Target, T, bool> canPerform = null,
            bool isRepeatable = false
            ) {
            this.name = name;
            this.action = action;
            this.canPerform = canPerform != null ? canPerform : (target, value) => true;
            this.isRepeatable = isRepeatable;
        }
    }
}