using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Mtop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHelper']"
	[global::Android.Runtime.Register ("org/android/agoo/net/mtop/MtopResponseHelper", DoNotGenerateAcw=true)]
	public partial class MtopResponseHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHelper']/field[@name='a']"
		[Register ("a")]
		public const string A = (string) "SUCCESS";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHelper']/field[@name='b']"
		[Register ("b")]
		public const string B = (string) "FAIL";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/mtop/MtopResponseHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopResponseHelper); }
		}

		protected MtopResponseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHelper']/constructor[@name='MtopResponseHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopResponseHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopResponseHelper)) {
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

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopResponseHelper']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lorg/android/agoo/net/mtop/Result;", "")]
		public static global::Org.Android.Agoo.Net.Mtop.Result Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lorg/android/agoo/net/mtop/Result;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Agoo.Net.Mtop.Result __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.Result> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
