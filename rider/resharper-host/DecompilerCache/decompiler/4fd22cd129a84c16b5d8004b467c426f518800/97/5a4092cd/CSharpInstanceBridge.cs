// Decompiled with JetBrains decompiler
// Type: Godot.Bridge.CSharpInstanceBridge
// Assembly: GodotSharp, Version=4.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FD22CD1-29A8-4C16-B5D8-004B467C426F
// Assembly location: /home/callum/Documents/Programs/godot_4.3/GodotSharp/Api/Debug/GodotSharp.dll
// XML documentation location: /home/callum/Documents/Programs/godot_4.3/GodotSharp/Api/Debug/GodotSharp.xml

using Godot.NativeInterop;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Godot.Bridge;

internal static class CSharpInstanceBridge
{
  [UnmanagedCallersOnly]
  internal static unsafe godot_bool Call(
    IntPtr godotObjectGCHandle,
    godot_string_name* method,
    godot_variant** args,
    int argCount,
    godot_variant_call_error* refCallError,
    godot_variant* ret)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
      {
        *ret = new godot_variant();
        refCallError->Error = godot_variant_call_error_error.GODOT_CALL_ERROR_CALL_ERROR_INSTANCE_IS_NULL;
        return godot_bool.False;
      }
      godot_variant ret1;
      if (!target.InvokeGodotClassMethod(in CustomUnsafe.AsRef(method), new NativeVariantPtrArgs(args, argCount), out ret1))
      {
        *ret = new godot_variant();
        refCallError->Error = godot_variant_call_error_error.GODOT_CALL_ERROR_CALL_ERROR_INVALID_METHOD;
        return godot_bool.False;
      }
      *ret = ret1;
      return godot_bool.True;
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
      *ret = new godot_variant();
      return godot_bool.False;
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe godot_bool Set(
    IntPtr godotObjectGCHandle,
    godot_string_name* name,
    godot_variant* value)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
        throw new InvalidOperationException();
      if (target.SetGodotClassPropertyValue(in CustomUnsafe.AsRef(name), in CustomUnsafe.AsRef(value)))
        return godot_bool.True;
      StringName ofDisposableValue = StringName.CreateTakingOwnershipOfDisposableValue(NativeFuncs.godotsharp_string_name_new_copy(in CustomUnsafe.AsRef(name)));
      Variant copyingBorrowed = Variant.CreateCopyingBorrowed(in *value);
      return target._Set(ofDisposableValue, copyingBorrowed).ToGodotBool();
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
      return godot_bool.False;
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe godot_bool Get(
    IntPtr godotObjectGCHandle,
    godot_string_name* name,
    godot_variant* outRet)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
        throw new InvalidOperationException();
      godot_variant godotVariant;
      if (target.GetGodotClassPropertyValue(in CustomUnsafe.AsRef(name), out godotVariant))
      {
        *outRet = godotVariant;
        return godot_bool.True;
      }
      if (target.HasGodotClassSignal(in CustomUnsafe.AsRef(name)))
      {
        godot_signal from = new godot_signal(NativeFuncs.godotsharp_string_name_new_copy(in *name), target.GetInstanceId());
        *outRet = VariantUtils.CreateFromSignalTakingOwnershipOfDisposableValue(from);
        return godot_bool.True;
      }
      if (target.HasGodotClassMethod(in CustomUnsafe.AsRef(name)))
      {
        godot_callable from = new godot_callable(NativeFuncs.godotsharp_string_name_new_copy(in *name), target.GetInstanceId());
        *outRet = VariantUtils.CreateFromCallableTakingOwnershipOfDisposableValue(from);
        return godot_bool.True;
      }
      StringName ofDisposableValue = StringName.CreateTakingOwnershipOfDisposableValue(NativeFuncs.godotsharp_string_name_new_copy(in CustomUnsafe.AsRef(name)));
      Variant variant = target._Get(ofDisposableValue);
      if (variant.VariantType == Variant.Type.Nil)
      {
        *outRet = new godot_variant();
        return godot_bool.False;
      }
      *outRet = variant.CopyNativeVariant();
      return godot_bool.True;
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
      *outRet = new godot_variant();
      return godot_bool.False;
    }
  }

  [UnmanagedCallersOnly]
  internal static void CallDispose(IntPtr godotObjectGCHandle, godot_bool okIfNull)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (okIfNull.ToBool())
        target?.Dispose();
      else
        target.Dispose();
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe void CallToString(
    IntPtr godotObjectGCHandle,
    godot_string* outRes,
    godot_bool* outValid)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
      {
        *outRes = new godot_string();
        *outValid = godot_bool.False;
      }
      else
      {
        string p_mono_string = target.ToString();
        if (p_mono_string == null)
        {
          *outRes = new godot_string();
          *outValid = godot_bool.False;
        }
        else
        {
          *outRes = Marshaling.ConvertStringToNative(p_mono_string);
          *outValid = godot_bool.True;
        }
      }
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
      *outRes = new godot_string();
      *outValid = godot_bool.False;
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe godot_bool HasMethodUnknownParams(
    IntPtr godotObjectGCHandle,
    godot_string_name* method)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      return target == null ? godot_bool.False : target.HasGodotClassMethod(in CustomUnsafe.AsRef(method)).ToGodotBool();
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
      return godot_bool.False;
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe void SerializeState(
    IntPtr godotObjectGCHandle,
    godot_dictionary* propertiesState,
    godot_dictionary* signalEventsState)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
        return;
      if (target is ISerializationListener serializationListener)
        serializationListener.OnBeforeSerialize();
      using (GodotSerializationInfo copyingBorrowed = GodotSerializationInfo.CreateCopyingBorrowed(in *propertiesState, in *signalEventsState))
        target.SaveGodotObjectData(copyingBorrowed);
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
    }
  }

  [UnmanagedCallersOnly]
  internal static unsafe void DeserializeState(
    IntPtr godotObjectGCHandle,
    godot_dictionary* propertiesState,
    godot_dictionary* signalEventsState)
  {
    try
    {
      GodotObject target = (GodotObject) GCHandle.FromIntPtr(godotObjectGCHandle).Target;
      if (target == null)
        return;
      using (GodotSerializationInfo copyingBorrowed = GodotSerializationInfo.CreateCopyingBorrowed(in *propertiesState, in *signalEventsState))
      {
        target.RestoreGodotObjectData(copyingBorrowed);
        if (!(target is ISerializationListener serializationListener))
          return;
        serializationListener.OnAfterDeserialize();
      }
    }
    catch (Exception ex)
    {
      ExceptionUtils.LogException(ex);
    }
  }
}
