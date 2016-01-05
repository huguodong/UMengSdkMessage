using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.proxy']/class[@name='ProxyFactroy']"
	[global::Android.Runtime.Register ("org/android/agoo/proxy/ProxyFactroy", DoNotGenerateAcw=true)]
	public partial class ProxyFactroy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/proxy/ProxyFactroy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProxyFactroy); }
		}

		protected ProxyFactroy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.proxy']/class[@name='ProxyFactroy']/constructor[@name='ProxyFactroy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProxyFactroy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProxyFactroy)) {
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

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.proxy']/class[@name='ProxyFactroy']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object GetInstance (global::Android.Content.Context p0, string p1)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
