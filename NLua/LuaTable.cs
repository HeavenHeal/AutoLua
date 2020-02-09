﻿
using System;
using System.Collections;
using System.Collections.Generic;
using NLua.Extensions;

using LuaState = KeraLua.Lua;

namespace NLua
{
    public class LuaTable : LuaBase
    {
        public LuaTable(int reference, Lua interpreter): base(reference, interpreter)
        {
        }

        /*
         * Indexer for string fields of the table
         */
        public object this[string field] {
            get
            {
                if (!TryGet(out var lua))
                    return null;
                return lua.GetObject(Reference, field);
            }
            set
            {
                if (!TryGet(out var lua))
                    return;
                lua.SetObject(Reference, field, value);
            }
        }

        /*
         * Indexer for numeric fields of the table
         */
        public object this[object field] {
            get
            {
                if (!TryGet(out var lua))
                    return null;

                return lua.GetObject(Reference, field);
            }
            set
            {
                if (!TryGet(out var lua))
                    return;

                lua.SetObject(Reference, field, value);
            }
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            if (!TryGet(out var lua))
                return null;

            return lua.GetTableDict(this).GetEnumerator();
        }

        public ICollection<object> Keys
        {
            get
            {
                if (!TryGet(out var lua))
                    return null;

                return lua.GetTableDict(this).Keys;
            }
        }


        public ICollection<object> Values
        {
            get
            {
                if (!TryGet(out var lua))
                    return null;

                return lua.GetTableDict(this).Values;
            }
        }

        public IDictionary<object, object> Items
        {
            get
            {
                if (!TryGet(out var lua))
                    return null;
                return lua.GetTableDict(this);
            }
        }

        /*
         * Gets an string fields of a table ignoring its metatable,
         * if it exists
         */
        internal object RawGet(string field)
        {
            if (!TryGet(out var lua))
                return null;

            return lua.RawGetObject(Reference, field);
        }

        /*
         * Pushes this table into the Lua stack
         */
        internal void Push(LuaState luaState)
        {
            luaState.GetRef(Reference);
        }

        public override string ToString()
        {
            return "table";
        }
    }
}