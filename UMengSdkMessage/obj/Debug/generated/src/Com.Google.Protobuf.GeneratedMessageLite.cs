using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']"
	[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite", DoNotGenerateAcw=true)]
	public abstract partial class GeneratedMessageLite : global::Com.Google.Protobuf.AbstractMessageLite, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']"
		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", DoNotGenerateAcw=true)]
		public abstract partial class ExtendableMessage : global::Com.Google.Protobuf.GeneratedMessageLite {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage.ExtensionWriter']"
			[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter", DoNotGenerateAcw=true)]
			protected internal partial class ExtensionWriter : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (ExtensionWriter); }
				}

				protected ExtensionWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
#pragma warning disable 0169
				static Delegate GetWriteUntil_ILcom_google_protobuf_CodedOutputStream_Handler ()
				{
					if (cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_ == null)
						cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_WriteUntil_ILcom_google_protobuf_CodedOutputStream_);
					return cb_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
				}

				static void n_WriteUntil_ILcom_google_protobuf_CodedOutputStream_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
				{
					global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Com.Google.Protobuf.CodedOutputStream p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (native_p1, JniHandleOwnership.DoNotTransfer);
					__this.WriteUntil (p0, p1);
				}
#pragma warning restore 0169

				static IntPtr id_writeUntil_ILcom_google_protobuf_CodedOutputStream_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage.ExtensionWriter']/method[@name='writeUntil' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.protobuf.CodedOutputStream']]"
				[Register ("writeUntil", "(ILcom/google/protobuf/CodedOutputStream;)V", "GetWriteUntil_ILcom_google_protobuf_CodedOutputStream_Handler")]
				public virtual void WriteUntil (int p0, global::Com.Google.Protobuf.CodedOutputStream p1)
				{
					if (id_writeUntil_ILcom_google_protobuf_CodedOutputStream_ == IntPtr.Zero)
						id_writeUntil_ILcom_google_protobuf_CodedOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeUntil", "(ILcom/google/protobuf/CodedOutputStream;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_writeUntil_ILcom_google_protobuf_CodedOutputStream_, new JValue (p0), new JValue (p1));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeUntil", "(ILcom/google/protobuf/CodedOutputStream;)V"), new JValue (p0), new JValue (p1));
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableMessage); }
			}

			protected ExtendableMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/constructor[@name='GeneratedMessageLite.ExtendableMessage' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected ExtendableMessage () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ExtendableMessage)) {
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

			static Delegate cb_d;
#pragma warning disable 0169
			static Delegate GetDHandler ()
			{
				if (cb_d == null)
					cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_D);
				return cb_d;
			}

			static bool n_D (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.D ();
			}
#pragma warning restore 0169

			static IntPtr id_d;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='d' and count(parameter)=0]"
			[Register ("d", "()Z", "GetDHandler")]
			protected virtual bool D ()
			{
				if (id_d == IntPtr.Zero)
					id_d = JNIEnv.GetMethodID (class_ref, "d", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_d);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "()Z"));
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
				global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.E ());
			}
