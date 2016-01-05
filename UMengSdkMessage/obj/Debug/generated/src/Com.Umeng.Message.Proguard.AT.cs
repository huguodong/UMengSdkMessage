using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aT", DoNotGenerateAcw=true)]
	public partial class AT : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AT); }
		}

		protected AT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/constructor[@name='aT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AT () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AT)) {
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_a), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B ());
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "GetBHandler")]
		public virtual string B ()
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='c' and count(parameter)=0]"
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.C (p0);
		}
#pragma warning restore 0169

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.D ());
		}
#pragma warning restore 0169

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='d' and count(parameter)=0]"
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_E);
			return cb_e;
		}

		static IntPtr n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.E ());
		}
#pragma warning restore 0169

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "GetEHandler")]
		public virtual string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.E (p0);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static IntPtr n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.F ());
		}
#pragma warning restore 0169

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "GetFHandler")]
		public virtual string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.F (p0);
		}
#pragma warning restore 0169

		static IntPtr id_f_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='f' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_G);
			return cb_g;
		}

		static IntPtr n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.G ());
		}
#pragma warning restore 0169

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "GetGHandler")]
		public virtual string G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_g), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_g_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetG_Ljava_lang_String_Handler ()
		{
			if (cb_g_Ljava_lang_String_ == null)
				cb_g_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_G_Ljava_lang_String_);
			return cb_g_Ljava_lang_String_;
		}

		static void n_G_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.G (p0);
		}
#pragma warning restore 0169

		static IntPtr id_g_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='g' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("g", "(Ljava/lang/String;)V", "GetG_Ljava_lang_String_Handler")]
		public virtual void G (string p0)
		{
			if (id_g_Ljava_lang_String_ == IntPtr.Zero)
				id_g_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "g", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_g_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_H);
			return cb_h;
		}

		static IntPtr n_H (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H ());
		}
#pragma warning restore 0169

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "GetHHandler")]
		public virtual string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_h), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_h_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetH_Ljava_lang_String_Handler ()
		{
			if (cb_h_Ljava_lang_String_ == null)
				cb_h_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_H_Ljava_lang_String_);
			return cb_h_Ljava_lang_String_;
		}

		static void n_H_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.H (p0);
		}
#pragma warning restore 0169

		static IntPtr id_h_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='h' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("h", "(Ljava/lang/String;)V", "GetH_Ljava_lang_String_Handler")]
		public virtual void H (string p0)
		{
			if (id_h_Ljava_lang_String_ == IntPtr.Zero)
				id_h_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "h", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_h_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_i;
#pragma warning disable 0169
		static Delegate GetIHandler ()
		{
			if (cb_i == null)
				cb_i = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_I);
			return cb_i;
		}

		static IntPtr n_I (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.I ());
		}
#pragma warning restore 0169

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "GetIHandler")]
		public virtual string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_i), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.I (p0);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		public virtual void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_J);
			return cb_j;
		}

		static IntPtr n_J (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.J ());
		}
#pragma warning restore 0169

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/String;", "GetJHandler")]
		public virtual string J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_j), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "j", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_j_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJ_Ljava_lang_String_Handler ()
		{
			if (cb_j_Ljava_lang_String_ == null)
				cb_j_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_J_Ljava_lang_String_);
			return cb_j_Ljava_lang_String_;
		}

		static void n_J_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.J (p0);
		}
#pragma warning restore 0169

		static IntPtr id_j_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='j' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("j", "(Ljava/lang/String;)V", "GetJ_Ljava_lang_String_Handler")]
		public virtual void J (string p0)
		{
			if (id_j_Ljava_lang_String_ == IntPtr.Zero)
				id_j_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "j", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_j_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "j", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_k;
#pragma warning disable 0169
		static Delegate GetKHandler ()
		{
			if (cb_k == null)
				cb_k = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_K);
			return cb_k;
		}

		static IntPtr n_K (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.K ());
		}
#pragma warning restore 0169

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Ljava/lang/String;", "GetKHandler")]
		public virtual string K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_k), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "k", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_k_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetK_Ljava_lang_String_Handler ()
		{
			if (cb_k_Ljava_lang_String_ == null)
				cb_k_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_K_Ljava_lang_String_);
			return cb_k_Ljava_lang_String_;
		}

		static void n_K_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.K (p0);
		}
#pragma warning restore 0169

		static IntPtr id_k_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='k' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("k", "(Ljava/lang/String;)V", "GetK_Ljava_lang_String_Handler")]
		public virtual void K (string p0)
		{
			if (id_k_Ljava_lang_String_ == IntPtr.Zero)
				id_k_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "k", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_k_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "k", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_l;
#pragma warning disable 0169
		static Delegate GetLHandler ()
		{
			if (cb_l == null)
				cb_l = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_L);
			return cb_l;
		}

		static IntPtr n_L (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.L ());
		}
#pragma warning restore 0169

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/lang/String;", "GetLHandler")]
		public virtual string L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_l), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "l", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_l_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetL_Ljava_lang_String_Handler ()
		{
			if (cb_l_Ljava_lang_String_ == null)
				cb_l_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_L_Ljava_lang_String_);
			return cb_l_Ljava_lang_String_;
		}

		static void n_L_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.L (p0);
		}
#pragma warning restore 0169

		static IntPtr id_l_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='l' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("l", "(Ljava/lang/String;)V", "GetL_Ljava_lang_String_Handler")]
		public virtual void L (string p0)
		{
			if (id_l_Ljava_lang_String_ == IntPtr.Zero)
				id_l_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "l", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_l_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "l", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_m;
#pragma warning disable 0169
		static Delegate GetMHandler ()
		{
			if (cb_m == null)
				cb_m = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_M);
			return cb_m;
		}

		static IntPtr n_M (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.M ());
		}
#pragma warning restore 0169

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Ljava/lang/String;", "GetMHandler")]
		public virtual string M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_m), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "m", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_m_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetM_Ljava_lang_String_Handler ()
		{
			if (cb_m_Ljava_lang_String_ == null)
				cb_m_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_M_Ljava_lang_String_);
			return cb_m_Ljava_lang_String_;
		}

		static void n_M_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.AT __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.M (p0);
		}
#pragma warning restore 0169

		static IntPtr id_m_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aT']/method[@name='m' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("m", "(Ljava/lang/String;)V", "GetM_Ljava_lang_String_Handler")]
		public virtual void M (string p0)
		{
			if (id_m_Ljava_lang_String_ == IntPtr.Zero)
				id_m_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "m", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_m_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "m", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
