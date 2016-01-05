using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']"
	[global::Android.Runtime.Register ("org/android/spdy/SuperviseData", DoNotGenerateAcw=true)]
	public partial class SuperviseData : global::Java.Lang.Object {


		static IntPtr bodySize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='bodySize']"
		[Register ("bodySize")]
		public int BodySize {
			get {
				if (bodySize_jfieldId == IntPtr.Zero)
					bodySize_jfieldId = JNIEnv.GetFieldID (class_ref, "bodySize", "I");
				return JNIEnv.GetIntField (Handle, bodySize_jfieldId);
			}
			set {
				if (bodySize_jfieldId == IntPtr.Zero)
					bodySize_jfieldId = JNIEnv.GetFieldID (class_ref, "bodySize", "I");
				JNIEnv.SetField (Handle, bodySize_jfieldId, value);
			}
		}

		static IntPtr compressSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='compressSize']"
		[Register ("compressSize")]
		public int CompressSize {
			get {
				if (compressSize_jfieldId == IntPtr.Zero)
					compressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "compressSize", "I");
				return JNIEnv.GetIntField (Handle, compressSize_jfieldId);
			}
			set {
				if (compressSize_jfieldId == IntPtr.Zero)
					compressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "compressSize", "I");
				JNIEnv.SetField (Handle, compressSize_jfieldId, value);
			}
		}

		static IntPtr recvBodySize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='recvBodySize']"
		[Register ("recvBodySize")]
		public int RecvBodySize {
			get {
				if (recvBodySize_jfieldId == IntPtr.Zero)
					recvBodySize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvBodySize", "I");
				return JNIEnv.GetIntField (Handle, recvBodySize_jfieldId);
			}
			set {
				if (recvBodySize_jfieldId == IntPtr.Zero)
					recvBodySize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvBodySize", "I");
				JNIEnv.SetField (Handle, recvBodySize_jfieldId, value);
			}
		}

		static IntPtr recvCompressSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='recvCompressSize']"
		[Register ("recvCompressSize")]
		public int RecvCompressSize {
			get {
				if (recvCompressSize_jfieldId == IntPtr.Zero)
					recvCompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvCompressSize", "I");
				return JNIEnv.GetIntField (Handle, recvCompressSize_jfieldId);
			}
			set {
				if (recvCompressSize_jfieldId == IntPtr.Zero)
					recvCompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvCompressSize", "I");
				JNIEnv.SetField (Handle, recvCompressSize_jfieldId, value);
			}
		}

		static IntPtr recvUncompressSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='recvUncompressSize']"
		[Register ("recvUncompressSize")]
		public int RecvUncompressSize {
			get {
				if (recvUncompressSize_jfieldId == IntPtr.Zero)
					recvUncompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvUncompressSize", "I");
				return JNIEnv.GetIntField (Handle, recvUncompressSize_jfieldId);
			}
			set {
				if (recvUncompressSize_jfieldId == IntPtr.Zero)
					recvUncompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "recvUncompressSize", "I");
				JNIEnv.SetField (Handle, recvUncompressSize_jfieldId, value);
			}
		}

		static IntPtr requestStart_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='requestStart']"
		[Register ("requestStart")]
		public long RequestStart {
			get {
				if (requestStart_jfieldId == IntPtr.Zero)
					requestStart_jfieldId = JNIEnv.GetFieldID (class_ref, "requestStart", "J");
				return JNIEnv.GetLongField (Handle, requestStart_jfieldId);
			}
			set {
				if (requestStart_jfieldId == IntPtr.Zero)
					requestStart_jfieldId = JNIEnv.GetFieldID (class_ref, "requestStart", "J");
				JNIEnv.SetField (Handle, requestStart_jfieldId, value);
			}
		}

		static IntPtr responseEnd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='responseEnd']"
		[Register ("responseEnd")]
		public long ResponseEnd {
			get {
				if (responseEnd_jfieldId == IntPtr.Zero)
					responseEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "responseEnd", "J");
				return JNIEnv.GetLongField (Handle, responseEnd_jfieldId);
			}
			set {
				if (responseEnd_jfieldId == IntPtr.Zero)
					responseEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "responseEnd", "J");
				JNIEnv.SetField (Handle, responseEnd_jfieldId, value);
			}
		}

		static IntPtr responseStart_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='responseStart']"
		[Register ("responseStart")]
		public long ResponseStart {
			get {
				if (responseStart_jfieldId == IntPtr.Zero)
					responseStart_jfieldId = JNIEnv.GetFieldID (class_ref, "responseStart", "J");
				return JNIEnv.GetLongField (Handle, responseStart_jfieldId);
			}
			set {
				if (responseStart_jfieldId == IntPtr.Zero)
					responseStart_jfieldId = JNIEnv.GetFieldID (class_ref, "responseStart", "J");
				JNIEnv.SetField (Handle, responseStart_jfieldId, value);
			}
		}

		static IntPtr sendEnd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='sendEnd']"
		[Register ("sendEnd")]
		public long SendEnd {
			get {
				if (sendEnd_jfieldId == IntPtr.Zero)
					sendEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sendEnd", "J");
				return JNIEnv.GetLongField (Handle, sendEnd_jfieldId);
			}
			set {
				if (sendEnd_jfieldId == IntPtr.Zero)
					sendEnd_jfieldId = JNIEnv.GetFieldID (class_ref, "sendEnd", "J");
				JNIEnv.SetField (Handle, sendEnd_jfieldId, value);
			}
		}

		static IntPtr sendStart_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='sendStart']"
		[Register ("sendStart")]
		public long SendStart {
			get {
				if (sendStart_jfieldId == IntPtr.Zero)
					sendStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sendStart", "J");
				return JNIEnv.GetLongField (Handle, sendStart_jfieldId);
			}
			set {
				if (sendStart_jfieldId == IntPtr.Zero)
					sendStart_jfieldId = JNIEnv.GetFieldID (class_ref, "sendStart", "J");
				JNIEnv.SetField (Handle, sendStart_jfieldId, value);
			}
		}

		static IntPtr uncompressSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SuperviseData']/field[@name='uncompressSize']"
		[Register ("uncompressSize")]
		public int UncompressSize {
			get {
				if (uncompressSize_jfieldId == IntPtr.Zero)
					uncompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "uncompressSize", "I");
				return JNIEnv.GetIntField (Handle, uncompressSize_jfieldId);
			}
			set {
				if (uncompressSize_jfieldId == IntPtr.Zero)
					uncompressSize_jfieldId = JNIEnv.GetFieldID (class_ref, "uncompressSize", "I");
				JNIEnv.SetField (Handle, uncompressSize_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SuperviseData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SuperviseData); }
		}

		protected SuperviseData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
