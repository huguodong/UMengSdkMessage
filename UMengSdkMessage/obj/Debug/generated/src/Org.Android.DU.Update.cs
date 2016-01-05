using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.DU {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.du']/class[@name='Update']"
	[global::Android.Runtime.Register ("org/android/du/Update", DoNotGenerateAcw=true)]
	public partial class Update : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.du']/class[@name='Update']/field[@name='ACTION_DU_UPDATE_SUCCESS']"
		[Register ("ACTION_DU_UPDATE_SUCCESS")]
		public const string ActionDuUpdateSuccess = (string) "com.taobao.du.update";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/du/Update", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Update); }
		}

		protected Update (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.du']/class[@name='Update']/constructor[@name='Update' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		protected Update (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Update)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getClassLoader;
#pragma warning disable 0169
		static Delegate GetGetClassLoaderHandler ()
		{
			if (cb_getClassLoader == null)
				cb_getClassLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassLoader);
			return cb_getClassLoader;
		}

		static IntPtr n_GetClassLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassLoader);
		}
#pragma warning restore 0169

		static IntPtr id_getClassLoader;
		public virtual global::Java.Lang.ClassLoader ClassLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='getClassLoader' and count(parameter)=0]"
			[Register ("getClassLoader", "()Ljava/lang/ClassLoader;", "GetGetClassLoaderHandler")]
			get {
				if (id_getClassLoader == IntPtr.Zero)
					id_getClassLoader = JNIEnv.GetMethodID (class_ref, "getClassLoader", "()Ljava/lang/ClassLoader;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (JNIEnv.CallObjectMethod  (Handle, id_getClassLoader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassLoader", "()Ljava/lang/ClassLoader;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBean_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetBean_Ljava_lang_Class_Handler ()
		{
			if (cb_getBean_Ljava_lang_Class_ == null)
				cb_getBean_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBean_Ljava_lang_Class_);
			return cb_getBean_Ljava_lang_Class_;
		}

		static IntPtr n_GetBean_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBean (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBean_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='getBean' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getBean", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetBean_Ljava_lang_Class_Handler")]
		public virtual global::Java.Lang.Object GetBean (global::Java.Lang.Class p0)
		{
			if (id_getBean_Ljava_lang_Class_ == IntPtr.Zero)
				id_getBean_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getBean", "(Ljava/lang/Class;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBean_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBean", "(Ljava/lang/Class;)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getBean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBean_Ljava_lang_String_Handler ()
		{
			if (cb_getBean_Ljava_lang_String_ == null)
				cb_getBean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBean_Ljava_lang_String_);
			return cb_getBean_Ljava_lang_String_;
		}

		static IntPtr n_GetBean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBean (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='getBean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBean", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetBean_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Object GetBean (string p0)
		{
			if (id_getBean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBean", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBean_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBean", "(Ljava/lang/String;)Ljava/lang/Object;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getBean_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBean_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBean_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBean_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBean_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBean_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBean_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBean_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='getBean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBean", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "GetGetBean_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Object GetBean (string p0, string p1)
		{
			if (id_getBean_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBean_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBean", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBean_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBean", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == null)
				cb_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_);
			return cb_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] p1 = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClassInstance (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='getClassInstance' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class[]'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("getClassInstance", "(Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "GetGetClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object GetClassInstance (string p0, global::Java.Lang.Class[] p1, global::Java.Lang.Object[] p2)
		{
			if (id_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getClassInstance", "(Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getClassInstance_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassInstance", "(Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler ()
		{
			if (cb_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == null)
				cb_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_);
			return cb_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		}

		static IntPtr n_InvokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] p2 = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeClassMethod (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='invokeClassMethod' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("invokeClassMethod", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object InvokeClassMethod (string p0, string p1, global::Java.Lang.Class[] p2, global::Java.Lang.Object[] p3)
		{
			if (id_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invokeClassMethod", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_invokeClassMethod_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invokeClassMethod", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler ()
		{
			if (cb_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == null)
				cb_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_);
			return cb_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		}

		static IntPtr n_InvokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class[] p2 = (global::Java.Lang.Class[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Class));
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeMethod (p0, p1, p2, p3));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='invokeMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object p0, string p1, global::Java.Lang.Class[] p2, global::Java.Lang.Object[] p3)
		{
			if (id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_invokeMethod_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Class_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_ismLoadclassSuccess;
#pragma warning disable 0169
		static Delegate GetIsmLoadclassSuccessHandler ()
		{
			if (cb_ismLoadclassSuccess == null)
				cb_ismLoadclassSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsmLoadclassSuccess);
			return cb_ismLoadclassSuccess;
		}

		static bool n_IsmLoadclassSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsmLoadclassSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_ismLoadclassSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='ismLoadclassSuccess' and count(parameter)=0]"
		[Register ("ismLoadclassSuccess", "()Z", "GetIsmLoadclassSuccessHandler")]
		public virtual bool IsmLoadclassSuccess ()
		{
			if (id_ismLoadclassSuccess == IntPtr.Zero)
				id_ismLoadclassSuccess = JNIEnv.GetMethodID (class_ref, "ismLoadclassSuccess", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_ismLoadclassSuccess);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ismLoadclassSuccess", "()Z"));
		}

		static Delegate cb_setmLoadclassSuccess_Z;
#pragma warning disable 0169
		static Delegate GetSetmLoadclassSuccess_ZHandler ()
		{
			if (cb_setmLoadclassSuccess_Z == null)
				cb_setmLoadclassSuccess_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetmLoadclassSuccess_Z);
			return cb_setmLoadclassSuccess_Z;
		}

		static void n_SetmLoadclassSuccess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Android.DU.Update __this = global::Java.Lang.Object.GetObject<global::Org.Android.DU.Update> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmLoadclassSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmLoadclassSuccess_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='Update']/method[@name='setmLoadclassSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setmLoadclassSuccess", "(Z)V", "GetSetmLoadclassSuccess_ZHandler")]
		public virtual void SetmLoadclassSuccess (bool p0)
		{
			if (id_setmLoadclassSuccess_Z == IntPtr.Zero)
				id_setmLoadclassSuccess_Z = JNIEnv.GetMethodID (class_ref, "setmLoadclassSuccess", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setmLoadclassSuccess_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmLoadclassSuccess", "(Z)V"), new JValue (p0));
		}

	}
}
