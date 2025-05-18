using Godot;
using Godot.NativeInterop;

partial class LobbyManager
{
#pragma warning disable CS0109 // Disable warning about redundant 'new' keyword
    /// <summary>
    /// Cached StringNames for the methods contained in this class, for fast lookup.
    /// </summary>
    public new class MethodName : global::Godot.Node.MethodName {
        /// <summary>
        /// Cached name for the '_Ready' method.
        /// </summary>
        public new static readonly global::Godot.StringName @_Ready = "_Ready";
        /// <summary>
        /// Cached name for the '_Process' method.
        /// </summary>
        public new static readonly global::Godot.StringName @_Process = "_Process";
        /// <summary>
        /// Cached name for the 'OnLobbyCreation' method.
        /// </summary>
        public new static readonly global::Godot.StringName @OnLobbyCreation = "OnLobbyCreation";
        /// <summary>
        /// Cached name for the 'OnLobbyJoin' method.
        /// </summary>
        public new static readonly global::Godot.StringName @OnLobbyJoin = "OnLobbyJoin";
        /// <summary>
        /// Cached name for the 'SendLobbyMessage' method.
        /// </summary>
        public new static readonly global::Godot.StringName @SendLobbyMessage = "SendLobbyMessage";
        /// <summary>
        /// Cached name for the 'OnLobbyMessageReceived' method.
        /// </summary>
        public new static readonly global::Godot.StringName @OnLobbyMessageReceived = "OnLobbyMessageReceived";
        /// <summary>
        /// Cached name for the 'InviteLobbyOverlay' method.
        /// </summary>
        public new static readonly global::Godot.StringName @InviteLobbyOverlay = "InviteLobbyOverlay";
        /// <summary>
        /// Cached name for the 'RemovePlayer' method.
        /// </summary>
        public new static readonly global::Godot.StringName @RemovePlayer = "RemovePlayer";
        /// <summary>
        /// Cached name for the 'LeaveLobby' method.
        /// </summary>
        public new static readonly global::Godot.StringName @LeaveLobby = "LeaveLobby";
        /// <summary>
        /// Cached name for the 'InvitePlayer' method.
        /// </summary>
        public new static readonly global::Godot.StringName @InvitePlayer = "InvitePlayer";
    }
    /// <summary>
    /// Get the method information for all the methods declared in this class.
    /// This method is used by Godot to register the available methods in the editor.
    /// Do not call this method.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal new static global::System.Collections.Generic.List<global::Godot.Bridge.MethodInfo> GetGodotMethodList()
    {
        var methods = new global::System.Collections.Generic.List<global::Godot.Bridge.MethodInfo>(10);
        methods.Add(new(name: MethodName.@_Ready, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)1, arguments: null, defaultArguments: null));
        methods.Add(new(name: MethodName.@_Process, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)1, arguments: new() { new(type: (global::Godot.Variant.Type)3, name: "delta", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@OnLobbyCreation, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "lobbyId", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@OnLobbyJoin, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "lobbyId", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@SendLobbyMessage, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "message", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@OnLobbyMessageReceived, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "sender", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), new(type: (global::Godot.Variant.Type)4, name: "message", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@InviteLobbyOverlay, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: null, defaultArguments: null));
        methods.Add(new(name: MethodName.@RemovePlayer, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "playerId", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        methods.Add(new(name: MethodName.@LeaveLobby, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: null, defaultArguments: null));
        methods.Add(new(name: MethodName.@InvitePlayer, returnVal: new(type: (global::Godot.Variant.Type)0, name: "", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false), flags: (global::Godot.MethodFlags)33, arguments: new() { new(type: (global::Godot.Variant.Type)4, name: "playerId", hint: (global::Godot.PropertyHint)0, hintString: "", usage: (global::Godot.PropertyUsageFlags)6, exported: false),  }, defaultArguments: null));
        return methods;
    }
#pragma warning restore CS0109
    /// <inheritdoc/>
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
    {
        if (method == MethodName.@_Ready && args.Count == 0) {
            @_Ready();
            ret = default;
            return true;
        }
        if (method == MethodName.@_Process && args.Count == 1) {
            @_Process(global::Godot.NativeInterop.VariantUtils.ConvertTo<double>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@OnLobbyCreation && args.Count == 1) {
            @OnLobbyCreation(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@OnLobbyJoin && args.Count == 1) {
            @OnLobbyJoin(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@SendLobbyMessage && args.Count == 1) {
            @SendLobbyMessage(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@OnLobbyMessageReceived && args.Count == 2) {
            @OnLobbyMessageReceived(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]), global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[1]));
            ret = default;
            return true;
        }
        if (method == MethodName.@InviteLobbyOverlay && args.Count == 0) {
            @InviteLobbyOverlay();
            ret = default;
            return true;
        }
        if (method == MethodName.@RemovePlayer && args.Count == 1) {
            @RemovePlayer(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@LeaveLobby && args.Count == 0) {
            @LeaveLobby();
            ret = default;
            return true;
        }
        if (method == MethodName.@InvitePlayer && args.Count == 1) {
            @InvitePlayer(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        return base.InvokeGodotClassMethod(method, args, out ret);
    }
#pragma warning disable CS0109 // Disable warning about redundant 'new' keyword
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal new static bool InvokeGodotClassStaticMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret)
    {
        if (method == MethodName.@OnLobbyCreation && args.Count == 1) {
            @OnLobbyCreation(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@OnLobbyJoin && args.Count == 1) {
            @OnLobbyJoin(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@SendLobbyMessage && args.Count == 1) {
            @SendLobbyMessage(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@OnLobbyMessageReceived && args.Count == 2) {
            @OnLobbyMessageReceived(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]), global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[1]));
            ret = default;
            return true;
        }
        if (method == MethodName.@InviteLobbyOverlay && args.Count == 0) {
            @InviteLobbyOverlay();
            ret = default;
            return true;
        }
        if (method == MethodName.@RemovePlayer && args.Count == 1) {
            @RemovePlayer(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        if (method == MethodName.@LeaveLobby && args.Count == 0) {
            @LeaveLobby();
            ret = default;
            return true;
        }
        if (method == MethodName.@InvitePlayer && args.Count == 1) {
            @InvitePlayer(global::Godot.NativeInterop.VariantUtils.ConvertTo<string>(args[0]));
            ret = default;
            return true;
        }
        ret = default;
        return false;
    }
#pragma warning restore CS0109
    /// <inheritdoc/>
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool HasGodotClassMethod(in godot_string_name method)
    {
        if (method == MethodName.@_Ready) {
           return true;
        }
        if (method == MethodName.@_Process) {
           return true;
        }
        if (method == MethodName.@OnLobbyCreation) {
           return true;
        }
        if (method == MethodName.@OnLobbyJoin) {
           return true;
        }
        if (method == MethodName.@SendLobbyMessage) {
           return true;
        }
        if (method == MethodName.@OnLobbyMessageReceived) {
           return true;
        }
        if (method == MethodName.@InviteLobbyOverlay) {
           return true;
        }
        if (method == MethodName.@RemovePlayer) {
           return true;
        }
        if (method == MethodName.@LeaveLobby) {
           return true;
        }
        if (method == MethodName.@InvitePlayer) {
           return true;
        }
        return base.HasGodotClassMethod(method);
    }
}
