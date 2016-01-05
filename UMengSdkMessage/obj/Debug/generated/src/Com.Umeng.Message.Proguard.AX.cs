using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aX", DoNotGenerateAcw=true)]
	public partial class AX : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/field[@name='c']"
		[Register ("c")]
		public const string C = (string) "agoo.pid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/field[@name='d']"
		[Register ("d")]
		public const string D = (string) "startservice -a {packname}.intent.action.COCKROACH --es cockroach cockroach-PPreotect --es pack {packname}";

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/field[@name='e']"
		[Register ("e")]
		public bool E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				return JNIEnv.GetBooleanField (Handle, e_jfieldId);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				JNIEnv.SetField (Handle, e_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aX", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AX); }
		}

		protected AX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/constructor[@name='aX' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;IZ)V", "")]
		public AX (global::Android.Content.Context p0, int p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AX)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;IZ)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;IZ)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_IZ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IZ, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_IZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AX __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Landroid/app/PendingIntent;", "")]
		public static global::Android.App.PendingIntent A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Landroid/app/PendingIntent;");
			global::Android.App.PendingIntent __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("a", "(Landroid/content/Context;IZ)Lcom/umeng/message/proguard/aX;", "")]
		public static global::Com.Umeng.Message.Proguard.AX A (global::Android.Content.Context p0, int p1, bool p2)
		{
			if (id_a_Landroid_content_Context_IZ == IntPtr.Zero)
				id_a_Landroid_content_Context_IZ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;IZ)Lcom/umeng/message/proguard/aX;");
			global::Com.Umeng.Message.Proguard.AX __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AX> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_IZ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AX __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aX']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)V", "")]
		public static void B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_, new JValue (p0));
		}

	}
}
