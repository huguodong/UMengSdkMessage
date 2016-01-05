using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']"
	[global::Android.Runtime.Register ("org/android/agoo/service/AgooService", DoNotGenerateAcw=true)]
	public abstract partial class AgooService : global::Android.App.Service {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/service/AgooService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooService); }
		}

		protected AgooService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/constructor[@name='AgooService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AgooService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AgooService)) {
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

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "")]
		public override sealed global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "")]
		public override sealed void OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onCreate);
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public override sealed void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
		}

		static IntPtr id_onStartCommand_Landroid_content_Intent_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/method[@name='onStartCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;II)I", "")]
		public override sealed global::Android.App.StartCommandResult OnStartCommand (global::Android.Content.Intent p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.StartCommandFlags p1, int p2)
		{
			if (id_onStartCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_onStartCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "onStartCommand", "(Landroid/content/Intent;II)I");
			global::Android.App.StartCommandResult __ret = (global::Android.App.StartCommandResult) JNIEnv.CallIntMethod  (Handle, id_onStartCommand_Landroid_content_Intent_II, new JValue (p0), new JValue ((int) p1), new JValue (p2));
			return __ret;
		}

		static IntPtr id_onUnbind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='AgooService']/method[@name='onUnbind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onUnbind", "(Landroid/content/Intent;)Z", "")]
		public override sealed bool OnUnbind (global::Android.Content.Intent p0)
		{
			if (id_onUnbind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUnbind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onUnbind_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("org/android/agoo/service/AgooService", DoNotGenerateAcw=true)]
	internal partial class AgooServiceInvoker : AgooService {

		public AgooServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgooServiceInvoker); }
		}

	}

}
