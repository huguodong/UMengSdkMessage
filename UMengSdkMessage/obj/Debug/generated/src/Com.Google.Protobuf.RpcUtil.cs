using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='RpcUtil']"
	[global::Android.Runtime.Register ("com/google/protobuf/RpcUtil", DoNotGenerateAcw=true)]
	public sealed partial class RpcUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='RpcUtil.AlreadyCalledException']"
		[global::Android.Runtime.Register ("com/google/protobuf/RpcUtil$AlreadyCalledException", DoNotGenerateAcw=true)]
		public sealed partial class AlreadyCalledException : global::Java.Lang.RuntimeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/RpcUtil$AlreadyCalledException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AlreadyCalledException); }
			}

			internal AlreadyCalledException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='RpcUtil.AlreadyCalledException']/constructor[@name='RpcUtil.AlreadyCalledException' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public AlreadyCalledException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (AlreadyCalledException)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/RpcUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcUtil); }
		}

		internal RpcUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_newOneTimeCallback_Lcom_google_protobuf_RpcCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='RpcUtil']/method[@name='newOneTimeCallback' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.RpcCallback']]"
		[Register ("newOneTimeCallback", "(Lcom/google/protobuf/RpcCallback;)Lcom/google/protobuf/RpcCallback;", "")]
		public static global::Com.Google.Protobuf.IRpcCallback NewOneTimeCallback (global::Com.Google.Protobuf.IRpcCallback p0)
		{
			if (id_newOneTimeCallback_Lcom_google_protobuf_RpcCallback_ == IntPtr.Zero)
				id_newOneTimeCallback_Lcom_google_protobuf_RpcCallback_ = JNIEnv.GetStaticMethodID (class_ref, "newOneTimeCallback", "(Lcom/google/protobuf/RpcCallback;)Lcom/google/protobuf/RpcCallback;");
			global::Com.Google.Protobuf.IRpcCallback __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.IRpcCallback> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newOneTimeCallback_Lcom_google_protobuf_RpcCallback_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
