using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='Internal']"
	[global::Android.Runtime.Register ("com/google/protobuf/Internal", DoNotGenerateAcw=true)]
	public partial class Internal : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Internal.EnumLite']"
		[Register ("com/google/protobuf/Internal$EnumLite", "", "Com.Google.Protobuf.Internal/IEnumLiteInvoker")]
		public partial interface IEnumLite : IJavaObject {

			int Number {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Internal.EnumLite']/method[@name='getNumber' and count(parameter)=0]"
				[Register ("getNumber", "()I", "GetGetNumberHandler:Com.Google.Protobuf.Internal/IEnumLiteInvoker, UMengSdkMessage")] get;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/Internal$EnumLite", DoNotGenerateAcw=true)]
		internal class IEnumLiteInvoker : global::Java.Lang.Object, IEnumLite {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/Internal$EnumLite");
			IntPtr class_ref;

			public static IEnumLite GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEnumLite> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.Internal.EnumLite"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnumLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEnumLiteInvoker); }
			}

			static Delegate cb_getNumber;
#pragma warning disable 0169
			static Delegate GetGetNumberHandler ()
			{
				if (cb_getNumber == null)
					cb_getNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumber);
				return cb_getNumber;
			}

			static int n_GetNumber (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.Internal.IEnumLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Internal.IEnumLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Number;
			}
#pragma warning restore 0169

			IntPtr id_getNumber;
			public int Number {
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getNumber);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Internal.EnumLiteMap']"
		[Register ("com/google/protobuf/Internal$EnumLiteMap", "", "Com.Google.Protobuf.Internal/IEnumLiteMapInvoker")]
		public partial interface IEnumLiteMap : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/interface[@name='Internal.EnumLiteMap']/method[@name='findValueByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("findValueByNumber", "(I)Ljava/lang/Object;", "GetFindValueByNumber_IHandler:Com.Google.Protobuf.Internal/IEnumLiteMapInvoker, UMengSdkMessage")]
			global::Java.Lang.Object FindValueByNumber (int p0);

		}

		[global::Android.Runtime.Register ("com/google/protobuf/Internal$EnumLiteMap", DoNotGenerateAcw=true)]
		internal class IEnumLiteMapInvoker : global::Java.Lang.Object, IEnumLiteMap {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/protobuf/Internal$EnumLiteMap");
			IntPtr class_ref;

			public static IEnumLiteMap GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEnumLiteMap> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.protobuf.Internal.EnumLiteMap"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEnumLiteMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IEnumLiteMapInvoker); }
			}

			static Delegate cb_findValueByNumber_I;
#pragma warning disable 0169
			static Delegate GetFindValueByNumber_IHandler ()
			{
				if (cb_findValueByNumber_I == null)
					cb_findValueByNumber_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FindValueByNumber_I);
				return cb_findValueByNumber_I;
			}

			static IntPtr n_FindValueByNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Protobuf.Internal.IEnumLiteMap __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.Internal.IEnumLiteMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FindValueByNumber (p0));
			}
#pragma warning restore 0169

			IntPtr id_findValueByNumber_I;
			public global::Java.Lang.Object FindValueByNumber (int p0)
			{
				if (id_findValueByNumber_I == IntPtr.Zero)
					id_findValueByNumber_I = JNIEnv.GetMethodID (class_ref, "findValueByNumber", "(I)Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_findValueByNumber_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/Internal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Internal); }
		}

		protected Internal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='Internal']/constructor[@name='Internal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Internal () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Internal)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_stringDefaultValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='Internal']/method[@name='stringDefaultValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringDefaultValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string StringDefaultValue (string p0)
		{
			if (id_stringDefaultValue_Ljava_lang_String_ == IntPtr.Zero)
				id_stringDefaultValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringDefaultValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringDefaultValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
