using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aN", DoNotGenerateAcw=true)]
	public abstract partial class AN : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aN", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AN); }
		}

		protected AN (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_umeng_message_proguard_aO_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/constructor[@name='aN' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aO']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/umeng/message/proguard/aO;)V", "")]
		protected AN (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.IAO p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AN)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		protected virtual string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetA_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public abstract void A (global::Android.Content.Context p0, global::Android.Content.Intent p1);

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler")]
		public virtual void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_a_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_a_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_a_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_a_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_A_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("a", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetA_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		protected virtual void A (string p0, global::Android.OS.Bundle p1)
		{
			if (id_a_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Landroid/os/Bundle;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_a_Ljava_lang_String_Landroid_os_Bundle_J;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Landroid_os_Bundle_JHandler ()
		{
			if (cb_a_Ljava_lang_String_Landroid_os_Bundle_J == null)
				cb_a_Ljava_lang_String_Landroid_os_Bundle_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_A_Ljava_lang_String_Landroid_os_Bundle_J);
			return cb_a_Ljava_lang_String_Landroid_os_Bundle_J;
		}

		static void n_A_Ljava_lang_String_Landroid_os_Bundle_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Landroid_os_Bundle_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='long']]"
		[Register ("a", "(Ljava/lang/String;Landroid/os/Bundle;J)V", "GetA_Ljava_lang_String_Landroid_os_Bundle_JHandler")]
		public virtual void A (string p0, global::Android.OS.Bundle p1, long p2)
		{
			if (id_a_Ljava_lang_String_Landroid_os_Bundle_J == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_os_Bundle_J = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/os/Bundle;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Landroid_os_Bundle_J, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Landroid/os/Bundle;J)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_a_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_JHandler ()
		{
			if (cb_a_Ljava_lang_String_J == null)
				cb_a_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_A_Ljava_lang_String_J);
			return cb_a_Ljava_lang_String_J;
		}

		static void n_A_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("a", "(Ljava/lang/String;J)V", "GetA_Ljava_lang_String_JHandler")]
		public virtual void A (string p0, long p1)
		{
			if (id_a_Ljava_lang_String_J == IntPtr.Zero)
				id_a_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;J)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_a_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_arrayLjava_lang_String_Handler ()
		{
			if (cb_a_arrayLjava_lang_String_ == null)
				cb_a_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_arrayLjava_lang_String_);
			return cb_a_arrayLjava_lang_String_;
		}

		static void n_A_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.A (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("a", "([Ljava/lang/String;)V", "GetA_arrayLjava_lang_String_Handler")]
		protected virtual void A (params  string[] p0)
		{
			if (id_a_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "([Ljava/lang/String;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B ());
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "GetBHandler")]
		protected virtual string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_b), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_b_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_;
		}

		static void n_B_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "GetB_Ljava_lang_String_Handler")]
		public virtual void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_b_Ljava_lang_String_Landroid_os_Bundle_J;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Landroid_os_Bundle_JHandler ()
		{
			if (cb_b_Ljava_lang_String_Landroid_os_Bundle_J == null)
				cb_b_Ljava_lang_String_Landroid_os_Bundle_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_B_Ljava_lang_String_Landroid_os_Bundle_J);
			return cb_b_Ljava_lang_String_Landroid_os_Bundle_J;
		}

		static void n_B_Ljava_lang_String_Landroid_os_Bundle_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_Landroid_os_Bundle_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='b' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='long']]"
		[Register ("b", "(Ljava/lang/String;Landroid/os/Bundle;J)V", "GetB_Ljava_lang_String_Landroid_os_Bundle_JHandler")]
		public virtual void B (string p0, global::Android.OS.Bundle p1, long p2)
		{
			if (id_b_Ljava_lang_String_Landroid_os_Bundle_J == IntPtr.Zero)
				id_b_Ljava_lang_String_Landroid_os_Bundle_J = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Landroid/os/Bundle;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_Landroid_os_Bundle_J, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;Landroid/os/Bundle;J)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_b_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_JHandler ()
		{
			if (cb_b_Ljava_lang_String_J == null)
				cb_b_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_B_Ljava_lang_String_J);
			return cb_b_Ljava_lang_String_J;
		}

		static void n_B_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("b", "(Ljava/lang/String;J)V", "GetB_Ljava_lang_String_JHandler")]
		public virtual void B (string p0, long p1)
		{
			if (id_b_Ljava_lang_String_J == IntPtr.Zero)
				id_b_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;J)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "GetCHandler")]
		public virtual string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_c_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_lang_String_Handler ()
		{
			if (cb_c_Ljava_lang_String_ == null)
				cb_c_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_C_Ljava_lang_String_);
			return cb_c_Ljava_lang_String_;
		}

		static void n_C_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)V", "GetC_Ljava_lang_String_Handler")]
		public virtual void C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_c_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.D ());
		}
#pragma warning restore 0169

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "GetDHandler")]
		public virtual string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_d), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_d_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "GetD_Ljava_lang_String_Handler")]
		public virtual void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;)V"), new JValue (native_p0));
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
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.E ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "GetEHandler")]
		public abstract void E ();

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.E (p0);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		public virtual void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.F ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "GetFHandler")]
		public abstract bool F ();

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_G);
			return cb_g;
		}

		static void n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AN __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.G ();
		}
#pragma warning restore 0169

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "GetGHandler")]
		protected virtual void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_g);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "()V"));
		}

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/aN", DoNotGenerateAcw=true)]
	internal partial class ANInvoker : AN {

		public ANInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ANInvoker); }
		}

		static IntPtr id_a_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetA_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override void A (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_a_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "GetEHandler")]
		public override void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_e);
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aN']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Z", "GetFHandler")]
		public override bool F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_f);
		}

	}

}
