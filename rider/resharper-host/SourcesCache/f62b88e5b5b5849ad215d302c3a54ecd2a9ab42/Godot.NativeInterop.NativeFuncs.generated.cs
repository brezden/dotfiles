using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Godot.Bridge;
using Godot.NativeInterop;

#pragma warning disable CA1707 // Disable warning: Identifiers should not contain underscores

namespace Godot.NativeInterop
{
[System.Runtime.CompilerServices.SkipLocalsInit]
unsafe partial class NativeFuncs
{
    private static global::Godot.NativeInterop.NativeFuncs.UnmanagedCallbacks _unmanagedCallbacks;

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.NativeInterop.godot_bool godotsharp_dotnet_module_is_initialized()
    {
        return _unmanagedCallbacks.godotsharp_dotnet_module_is_initialized();
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::System.IntPtr godotsharp_method_bind_get_method(in global::Godot.NativeInterop.godot_string_name p_classname, in global::Godot.NativeInterop.godot_string_name p_methodname)
    {
        global::Godot.NativeInterop.godot_string_name* p_classname_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_classname);
        global::Godot.NativeInterop.godot_string_name* p_methodname_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_methodname);
        return _unmanagedCallbacks.godotsharp_method_bind_get_method(p_classname_ptr, p_methodname_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::System.IntPtr godotsharp_method_bind_get_method_with_compatibility(in global::Godot.NativeInterop.godot_string_name p_classname, in global::Godot.NativeInterop.godot_string_name p_methodname,  ulong p_hash)
    {
        global::Godot.NativeInterop.godot_string_name* p_classname_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_classname);
        global::Godot.NativeInterop.godot_string_name* p_methodname_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_methodname);
        return _unmanagedCallbacks.godotsharp_method_bind_get_method_with_compatibility(p_classname_ptr, p_methodname_ptr, p_hash);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial delegate* unmanaged<global::System.IntPtr> godotsharp_get_class_constructor(in global::Godot.NativeInterop.godot_string_name p_classname)
    {
        global::Godot.NativeInterop.godot_string_name* p_classname_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_classname);
        return _unmanagedCallbacks.godotsharp_get_class_constructor(p_classname_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::System.IntPtr godotsharp_engine_get_singleton(in global::Godot.NativeInterop.godot_string p_name)
    {
        global::Godot.NativeInterop.godot_string* p_name_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_name);
        return _unmanagedCallbacks.godotsharp_engine_get_singleton(p_name_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.Error godotsharp_stack_info_vector_resize(ref global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector,  int p_size)
    {
        global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector_copy = p_stack_info_vector;
        global::Godot.Error ret = _unmanagedCallbacks.godotsharp_stack_info_vector_resize(&p_stack_info_vector_copy, p_size);
        p_stack_info_vector = p_stack_info_vector_copy;
        return ret;
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_stack_info_vector_destroy(ref global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector)
    {
        global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector_copy = p_stack_info_vector;
        _unmanagedCallbacks.godotsharp_stack_info_vector_destroy(&p_stack_info_vector_copy);
        p_stack_info_vector = p_stack_info_vector_copy;
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_editor_file_system_update_files(in global::Godot.NativeInterop.godot_packed_string_array p_script_paths)
    {
        global::Godot.NativeInterop.godot_packed_string_array* p_script_paths_ptr = (global::Godot.NativeInterop.godot_packed_string_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_script_paths);
        _unmanagedCallbacks.godotsharp_internal_editor_file_system_update_files(p_script_paths_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_script_debugger_send_error(in global::Godot.NativeInterop.godot_string p_func, in global::Godot.NativeInterop.godot_string p_file,  int p_line, in global::Godot.NativeInterop.godot_string p_err, in global::Godot.NativeInterop.godot_string p_descr,  global::Godot.NativeInterop.godot_error_handler_type p_type, in global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector)
    {
        global::Godot.NativeInterop.godot_string* p_func_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_func);
        global::Godot.NativeInterop.godot_string* p_file_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_file);
        global::Godot.NativeInterop.godot_string* p_err_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_err);
        global::Godot.NativeInterop.godot_string* p_descr_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_descr);
        global::Godot.DebuggingUtils.godot_stack_info_vector p_stack_info_vector_copy = p_stack_info_vector;
        _unmanagedCallbacks.godotsharp_internal_script_debugger_send_error(p_func_ptr, p_file_ptr, p_line, p_err_ptr, p_descr_ptr, p_type, &p_stack_info_vector_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.NativeInterop.godot_bool godotsharp_internal_script_debugger_is_active()
    {
        return _unmanagedCallbacks.godotsharp_internal_script_debugger_is_active();
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::System.IntPtr godotsharp_internal_object_get_associated_gchandle( global::System.IntPtr ptr)
    {
        return _unmanagedCallbacks.godotsharp_internal_object_get_associated_gchandle(ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_object_disposed( global::System.IntPtr ptr,  global::System.IntPtr gcHandleToFree)
    {
        _unmanagedCallbacks.godotsharp_internal_object_disposed(ptr, gcHandleToFree);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_refcounted_disposed( global::System.IntPtr ptr,  global::System.IntPtr gcHandleToFree,  global::Godot.NativeInterop.godot_bool isFinalizer)
    {
        _unmanagedCallbacks.godotsharp_internal_refcounted_disposed(ptr, gcHandleToFree, isFinalizer);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.Error godotsharp_internal_signal_awaiter_connect( global::System.IntPtr source, in global::Godot.NativeInterop.godot_string_name signal,  global::System.IntPtr target,  global::System.IntPtr awaiterHandlePtr)
    {
        global::Godot.NativeInterop.godot_string_name* signal_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in signal);
        return _unmanagedCallbacks.godotsharp_internal_signal_awaiter_connect(source, signal_ptr, target, awaiterHandlePtr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_tie_native_managed_to_unmanaged( global::System.IntPtr gcHandleIntPtr,  global::System.IntPtr unmanaged, in global::Godot.NativeInterop.godot_string_name nativeName,  global::Godot.NativeInterop.godot_bool refCounted)
    {
        global::Godot.NativeInterop.godot_string_name* nativeName_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in nativeName);
        _unmanagedCallbacks.godotsharp_internal_tie_native_managed_to_unmanaged(gcHandleIntPtr, unmanaged, nativeName_ptr, refCounted);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_tie_user_managed_to_unmanaged( global::System.IntPtr gcHandleIntPtr,  global::System.IntPtr unmanaged,  global::Godot.NativeInterop.godot_ref* scriptPtr,  global::Godot.NativeInterop.godot_bool refCounted)
    {
        _unmanagedCallbacks.godotsharp_internal_tie_user_managed_to_unmanaged(gcHandleIntPtr, unmanaged, scriptPtr, refCounted);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_tie_managed_to_unmanaged_with_pre_setup( global::System.IntPtr gcHandleIntPtr,  global::System.IntPtr unmanaged)
    {
        _unmanagedCallbacks.godotsharp_internal_tie_managed_to_unmanaged_with_pre_setup(gcHandleIntPtr, unmanaged);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::System.IntPtr godotsharp_internal_unmanaged_get_script_instance_managed( global::System.IntPtr p_unmanaged, out global::Godot.NativeInterop.godot_bool r_has_cs_script_instance)
    {
        global::Godot.NativeInterop.godot_bool r_has_cs_script_instance_copy;
        global::System.IntPtr ret = _unmanagedCallbacks.godotsharp_internal_unmanaged_get_script_instance_managed(p_unmanaged, &r_has_cs_script_instance_copy);
        r_has_cs_script_instance = r_has_cs_script_instance_copy;
        return ret;
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::System.IntPtr godotsharp_internal_unmanaged_get_instance_binding_managed( global::System.IntPtr p_unmanaged)
    {
        return _unmanagedCallbacks.godotsharp_internal_unmanaged_get_instance_binding_managed(p_unmanaged);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::System.IntPtr godotsharp_internal_unmanaged_instance_binding_create_managed( global::System.IntPtr p_unmanaged,  global::System.IntPtr oldGCHandlePtr)
    {
        return _unmanagedCallbacks.godotsharp_internal_unmanaged_instance_binding_create_managed(p_unmanaged, oldGCHandlePtr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_new_csharp_script( global::Godot.NativeInterop.godot_ref* r_dest)
    {
        _unmanagedCallbacks.godotsharp_internal_new_csharp_script(r_dest);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.NativeInterop.godot_bool godotsharp_internal_script_load(in global::Godot.NativeInterop.godot_string p_path,  global::Godot.NativeInterop.godot_ref* r_dest)
    {
        global::Godot.NativeInterop.godot_string* p_path_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_path);
        return _unmanagedCallbacks.godotsharp_internal_script_load(p_path_ptr, r_dest);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_internal_reload_registered_script( global::System.IntPtr scriptPtr)
    {
        _unmanagedCallbacks.godotsharp_internal_reload_registered_script(scriptPtr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_array_filter_godot_objects_by_native(in global::Godot.NativeInterop.godot_string_name p_native_name, in global::Godot.NativeInterop.godot_array p_input, out global::Godot.NativeInterop.godot_array r_output)
    {
        global::Godot.NativeInterop.godot_string_name* p_native_name_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_native_name);
        global::Godot.NativeInterop.godot_array* p_input_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_input);
        r_output = default;
        global::Godot.NativeInterop.godot_array* r_output_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_output);
        _unmanagedCallbacks.godotsharp_array_filter_godot_objects_by_native(p_native_name_ptr, p_input_ptr, r_output_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_array_filter_godot_objects_by_non_native(in global::Godot.NativeInterop.godot_array p_input, out global::Godot.NativeInterop.godot_array r_output)
    {
        global::Godot.NativeInterop.godot_array* p_input_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_input);
        r_output = default;
        global::Godot.NativeInterop.godot_array* r_output_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_output);
        _unmanagedCallbacks.godotsharp_array_filter_godot_objects_by_non_native(p_input_ptr, r_output_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_ref_new_from_ref_counted_ptr(out global::Godot.NativeInterop.godot_ref r_dest,  global::System.IntPtr p_ref_counted_ptr)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_ref* r_dest_ptr = (global::Godot.NativeInterop.godot_ref*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_ref_new_from_ref_counted_ptr(r_dest_ptr, p_ref_counted_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_ref_destroy(ref global::Godot.NativeInterop.godot_ref p_instance)
    {
        global::Godot.NativeInterop.godot_ref* p_instance_ptr = (global::Godot.NativeInterop.godot_ref*)CustomUnsafe.AsPointer(ref p_instance);
        _unmanagedCallbacks.godotsharp_ref_destroy(p_instance_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_name_new_from_string(out global::Godot.NativeInterop.godot_string_name r_dest, in global::Godot.NativeInterop.godot_string p_name)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_string_name* r_dest_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string* p_name_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_name);
        _unmanagedCallbacks.godotsharp_string_name_new_from_string(r_dest_ptr, p_name_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_new_from_string(out global::Godot.NativeInterop.godot_node_path r_dest, in global::Godot.NativeInterop.godot_string p_name)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_node_path* r_dest_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string* p_name_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_name);
        _unmanagedCallbacks.godotsharp_node_path_new_from_string(r_dest_ptr, p_name_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_name_as_string(out global::Godot.NativeInterop.godot_string r_dest, in global::Godot.NativeInterop.godot_string_name p_name)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_string* r_dest_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string_name* p_name_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_name);
        _unmanagedCallbacks.godotsharp_string_name_as_string(r_dest_ptr, p_name_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_as_string(out global::Godot.NativeInterop.godot_string r_dest, in global::Godot.NativeInterop.godot_node_path p_np)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_string* r_dest_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_node_path* p_np_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_np);
        _unmanagedCallbacks.godotsharp_node_path_as_string(r_dest_ptr, p_np_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_byte_array godotsharp_packed_byte_array_new_mem_copy( byte* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_byte_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_int32_array godotsharp_packed_int32_array_new_mem_copy( int* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_int32_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_int64_array godotsharp_packed_int64_array_new_mem_copy( long* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_int64_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_float32_array godotsharp_packed_float32_array_new_mem_copy( float* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_float32_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_float64_array godotsharp_packed_float64_array_new_mem_copy( double* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_float64_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector2_array godotsharp_packed_vector2_array_new_mem_copy( global::Godot.Vector2* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_vector2_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector3_array godotsharp_packed_vector3_array_new_mem_copy( global::Godot.Vector3* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_vector3_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector4_array godotsharp_packed_vector4_array_new_mem_copy( global::Godot.Vector4* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_vector4_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_color_array godotsharp_packed_color_array_new_mem_copy( global::Godot.Color* p_src,  int p_length)
    {
        return _unmanagedCallbacks.godotsharp_packed_color_array_new_mem_copy(p_src, p_length);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_string_array_add(ref global::Godot.NativeInterop.godot_packed_string_array r_dest, in global::Godot.NativeInterop.godot_string p_element)
    {
        global::Godot.NativeInterop.godot_packed_string_array* r_dest_ptr = (global::Godot.NativeInterop.godot_packed_string_array*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string* p_element_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_element);
        _unmanagedCallbacks.godotsharp_packed_string_array_add(r_dest_ptr, p_element_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_callable_new_with_delegate( global::System.IntPtr p_delegate_handle,  global::System.IntPtr p_trampoline,  global::System.IntPtr p_object, out global::Godot.NativeInterop.godot_callable r_callable)
    {
        r_callable = default;
        global::Godot.NativeInterop.godot_callable* r_callable_ptr = (global::Godot.NativeInterop.godot_callable*)CustomUnsafe.AsPointer(ref r_callable);
        _unmanagedCallbacks.godotsharp_callable_new_with_delegate(p_delegate_handle, p_trampoline, p_object, r_callable_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.NativeInterop.godot_bool godotsharp_callable_get_data_for_marshalling(in global::Godot.NativeInterop.godot_callable p_callable, out global::System.IntPtr r_delegate_handle, out global::System.IntPtr r_trampoline, out global::System.IntPtr r_object, out global::Godot.NativeInterop.godot_string_name r_name)
    {
        global::Godot.NativeInterop.godot_callable* p_callable_ptr = (global::Godot.NativeInterop.godot_callable*)CustomUnsafe.ReadOnlyRefAsPointer(in p_callable);
        global::System.IntPtr r_delegate_handle_copy;
        global::System.IntPtr r_trampoline_copy;
        global::System.IntPtr r_object_copy;
        r_name = default;
        global::Godot.NativeInterop.godot_string_name* r_name_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.AsPointer(ref r_name);
        global::Godot.NativeInterop.godot_bool ret = _unmanagedCallbacks.godotsharp_callable_get_data_for_marshalling(p_callable_ptr, &r_delegate_handle_copy, &r_trampoline_copy, &r_object_copy, r_name_ptr);
        r_delegate_handle = r_delegate_handle_copy;
        r_trampoline = r_trampoline_copy;
        r_object = r_object_copy;
        return ret;
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.NativeInterop.godot_variant godotsharp_callable_call(in global::Godot.NativeInterop.godot_callable p_callable,  global::Godot.NativeInterop.godot_variant** p_args,  int p_arg_count, out global::Godot.NativeInterop.godot_variant_call_error p_call_error)
    {
        global::Godot.NativeInterop.godot_callable* p_callable_ptr = (global::Godot.NativeInterop.godot_callable*)CustomUnsafe.ReadOnlyRefAsPointer(in p_callable);
        p_call_error = default;
        global::Godot.NativeInterop.godot_variant_call_error* p_call_error_ptr = (global::Godot.NativeInterop.godot_variant_call_error*)CustomUnsafe.AsPointer(ref p_call_error);
        return _unmanagedCallbacks.godotsharp_callable_call(p_callable_ptr, p_args, p_arg_count, p_call_error_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_callable_call_deferred(in global::Godot.NativeInterop.godot_callable p_callable,  global::Godot.NativeInterop.godot_variant** p_args,  int p_arg_count)
    {
        global::Godot.NativeInterop.godot_callable* p_callable_ptr = (global::Godot.NativeInterop.godot_callable*)CustomUnsafe.ReadOnlyRefAsPointer(in p_callable);
        _unmanagedCallbacks.godotsharp_callable_call_deferred(p_callable_ptr, p_args, p_arg_count);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::Godot.Color godotsharp_color_from_ok_hsl( float p_h,  float p_s,  float p_l,  float p_alpha)
    {
        return _unmanagedCallbacks.godotsharp_color_from_ok_hsl(p_h, p_s, p_l, p_alpha);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_method_bind_ptrcall( global::System.IntPtr p_method_bind,  global::System.IntPtr p_instance,  void** p_args,  void* p_ret)
    {
        _unmanagedCallbacks.godotsharp_method_bind_ptrcall(p_method_bind, p_instance, p_args, p_ret);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_variant godotsharp_method_bind_call( global::System.IntPtr p_method_bind,  global::System.IntPtr p_instance,  global::Godot.NativeInterop.godot_variant** p_args,  int p_arg_count, out global::Godot.NativeInterop.godot_variant_call_error p_call_error)
    {
        p_call_error = default;
        global::Godot.NativeInterop.godot_variant_call_error* p_call_error_ptr = (global::Godot.NativeInterop.godot_variant_call_error*)CustomUnsafe.AsPointer(ref p_call_error);
        return _unmanagedCallbacks.godotsharp_method_bind_call(p_method_bind, p_instance, p_args, p_arg_count, p_call_error_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_string_name(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_string_name p_s)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string_name* p_s_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_s);
        _unmanagedCallbacks.godotsharp_variant_new_string_name(r_dest_ptr, p_s_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_copy(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_variant p_src)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_variant* p_src_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_src);
        _unmanagedCallbacks.godotsharp_variant_new_copy(r_dest_ptr, p_src_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_node_path(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_node_path p_np)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_node_path* p_np_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_np);
        _unmanagedCallbacks.godotsharp_variant_new_node_path(r_dest_ptr, p_np_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_object(out global::Godot.NativeInterop.godot_variant r_dest,  global::System.IntPtr p_obj)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_variant_new_object(r_dest_ptr, p_obj);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_transform2d(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.Transform2D p_t2d)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.Transform2D p_t2d_copy = p_t2d;
        _unmanagedCallbacks.godotsharp_variant_new_transform2d(r_dest_ptr, &p_t2d_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_basis(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.Basis p_basis)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.Basis p_basis_copy = p_basis;
        _unmanagedCallbacks.godotsharp_variant_new_basis(r_dest_ptr, &p_basis_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_transform3d(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.Transform3D p_trans)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.Transform3D p_trans_copy = p_trans;
        _unmanagedCallbacks.godotsharp_variant_new_transform3d(r_dest_ptr, &p_trans_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_projection(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.Projection p_proj)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.Projection p_proj_copy = p_proj;
        _unmanagedCallbacks.godotsharp_variant_new_projection(r_dest_ptr, &p_proj_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_aabb(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.Aabb p_aabb)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.Aabb p_aabb_copy = p_aabb;
        _unmanagedCallbacks.godotsharp_variant_new_aabb(r_dest_ptr, &p_aabb_copy);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_dictionary(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_dictionary p_dict)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_dictionary* p_dict_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.ReadOnlyRefAsPointer(in p_dict);
        _unmanagedCallbacks.godotsharp_variant_new_dictionary(r_dest_ptr, p_dict_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_array p_arr)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_array* p_arr_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_arr);
        _unmanagedCallbacks.godotsharp_variant_new_array(r_dest_ptr, p_arr_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_byte_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_byte_array p_pba)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_byte_array* p_pba_ptr = (global::Godot.NativeInterop.godot_packed_byte_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pba);
        _unmanagedCallbacks.godotsharp_variant_new_packed_byte_array(r_dest_ptr, p_pba_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_int32_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_int32_array p_pia)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_int32_array* p_pia_ptr = (global::Godot.NativeInterop.godot_packed_int32_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pia);
        _unmanagedCallbacks.godotsharp_variant_new_packed_int32_array(r_dest_ptr, p_pia_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_int64_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_int64_array p_pia)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_int64_array* p_pia_ptr = (global::Godot.NativeInterop.godot_packed_int64_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pia);
        _unmanagedCallbacks.godotsharp_variant_new_packed_int64_array(r_dest_ptr, p_pia_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_float32_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_float32_array p_pra)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_float32_array* p_pra_ptr = (global::Godot.NativeInterop.godot_packed_float32_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pra);
        _unmanagedCallbacks.godotsharp_variant_new_packed_float32_array(r_dest_ptr, p_pra_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_float64_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_float64_array p_pra)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_float64_array* p_pra_ptr = (global::Godot.NativeInterop.godot_packed_float64_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pra);
        _unmanagedCallbacks.godotsharp_variant_new_packed_float64_array(r_dest_ptr, p_pra_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_string_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_string_array p_psa)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_string_array* p_psa_ptr = (global::Godot.NativeInterop.godot_packed_string_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_psa);
        _unmanagedCallbacks.godotsharp_variant_new_packed_string_array(r_dest_ptr, p_psa_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_vector2_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_vector2_array p_pv2a)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_vector2_array* p_pv2a_ptr = (global::Godot.NativeInterop.godot_packed_vector2_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pv2a);
        _unmanagedCallbacks.godotsharp_variant_new_packed_vector2_array(r_dest_ptr, p_pv2a_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_vector3_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_vector3_array p_pv3a)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_vector3_array* p_pv3a_ptr = (global::Godot.NativeInterop.godot_packed_vector3_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pv3a);
        _unmanagedCallbacks.godotsharp_variant_new_packed_vector3_array(r_dest_ptr, p_pv3a_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_vector4_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_vector4_array p_pv4a)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_vector4_array* p_pv4a_ptr = (global::Godot.NativeInterop.godot_packed_vector4_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pv4a);
        _unmanagedCallbacks.godotsharp_variant_new_packed_vector4_array(r_dest_ptr, p_pv4a_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_new_packed_color_array(out global::Godot.NativeInterop.godot_variant r_dest, in global::Godot.NativeInterop.godot_packed_color_array p_pca)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_variant* r_dest_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_packed_color_array* p_pca_ptr = (global::Godot.NativeInterop.godot_packed_color_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_pca);
        _unmanagedCallbacks.godotsharp_variant_new_packed_color_array(r_dest_ptr, p_pca_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_variant_as_bool(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_bool(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial long godotsharp_variant_as_int(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_int(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial double godotsharp_variant_as_float(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_float(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_string godotsharp_variant_as_string(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_string(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector2 godotsharp_variant_as_vector2(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector2(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector2I godotsharp_variant_as_vector2i(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector2i(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Rect2 godotsharp_variant_as_rect2(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_rect2(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Rect2I godotsharp_variant_as_rect2i(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_rect2i(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector3 godotsharp_variant_as_vector3(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector3(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector3I godotsharp_variant_as_vector3i(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector3i(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Transform2D godotsharp_variant_as_transform2d(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_transform2d(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector4 godotsharp_variant_as_vector4(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector4(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Vector4I godotsharp_variant_as_vector4i(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_vector4i(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Plane godotsharp_variant_as_plane(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_plane(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Quaternion godotsharp_variant_as_quaternion(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_quaternion(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Aabb godotsharp_variant_as_aabb(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_aabb(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Basis godotsharp_variant_as_basis(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_basis(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Transform3D godotsharp_variant_as_transform3d(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_transform3d(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Projection godotsharp_variant_as_projection(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_projection(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Color godotsharp_variant_as_color(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_color(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_string_name godotsharp_variant_as_string_name(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_string_name(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_node_path godotsharp_variant_as_node_path(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_node_path(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Rid godotsharp_variant_as_rid(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_rid(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_callable godotsharp_variant_as_callable(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_callable(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_signal godotsharp_variant_as_signal(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_signal(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_dictionary godotsharp_variant_as_dictionary(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_dictionary(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_array godotsharp_variant_as_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_byte_array godotsharp_variant_as_packed_byte_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_byte_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_int32_array godotsharp_variant_as_packed_int32_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_int32_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_int64_array godotsharp_variant_as_packed_int64_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_int64_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_float32_array godotsharp_variant_as_packed_float32_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_float32_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_float64_array godotsharp_variant_as_packed_float64_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_float64_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_string_array godotsharp_variant_as_packed_string_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_string_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector2_array godotsharp_variant_as_packed_vector2_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_vector2_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector3_array godotsharp_variant_as_packed_vector3_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_vector3_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_vector4_array godotsharp_variant_as_packed_vector4_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_vector4_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_packed_color_array godotsharp_variant_as_packed_color_array(in global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_variant_as_packed_color_array(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_variant_equals(in global::Godot.NativeInterop.godot_variant p_a, in global::Godot.NativeInterop.godot_variant p_b)
    {
        global::Godot.NativeInterop.godot_variant* p_a_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_a);
        global::Godot.NativeInterop.godot_variant* p_b_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_b);
        return _unmanagedCallbacks.godotsharp_variant_equals(p_a_ptr, p_b_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_new_with_utf16_chars(out global::Godot.NativeInterop.godot_string r_dest,  char* p_contents)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_string* r_dest_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_string_new_with_utf16_chars(r_dest_ptr, p_contents);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_name_new_copy(out global::Godot.NativeInterop.godot_string_name r_dest, in global::Godot.NativeInterop.godot_string_name p_src)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_string_name* r_dest_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_string_name* p_src_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.ReadOnlyRefAsPointer(in p_src);
        _unmanagedCallbacks.godotsharp_string_name_new_copy(r_dest_ptr, p_src_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_new_copy(out global::Godot.NativeInterop.godot_node_path r_dest, in global::Godot.NativeInterop.godot_node_path p_src)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_node_path* r_dest_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_node_path* p_src_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_src);
        _unmanagedCallbacks.godotsharp_node_path_new_copy(r_dest_ptr, p_src_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_new(out global::Godot.NativeInterop.godot_array r_dest)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_array_new(r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_new_copy(out global::Godot.NativeInterop.godot_array r_dest, in global::Godot.NativeInterop.godot_array p_src)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_array* p_src_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_src);
        _unmanagedCallbacks.godotsharp_array_new_copy(r_dest_ptr, p_src_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_variant* godotsharp_array_ptrw(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        return _unmanagedCallbacks.godotsharp_array_ptrw(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_new(out global::Godot.NativeInterop.godot_dictionary r_dest)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_dictionary* r_dest_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_dictionary_new(r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_new_copy(out global::Godot.NativeInterop.godot_dictionary r_dest, in global::Godot.NativeInterop.godot_dictionary p_src)
    {
        r_dest = default;
        global::Godot.NativeInterop.godot_dictionary* r_dest_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref r_dest);
        global::Godot.NativeInterop.godot_dictionary* p_src_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.ReadOnlyRefAsPointer(in p_src);
        _unmanagedCallbacks.godotsharp_dictionary_new_copy(r_dest_ptr, p_src_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_byte_array_destroy(ref global::Godot.NativeInterop.godot_packed_byte_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_byte_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_byte_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_byte_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_int32_array_destroy(ref global::Godot.NativeInterop.godot_packed_int32_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_int32_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_int32_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_int32_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_int64_array_destroy(ref global::Godot.NativeInterop.godot_packed_int64_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_int64_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_int64_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_int64_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_float32_array_destroy(ref global::Godot.NativeInterop.godot_packed_float32_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_float32_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_float32_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_float32_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_float64_array_destroy(ref global::Godot.NativeInterop.godot_packed_float64_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_float64_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_float64_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_float64_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_string_array_destroy(ref global::Godot.NativeInterop.godot_packed_string_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_string_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_string_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_string_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_vector2_array_destroy(ref global::Godot.NativeInterop.godot_packed_vector2_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_vector2_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_vector2_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_vector2_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_vector3_array_destroy(ref global::Godot.NativeInterop.godot_packed_vector3_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_vector3_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_vector3_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_vector3_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_vector4_array_destroy(ref global::Godot.NativeInterop.godot_packed_vector4_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_vector4_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_vector4_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_vector4_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_packed_color_array_destroy(ref global::Godot.NativeInterop.godot_packed_color_array p_self)
    {
        global::Godot.NativeInterop.godot_packed_color_array* p_self_ptr = (global::Godot.NativeInterop.godot_packed_color_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_packed_color_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_variant_destroy(ref global::Godot.NativeInterop.godot_variant p_self)
    {
        global::Godot.NativeInterop.godot_variant* p_self_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_variant_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_destroy(ref global::Godot.NativeInterop.godot_string p_self)
    {
        global::Godot.NativeInterop.godot_string* p_self_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_string_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_name_destroy(ref global::Godot.NativeInterop.godot_string_name p_self)
    {
        global::Godot.NativeInterop.godot_string_name* p_self_ptr = (global::Godot.NativeInterop.godot_string_name*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_string_name_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_destroy(ref global::Godot.NativeInterop.godot_node_path p_self)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_node_path_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_signal_destroy(ref global::Godot.NativeInterop.godot_signal p_self)
    {
        global::Godot.NativeInterop.godot_signal* p_self_ptr = (global::Godot.NativeInterop.godot_signal*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_signal_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_callable_destroy(ref global::Godot.NativeInterop.godot_callable p_self)
    {
        global::Godot.NativeInterop.godot_callable* p_self_ptr = (global::Godot.NativeInterop.godot_callable*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_callable_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_destroy(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_destroy(ref global::Godot.NativeInterop.godot_dictionary p_self)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_dictionary_destroy(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_array_add(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_variant p_item)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_item_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_item);
        return _unmanagedCallbacks.godotsharp_array_add(p_self_ptr, p_item_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_array_add_range(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_array p_collection)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_array* p_collection_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_collection);
        return _unmanagedCallbacks.godotsharp_array_add_range(p_self_ptr, p_collection_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_array_binary_search(ref global::Godot.NativeInterop.godot_array p_self,  int p_index,  int p_count, in global::Godot.NativeInterop.godot_variant p_value)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_value);
        return _unmanagedCallbacks.godotsharp_array_binary_search(p_self_ptr, p_index, p_count, p_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_duplicate(ref global::Godot.NativeInterop.godot_array p_self,  global::Godot.NativeInterop.godot_bool p_deep, out global::Godot.NativeInterop.godot_array r_dest)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_array_duplicate(p_self_ptr, p_deep, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_fill(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_variant p_value)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_value);
        _unmanagedCallbacks.godotsharp_array_fill(p_self_ptr, p_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_array_index_of(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_variant p_item,  int p_index)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_item_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_item);
        return _unmanagedCallbacks.godotsharp_array_index_of(p_self_ptr, p_item_ptr, p_index);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_insert(ref global::Godot.NativeInterop.godot_array p_self,  int p_index, in global::Godot.NativeInterop.godot_variant p_item)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_item_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_item);
        _unmanagedCallbacks.godotsharp_array_insert(p_self_ptr, p_index, p_item_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_array_last_index_of(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_variant p_item,  int p_index)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_item_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_item);
        return _unmanagedCallbacks.godotsharp_array_last_index_of(p_self_ptr, p_item_ptr, p_index);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_make_read_only(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_make_read_only(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_max(ref global::Godot.NativeInterop.godot_array p_self, out global::Godot.NativeInterop.godot_variant r_value)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_value = default;
        global::Godot.NativeInterop.godot_variant* r_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_value);
        _unmanagedCallbacks.godotsharp_array_max(p_self_ptr, r_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_min(ref global::Godot.NativeInterop.godot_array p_self, out global::Godot.NativeInterop.godot_variant r_value)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_value = default;
        global::Godot.NativeInterop.godot_variant* r_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_value);
        _unmanagedCallbacks.godotsharp_array_min(p_self_ptr, r_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_pick_random(ref global::Godot.NativeInterop.godot_array p_self, out global::Godot.NativeInterop.godot_variant r_value)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_value = default;
        global::Godot.NativeInterop.godot_variant* r_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_value);
        _unmanagedCallbacks.godotsharp_array_pick_random(p_self_ptr, r_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_array_recursive_equal(ref global::Godot.NativeInterop.godot_array p_self, in global::Godot.NativeInterop.godot_array p_other)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_array* p_other_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_other);
        return _unmanagedCallbacks.godotsharp_array_recursive_equal(p_self_ptr, p_other_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_remove_at(ref global::Godot.NativeInterop.godot_array p_self,  int p_index)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_remove_at(p_self_ptr, p_index);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.Error godotsharp_array_resize(ref global::Godot.NativeInterop.godot_array p_self,  int p_new_size)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        return _unmanagedCallbacks.godotsharp_array_resize(p_self_ptr, p_new_size);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_reverse(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_reverse(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_shuffle(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_shuffle(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_slice(ref global::Godot.NativeInterop.godot_array p_self,  int p_start,  int p_end,  int p_step,  global::Godot.NativeInterop.godot_bool p_deep, out global::Godot.NativeInterop.godot_array r_dest)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_array_slice(p_self_ptr, p_start, p_end, p_step, p_deep, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_sort(ref global::Godot.NativeInterop.godot_array p_self)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_array_sort(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_array_to_string(ref global::Godot.NativeInterop.godot_array p_self, out global::Godot.NativeInterop.godot_string r_str)
    {
        global::Godot.NativeInterop.godot_array* p_self_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref p_self);
        r_str = default;
        global::Godot.NativeInterop.godot_string* r_str_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_str);
        _unmanagedCallbacks.godotsharp_array_to_string(p_self_ptr, r_str_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_dictionary_try_get_value(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_variant p_key, out global::Godot.NativeInterop.godot_variant r_value)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_key);
        r_value = default;
        global::Godot.NativeInterop.godot_variant* r_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_value);
        return _unmanagedCallbacks.godotsharp_dictionary_try_get_value(p_self_ptr, p_key_ptr, r_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_set_value(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_variant p_key, in global::Godot.NativeInterop.godot_variant p_value)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_key);
        global::Godot.NativeInterop.godot_variant* p_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_value);
        _unmanagedCallbacks.godotsharp_dictionary_set_value(p_self_ptr, p_key_ptr, p_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_keys(ref global::Godot.NativeInterop.godot_dictionary p_self, out global::Godot.NativeInterop.godot_array r_dest)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_dictionary_keys(p_self_ptr, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_values(ref global::Godot.NativeInterop.godot_dictionary p_self, out global::Godot.NativeInterop.godot_array r_dest)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        r_dest = default;
        global::Godot.NativeInterop.godot_array* r_dest_ptr = (global::Godot.NativeInterop.godot_array*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_dictionary_values(p_self_ptr, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_dictionary_count(ref global::Godot.NativeInterop.godot_dictionary p_self)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        return _unmanagedCallbacks.godotsharp_dictionary_count(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_key_value_pair_at(ref global::Godot.NativeInterop.godot_dictionary p_self,  int p_index, out global::Godot.NativeInterop.godot_variant r_key, out global::Godot.NativeInterop.godot_variant r_value)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        r_key = default;
        global::Godot.NativeInterop.godot_variant* r_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_key);
        r_value = default;
        global::Godot.NativeInterop.godot_variant* r_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_value);
        _unmanagedCallbacks.godotsharp_dictionary_key_value_pair_at(p_self_ptr, p_index, r_key_ptr, r_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_add(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_variant p_key, in global::Godot.NativeInterop.godot_variant p_value)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_key);
        global::Godot.NativeInterop.godot_variant* p_value_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_value);
        _unmanagedCallbacks.godotsharp_dictionary_add(p_self_ptr, p_key_ptr, p_value_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_clear(ref global::Godot.NativeInterop.godot_dictionary p_self)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_dictionary_clear(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_dictionary_contains_key(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_variant p_key)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_key);
        return _unmanagedCallbacks.godotsharp_dictionary_contains_key(p_self_ptr, p_key_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_duplicate(ref global::Godot.NativeInterop.godot_dictionary p_self,  global::Godot.NativeInterop.godot_bool p_deep, out global::Godot.NativeInterop.godot_dictionary r_dest)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        r_dest = default;
        global::Godot.NativeInterop.godot_dictionary* r_dest_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_dictionary_duplicate(p_self_ptr, p_deep, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_merge(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_dictionary p_dictionary,  global::Godot.NativeInterop.godot_bool p_overwrite)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_dictionary* p_dictionary_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.ReadOnlyRefAsPointer(in p_dictionary);
        _unmanagedCallbacks.godotsharp_dictionary_merge(p_self_ptr, p_dictionary_ptr, p_overwrite);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_dictionary_recursive_equal(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_dictionary p_other)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_dictionary* p_other_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.ReadOnlyRefAsPointer(in p_other);
        return _unmanagedCallbacks.godotsharp_dictionary_recursive_equal(p_self_ptr, p_other_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_dictionary_remove_key(ref global::Godot.NativeInterop.godot_dictionary p_self, in global::Godot.NativeInterop.godot_variant p_key)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        global::Godot.NativeInterop.godot_variant* p_key_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_key);
        return _unmanagedCallbacks.godotsharp_dictionary_remove_key(p_self_ptr, p_key_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_make_read_only(ref global::Godot.NativeInterop.godot_dictionary p_self)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        _unmanagedCallbacks.godotsharp_dictionary_make_read_only(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_dictionary_to_string(ref global::Godot.NativeInterop.godot_dictionary p_self, out global::Godot.NativeInterop.godot_string r_str)
    {
        global::Godot.NativeInterop.godot_dictionary* p_self_ptr = (global::Godot.NativeInterop.godot_dictionary*)CustomUnsafe.AsPointer(ref p_self);
        r_str = default;
        global::Godot.NativeInterop.godot_string* r_str_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_str);
        _unmanagedCallbacks.godotsharp_dictionary_to_string(p_self_ptr, r_str_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_simplify_path(in global::Godot.NativeInterop.godot_string p_self, out global::Godot.NativeInterop.godot_string r_simplified_path)
    {
        global::Godot.NativeInterop.godot_string* p_self_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_simplified_path = default;
        global::Godot.NativeInterop.godot_string* r_simplified_path_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_simplified_path);
        _unmanagedCallbacks.godotsharp_string_simplify_path(p_self_ptr, r_simplified_path_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_to_camel_case(in global::Godot.NativeInterop.godot_string p_self, out global::Godot.NativeInterop.godot_string r_camel_case)
    {
        global::Godot.NativeInterop.godot_string* p_self_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_camel_case = default;
        global::Godot.NativeInterop.godot_string* r_camel_case_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_camel_case);
        _unmanagedCallbacks.godotsharp_string_to_camel_case(p_self_ptr, r_camel_case_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_to_pascal_case(in global::Godot.NativeInterop.godot_string p_self, out global::Godot.NativeInterop.godot_string r_pascal_case)
    {
        global::Godot.NativeInterop.godot_string* p_self_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_pascal_case = default;
        global::Godot.NativeInterop.godot_string* r_pascal_case_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_pascal_case);
        _unmanagedCallbacks.godotsharp_string_to_pascal_case(p_self_ptr, r_pascal_case_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_string_to_snake_case(in global::Godot.NativeInterop.godot_string p_self, out global::Godot.NativeInterop.godot_string r_snake_case)
    {
        global::Godot.NativeInterop.godot_string* p_self_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_snake_case = default;
        global::Godot.NativeInterop.godot_string* r_snake_case_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_snake_case);
        _unmanagedCallbacks.godotsharp_string_to_snake_case(p_self_ptr, r_snake_case_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_get_as_property_path(in global::Godot.NativeInterop.godot_node_path p_self, ref global::Godot.NativeInterop.godot_node_path r_dest)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        global::Godot.NativeInterop.godot_node_path* r_dest_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.AsPointer(ref r_dest);
        _unmanagedCallbacks.godotsharp_node_path_get_as_property_path(p_self_ptr, r_dest_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_get_concatenated_names(in global::Godot.NativeInterop.godot_node_path p_self, out global::Godot.NativeInterop.godot_string r_names)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_names = default;
        global::Godot.NativeInterop.godot_string* r_names_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_names);
        _unmanagedCallbacks.godotsharp_node_path_get_concatenated_names(p_self_ptr, r_names_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_get_concatenated_subnames(in global::Godot.NativeInterop.godot_node_path p_self, out global::Godot.NativeInterop.godot_string r_subnames)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_subnames = default;
        global::Godot.NativeInterop.godot_string* r_subnames_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_subnames);
        _unmanagedCallbacks.godotsharp_node_path_get_concatenated_subnames(p_self_ptr, r_subnames_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_get_name(in global::Godot.NativeInterop.godot_node_path p_self,  int p_idx, out global::Godot.NativeInterop.godot_string r_name)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_name = default;
        global::Godot.NativeInterop.godot_string* r_name_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_name);
        _unmanagedCallbacks.godotsharp_node_path_get_name(p_self_ptr, p_idx, r_name_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_node_path_get_name_count(in global::Godot.NativeInterop.godot_node_path p_self)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_node_path_get_name_count(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_node_path_get_subname(in global::Godot.NativeInterop.godot_node_path p_self,  int p_idx, out global::Godot.NativeInterop.godot_string r_subname)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        r_subname = default;
        global::Godot.NativeInterop.godot_string* r_subname_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_subname);
        _unmanagedCallbacks.godotsharp_node_path_get_subname(p_self_ptr, p_idx, r_subname_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_node_path_get_subname_count(in global::Godot.NativeInterop.godot_node_path p_self)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_node_path_get_subname_count(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_node_path_is_absolute(in global::Godot.NativeInterop.godot_node_path p_self)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_node_path_is_absolute(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial global::Godot.NativeInterop.godot_bool godotsharp_node_path_equals(in global::Godot.NativeInterop.godot_node_path p_self, in global::Godot.NativeInterop.godot_node_path p_other)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        global::Godot.NativeInterop.godot_node_path* p_other_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_other);
        return _unmanagedCallbacks.godotsharp_node_path_equals(p_self_ptr, p_other_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial int godotsharp_node_path_hash(in global::Godot.NativeInterop.godot_node_path p_self)
    {
        global::Godot.NativeInterop.godot_node_path* p_self_ptr = (global::Godot.NativeInterop.godot_node_path*)CustomUnsafe.ReadOnlyRefAsPointer(in p_self);
        return _unmanagedCallbacks.godotsharp_node_path_hash(p_self_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_bytes_to_var(in global::Godot.NativeInterop.godot_packed_byte_array p_bytes,  global::Godot.NativeInterop.godot_bool p_allow_objects, out global::Godot.NativeInterop.godot_variant r_ret)
    {
        global::Godot.NativeInterop.godot_packed_byte_array* p_bytes_ptr = (global::Godot.NativeInterop.godot_packed_byte_array*)CustomUnsafe.ReadOnlyRefAsPointer(in p_bytes);
        r_ret = default;
        global::Godot.NativeInterop.godot_variant* r_ret_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_ret);
        _unmanagedCallbacks.godotsharp_bytes_to_var(p_bytes_ptr, p_allow_objects, r_ret_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_convert(in global::Godot.NativeInterop.godot_variant p_what,  int p_type, out global::Godot.NativeInterop.godot_variant r_ret)
    {
        global::Godot.NativeInterop.godot_variant* p_what_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        r_ret = default;
        global::Godot.NativeInterop.godot_variant* r_ret_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_ret);
        _unmanagedCallbacks.godotsharp_convert(p_what_ptr, p_type, r_ret_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial int godotsharp_hash(in global::Godot.NativeInterop.godot_variant p_var)
    {
        global::Godot.NativeInterop.godot_variant* p_var_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_var);
        return _unmanagedCallbacks.godotsharp_hash(p_var_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial global::System.IntPtr godotsharp_instance_from_id( ulong p_instance_id)
    {
        return _unmanagedCallbacks.godotsharp_instance_from_id(p_instance_id);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_print(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_print(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_print_rich(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_print_rich(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_printerr(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_printerr(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_printraw(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_printraw(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_prints(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_prints(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_printt(in global::Godot.NativeInterop.godot_string p_what)
    {
        global::Godot.NativeInterop.godot_string* p_what_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        _unmanagedCallbacks.godotsharp_printt(p_what_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial float godotsharp_randf()
    {
        return _unmanagedCallbacks.godotsharp_randf();
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial uint godotsharp_randi()
    {
        return _unmanagedCallbacks.godotsharp_randi();
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_randomize()
    {
        _unmanagedCallbacks.godotsharp_randomize();
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial double godotsharp_randf_range( double from,  double to)
    {
        return _unmanagedCallbacks.godotsharp_randf_range(from, to);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial double godotsharp_randfn( double mean,  double deviation)
    {
        return _unmanagedCallbacks.godotsharp_randfn(mean, deviation);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial int godotsharp_randi_range( int from,  int to)
    {
        return _unmanagedCallbacks.godotsharp_randi_range(from, to);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial uint godotsharp_rand_from_seed( ulong seed, out ulong newSeed)
    {
        ulong newSeed_copy;
        uint ret = _unmanagedCallbacks.godotsharp_rand_from_seed(seed, &newSeed_copy);
        newSeed = newSeed_copy;
        return ret;
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_seed( ulong seed)
    {
        _unmanagedCallbacks.godotsharp_seed(seed);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_weakref( global::System.IntPtr p_obj, out global::Godot.NativeInterop.godot_ref r_weak_ref)
    {
        r_weak_ref = default;
        global::Godot.NativeInterop.godot_ref* r_weak_ref_ptr = (global::Godot.NativeInterop.godot_ref*)CustomUnsafe.AsPointer(ref r_weak_ref);
        _unmanagedCallbacks.godotsharp_weakref(p_obj, r_weak_ref_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_str_to_var(in global::Godot.NativeInterop.godot_string p_str, out global::Godot.NativeInterop.godot_variant r_ret)
    {
        global::Godot.NativeInterop.godot_string* p_str_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_str);
        r_ret = default;
        global::Godot.NativeInterop.godot_variant* r_ret_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.AsPointer(ref r_ret);
        _unmanagedCallbacks.godotsharp_str_to_var(p_str_ptr, r_ret_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_var_to_bytes(in global::Godot.NativeInterop.godot_variant p_what,  global::Godot.NativeInterop.godot_bool p_full_objects, out global::Godot.NativeInterop.godot_packed_byte_array r_bytes)
    {
        global::Godot.NativeInterop.godot_variant* p_what_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_what);
        r_bytes = default;
        global::Godot.NativeInterop.godot_packed_byte_array* r_bytes_ptr = (global::Godot.NativeInterop.godot_packed_byte_array*)CustomUnsafe.AsPointer(ref r_bytes);
        _unmanagedCallbacks.godotsharp_var_to_bytes(p_what_ptr, p_full_objects, r_bytes_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_var_to_str(in global::Godot.NativeInterop.godot_variant p_var, out global::Godot.NativeInterop.godot_string r_ret)
    {
        global::Godot.NativeInterop.godot_variant* p_var_ptr = (global::Godot.NativeInterop.godot_variant*)CustomUnsafe.ReadOnlyRefAsPointer(in p_var);
        r_ret = default;
        global::Godot.NativeInterop.godot_string* r_ret_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_ret);
        _unmanagedCallbacks.godotsharp_var_to_str(p_var_ptr, r_ret_ptr);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    internal static partial void godotsharp_err_print_error(in global::Godot.NativeInterop.godot_string p_function, in global::Godot.NativeInterop.godot_string p_file,  int p_line, in global::Godot.NativeInterop.godot_string p_error, in global::Godot.NativeInterop.godot_string p_message,  global::Godot.NativeInterop.godot_bool p_editor_notify,  global::Godot.NativeInterop.godot_error_handler_type p_type)
    {
        global::Godot.NativeInterop.godot_string* p_function_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_function);
        global::Godot.NativeInterop.godot_string* p_file_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_file);
        global::Godot.NativeInterop.godot_string* p_error_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_error);
        global::Godot.NativeInterop.godot_string* p_message_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.ReadOnlyRefAsPointer(in p_message);
        _unmanagedCallbacks.godotsharp_err_print_error(p_function_ptr, p_file_ptr, p_line, p_error_ptr, p_message_ptr, p_editor_notify, p_type);
    }

    [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public static partial void godotsharp_object_to_string( global::System.IntPtr ptr, out global::Godot.NativeInterop.godot_string r_str)
    {
        r_str = default;
        global::Godot.NativeInterop.godot_string* r_str_ptr = (global::Godot.NativeInterop.godot_string*)CustomUnsafe.AsPointer(ref r_str);
        _unmanagedCallbacks.godotsharp_object_to_string(ptr, r_str_ptr);
    }

}

}

#pragma warning restore CA1707