#pragma warning restore 0169

			static IntPtr id_e;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='e' and count(parameter)=0]"
			[Register ("e", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;", "GetEHandler")]
			protected virtual global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter E ()
			{
				if (id_e == IntPtr.Zero)
					id_e = JNIEnv.GetMethodID (class_ref, "e", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter> (JNIEnv.CallObjectMethod  (Handle, id_e), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.F ());
			}
#pragma warning restore 0169

			static IntPtr id_f;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='f' and count(parameter)=0]"
			[Register ("f", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;", "GetFHandler")]
			protected virtual global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter F ()
			{
				if (id_f == IntPtr.Zero)
					id_f = JNIEnv.GetMethodID (class_ref, "f", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter> (JNIEnv.CallObjectMethod  (Handle, id_f), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage.ExtensionWriter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "()Lcom/google/protobuf/GeneratedMessageLite$ExtendableMessage$ExtensionWriter;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_g;
#pragma warning disable 0169
			static Delegate GetGHandler ()
			{
				if (cb_g == null)
					cb_g = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_G);
				return cb_g;
			}

			static int n_G (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.G ();
			}
#pragma warning restore 0169

			static IntPtr id_g;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='g' and count(parameter)=0]"
			[Register ("g", "()I", "GetGHandler")]
			protected virtual int G ()
			{
				if (id_g == IntPtr.Zero)
					id_g = JNIEnv.GetMethodID (class_ref, "g", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_g);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "()I"));
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='getExtension' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessageLite.GeneratedExtension']]"
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='getExtension' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.GeneratedMessageLite.GeneratedExtension'] and parameter[2][@type='int']]"
			[Register ("getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;", "")]
			public global::Java.Lang.Object GetExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0, int p1)
			{
				if (id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I == IntPtr.Zero)
					id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;I)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='getExtensionCount' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessageLite.GeneratedExtension']]"
			[Register ("getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I", "")]
			public int GetExtensionCount (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "getExtensionCount", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)I");
				int __ret = JNIEnv.CallIntMethod  (Handle, id_getExtensionCount_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

			static Delegate cb_h;
#pragma warning disable 0169
			static Delegate GetHHandler ()
			{
				if (cb_h == null)
					cb_h = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_H);
				return cb_h;
			}

			static int n_H (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite.ExtendableMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.H ();
			}
#pragma warning restore 0169

			static IntPtr id_h;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='h' and count(parameter)=0]"
			[Register ("h", "()I", "GetHHandler")]
			protected virtual int H ()
			{
				if (id_h == IntPtr.Zero)
					id_h = JNIEnv.GetMethodID (class_ref, "h", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_h);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h", "()I"));
			}

			static IntPtr id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.ExtendableMessage']/method[@name='hasExtension' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.GeneratedMessageLite.GeneratedExtension']]"
			[Register ("hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z", "")]
			public bool HasExtension (global::Com.Google.Protobuf.GeneratedMessageLite.GeneratedExtension p0)
			{
				if (id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ == IntPtr.Zero)
					id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_ = JNIEnv.GetMethodID (class_ref, "hasExtension", "(Lcom/google/protobuf/GeneratedMessageLite$GeneratedExtension;)Z");
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasExtension_Lcom_google_protobuf_GeneratedMessageLite_GeneratedExtension_, new JValue (p0));
				return __ret;
			}

		}

		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$ExtendableMessage", DoNotGenerateAcw=true)]
		internal partial class ExtendableMessageInvoker : ExtendableMessage {

			public ExtendableMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExtendableMessageInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.GeneratedExtension']"
		[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite$GeneratedExtension", DoNotGenerateAcw=true)]
		public sealed partial class GeneratedExtension : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite$GeneratedExtension", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GeneratedExtension); }
			}

			internal GeneratedExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getContainingTypeDefaultInstance;
			public global::Java.Lang.Object ContainingTypeDefaultInstance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.GeneratedExtension']/method[@name='getContainingTypeDefaultInstance' and count(parameter)=0]"
				[Register ("getContainingTypeDefaultInstance", "()Lcom/google/protobuf/MessageLite;", "GetGetContainingTypeDefaultInstanceHandler")]
				get {
					if (id_getContainingTypeDefaultInstance == IntPtr.Zero)
						id_getContainingTypeDefaultInstance = JNIEnv.GetMethodID (class_ref, "getContainingTypeDefaultInstance", "()Lcom/google/protobuf/MessageLite;");
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getContainingTypeDefaultInstance), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr id_getNumber;
			public int Number {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite.GeneratedExtension']/method[@name='getNumber' and count(parameter)=0]"
				[Register ("getNumber", "()I", "GetGetNumberHandler")]
				get {
					if (id_getNumber == IntPtr.Zero)
						id_getNumber = JNIEnv.GetMethodID (class_ref, "getNumber", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_getNumber);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/GeneratedMessageLite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneratedMessageLite); }
		}

		protected GeneratedMessageLite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']/constructor[@name='GeneratedMessageLite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected GeneratedMessageLite () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeneratedMessageLite)) {
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

		static Delegate cb_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
#pragma warning disable 0169
		static Delegate GetA_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_IHandler ()
		{
			if (cb_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I == null)
				cb_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_A_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I);
			return cb_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
		}

		static bool n_A_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Google.Protobuf.GeneratedMessageLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.CodedInputStream p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Protobuf.ExtensionRegistryLite p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.ExtensionRegistryLite> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.google.protobuf.CodedInputStream'] and parameter[2][@type='com.google.protobuf.ExtensionRegistryLite'] and parameter[3][@type='int']]"
		[Register ("a", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;I)Z", "GetA_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_IHandler")]
		protected virtual bool A (global::Com.Google.Protobuf.CodedInputStream p0, global::Com.Google.Protobuf.ExtensionRegistryLite p1, int p2)
		{
			if (id_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I == IntPtr.Zero)
				id_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;I)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Lcom_google_protobuf_CodedInputStream_Lcom_google_protobuf_ExtensionRegistryLite_I, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/google/protobuf/CodedInputStream;Lcom/google/protobuf/ExtensionRegistryLite;I)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Google.Protobuf.GeneratedMessageLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected virtual void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_b);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
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
			global::Com.Google.Protobuf.GeneratedMessageLite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.GeneratedMessageLite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='GeneratedMessageLite']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/Object;", "GetCHandler")]
		protected virtual global::Java.Lang.Object C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_c), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/google/protobuf/GeneratedMessageLite", DoNotGenerateAcw=true)]
	internal partial class GeneratedMessageLiteInvoker : GeneratedMessageLite {

		public GeneratedMessageLiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneratedMessageLiteInvoker); }
		}

	}

}
