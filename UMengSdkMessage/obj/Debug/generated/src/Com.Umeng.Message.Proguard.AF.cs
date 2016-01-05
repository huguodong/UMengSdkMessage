using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aF", DoNotGenerateAcw=true)]
	public partial class AF : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='c']"
		[Register ("c")]
		public const string C = (string) "updateInfo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='d']"
		[Register ("d")]
		public const string D = (string) "info";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='e']"
		[Register ("e")]
		public const string E = (string) "name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='f']"
		[Register ("f")]
		public const string F = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='g']"
		[Register ("g")]
		public const string G = (string) "size";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='h']"
		[Register ("h")]
		public const string H = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/field[@name='i']"
		[Register ("i")]
		public const string I = (string) "version";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aF", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AF); }
		}

		protected AF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/constructor[@name='aF' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AF () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AF)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_a_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.HashMap']]"
		[Register ("a", "(Ljava/util/HashMap;)V", "")]
		public void A (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_a_Ljava_util_HashMap_ == IntPtr.Zero)
				id_a_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/HashMap;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_HashMap_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aF']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/umeng/message/proguard/aG;", "")]
		public global::Com.Umeng.Message.Proguard.AG B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lcom/umeng/message/proguard/aG;");
			return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AG> (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

	}
}
