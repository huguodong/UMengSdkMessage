using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aR", DoNotGenerateAcw=true)]
	public partial class AR : global::Com.Umeng.Message.Proguard.AN {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/field[@name='g']"
		[Register ("g")]
		public const string G = (string) "10";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/field[@name='h']"
		[Register ("h")]
		public const string H = (string) "11";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/field[@name='j']"
		[Register ("j")]
		public const string J = (string) "13";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/field[@name='k']"
		[Register ("k")]
		public const string K = (string) "14";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aR", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AR); }
		}

		protected AR (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/constructor[@name='aR' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aO']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/umeng/message/proguard/aO;)V", "")]
		public AR (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.IAO p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AR)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/umeng/message/proguard/aO;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/umeng/message/proguard/aO;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/umeng/message/proguard/aO;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_a_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_a_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_Landroid_content_Intent_);
			return cb_a_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_A_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetA_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override void A (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_a_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void A (string p0, string p1, string p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_a_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Map_Handler ()
		{
			if (cb_a_Ljava_util_Map_ == null)
				cb_a_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Map_);
			return cb_a_Ljava_util_Map_;
		}

		static void n_A_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)V", "GetA_Ljava_util_Map_Handler")]
		protected virtual void A (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/Map;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_E);
			return cb_e;
		}

		static void n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.E ();
		}
#pragma warning restore 0169

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "GetEHandler")]
		public override void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_e);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "()V"));
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_F);
			return cb_f;
		}

		static bool n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.F ();
		}
#pragma warning restore 0169

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "GetFHandler")]
		public override bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_f);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "()Z"));
		}

		static Delegate cb_f_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetF_Ljava_lang_String_Handler ()
		{
			if (cb_f_Ljava_lang_String_ == null)
				cb_f_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_F_Ljava_lang_String_);
			return cb_f_Ljava_lang_String_;
		}

		static void n_F_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AR __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AR> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.F (p0);
		}
#pragma warning restore 0169

		static IntPtr id_f_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='f' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("f", "(Ljava/lang/String;)V", "GetF_Ljava_lang_String_Handler")]
		public virtual void F (string p0)
		{
			if (id_f_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "f", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_f_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aR']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "")]
		public void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_i);
		}

	}
}
