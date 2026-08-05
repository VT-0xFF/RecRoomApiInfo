using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using RenderHeads.Media.AVProMovieCapture;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RenderHeads.Media.AVProMovieCapture
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Ambisonic Source", 601)]
	public class AmbisonicSource : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AmbisonicWavWriter _sink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Listener is optional but allows positions to be calculated relative to a transform.  This is useful if the listener is not located at 0,0,0.")]
		private Transform _listener;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Vector3 GGCEEAPMIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KLBIMEDKOCP MLGDKFJHELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CJDDJKCEPMG ABGHDNGEOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GBBHFOJBICN KJAJOLMPNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr AEACECMAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int FAEOMFPIHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] BPABBAPOAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> OMKNIEJCOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> FOPMEHFIGMB;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x913D1C0", Offset = "0x913B7C0", VA = "0x18913D1C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x913CF30", Offset = "0x913B530", VA = "0x18913CF30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x913C250", Offset = "0x913A850", VA = "0x18913C250")]
		internal void HFNJJDCIHFC(KLBIMEDKOCP DPNBGBIGDNP, CJDDJKCEPMG AKHLBCCNMNO, GBBHFOJBICN DAGKKINHIEK, int JKECDHGGKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x913D0A0", Offset = "0x913B6A0", VA = "0x18913D0A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x913C650", Offset = "0x913AC50", VA = "0x18913C650")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x913C230", Offset = "0x913A830", VA = "0x18913C230")]
		private void FPJGLFEMMDE(Vector3 APHHGJIDDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x913D340", Offset = "0x913B940", VA = "0x18913D340")]
		private void PDNLCJEGAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x913C7B0", Offset = "0x913ADB0", VA = "0x18913C7B0")]
		private void OnAudioFilterRead(float[] JDONDHOKKFH, int MNLBIBCDEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x913BFF0", Offset = "0x913A5F0", VA = "0x18913BFF0")]
		internal void ABFGDHOPOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x913C610", Offset = "0x913AC10", VA = "0x18913C610")]
		internal int IJMMHGFCNBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x913C440", Offset = "0x913AA40", VA = "0x18913C440")]
		internal void IEBPLIELHOJ(bool IBDNOCKMJPM, bool JHOIKJFBBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x913D4F0", Offset = "0x913BAF0", VA = "0x18913D4F0")]
		public AmbisonicSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Ambisonic WAV Writer", 601)]
	public class AmbisonicWavWriter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private KLBIMEDKOCP _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private PGGLILAJLAF _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Range(4f, 32f)]
		private int _bufferCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float[] CDCBDILIBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private PLBBPKACHKG MMCKAGHNNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> NABMMMICCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int AGLDALAJMKB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KLBIMEDKOCP IMCMDOCIAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			get
			{
				return default(KLBIMEDKOCP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PGGLILAJLAF ENMJPKHIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
			get
			{
				return default(PGGLILAJLAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x913D610", Offset = "0x913BC10", VA = "0x18913D610")]
		internal void ADJGPKAKKOJ(AmbisonicSource NGOJMGCIOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x913DED0", Offset = "0x913C4D0", VA = "0x18913DED0")]
		internal void LOBHCILICMB(AmbisonicSource NGOJMGCIOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x913E070", Offset = "0x913C670", VA = "0x18913E070")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x913DD10", Offset = "0x913C310", VA = "0x18913DD10")]
		private void JIJGKEEEJBP(AmbisonicSource NGOJMGCIOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x913DCC0", Offset = "0x913C2C0", VA = "0x18913DCC0")]
		private void HIHNAAHHKIC(bool BGGIFLAFJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x913D7A0", Offset = "0x913BDA0", VA = "0x18913D7A0")]
		private void CELNBPHDHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x913DBC0", Offset = "0x913C1C0", VA = "0x18913DBC0")]
		private void DMEHNEGCPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x913DCF0", Offset = "0x913C2F0", VA = "0x18913DCF0")]
		private bool HKMBFJCMNCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x913DFB0", Offset = "0x913C5B0", VA = "0x18913DFB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x913E080", Offset = "0x913C680", VA = "0x18913E080")]
		private void PJPAPLMPHFC(bool JHOIKJFBBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x913DDC0", Offset = "0x913C3C0", VA = "0x18913DDC0")]
		internal void JLGLMNGFBNL(float[] JDONDHOKKFH, int BDAKDFHBKEN, bool HIBPFFKEFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x913D760", Offset = "0x913BD60", VA = "0x18913D760")]
		private void BKKBPILJNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x913E2C0", Offset = "0x913C8C0", VA = "0x18913E2C0")]
		public AmbisonicWavWriter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AddComponentMenu("AVPro Movie Capture/Audio/AudioSource To WAV", 701)]
	public class AudioSourceToWav : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PLBBPKACHKG MMCKAGHNNII;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x913E400", Offset = "0x913CA00", VA = "0x18913E400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x913E3C0", Offset = "0x913C9C0", VA = "0x18913E3C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x913E390", Offset = "0x913C990", VA = "0x18913E390")]
		private void OnAudioFilterRead(float[] CDDIADBJAOB, int NOJMAMBJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x913E540", Offset = "0x913CB40", VA = "0x18913E540")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum IOGIBNABILI
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			HighestDepthCamera,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MainCameraTag,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			EditorSceneView,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Tag,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			Name,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum ABNKPEMMDDA
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Frame
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private IOGIBNABILI _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ABNKPEMMDDA _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool _scanHiddenCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string _tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Camera[] JHJKKJGCBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int JHNLPFAOIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int NDFCHEHFPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool ALPGJAELLBH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera AECJMHFPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x913F490", Offset = "0x913DA90", VA = "0x18913F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IOGIBNABILI KPGEDCAFEFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(IOGIBNABILI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x913F4E0", Offset = "0x913DAE0", VA = "0x18913F4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ABNKPEMMDDA AKELDEAGOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			get
			{
				return default(ABNKPEMMDDA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x913F4C0", Offset = "0x913DAC0", VA = "0x18913F4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HDIKLECNGCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x913F4D0", Offset = "0x913DAD0", VA = "0x18913F4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string LNLKBDACJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x913F510", Offset = "0x913DB10", VA = "0x18913F510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FDCAFPLDMEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x913F4F0", Offset = "0x913DAF0", VA = "0x18913F4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x913EC30", Offset = "0x913D230", VA = "0x18913EC30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x913F2D0", Offset = "0x913D8D0", VA = "0x18913F2D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x913EC30", Offset = "0x913D230", VA = "0x18913EC30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x913F3C0", Offset = "0x913D9C0", VA = "0x18913F3C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x913F170", Offset = "0x913D770", VA = "0x18913F170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x913ECF0", Offset = "0x913D2F0", VA = "0x18913ECF0")]
		private void JKPGGFECJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x913EC40", Offset = "0x913D240", VA = "0x18913EC40")]
		private void CJAPPLCNNAL(Scene BLFJNFOGIPN, LoadSceneMode IBLGEJEKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x913F210", Offset = "0x913D810", VA = "0x18913F210")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x913EEE0", Offset = "0x913D4E0", VA = "0x18913EEE0")]
		private Camera NJHNBGMPCKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x913F2E0", Offset = "0x913D8E0", VA = "0x18913F2E0")]
		public void UpdateCameraCache(bool NDHJIDNCBDK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x913EDE0", Offset = "0x913D3E0", VA = "0x18913EDE0")]
		private static Camera LEPIFKAJKHL(int LPPIHKJODAB, Camera[] LECIJIFIMLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x913EBA0", Offset = "0x913D1A0", VA = "0x18913EBA0")]
		private static Camera ACDNFELFOJG(int LPPIHKJODAB, Camera[] LECIJIFIMLJ, string PEIEJMGOHLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x913EC50", Offset = "0x913D250", VA = "0x18913EC50")]
		private static Camera DCHOIJGEKPA(int LPPIHKJODAB, Camera[] LECIJIFIMLJ, string NDIENANOGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x913F3E0", Offset = "0x913D9E0", VA = "0x18913F3E0")]
		public CameraSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioClip)", 500)]
	public class CaptureAudioFromAudioClip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private AudioClip _audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool _restartAudioClipOnCaptureStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int DINBALKCGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int KEMAGNADPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int FHGJCKOAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int IOICADIMLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] KGJLCOKLJEI;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x913FA40", Offset = "0x913E040", VA = "0x18913FA40")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x913F750", Offset = "0x913DD50", VA = "0x18913F750")]
		private void KPBDJNHPMPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x913F770", Offset = "0x913DD70", VA = "0x18913F770")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x913FA60", Offset = "0x913E060", VA = "0x18913FA60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x913F530", Offset = "0x913DB30", VA = "0x18913F530")]
		private float[] IEDANABOLNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x913FB00", Offset = "0x913E100", VA = "0x18913FB00")]
		public CaptureAudioFromAudioClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioListener)", 500)]
	[RequireComponent(typeof(AudioListener))]
	public class CaptureAudioFromAudioListener : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int HOFJAOEJMBD = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] KKMIHIHHCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] EMFKKLMJPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int IFBDHBMDNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle KCLNMLFBFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int CDECBPJPFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int CBAHBNDDEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object PHBNDAMAJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool HCGLCPMHHLN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] NMOMPCBFOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MNDELBJFKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAA0E0", Offset = "0xAA86E0", VA = "0x180AAA0E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr IIPBFINALBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x91405A0", Offset = "0x913EBA0", VA = "0x1891405A0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int IJJJHOIPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xEC0B20", Offset = "0xEBF120", VA = "0x180EC0B20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int MKDHOMNICII
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x91405B0", Offset = "0x913EBB0", VA = "0x1891405B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int PBGCLFLOJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x913FE70", Offset = "0x913E470", VA = "0x18913FE70", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1009380", Offset = "0x1007980", VA = "0x181009380", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9140400", Offset = "0x913EA00", VA = "0x189140400", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x913FE60", Offset = "0x913E460", VA = "0x18913FE60", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9140350", Offset = "0x913E950", VA = "0x189140350", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9140260", Offset = "0x913E860", VA = "0x189140260", Slot = "13")]
		public override IntPtr ReadData([Out] int NODGHDHCBPE)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x913FB10", Offset = "0x913E110", VA = "0x18913FB10", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x913FBB0", Offset = "0x913E1B0", VA = "0x18913FBB0")]
		private void OnAudioFilterRead(float[] CDDIADBJAOB, int NOJMAMBJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x91404E0", Offset = "0x913EAE0", VA = "0x1891404E0")]
		public CaptureAudioFromAudioListener()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioRenderer)", 500)]
	public class CaptureAudioFromAudioRenderer : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int DANNCDHHKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool IJEIIMNKDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> JKKPKFPENDP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase BABGDNJDBHH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int MKDHOMNICII
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x91405B0", Offset = "0x913EBB0", VA = "0x1891405B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int PBGCLFLOJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9140760", Offset = "0x913ED60", VA = "0x189140760", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9140610", Offset = "0x913EC10", VA = "0x189140610")]
		private NativeArray<float> GBDJHOCHIJA(int NODGHDHCBPE)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void KAMKANHONIM(NativeArray<float> DNGAEEFBGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9140780", Offset = "0x913ED80", VA = "0x189140780", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9140890", Offset = "0x913EE90", VA = "0x189140890", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x91405C0", Offset = "0x913EBC0", VA = "0x1891405C0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x91408F0", Offset = "0x913EEF0", VA = "0x1891408F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAC3A10", Offset = "0xAC2010", VA = "0x180AC3A10")]
		public CaptureAudioFromAudioRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CaptureAudioFromMultipleSources : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private List<OnAudioFilterReadForwarder> _onAudioFilterReadForwarders;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const int HOFJAOEJMBD = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] KKMIHIHHCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] EMFKKLMJPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int NNJCEBBAPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int MMPOHDIMDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle KCLNMLFBFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int CDECBPJPFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool EFOFPKGNBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int PJLBAPMKJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int CBAHBNDDEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object PHBNDAMAJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool HFFMNAFIHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool HCGLCPMHHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int ONGKCDAAOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int FEEKJMCIMEF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> OOLBCFDHKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool AKEBJFIAKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA5500", Offset = "0xAA3B00", VA = "0x180AA5500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] NMOMPCBFOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int MNDELBJFKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr IIPBFINALBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9141D20", Offset = "0x9140320", VA = "0x189141D20")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int IJJJHOIPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1342270", Offset = "0x1340870", VA = "0x181342270", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int MKDHOMNICII
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x91405B0", Offset = "0x913EBB0", VA = "0x1891405B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int PBGCLFLOJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCC0", Offset = "0xB2C2C0", VA = "0x180B2DCC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x91417D0", Offset = "0x913FDD0", VA = "0x1891417D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9140FE0", Offset = "0x913F5E0", VA = "0x189140FE0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x91415E0", Offset = "0x913FBE0", VA = "0x1891415E0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x91419B0", Offset = "0x913FFB0", VA = "0x1891419B0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9140FD0", Offset = "0x913F5D0", VA = "0x189140FD0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9141520", Offset = "0x913FB20", VA = "0x189141520", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x91413D0", Offset = "0x913F9D0", VA = "0x1891413D0", Slot = "13")]
		public override IntPtr ReadData([Out] int NODGHDHCBPE)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x91409E0", Offset = "0x913EFE0", VA = "0x1891409E0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9140B60", Offset = "0x913F160", VA = "0x189140B60")]
		public void OnAudioFilterReadCombiner(float[] CDDIADBJAOB, int NOJMAMBJJKK, bool CFEJAIBFEAP, int KBIICOGOBJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9140A80", Offset = "0x913F080", VA = "0x189140A80")]
		private float[] IABBCMGCAKA(float[] CDDIADBJAOB, int HAIPKNLNBGE, int NIPIFCKAOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9141C60", Offset = "0x9140260", VA = "0x189141C60")]
		public CaptureAudioFromMultipleSources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From Wwise)", 500)]
	public class CaptureAudioFromWwise : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CaptureBase BABGDNJDBHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int MKDHOMNICII
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int PBGCLFLOJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9141D30", Offset = "0x9140330", VA = "0x189141D30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC3A10", Offset = "0xAC2010", VA = "0x180AC3A10")]
		public CaptureAudioFromWwise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera", 1)]
	public class CaptureFromCamera : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CJFKMMKGMHA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CaptureFromCamera <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public CJFKMMKGMHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x913EAB0", Offset = "0x913D0B0", VA = "0x18913EAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x913EB50", Offset = "0x913D150", VA = "0x18913EB50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CECJKDOHDDF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CaptureFromCamera <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public CECJKDOHDDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x913E650", Offset = "0x913CC50", VA = "0x18913E650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x913EA60", Offset = "0x913D060", VA = "0x18913EA60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Camera _lastCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Camera[] _contribCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private bool _useContributingCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private RenderTexture PJHDNIEOGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture NIDEGHHCPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr NLLPKKBAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture BBKOLDKNEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture JGNKJGCBDPL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector FFPMHJICOOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBBB110", Offset = "0xBB9710", VA = "0x180BBB110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC1EEA0", Offset = "0xC1D4A0", VA = "0x180C1EEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NPLFLKKNNBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x25B1740", Offset = "0x25AFD40", VA = "0x1825B1740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9148C10", Offset = "0x9147210", VA = "0x189148C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x914A1C0", Offset = "0x91487C0", VA = "0x18914A1C0")]
		public void SetCamera(Camera IIGANHEFLPD, bool JPKACEGEMNP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x914A170", Offset = "0x9148770", VA = "0x18914A170")]
		public void SetCamera(Camera IIGANHEFLPD, Camera[] IFBPPDCHIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9149110", Offset = "0x9147710", VA = "0x189149110")]
		private bool GCAHJCLGJJN(Texture BDFJHOHMCFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9149500", Offset = "0x9147B00", VA = "0x189149500")]
		private bool NENPFNKJGHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9148C30", Offset = "0x9147230", VA = "0x189148C30")]
		private bool AMFHLBAJMPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x914A410", Offset = "0x9148A10", VA = "0x18914A410", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9149560", Offset = "0x9147B60", VA = "0x189149560")]
		[IteratorStateMachine(typeof(CJFKMMKGMHA))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9148C60", Offset = "0x9147260", VA = "0x189148C60")]
		[IteratorStateMachine(typeof(CECJKDOHDDF))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x91491F0", Offset = "0x91477F0", VA = "0x1891491F0")]
		private bool HGEBLOMHPIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9148CE0", Offset = "0x91472E0", VA = "0x189148CE0")]
		private void FDPMMBJGJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x914A2E0", Offset = "0x91488E0", VA = "0x18914A2E0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9149330", Offset = "0x9147930", VA = "0x189149330")]
		private void JNCLJELDKPF(int EPJLFMHGDCC, int GHDHPPBLHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC3BAA0", Offset = "0xC3A0A0", VA = "0x180C3BAA0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x91496F0", Offset = "0x9147CF0", VA = "0x1891496F0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x91495E0", Offset = "0x9147BE0", VA = "0x1891495E0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x914A5A0", Offset = "0x9148BA0", VA = "0x18914A5A0")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9148C20", Offset = "0x9147220", VA = "0x189148C20")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void AELAFCJECGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum JLMLIMJLHGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			Unity,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Unity2018
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ENFKACKMPNF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CaptureFromCamera360 <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public ENFKACKMPNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9151D50", Offset = "0x9150350", VA = "0x189151D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x9151DC0", Offset = "0x91503C0", VA = "0x189151DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private MNIPLDNLEFG _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private KOLGCAIPDIH _cubemapDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private bool _supportGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private bool _supportCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26A")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private bool _onlyLeftRightRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26B")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[Tooltip("Render 180 degree equirectangular instead of 360 degrees")]
		private bool _render180Degrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private AECHOIMOGPC _stereoRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Makes assumption that 1 Unity unit is 1m")]
		[SerializeField]
		private float _ipd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		[Tooltip("Percentage cube faces are overdrawn each edge then blended to alleviate screen space FX seams")]
		private float _blendOverlapPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private RenderTexture IALGDNPJOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] NPGKJGEPADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material PHKHFJBCADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material KMDLBKPIGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture LFINHMMALNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture IMNEHCDLCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr NLLPKKBAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int IGNBDJKDPCL;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector FFPMHJICOOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBBB110", Offset = "0xBB9710", VA = "0x180BBB110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC1EEA0", Offset = "0xC1D4A0", VA = "0x180C1EEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public MNIPLDNLEFG MPNEKFAPLID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xBBB490", Offset = "0xBB9A90", VA = "0x180BBB490")]
			get
			{
				return default(MNIPLDNLEFG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9148BB0", Offset = "0x91471B0", VA = "0x189148BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KOLGCAIPDIH LPILDICEBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9148B50", Offset = "0x9147150", VA = "0x189148B50")]
			get
			{
				return default(KOLGCAIPDIH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9148BA0", Offset = "0x91471A0", VA = "0x189148BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OHFCOFDNCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x25B1740", Offset = "0x25AFD40", VA = "0x1825B1740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9148C10", Offset = "0x9147210", VA = "0x189148C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool JDBKKCINMAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9148B90", Offset = "0x9147190", VA = "0x189148B90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9148C00", Offset = "0x9147200", VA = "0x189148C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FLPMHFJPEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9148B70", Offset = "0x9147170", VA = "0x189148B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9148BD0", Offset = "0x91471D0", VA = "0x189148BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DEPLHMBAINP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9148B80", Offset = "0x9147180", VA = "0x189148B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9148BE0", Offset = "0x91471E0", VA = "0x189148BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AECHOIMOGPC BFEIBJJKDFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2969070", Offset = "0x2967670", VA = "0x182969070")]
			get
			{
				return default(AECHOIMOGPC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9148BF0", Offset = "0x91471F0", VA = "0x189148BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float DFIEAHFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9148B60", Offset = "0x9147160", VA = "0x189148B60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9148BC0", Offset = "0x91471C0", VA = "0x189148BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9148A80", Offset = "0x9147080", VA = "0x189148A80")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9145570", Offset = "0x9143B70", VA = "0x189145570")]
		private JLMLIMJLHGO HGHMJLDLEAA()
		{
			return default(JLMLIMJLHGO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC24FD0", Offset = "0xC235D0", VA = "0x180C24FD0")]
		public void SetCamera(Camera ADKEJHHNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9148910", Offset = "0x9146F10", VA = "0x189148910", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x91455A0", Offset = "0x9143BA0", VA = "0x1891455A0")]
		[IteratorStateMachine(typeof(ENFKACKMPNF))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x91445B0", Offset = "0x9142BB0", VA = "0x1891445B0")]
		private void BABGDNJDBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9144DF0", Offset = "0x91433F0", VA = "0x189144DF0")]
		private static void DEBBJNKKPLA(RenderTexture BDFJHOHMCFM, Color FPHNLEHIJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9144900", Offset = "0x9142F00", VA = "0x189144900")]
		private void CDHHJOCJBLF(RenderTexture DMPAMNPHBON, RenderTexture AMMKGILEHBG, bool OGPOAHLKHMC, Quaternion LDAEEKEKDJC, bool NIBHKAOIKFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9144F80", Offset = "0x9143580", VA = "0x189144F80")]
		private void FDPMMBJGJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9145620", Offset = "0x9143C20", VA = "0x189145620")]
		private void OICMEAFFCFO(Camera ADKEJHHNPHO, RenderTexture OHOHPEFHDKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9144D10", Offset = "0x9143310", VA = "0x189144D10")]
		private void DCBJJKMGCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9147300", Offset = "0x9145900", VA = "0x189147300", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9145530", Offset = "0x9143B30", VA = "0x189145530", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9148710", Offset = "0x9146D10", VA = "0x189148710", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9147030", Offset = "0x9145630", VA = "0x189147030", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 Stereo ODS (VR)", 101)]
	public class CaptureFromCamera360ODS : CaptureBase
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[SerializeField]
			public Camera camera;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[SerializeField]
			public CameraSelector cameraSelector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[Tooltip("Render 180 degree equirectangular instead of 360 degrees.  Also faster rendering")]
			[SerializeField]
			public bool render180Degrees;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			[Tooltip("Makes assumption that 1 Unity unit is 1m")]
			[SerializeField]
			public float ipd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			[SerializeField]
			[Tooltip("Higher value meant less slices to render, but can affect quality.")]
			public int pixelSliceSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			[SerializeField]
			[Range(1f, 31f)]
			[Tooltip("May need to be increased to work with some post image effects. Value is in pixels.")]
			public int paddingSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[SerializeField]
			public CameraClearFlags cameraClearMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			[SerializeField]
			public Color cameraClearColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[SerializeField]
			public Behaviour[] cameraImageEffects;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9152050", Offset = "0x9150650", VA = "0x189152050")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class HEKJCAKJLFC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CaptureFromCamera360ODS <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public HEKJCAKJLFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9151E10", Offset = "0x9150410", VA = "0x189151E10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9151E80", Offset = "0x9150480", VA = "0x189151E80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Settings _settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int MFDMLNHCICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DCDFIODBLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform CCCBMHLGNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera NNKBIMGCKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera AONFKHLNJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera FMFLMLKBAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera ELGHLDIDMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture JBIJNHBGGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr NLLPKKBAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material MHDODJEAGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int CHIAFBHKLBB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings HFNJJDCIHFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBBB110", Offset = "0xBB9710", VA = "0x180BBB110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x91444A0", Offset = "0x9142AA0", VA = "0x1891444A0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x91441A0", Offset = "0x91427A0", VA = "0x1891441A0")]
		public void SetCamera(Camera ADKEJHHNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x91441D0", Offset = "0x91427D0", VA = "0x1891441D0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x91428F0", Offset = "0x9140EF0", VA = "0x1891428F0")]
		private Camera HKBOJJOADDJ(Camera ADKEJHHNPHO, string BIDJKBKCFGP, float KDILOLAHKIK, float PPOAEOKFAPJ, int BLFEAJKCKFG, int AIEPFHPGBNF, float BDGKGDGCMED, float HLHHHKKPLIG, int PELKCKDNIGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9144310", Offset = "0x9142910", VA = "0x189144310", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9142F40", Offset = "0x9141540", VA = "0x189142F40")]
		[IteratorStateMachine(typeof(HEKJCAKJLFC))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x91424E0", Offset = "0x9140AE0", VA = "0x1891424E0")]
		private void BABGDNJDBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x91427D0", Offset = "0x9140DD0", VA = "0x1891427D0")]
		private void DCBJJKMGCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9141E40", Offset = "0x9140440", VA = "0x189141E40")]
		private void AIAABMEOGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x91428B0", Offset = "0x9140EB0", VA = "0x1891428B0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9143200", Offset = "0x9141800", VA = "0x189143200", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9141D90", Offset = "0x9140390", VA = "0x189141D90")]
		private static void AEAKAGEGFJM(Camera ADKEJHHNPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9142FC0", Offset = "0x91415C0", VA = "0x189142FC0", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Screen", 0)]
	public class CaptureFromScreen : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class JMIFFNIJBAA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CaptureFromScreen <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public JMIFFNIJBAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9151ED0", Offset = "0x91504D0", VA = "0x189151ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9152000", Offset = "0x9150600", VA = "0x189152000", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private bool _captureMouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private MouseCursor _mouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IntPtr NLLPKKBAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture NIDEGHHCPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer AMANGCCPMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator PGOEDJNLMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool FKNHLLFFNEN;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CEJPDCMLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBCA4F0", Offset = "0xBC8AF0", VA = "0x180BCA4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBD0A40", Offset = "0xBCF040", VA = "0x180BD0A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor HLBHOPMCNPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBBB100", Offset = "0xBB9700", VA = "0x180BBB100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC24FD0", Offset = "0xC235D0", VA = "0x180C24FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x914ABD0", Offset = "0x91491D0", VA = "0x18914ABD0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x914A700", Offset = "0x9148D00", VA = "0x18914A700")]
		private void NOPGMIIGCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x914A620", Offset = "0x9148C20", VA = "0x18914A620")]
		private void GDFLLIONFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x914AFE0", Offset = "0x91495E0", VA = "0x18914AFE0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x914AB50", Offset = "0x9149150", VA = "0x18914AB50")]
		[IteratorStateMachine(typeof(JMIFFNIJBAA))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x914B130", Offset = "0x9149730", VA = "0x18914B130", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x914B160", Offset = "0x9149760", VA = "0x18914B160")]
		public CaptureFromScreen()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Texture", 3)]
	public class CaptureFromTexture : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class BGFHMIBBJGF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public CaptureFromTexture <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public BGFHMIBBJGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x913E590", Offset = "0x913CB90", VA = "0x18913E590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x913E600", Offset = "0x913CC00", VA = "0x18913E600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("If enabled the method the encoder will only process frames each time UpdateSourceTexture() is called. This is useful if the texture is updating at a different rate compared to Unity, eg for webcam capture.")]
		[SerializeField]
		private bool _manualUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Texture DBGOCBECHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture NIDEGHHCPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr NLLPKKBAGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool HFKBACOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool NCHCGAPBEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBCA4F0", Offset = "0xBC8AF0", VA = "0x180BCA4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD0A40", Offset = "0xBCF040", VA = "0x180BD0A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xC24FD0", Offset = "0xC235D0", VA = "0x180C24FD0")]
		public void SetSourceTexture(Texture BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x914B870", Offset = "0x9149E70", VA = "0x18914B870")]
		private bool GCAHJCLGJJN(Texture BDFJHOHMCFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x914C260", Offset = "0x914A860", VA = "0x18914C260")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x914B7E0", Offset = "0x9149DE0", VA = "0x18914B7E0")]
		private bool DDALGHOFKFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x914B850", Offset = "0x9149E50", VA = "0x18914B850")]
		private bool DIGCMIHMEMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x914C1B0", Offset = "0x914A7B0", VA = "0x18914C1B0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x914BBE0", Offset = "0x914A1E0", VA = "0x18914BBE0")]
		[IteratorStateMachine(typeof(BGFHMIBBJGF))]
		private IEnumerator OAHFDONJKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x914B1D0", Offset = "0x91497D0", VA = "0x18914B1D0")]
		private void BABGDNJDBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x914BA50", Offset = "0x914A050", VA = "0x18914BA50")]
		private void JNCLJELDKPF(int EPJLFMHGDCC, int GHDHPPBLHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x914B730", Offset = "0x9149D30", VA = "0x18914B730")]
		private void DCBJJKMGCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x914B950", Offset = "0x9149F50", VA = "0x18914B950", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x914BC60", Offset = "0x914A260", VA = "0x18914BC60", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x914C0A0", Offset = "0x914A6A0", VA = "0x18914C0A0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x914C270", Offset = "0x914A870", VA = "0x18914C270")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x914C2E0", Offset = "0x914A8E0", VA = "0x18914C2E0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x914C270", Offset = "0x914A870", VA = "0x18914C270")]
		public CaptureFromWebCamTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	[AddComponentMenu("AVPro Movie Capture/Utils/Capture GUI", 300)]
	public class CaptureGUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private enum KPGECBENGAA
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			VideoCodecs,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			AudioCodecs,
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			AudioInputDevices,
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			ImageCodecs
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AudioListener KBJKEJBNDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private CaptureBase _movieCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private bool _showUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private bool _whenRecordingAutoHideUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GUISkin _guiSkin;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly string[] KEMJALCFGOP;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] OBLKEIJLJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KPGECBENGAA DMODOOHAHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] FNGCPFHGMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] ODBPHIMBFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] GOENONGOIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] NNIMMMMGOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] JADLHEEEGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] GDMCBKMDKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] PPNNPPEMIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int GFHGCLMBNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle KMHAMMHPADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int AFNFMMDHKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 MOPNGLJIPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 EGFLIGIKFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 JBKJKPHLNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 HLPADHCOOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long CDKJNEPHAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float MPPGDADHPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float HEJJALBDPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint NIAGEMOMAOF;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase AHIBNEGALFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JOPDHBGHOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF8C250", Offset = "0xF8A850", VA = "0x180F8C250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xF8C260", Offset = "0xF8A860", VA = "0x180F8C260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FCBHDLIBFAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9150ED0", Offset = "0x914F4D0", VA = "0x189150ED0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x914EB80", Offset = "0x914D180", VA = "0x18914EB80")]
		private void HHFJFDEELCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x91509B0", Offset = "0x914EFB0", VA = "0x1891509B0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x914C350", Offset = "0x914A950", VA = "0x18914C350")]
		private void CAOHNIKPMIG(int NMILEMOAODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x914F550", Offset = "0x914DB50", VA = "0x18914F550")]
		private void NOBJIFHHCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x914E740", Offset = "0x914CD40", VA = "0x18914E740")]
		private void EADMEMAACLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x914EAF0", Offset = "0x914D0F0", VA = "0x18914EAF0")]
		private void EFIBDKLBBOL(string JGPEJMANNEB, string PDHHCOODKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x914E560", Offset = "0x914CB60", VA = "0x18914E560")]
		private void CELNBPHDHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x914E6B0", Offset = "0x914CCB0", VA = "0x18914E6B0")]
		private void DMEHNEGCPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x914F4D0", Offset = "0x914DAD0", VA = "0x18914F4D0")]
		private void LIABHIHMJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x914E630", Offset = "0x914CC30", VA = "0x18914E630")]
		private void DHACMFDAAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x914F450", Offset = "0x914DA50", VA = "0x18914F450")]
		private void LGJECKNJIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9150F40", Offset = "0x914F540", VA = "0x189150F40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9151780", Offset = "0x914FD80", VA = "0x189151780")]
		public CaptureGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Motion Blur", 301)]
	public class MotionBlur : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private RenderTextureFormat _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private int _numSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private RenderTexture ABAFNOLOMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture OJFIGFDOKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material OCFNIHANOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material CNCHICNGAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int DHPODKGKPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int BGDOLIAAOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int AKDODMBEJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool ABKHLEDOIHB;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int EKMPGCEILCB;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int LDAHEDNILKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float DGAJNEEKCNH;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool FIGFGCLBJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x13421A0", Offset = "0x13407A0", VA = "0x1813421A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x180B0E0", Offset = "0x18096E0", VA = "0x18180B0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int PGIBJMDOEBN
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x916A680", Offset = "0x9168C80", VA = "0x18916A680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int ICDFMEPLMLK
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture FHFBILOBNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9169C80", Offset = "0x9168280", VA = "0x189169C80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x916A630", Offset = "0x9168C30", VA = "0x18916A630")]
		public void SetTargetSize(int EPJLFMHGDCC, int GHDHPPBLHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x916A650", Offset = "0x9168C50", VA = "0x18916A650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x916A390", Offset = "0x9168990", VA = "0x18916A390")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9169D10", Offset = "0x9168310", VA = "0x189169D10")]
		private void HFNJJDCIHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x916A150", Offset = "0x9168750", VA = "0x18916A150")]
		private void NANHBFDJNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x916A1B0", Offset = "0x91687B0", VA = "0x18916A1B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x916A3F0", Offset = "0x91689F0", VA = "0x18916A3F0")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86581D0", Offset = "0x86567D0", VA = "0x1886581D0")]
		private static float NBEAKEHOAIP(float JGPEJMANNEB, float PDHHCOODKIC, float DHDFDKFCOJK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x916A070", Offset = "0x9168670", VA = "0x18916A070")]
		private void IEHANLKKDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9169B60", Offset = "0x9168160", VA = "0x189169B60")]
		public void Accumulate(Texture PPEFJKBNOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x916A4C0", Offset = "0x9168AC0", VA = "0x18916A4C0")]
		private void OnRenderImage(RenderTexture PPEFJKBNOEP, RenderTexture DNPKCGAKHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x916A660", Offset = "0x9168C60", VA = "0x18916A660")]
		public MotionBlur()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Render Mouse Cursor", 302)]
	public class MouseCursor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[Range(1f, 16f)]
		[SerializeField]
		private int _sizeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private int _depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GUIContent INBFKLGBBBD;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x916A8C0", Offset = "0x9168EC0", VA = "0x18916A8C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x916A800", Offset = "0x9168E00", VA = "0x18916A800")]
		public void SetTexture(Texture2D BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x916A690", Offset = "0x9168C90", VA = "0x18916A690")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x916A980", Offset = "0x9168F80", VA = "0x18916A980")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> GECMEPOLGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x916A9F0", Offset = "0x9168FF0", VA = "0x18916A9F0")]
		private void OnAudioFilterRead(float[] CDDIADBJAOB, int NOJMAMBJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum CBGGPLOICAF
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class EHOOFILEKNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector CLDEGJKHMOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode PJBNIHPBOKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool NKKDMHIKBLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool GPHCKNEHJGB;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
			internal EHOOFILEKNO(PlayableDirector KLMEOMHLHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x915E710", Offset = "0x915CD10", VA = "0x18915E710")]
			internal bool KJFDNIOHLHM(PlayableDirector KLMEOMHLHPA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x915E540", Offset = "0x915CB40", VA = "0x18915E540")]
			internal void CELNBPHDHBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x915E640", Offset = "0x915CC40", VA = "0x18915E640")]
			internal void DMEHNEGCPBB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private CBGGPLOICAF _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<EHOOFILEKNO> HPMLKAKKOHG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public CBGGPLOICAF AKELDEAGOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(CBGGPLOICAF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x916C2B0", Offset = "0x916A8B0", VA = "0x18916C2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x916B920", Offset = "0x9169F20", VA = "0x18916B920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x916B920", Offset = "0x9169F20", VA = "0x18916B920")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x916BE30", Offset = "0x916A430", VA = "0x18916BE30")]
		internal void OBFILMIAKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x916B930", Offset = "0x9169F30", VA = "0x18916B930")]
		internal void CELNBPHDHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x916BB60", Offset = "0x916A160", VA = "0x18916BB60")]
		internal void DMEHNEGCPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x916BEF0", Offset = "0x916A4F0", VA = "0x18916BEF0")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x916BE40", Offset = "0x916A440", VA = "0x18916BE40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x916BD40", Offset = "0x916A340", VA = "0x18916BD40")]
		private void JKPGGFECJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x916BB50", Offset = "0x916A150", VA = "0x18916BB50")]
		private void CJAPPLCNNAL(Scene BLFJNFOGIPN, LoadSceneMode IBLGEJEKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x916C220", Offset = "0x916A820", VA = "0x18916C220")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int IJJJHOIPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int MKDHOMNICII
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int PBGCLFLOJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PrepareCapture();

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void StartCapture();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void StopCapture();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PauseCapture();

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void ResumeCapture();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FlushBuffer();

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x916C880", Offset = "0x916AE80", VA = "0x18916C880", Slot = "13")]
		public virtual IntPtr ReadData([Out] int NODGHDHCBPE)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x916C6F0", Offset = "0x916ACF0", VA = "0x18916C6F0")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x916C810", Offset = "0x916AE10", VA = "0x18916C810")]
		private static int NLCEEKJINBD(AudioSpeakerMode IBLGEJEKAPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum JJHAGNGICFB
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class JLPBHINLDBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer MHJLOIIHJGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool GPHCKNEHJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool NKKDMHIKBLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool ICGPJBAPIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double HIGIDLDJAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float EAHFBHJENJJ;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
			internal JLPBHINLDBP(VideoPlayer PLGGDBMBOEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9167DF0", Offset = "0x91663F0", VA = "0x189167DF0")]
			internal bool KJFDNIOHLHM(VideoPlayer PLGGDBMBOEL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x91677E0", Offset = "0x9165DE0", VA = "0x1891677E0")]
			internal void CELNBPHDHBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9167E50", Offset = "0x9166450", VA = "0x189167E50")]
			internal bool MGAMJPFKMKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9167F30", Offset = "0x9166530", VA = "0x189167F30")]
			internal void PNKOPNGFPLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9167740", Offset = "0x9165D40", VA = "0x189167740")]
			private void BHMIICMJOOO(VideoPlayer NGOJMGCIOHB, long PFGENNMLDOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9167640", Offset = "0x9165C40", VA = "0x189167640")]
			private void BCMODKDIHDN(VideoPlayer NGOJMGCIOHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9167E90", Offset = "0x9166490", VA = "0x189167E90")]
			internal void NBJLPPBNIGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x91678F0", Offset = "0x9165EF0", VA = "0x1891678F0")]
			internal bool FPGILMIKMIA(float KJDBPOBDAMF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9167860", Offset = "0x9165E60", VA = "0x189167860")]
			internal void DMEHNEGCPBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class PBGJFBCIMNG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public VideoPlayerController <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public PBGJFBCIMNG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x916AA20", Offset = "0x9169020", VA = "0x18916AA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x916AB90", Offset = "0x9169190", VA = "0x18916AB90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private JJHAGNGICFB _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<JLPBHINLDBP> IPCDKIIKHLG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public JJHAGNGICFB AKELDEAGOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(JJHAGNGICFB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x916D770", Offset = "0x916BD70", VA = "0x18916D770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x916CA20", Offset = "0x916B020", VA = "0x18916CA20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x916CA20", Offset = "0x916B020", VA = "0x18916CA20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x916CFE0", Offset = "0x916B5E0", VA = "0x18916CFE0")]
		internal void OBFILMIAKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x916CBF0", Offset = "0x916B1F0", VA = "0x18916CBF0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x916C9A0", Offset = "0x916AFA0", VA = "0x18916C9A0")]
		[IteratorStateMachine(typeof(PBGJFBCIMNG))]
		internal IEnumerator ADAOOIFPDFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x916CA30", Offset = "0x916B030", VA = "0x18916CA30")]
		internal void CELNBPHDHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x916CD60", Offset = "0x916B360", VA = "0x18916CD60")]
		internal void DMEHNEGCPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x916D340", Offset = "0x916B940", VA = "0x18916D340")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x916D120", Offset = "0x916B720", VA = "0x18916D120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x916CEF0", Offset = "0x916B4F0", VA = "0x18916CEF0")]
		private void JKPGGFECJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x916CBE0", Offset = "0x916B1E0", VA = "0x18916CBE0")]
		private void CJAPPLCNNAL(Scene BLFJNFOGIPN, LoadSceneMode IBLGEJEKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x916D6E0", Offset = "0x916BCE0", VA = "0x18916D6E0")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x916D1D0", Offset = "0x916B7D0", VA = "0x18916D1D0")]
		[CompilerGenerated]
		private bool PIGOFFEFEGG()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum KLBIMEDKOCP
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	First = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Second,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Third
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum PGGLILAJLAF
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ACN_SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum CJDDJKCEPMG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ACN
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum GBBHFOJBICN
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JBIDGKPNFAO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum JLLEGIDDCCH
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Unknown = -2,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Current = -1,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		First = 0,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Windows = 0,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		macOS = 1,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		iOS = 2,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Android = 3,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Count = 4
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum HHAKBCECKBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RGBA32,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		BGRA32,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		YCbCr422_YUY2,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		YCbCr422_UYVY,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		YCbCr422_HDYC
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum KJIMFFOPBEE
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		CaptureFrameBuffer,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeResources,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Setup
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static string[] NCCDNPBPJEI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly string[] LJFIJCNEJBM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string[] CEOBLAIHDCE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly string[] KEHINDBBGLA;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static readonly string[] EBEDJBCMBBA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly string[] EICADDFNFOC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly string[] IJELBLFEIMB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static IntPtr JFPPMPFEGME;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static IntPtr OFMNMNIKLBB;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private static IntPtr IJBGBKIOJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9161790", Offset = "0x915FD90", VA = "0x189161790")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private static IntPtr HHAENHKDGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9160780", Offset = "0x915ED80", VA = "0x189160780")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x9160210", Offset = "0x915E810", VA = "0x189160210")]
	public static extern IntPtr FPMBGNJOLOO(int NLHPOMKKJPP);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x915F520", Offset = "0x915DB20", VA = "0x18915F520")]
	public static extern void BNDHHGJMPPL(IntPtr MHKMPBAHOMB);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x9160C60", Offset = "0x915F260", VA = "0x189160C60")]
	public static extern void JCALELKOMDC(IntPtr MHKMPBAHOMB, float DPCANMPCIJB, float CAEAPLNBOOH, KLBIMEDKOCP DPNBGBIGDNP, CJDDJKCEPMG AKHLBCCNMNO, float[] HKCCJKBMPJH);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x915FDE0", Offset = "0x915E3E0", VA = "0x18915FDE0")]
	public static extern void EIHGGMOJMOH(IntPtr MHKMPBAHOMB, float[] GPIHKPLOPDH, int HFHLLPEGDPI, int FLPJFHMEPEE, int MHNNBGBBODA, float[] FIEPDLGGJPF, int KEKMNFNGODG, int EHHCHDOHGBP, KLBIMEDKOCP DPNBGBIGDNP);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x915F9F0", Offset = "0x915DFF0", VA = "0x18915F9F0")]
	public static string CPCMEHIIBMO(HHAKBCECKBI GNNNFNJGFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x91609A0", Offset = "0x915EFA0", VA = "0x1891609A0")]
	public static void IPFKDALBGDN(KJIMFFOPBEE NFCCDILHFDA, int MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9161940", Offset = "0x915FF40", VA = "0x189161940")]
	private static extern IntPtr PAIDGBGPGGD();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9161720", Offset = "0x915FD20", VA = "0x189161720")]
	private static extern IntPtr NDODKKIHLJH();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9160290", Offset = "0x915E890", VA = "0x189160290")]
	public static extern bool HAKAIDJFGEI();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x91601A0", Offset = "0x915E7A0", VA = "0x1891601A0")]
	public static extern void FGPLPNIGCPF();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x915F350", Offset = "0x915D950", VA = "0x18915F350")]
	public static string AOADDJCDOHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x915F4A0", Offset = "0x915DAA0", VA = "0x18915F4A0")]
	public static bool BHOAONKIJMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x91612C0", Offset = "0x915F8C0", VA = "0x1891612C0")]
	public static extern int LFIJNPDLKCC();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x91619B0", Offset = "0x915FFB0", VA = "0x1891619B0")]
	public static extern bool PAOCLOEBGAB(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9161240", Offset = "0x915F840", VA = "0x189161240")]
	public static extern MACDKELELIE KNCEHLNFDPB(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x915F2D0", Offset = "0x915D8D0", VA = "0x18915F2D0")]
	public static extern void ALMFHOFNGEF(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9160F90", Offset = "0x915F590", VA = "0x189160F90")]
	public static string JPLPHGMIMAB(int CLKFNGNLLGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9160930", Offset = "0x915EF30", VA = "0x189160930")]
	public static extern int IKPNFECAFOF();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x91618C0", Offset = "0x915FEC0", VA = "0x1891618C0")]
	public static extern bool OIPIJCIBHLC(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x915F250", Offset = "0x915D850", VA = "0x18915F250")]
	public static extern MACDKELELIE ACGHKLDLBNJ(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9161330", Offset = "0x915F930", VA = "0x189161330")]
	public static extern void LIJCGBCMGJM(int CLKFNGNLLGD);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x9160580", Offset = "0x915EB80", VA = "0x189160580")]
	public static string HIDHFKOHEMM(int CLKFNGNLLGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x915FEE0", Offset = "0x915E4E0", VA = "0x18915FEE0")]
	public static extern int FBECPPHJOLE();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x9160020", Offset = "0x915E620", VA = "0x189160020")]
	public static string FEFENBIGMHC(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x91608B0", Offset = "0x915EEB0", VA = "0x1891608B0")]
	public static extern MACDKELELIE IKBKDPBBGAL(int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x915F620", Offset = "0x915DC20", VA = "0x18915F620")]
	public static string[] CBICKGHOKIM(int PCBBDLJJNIJ, int PIPIDPAGKGC = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x915FAC0", Offset = "0x915E0C0", VA = "0x18915FAC0")]
	public static extern int DDFOBOHEKOC(string GDCFOAHKBOL, uint EPJLFMHGDCC, uint GHDHPPBLHGA, float FGKHNEAFLOP, int OFCLANOKPBA, bool JIHNJMLIBPP, bool PPFNPBNHFPF, int PCBBDLJJNIJ, DCGKKEPDMEC PBLDFAKOFIK, int KAIDHDMDFJJ, int ABMODILDDHE, int FODGKHJNAIP, int PIPIDPAGKGC, bool OMHEKGDEJPN, VideoEncoderHints OAIMHBEFJGG);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x9161110", Offset = "0x915F710", VA = "0x189161110")]
	public static extern int KMBEDHCAGIN(string GDCFOAHKBOL, uint EPJLFMHGDCC, uint GHDHPPBLHGA, float FGKHNEAFLOP, int OFCLANOKPBA, bool JIHNJMLIBPP, bool PPFNPBNHFPF, int JAGIDFCBCNF, bool OMHEKGDEJPN, int GKJJAABCABJ, ImageEncoderHints OAIMHBEFJGG);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x9160D40", Offset = "0x915F340", VA = "0x189160D40")]
	public static extern int JKMONAECJGO(string GDCFOAHKBOL, uint EPJLFMHGDCC, uint GHDHPPBLHGA, float FGKHNEAFLOP, int OFCLANOKPBA, bool PPFNPBNHFPF, int LCFOMHAICPC, bool OMHEKGDEJPN);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x9161AB0", Offset = "0x91600B0", VA = "0x189161AB0")]
	public static extern bool PLMAAMEONBL(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x915F5A0", Offset = "0x915DBA0", VA = "0x18915F5A0")]
	public static extern bool CBAAGCLJNEL(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x9161690", Offset = "0x915FC90", VA = "0x189161690")]
	public static extern int MPHFFHGLKDE(int MNHLJANEAIO, uint IFICFFIDJHL);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x9160420", Offset = "0x915EA20", VA = "0x189160420")]
	public static extern void HHDOIPBONJM(int MNHLJANEAIO, IntPtr CDDIADBJAOB);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x9160300", Offset = "0x915E900", VA = "0x189160300")]
	public static extern void HCAJGFEGBNO(int MNHLJANEAIO, IntPtr CDDIADBJAOB, uint NODGHDHCBPE);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x915F8D0", Offset = "0x915DED0", VA = "0x18915F8D0")]
	public static extern void CDBKOAJNOFN(int MNHLJANEAIO, IntPtr IACHAPOGOAJ, IntPtr NGAPFKFLCLD, uint CCGBHMIFAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x915FD60", Offset = "0x915E360", VA = "0x18915FD60")]
	public static extern void EEEOMJDOMAD(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x9161420", Offset = "0x915FA20", VA = "0x189161420")]
	public static extern void MBDDDNAIIMI(int MNHLJANEAIO, bool DLHMKONBOOO);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x91614B0", Offset = "0x915FAB0", VA = "0x1891614B0")]
	public static extern bool MIDGNHFBKPG(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	public static bool EPONJOCBAFJ(int MNHLJANEAIO, StringBuilder OPGPHCADNCO, int NODGHDHCBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x9160E30", Offset = "0x915F430", VA = "0x189160E30")]
	public static extern void JPFOFLNNJFN(int MNHLJANEAIO, IntPtr BDFJHOHMCFM);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x915F970", Offset = "0x915DF70", VA = "0x18915F970")]
	public static extern void CHOPDGDNBFM(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x915F1D0", Offset = "0x915D7D0", VA = "0x18915F1D0")]
	public static extern uint AAEBPCFOKCG(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x91603A0", Offset = "0x915E9A0", VA = "0x1891603A0")]
	public static extern uint HDJFLDGJFCL(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x9160700", Offset = "0x915ED00", VA = "0x189160700")]
	public static extern uint HILHFJHMOEI(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x9161A30", Offset = "0x9160030", VA = "0x189161A30")]
	public static extern float PCJAPDNAICF(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x915F420", Offset = "0x915DA20", VA = "0x18915F420")]
	public static extern uint BCKPBGCJFJM(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x915FC20", Offset = "0x915E220", VA = "0x18915FC20")]
	public static extern uint DGJNDLEEPAA(int MNHLJANEAIO);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x91613B0", Offset = "0x915F9B0", VA = "0x1891613B0")]
	private static extern IntPtr LJNPBIJMNEH();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9160EC0", Offset = "0x915F4C0", VA = "0x189160EC0")]
	private static extern bool JPLPHGMIMAB(int PMIGBJGNLLP, StringBuilder NDIENANOGEK, int MEOLLICIKCA);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x91604B0", Offset = "0x915EAB0", VA = "0x1891604B0")]
	private static extern bool HIDHFKOHEMM(int PMIGBJGNLLP, StringBuilder NDIENANOGEK, int MEOLLICIKCA);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x915FF50", Offset = "0x915E550", VA = "0x18915FF50")]
	private static extern bool FEFENBIGMHC(int PMIGBJGNLLP, StringBuilder NDIENANOGEK, int MEOLLICIKCA);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x915F7F0", Offset = "0x915DDF0", VA = "0x18915F7F0")]
	private static extern bool CBICKGHOKIM(int PCBBDLJJNIJ, int PIPIDPAGKGC, StringBuilder HMBMLCOJDGM, int FLBLIAKBGPD);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x915FCA0", Offset = "0x915E2A0", VA = "0x18915FCA0")]
	private static extern bool EEDGAPGAACO(string GCHFOIBBBFF, [Out] ulong NPGBOGJNMAM, [Out] ulong NLLAOKILENK, [Out] ulong BFJGEHEOGME);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x9161530", Offset = "0x915FB30", VA = "0x189161530")]
	public static bool MJIJJHCBKLC(string BFHDBHOMJKM, [Out] ulong EIJIDGHNNNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EAGBNJGIDCO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct HONNPBPNBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public float DPCANMPCIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float CAEAPLNBOOH;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x915F080", Offset = "0x915D680", VA = "0x18915F080")]
		public void ALFELEMCMFC(Vector3 APHHGJIDDCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static float[] BHAKCEGNCIB;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static float[] FGDMBBDPMKF;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x915DA10", Offset = "0x915C010", VA = "0x18915DA10")]
	public static float[] AKJBPAGIPHA(GBBHFOJBICN DAGKKINHIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x915E010", Offset = "0x915C610", VA = "0x18915E010")]
	public static int IFCIHAKHEKJ(KLBIMEDKOCP DPNBGBIGDNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x915E0A0", Offset = "0x915C6A0", VA = "0x18915E0A0")]
	public static CJDDJKCEPMG NIAAJIIAODB(PGGLILAJLAF OFCLANOKPBA)
	{
		return default(CJDDJKCEPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x915E0A0", Offset = "0x915C6A0", VA = "0x18915E0A0")]
	public static GBBHFOJBICN JJOLIMONALJ(PGGLILAJLAF OFCLANOKPBA)
	{
		return default(GBBHFOJBICN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x915E4B0", Offset = "0x915CAB0", VA = "0x18915E4B0")]
	static EAGBNJGIDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x915DD40", Offset = "0x915C340", VA = "0x18915DD40")]
	private static float[] IAALLFEPBMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x915E410", Offset = "0x915CA10", VA = "0x18915E410")]
	private static int ONBGHKADLNH(int FAMCMDDOOMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x915E040", Offset = "0x915C640", VA = "0x18915E040")]
	private static int JFEICKHJABA(int FAMCMDDOOMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x915E490", Offset = "0x915CA90", VA = "0x18915E490")]
	private static int PPENMIOJBKF(int GBNAKFLHCOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x915E220", Offset = "0x915C820", VA = "0x18915E220")]
	private static float NNKGCAFIEGO(int FAMCMDDOOMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x915E0B0", Offset = "0x915C6B0", VA = "0x18915E0B0")]
	private static float NNKGCAFIEGO(int FMCINJJNLDO, int GKBAKEEHEPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x915DA90", Offset = "0x915C090", VA = "0x18915DA90")]
	private static float[] BAKJEAKLCMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class MAFMCHPHCGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private uint FPGEBGKBCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private uint GMAOOCCGLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private uint BKJPBAJEHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float NCAKNJFFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private uint JJCLCHIMNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private uint ABADEJMEBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private ulong LNJONABJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int CGJACNIPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private DCGKKEPDMEC POGIBEGMKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int JAPLNIAHNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private int DANNCDHHKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float GJNNPHJNICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int IJPCICJOFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private int DHPODKGKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private float APPJKDOHPMF;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float JFPMDPPENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD7C160", Offset = "0xD7A760", VA = "0x180D7C160")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public uint LCBNNIHFONO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public uint EEOGPIBBIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xBA16C0", Offset = "0xB9FCC0", VA = "0x180BA16C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public uint BBKANIGKLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float ACDOPOGKGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB02540", Offset = "0xB00B40", VA = "0x180B02540")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEDB240", Offset = "0xED9840", VA = "0x180EDB240")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	internal uint ACLINIBNDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	internal uint MPLAKDJLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x10B1C80", Offset = "0x10B0280", VA = "0x1810B1C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public DCGKKEPDMEC IBAIBMBONHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAE8040", Offset = "0xAE6640", VA = "0x180AE8040")]
		get
		{
			return default(DCGKKEPDMEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAE7780", Offset = "0xAE5D80", VA = "0x180AE7780")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int HFGHIGKHDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xEF6820", Offset = "0xEF4E20", VA = "0x180EF6820")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int DDLIGAFHCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAC5010", Offset = "0xAC3610", VA = "0x180AC5010")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x178F650", Offset = "0x178DC50", VA = "0x18178F650")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x9169B50", Offset = "0x9168150", VA = "0x189169B50")]
	internal void PMIKALHCDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x9169B00", Offset = "0x9168100", VA = "0x189169B00")]
	internal void GNEHLLKAKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7959730", Offset = "0x7957D30", VA = "0x187959730")]
	public MAFMCHPHCGG()
	{
	}
}
namespace RenderHeads.Media.AVProMovieCapture
{
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 80)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class VideoEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum JMLKINMPBEH
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Unknown = -1,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			Gamma,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[Tooltip("Average number of bits per second for the resulting video. Zero uses the codec defaults.")]
		public uint averageBitrate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[Tooltip("Maximum number of bits per second for the resulting video. Zero uses the codec defaults.")]
		public uint maximumBitrate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[Range(0f, 1f)]
		public float quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[Tooltip("How often a keyframe is inserted.  Zero uses the codec defaults.")]
		public uint keyframeInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[Tooltip("Move the 'moov' atom in the video file from the end to the start of the file to make streaming start fast.  Also known as 'Fast Start' in some encoders")]
		public bool allowFastStartStreamingPostProcess;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[Tooltip("Hints to the encoder to use the alpha channel for transparency if possible")]
		public bool supportTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public bool useHardwareEncoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[Tooltip("Enable Constant Quality")]
		public bool enableConstantQuality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[Tooltip("Enable fragmented writing support for QuickTime (mov, mp4) files")]
		public bool enableFragmentedWriting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public bool androidNoCaptureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public bool iOSSaveCaptureWhenAppLosesFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public bool padding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public OCCCFCIMPAD injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public AECHOIMOGPC stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public OCCCFCIMPAD injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public KHCDKAIEPBB sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JMLKINMPBEH colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public KHDFHKFOKAP transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public LBKILBJBEPF androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public CLFBNBLAJIO colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public NAGFGGPCDHG realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public OFKDPLFMHBD orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x916C930", Offset = "0x916AF30", VA = "0x18916C930")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x916C8D0", Offset = "0x916AED0", VA = "0x18916C8D0")]
		public void CCFHBFMBLLJ()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum BAEEABNPJAE
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			Unknown = -1,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			Gamma,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			Linear
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[Range(0f, 1f)]
		public float quality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Tooltip("Hints to the encoder to use the alpha channel for transparency if possible")]
		public bool supportTransparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public BAEEABNPJAE colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public KHDFHKFOKAP transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public LBKILBJBEPF androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x915F190", Offset = "0x915D790", VA = "0x18915F190")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x915F170", Offset = "0x915D770", VA = "0x18915F170")]
		public void CCFHBFMBLLJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class EncoderHints
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public VideoEncoderHints videoHints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ImageEncoderHints imageHints;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x915E890", Offset = "0x915CE90", VA = "0x18915E890")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x915E770", Offset = "0x915CD70", VA = "0x18915E770")]
		public void CCFHBFMBLLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum PJEEAIPALIL
		{
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			POW2_8192x8192,
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			POW2_8192x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			POW2_4096x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			POW2_4096x2048,
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			POW2_2048x4096,
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			UHD_3840x2160,
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			UHD_3840x2048,
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			UHD_3840x1920,
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			UHD_2560x1440,
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			POW2_2048x2048,
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			POW2_2048x1024,
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			HD_1920x1080,
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			HD_1280x720,
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			SD_1024x768,
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			SD_800x600,
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			SD_800x450,
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			SD_640x480,
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			SD_640x360,
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			SD_320x240,
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			Original,
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			Custom
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public enum KOLGCAIPDIH
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum MNIPLDNLEFG
		{
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			POW2_8192 = 8192,
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			POW2_4096 = 4096,
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			POW2_2048 = 2048,
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			POW2_1024 = 1024,
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			POW2_512 = 512,
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			POW2_256 = 256
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public enum DJFPKKNALFM
		{
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			Original = 1,
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			Half = 2,
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			Quarter = 4,
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			Eighth = 8,
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			Sixteenth = 16,
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			Custom = 100
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum DFLAAFIIBMC
		{
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			RelativeToProject = 0,
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			RelativeToPersistentData = 1,
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			Absolute = 2,
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			RelativeToDesktop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			RelativeToPictures = 4,
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			RelativeToVideos = 5,
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			PhotoLibrary = 6,
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			RelativeToTemporaryCachePath = 7,
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[Obsolete("Use RelativeToPersistentData")]
			RelativeToPeristentData = 1
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum PBCKKIHHDPF
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string OGGMNPMHDLC = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private EncoderHints _encoderHintsWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private EncoderHints _encoderHintsMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private EncoderHints _encoderHintsIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private EncoderHints _encoderHintsAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private KeyCode _captureKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool _isRealTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private MJNNONPHCFI _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private ONHGEDGBAKN _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private FLJBPHCHANJ _stopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private int _stopFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float _stopSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool _pauseCaptureOnAppPause;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly string[] DefaultVideoCodecPriorityWindows;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly string[] DefaultVideoCodecPriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly string[] DefaultVideoCodecPriorityAndroid;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly string[] DefaultAudioCodecPriorityWindows;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly string[] DefaultAudioCodecPriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly string[] DefaultAudioCodecPriorityIOS;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly string[] DefaultAudioCodecPriorityAndroid;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityWindow;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityMacOS;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityIOS;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly string[] DefaultAudioCaptureDevicePriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private string[] _videoCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private string[] _videoCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private string[] _videoCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private string[] _audioCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private string[] _audioCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private string[] _audioCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private float _frameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		[Tooltip("Timelapse scale makes the frame capture run at a fraction of the target frame rate.  Default value is 1")]
		private int _timelapseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		[Tooltip("Manual update mode requires user to call FrameUpdate() each time a frame is ready")]
		private PBCKKIHHDPF _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private DJFPKKNALFM _downScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private Vector2 _maxVideoSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceVideoCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[Range(0f, 128f)]
		[SerializeField]
		private int _forceVideoCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[Range(-1f, 128f)]
		[SerializeField]
		private int _forceAudioCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceAudioCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private bool _flipVertically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[Tooltip("Flushing the GPU during each capture results in less latency, but can slow down rendering performance for complex scenes.")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		[Tooltip("This option can help issues where skinning is used, or other animation/rendering effects that only complete later in the frame.")]
		protected bool _useWaitForEndOfFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCB")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		[Tooltip("Update the media gallery")]
		protected bool _androidUpdateMediaGallery;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		[Tooltip("Portrait captures may be rotated 90° to better utilise the encoder, check this to disable the rotation at the risk of not being able to capture the full vertical resolution.")]
		private bool _androidNoCaptureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool _iOSSaveCaptureWhenAppLosesFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Tooltip("Log the start and stop of the capture.  Disable this for less garbage generation.")]
		[SerializeField]
		private bool _logCaptureStartStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private DCGKKEPDMEC _audioCaptureSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private UnityAudioCapture _unityAudioCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[Range(0f, 32f)]
		[SerializeField]
		private int _forceAudioInputDeviceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[Range(8000f, 96000f)]
		private int _manualAudioSampleRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[Range(1f, 8f)]
		private int _manualAudioChannelCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		protected DIIFGFIFLLF _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const DFLAAFIIBMC DefaultOutputFolderType = DFLAAFIIBMC.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string CHINPAOBCNN = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private DFLAAFIIBMC _outputFolderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string _outputFolderPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string _filenamePrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private bool _appendFilenameTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x109")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private bool _allowManualFileExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string _filenameExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string _namedPipePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool _writeOrientationMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private int _imageSequenceStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Range(2f, 12f)]
		private int _imageSequenceZeroDigits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private FMANPEBDBGO _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private FMANPEBDBGO _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private FMANPEBDBGO _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private FMANPEBDBGO _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected PJEEAIPALIL _renderResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		protected Vector2 _renderSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		protected int _renderAntiAliasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		protected bool _useMotionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		[Range(0f, 64f)]
		protected int _motionBlurSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		protected Camera[] _motionBlurCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		protected MotionBlur _motionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool _allowVSyncDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x169")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private int _minimumDiskSpaceMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private TimelineController _timelineController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private VideoPlayerController _videoPlayerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		protected Texture2D LNGCOJLKIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int AHDAGIALEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int FPNBPBFKIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int OHPNHIFIGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int BGDOLIAAOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int AKDODMBEJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool EFOFPKGNBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19D")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool HCGLCPMHHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string MLMNMCGDLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string OMIPLNOGOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo AJFNLNNGFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected JBIDGKPNFAO.HHAKBCECKBI FMPBBCNKAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private ALPMDJBDEPA IHBIALMCFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private ALPMDJBDEPA JGHAOIHDKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private LKGDCFDCBAP EABBDOMCFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int BLLCPDKIICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float BJHEFHIMFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool KCLBEKGALJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool JMJGBOKGJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E2")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool PBHCPDDANEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E3")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool POFILGJBNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float NLMOBFJCPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float EFDIBFLACDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float GCMLOENCNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction DKJEPGKPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long KEOAEJPFKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected KHDFHKFOKAP NHDCLLFCKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture MGBIICPDHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material BFPHGCBAMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float FFGIHAJLEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool JBBKOAJKJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<AIKHOFOAIIL> FLFCDHLMMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<AIKHOFOAIIL> MHNMKMECFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<AIKHOFOAIIL> PGNBEMDBIMF;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> ODNIJFDGNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent PALACHHEKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent HNPNFODPPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private MAFMCHPHCGG OFCLPEGBEHH;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool AFIPCFKGCFK;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool LKKBIONHDHG;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public DIIFGFIFLLF ANGEFPPKEBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x17CBE80", Offset = "0x17CA480", VA = "0x1817CBE80")]
			get
			{
				return default(DIIFGFIFLLF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x17CB9A0", Offset = "0x17C9FA0", VA = "0x1817CB9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public DFLAAFIIBMC OLNENDCJGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC16D50", Offset = "0xC15350", VA = "0x180C16D50")]
			get
			{
				return default(DFLAAFIIBMC);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC16990", Offset = "0xC14F90", VA = "0x180C16990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string JKKJOPHNKMM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB42A80", Offset = "0xB41080", VA = "0x180B42A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xB3BEE0", Offset = "0xB3A4E0", VA = "0x180B3BEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string KEACBABHNEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xB363D0", Offset = "0xB349D0", VA = "0x180B363D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB3DFD0", Offset = "0xB3C5D0", VA = "0x180B3DFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool CMFFDHPDBPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xB363C0", Offset = "0xB349C0", VA = "0x180B363C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB60C80", Offset = "0xB5F280", VA = "0x180B60C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool OEGKBDCEBHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x227F260", Offset = "0x227D860", VA = "0x18227F260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x227C800", Offset = "0x227AE00", VA = "0x18227C800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string KKCBMFGKHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB37FD0", Offset = "0xB365D0", VA = "0x180B37FD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB36CD0", Offset = "0xB352D0", VA = "0x180B36CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string CIKPICKFHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xB0B1E0", Offset = "0xB097E0", VA = "0x180B0B1E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xB38430", Offset = "0xB36A30", VA = "0x180B38430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool GHJJHDMPFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB69C20", Offset = "0xB68220", VA = "0x180B69C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBD0CF0", Offset = "0xBCF2F0", VA = "0x180BD0CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int IJCEGDIPJMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB383D0", Offset = "0xB369D0", VA = "0x180B383D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xB9B190", Offset = "0xB99790", VA = "0x180B9B190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int NNFDLDJACFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x187D9B0", Offset = "0x187BFB0", VA = "0x18187D9B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x915D8B0", Offset = "0x915BEB0", VA = "0x18915D8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GKKECOACFNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x191C6F0", Offset = "0x191ACF0", VA = "0x18191C6F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x915D990", Offset = "0x915BF90", VA = "0x18915D990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int AAIDCAMHAAM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x211C390", Offset = "0x211A990", VA = "0x18211C390")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x915D920", Offset = "0x915BF20", VA = "0x18915D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] OGNBKNCDHCG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC22600", Offset = "0xC20C00", VA = "0x180C22600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xDB0C80", Offset = "0xDAF280", VA = "0x180DB0C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur HNJEOBPJKMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC1E6D0", Offset = "0xC1CCD0", VA = "0x180C1E6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD1290", Offset = "0xBCF890", VA = "0x180BD1290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public KHDFHKFOKAP NEIHGIEBIGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xBBB430", Offset = "0xBB9A30", VA = "0x180BBB430")]
			get
			{
				return default(KHDFHKFOKAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> PGKFPGKKKGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x915D740", Offset = "0x915BD40", VA = "0x18915D740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string DFFKNAKACHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB42CF0", Offset = "0xB412F0", VA = "0x180B42CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent KPBDJNHPMPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xBBB130", Offset = "0xBB9730", VA = "0x180BBB130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent HNPJADFEOJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBBB150", Offset = "0xBB9750", VA = "0x180BBB150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<AIKHOFOAIIL> IDGEBKHOFFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBD55E0", Offset = "0xBD3BE0", VA = "0x180BD55E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBCE180", Offset = "0xBCC780", VA = "0x180BCE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<AIKHOFOAIIL> IOLHOHABIFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBD64F0", Offset = "0xBD4AF0", VA = "0x180BD64F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xBCF6C0", Offset = "0xBCDCC0", VA = "0x180BCF6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public PJEEAIPALIL JEENHCAPBNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x23DEC40", Offset = "0x23DD240", VA = "0x1823DEC40")]
			get
			{
				return default(PJEEAIPALIL);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x915D860", Offset = "0x915BE60", VA = "0x18915D860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 GONLAEDNDON
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x915D790", Offset = "0x915BD90", VA = "0x18915D790")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x278E930", Offset = "0x278CF30", VA = "0x18278E930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int PABLKMJHEPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x191C730", Offset = "0x191AD30", VA = "0x18191C730")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x266BA90", Offset = "0x266A090", VA = "0x18266BA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool CFCLKKKJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFE0520", Offset = "0xFDEB20", VA = "0x180FE0520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool ICEAANDHACJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xFE0530", Offset = "0xFDEB30", VA = "0x180FE0530")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xFE0FF0", Offset = "0xFDF5F0", VA = "0x180FE0FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public DCGKKEPDMEC IBAIBMBONHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB61F50", Offset = "0xB60550", VA = "0x180B61F50")]
			get
			{
				return default(DCGKKEPDMEC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB61630", Offset = "0xB5FC30", VA = "0x180B61630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int DFEJGLBJGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F625E0", Offset = "0x1F60BE0", VA = "0x181F625E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x28A6210", Offset = "0x28A4810", VA = "0x1828A6210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int JABBACAEKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB49E80", Offset = "0xB48480", VA = "0x180B49E80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xB48D40", Offset = "0xB47340", VA = "0x180B48D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture JGGFFMBDNPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAAEEA0", Offset = "0xAAD4A0", VA = "0x180AAEEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAAEEB0", Offset = "0xAAD4B0", VA = "0x180AAEEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int NDLEEPGEIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB69390", Offset = "0xB67990", VA = "0x180B69390")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x915D870", Offset = "0x915BE70", VA = "0x18915D870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float NFMBKHHDFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1679010", Offset = "0x1677610", VA = "0x181679010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x915D880", Offset = "0x915BE80", VA = "0x18915D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MJNNONPHCFI NJFOPOEMHCC
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(MJNNONPHCFI);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xB28E50", Offset = "0xB27450", VA = "0x180B28E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ONHGEDGBAKN MMJBGKPCGGA
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xEC0B20", Offset = "0xEBF120", VA = "0x180EC0B20")]
			get
			{
				return default(ONHGEDGBAKN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1003BB0", Offset = "0x10021B0", VA = "0x181003BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float JHKOFELEAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAF7190", Offset = "0xAF5790", VA = "0x180AF7190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x915D950", Offset = "0x915BF50", VA = "0x18915D950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public FLJBPHCHANJ KAIHLNLGGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x152C9A0", Offset = "0x152AFA0", VA = "0x18152C9A0")]
			get
			{
				return default(FLJBPHCHANJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2385290", Offset = "0x2383890", VA = "0x182385290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int KBENJKJMPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xEC0BF0", Offset = "0xEBF1F0", VA = "0x180EC0BF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x915D960", Offset = "0x915BF60", VA = "0x18915D960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float HJPLFDGEHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1090930", Offset = "0x108EF30", VA = "0x181090930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x915D970", Offset = "0x915BF70", VA = "0x18915D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool CLMDBDCHGMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD78CF0", Offset = "0xD772F0", VA = "0x180D78CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD77FF0", Offset = "0xD765F0", VA = "0x180D77FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public MAFMCHPHCGG HJKAHDBBCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xBBB140", Offset = "0xBB9740", VA = "0x180BBB140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] CDLAONOODJE
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x915D9E0", Offset = "0x915BFE0", VA = "0x18915D9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] BJPNCKBGGAL
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x915D9B0", Offset = "0x915BFB0", VA = "0x18915D9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] PIDEIPICGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAB03C0", Offset = "0xAAE9C0", VA = "0x180AB03C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x915D830", Offset = "0x915BE30", VA = "0x18915D830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] IHMHCKOMJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAB04B0", Offset = "0xAAEAB0", VA = "0x180AB04B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x915D800", Offset = "0x915BE00", VA = "0x18915D800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int DIJMKEJDMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x3019BD0", Offset = "0x30181D0", VA = "0x183019BD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x5D13FF0", Offset = "0x5D125F0", VA = "0x185D13FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public PBCKKIHHDPF HPCGMPAPAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xF66CA0", Offset = "0xF652A0", VA = "0x180F66CA0")]
			get
			{
				return default(PBCKKIHHDPF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xF65540", Offset = "0xF63B40", VA = "0x180F65540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DJFPKKNALFM BKFBBICDBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xF66C90", Offset = "0xF65290", VA = "0x180F66C90")]
			get
			{
				return default(DJFPKKNALFM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF65370", Offset = "0xF63970", VA = "0x180F65370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 LDAJBFHHNBC
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2A78CD0", Offset = "0x2A772D0", VA = "0x182A78CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE8770", Offset = "0x2AE6D70", VA = "0x182AE8770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool NOEHHDIILON
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x10F6C60", Offset = "0x10F5260", VA = "0x1810F6C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x18D33F0", Offset = "0x18D19F0", VA = "0x1818D33F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool NMLGFAIGILN
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x82D0E70", Offset = "0x82CF470", VA = "0x1882D0E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x915D9A0", Offset = "0x915BFA0", VA = "0x18915D9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool DOJPOFCHOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2A86DB0", Offset = "0x2A853B0", VA = "0x182A86DB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2A872F0", Offset = "0x2A858F0", VA = "0x182A872F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool GLACJELHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x169C6E0", Offset = "0x169ACE0", VA = "0x18169C6E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x169B280", Offset = "0x1699880", VA = "0x18169B280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool BFDCHPENNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x23B78D0", Offset = "0x23B5ED0", VA = "0x1823B78D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x915D980", Offset = "0x915BF80", VA = "0x18915D980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController PAJNAIPEOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC3A980", Offset = "0xC38F80", VA = "0x180C3A980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB6D190", Offset = "0xB6B790", VA = "0x180B6D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController DONBIOJNGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC1F3B0", Offset = "0xC1D9B0", VA = "0x180C1F3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x10A29E0", Offset = "0x10A0FE0", VA = "0x1810A29E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public ALPMDJBDEPA OKFENLEJOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB80E30", Offset = "0xB7F430", VA = "0x180B80E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public ALPMDJBDEPA EFOKDCOHHBP
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB80E60", Offset = "0xB7F460", VA = "0x180B80E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public LKGDCFDCBAP DBELFMJCAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xC3A9E0", Offset = "0xC38FE0", VA = "0x180C3A9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int DMECCHIKOFH
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD5D0", Offset = "0xAABBD0", VA = "0x180AAD5D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD5E0", Offset = "0xAABBE0", VA = "0x180AAD5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int MHEGCBEAPGK
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB78DB0", Offset = "0xB773B0", VA = "0x180B78DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x10E2C60", Offset = "0x10E1260", VA = "0x1810E2C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public FMANPEBDBGO GPBEPDHLJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x187D9C0", Offset = "0x187BFC0", VA = "0x18187D9C0")]
			get
			{
				return default(FMANPEBDBGO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22F8FF0", Offset = "0x22F75F0", VA = "0x1822F8FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string OPEEDPLHNGL
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x915D7B0", Offset = "0x915BDB0", VA = "0x18915D7B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x915D8E0", Offset = "0x915BEE0", VA = "0x18915D8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
		protected static JBIDGKPNFAO.JLLEGIDDCCH MHMILKPODEL()
		{
			return default(JBIDGKPNFAO.JLLEGIDDCCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x91557D0", Offset = "0x9153DD0", VA = "0x1891557D0")]
		public EncoderHints GetEncoderHints(JBIDGKPNFAO.JLLEGIDDCCH CAHJAEKGIEG = JBIDGKPNFAO.JLLEGIDDCCH.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x915AF80", Offset = "0x9159580", VA = "0x18915AF80")]
		public void SetEncoderHints(EncoderHints OAIMHBEFJGG, JBIDGKPNFAO.JLLEGIDDCCH CAHJAEKGIEG = JBIDGKPNFAO.JLLEGIDDCCH.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void UpdateMediaGallery(string MBCEALKPIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9153BA0", Offset = "0x91521A0", VA = "0x189153BA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x915C2C0", Offset = "0x915A8C0", VA = "0x18915C2C0")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x915B5A0", Offset = "0x9159BA0", VA = "0x18915B5A0", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9155BF0", Offset = "0x91541F0", VA = "0x189155BF0")]
		private static bool HPKJKJEJGHJ(ALPMDJBDEPA JNIGMOCHOGG, CDMAJMGIEBO GCFJDFMJHLO, int KPMOFENMGMP, string[] FJPMPGJJLND, MACDKELELIE BFMEFONPLNM, bool JHCFENAMDLA, bool PCOHKKNNLOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x915AC60", Offset = "0x9159260", VA = "0x18915AC60")]
		public ALPMDJBDEPA SelectVideoCodec(bool IMLBCDKLBIE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x915A5C0", Offset = "0x9158BC0", VA = "0x18915A5C0")]
		public ALPMDJBDEPA SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x915A930", Offset = "0x9158F30", VA = "0x18915A930")]
		public LKGDCFDCBAP SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9155940", Offset = "0x9153F40", VA = "0x189155940")]
		public static Vector2 GetRecordingResolution(int EPJLFMHGDCC, int GHDHPPBLHGA, DJFPKKNALFM DHFCACFJGGK, Vector2 IFKACNNKPME)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x915AB50", Offset = "0x9159150", VA = "0x18915AB50")]
		public void SelectRecordingResolution(int EPJLFMHGDCC, int GHDHPPBLHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9157A10", Offset = "0x9156010", VA = "0x189157A10", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9157C50", Offset = "0x9156250", VA = "0x189157C50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9153A40", Offset = "0x9152040", VA = "0x189153A40")]
		private void ADOMKGKFNHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x91579C0", Offset = "0x9155FC0", VA = "0x1891579C0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9156570", Offset = "0x9154B70", VA = "0x189156570")]
		protected void LINOLBPNHJO(Texture2D BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9156170", Offset = "0x9154770", VA = "0x189156170")]
		protected bool KHBMFEIJGJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x91565F0", Offset = "0x9154BF0", VA = "0x1891565F0")]
		protected bool LNNHHICEJCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9154F30", Offset = "0x9153530", VA = "0x189154F30", Slot = "7")]
		public virtual void EncodePointer(IntPtr JHHCFBDKMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9156160", Offset = "0x9154760", VA = "0x189156160")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9156140", Offset = "0x9154740", VA = "0x189156140")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9156150", Offset = "0x9154750", VA = "0x189156150")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9155A10", Offset = "0x9154010", VA = "0x189155A10")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB42700", Offset = "0xB40D00", VA = "0x180B42700")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9156BD0", Offset = "0x91551D0", VA = "0x189156BD0", Slot = "8")]
		protected virtual string NBMKHCCNDKM(string NENEEJEOIOE, string DFNPOGLJDLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x91562B0", Offset = "0x91548B0", VA = "0x1891562B0")]
		private static string KPFPHNBOMBE(DFLAAFIIBMC EBOMPEGHNJL, string BFHDBHOMJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9153870", Offset = "0x9151E70", VA = "0x189153870")]
		private static string ACGENNNHBBE(DFLAAFIIBMC EBOMPEGHNJL, string BFHDBHOMJKM, string GDCFOAHKBOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9154850", Offset = "0x9152E50", VA = "0x189154850")]
		protected static bool DIKCOFEACCL(string BFHDBHOMJKM, string BEFEDMIPOOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9156FB0", Offset = "0x91555B0", VA = "0x189156FB0")]
		protected void NKMEAJBOBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9155190", Offset = "0x9153790", VA = "0x189155190")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool NFCHHMKLPHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9157F00", Offset = "0x9156500", VA = "0x189157F00")]
		private bool PGPHILFMGNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9158820", Offset = "0x9156E20", VA = "0x189158820", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x915A450", Offset = "0x9158A50", VA = "0x18915A450")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1654700", Offset = "0x1652D00", VA = "0x181654700")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9155F30", Offset = "0x9154530", VA = "0x189155F30")]
		protected void IOHGOGHJHGA(AECHOIMOGPC IPBIHMNNKHP, KHCDKAIEPBB JJEMFALMEPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x915B020", Offset = "0x9159620", VA = "0x18915B020")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x91585E0", Offset = "0x9156BE0", VA = "0x1891585E0")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x915A4D0", Offset = "0x9158AD0", VA = "0x18915A4D0")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9154820", Offset = "0x9152E20", VA = "0x189154820")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9154890", Offset = "0x9152E90", VA = "0x189154890")]
		public static void DeleteCapture(DIIFGFIFLLF HAKAPAEFLDN, string BFHDBHOMJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x91560E0", Offset = "0x91546E0", VA = "0x1891560E0")]
		protected void IPFKDALBGDN(JBIDGKPNFAO.KJIMFFOPBEE NFCCDILHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x915B650", Offset = "0x9159C50", VA = "0x18915B650", Slot = "11")]
		public virtual void StopCapture(bool DLHMKONBOOO = false, bool LPONHHNAFFE = false, bool OAADBBHOAIB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9155640", Offset = "0x9153C40", VA = "0x189155640")]
		private static JCMEEJMDEND.BECHCFKBNHA GKBJGBBCJIA(VideoEncoderHints OAIMHBEFJGG, string NAOLAABOPLP)
		{
			return default(JCMEEJMDEND.BECHCFKBNHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x91569D0", Offset = "0x9154FD0", VA = "0x1891569D0")]
		private static bool MLLHPJKCLNH(string FOJGLONLCLC, VideoEncoderHints OAIMHBEFJGG, string NAOLAABOPLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9157CE0", Offset = "0x91562E0", VA = "0x189157CE0")]
		protected void PCEGMFJGJEL(string FOJGLONLCLC, VideoEncoderHints OAIMHBEFJGG, string NAOLAABOPLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9153830", Offset = "0x9151E30", VA = "0x189153830")]
		private void ABJONEABPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9155FC0", Offset = "0x91545C0", VA = "0x189155FC0")]
		private bool IPBDDOMPGBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9157770", Offset = "0x9155D70", VA = "0x189157770")]
		protected bool NOGFMNICBMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x915C260", Offset = "0x915A860", VA = "0x18915C260")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9156660", Offset = "0x9154C60", VA = "0x189156660")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x91561F0", Offset = "0x91547F0", VA = "0x1891561F0")]
		private void KKLJIKAGMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9155E90", Offset = "0x9154490", VA = "0x189155E90")]
		private void IHINFLHOAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9158580", Offset = "0x9156B80", VA = "0x189158580")]
		protected bool PLHILEMDEFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x91578E0", Offset = "0x9155EE0", VA = "0x1891578E0")]
		protected bool OHPNKLIMECN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9155880", Offset = "0x9153E80", VA = "0x189155880")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x91547F0", Offset = "0x9152DF0", VA = "0x1891547F0")]
		protected float CMNOOGNBCMG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9154450", Offset = "0x9152A50", VA = "0x189154450")]
		protected bool BFFJHEOBGPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9157EC0", Offset = "0x91564C0", VA = "0x189157EC0")]
		protected void PDFBPFJEBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9155BA0", Offset = "0x91541A0", VA = "0x189155BA0")]
		protected void HCHGEPOJLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB80720", Offset = "0xB7ED20", VA = "0x180B80720", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9157820", Offset = "0x9155E20", VA = "0x189157820")]
		protected void OELHIPLNCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9154E80", Offset = "0x9153480", VA = "0x189154E80")]
		public void EncodeAudio(NativeArray<float> NGAPFKFLCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9154D60", Offset = "0x9153360", VA = "0x189154D60")]
		public void EncodeAudio(float[] NGAPFKFLCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9158720", Offset = "0x9156D20", VA = "0x189158720", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x915BE60", Offset = "0x915A460", VA = "0x18915BE60", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x91549A0", Offset = "0x9152FA0", VA = "0x1891549A0")]
		protected bool EECHICMHGMF(int EPJLFMHGDCC, int GHDHPPBLHGA, bool LBOPPLHOECI = false, int KHGBNNIOCPM = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9154630", Offset = "0x9152C30", VA = "0x189154630")]
		protected RenderTexture BHBDAMCLEII(Texture CMMJPMFOJIH, bool LBOPPLHOECI = false, int KHGBNNIOCPM = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x91585B0", Offset = "0x9156BB0", VA = "0x1891585B0")]
		protected void PMIKALHCDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x915BE00", Offset = "0x915A400", VA = "0x18915BE00")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9156410", Offset = "0x9154A10", VA = "0x189156410")]
		protected int LAJNJIKBGFB(Camera ADKEJHHNPHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x91556D0", Offset = "0x9153CD0", VA = "0x1891556D0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9155A20", Offset = "0x9154020", VA = "0x189155A20")]
		public static void GetResolution(PJEEAIPALIL DPJDNHFKCDJ, int EPJLFMHGDCC, int GHDHPPBLHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x91569C0", Offset = "0x9154FC0", VA = "0x1891569C0")]
		protected static int MEIKOODJLEE(int KOPHBHGIACG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x915D230", Offset = "0x915B830", VA = "0x18915D230")]
		public CaptureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum MACDKELELIE
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	AVFoundation,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	MediaFoundation,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	DirectShow,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	MediaCodec
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum FDFGHPIOEKD
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Audio
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ALPMDJBDEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private FDFGHPIOEKD OEKBEMFMDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private int DDBGNDNNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private bool NEPEIJIJOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MACDKELELIE DBKJKJKFJLC;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public MACDKELELIE LDLHAJBEJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0", Slot = "6")]
		get
		{
			return default(MACDKELELIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool AHLDKNBCNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x9152850", Offset = "0x9150E50", VA = "0x189152850")]
	public void CBHDPKHBOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x91529B0", Offset = "0x9150FB0", VA = "0x1891529B0")]
	internal ALPMDJBDEPA(FDFGHPIOEKD KPJPOJCDJCE, int PMIGBJGNLLP, string NDIENANOGEK, MACDKELELIE MILNDCBAEON, bool MKBAFEFOEEL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CDMAJMGIEBO : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private ALPMDJBDEPA[] JDLOONPFIEE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public ALPMDJBDEPA[] AFAPNFHACDF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x29A3DD0", Offset = "0x29A23D0", VA = "0x1829A3DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x91537C0", Offset = "0x9151DC0", VA = "0x1891537C0")]
	internal CDMAJMGIEBO(ALPMDJBDEPA[] NHAJNGJLFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x9153720", Offset = "0x9151D20", VA = "0x189153720")]
	public ALPMDJBDEPA ICAODLOOMCK(string NDIENANOGEK, MACDKELELIE KHJPKACKNPL = MACDKELELIE.Unknown)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x91536C0", Offset = "0x9151CC0", VA = "0x1891536C0")]
	public ALPMDJBDEPA DFDEPPMNMKH(MACDKELELIE MILNDCBAEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A90680", Offset = "0x2A8EC80", VA = "0x182A90680", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BJHPCJOAPNH
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static bool DFHGDJOEDDK;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static CDMAJMGIEBO ENGGJKMGFBP;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static CDMAJMGIEBO KDNGLDAJJEP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public static CDMAJMGIEBO FCINDOGMEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9153440", Offset = "0x9151A40", VA = "0x189153440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static CDMAJMGIEBO HNDBKJKHKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x91534A0", Offset = "0x9151AA0", VA = "0x1891534A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x91533A0", Offset = "0x91519A0", VA = "0x1891533A0")]
	private static void LMPOEECHPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x9152B40", Offset = "0x9151140", VA = "0x189152B40")]
	private static void JDFIBAFLIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum LAPEEJPJLGC
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	AudioInput
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class LKGDCFDCBAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private LAPEEJPJLGC MDPMAMCCEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private int DDBGNDNNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private string JLFIMMGPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private MACDKELELIE DBKJKJKFJLC;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public MACDKELELIE LDLHAJBEJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970", Slot = "6")]
		get
		{
			return default(MACDKELELIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x91699B0", Offset = "0x9167FB0", VA = "0x1891699B0")]
	internal LKGDCFDCBAP(LAPEEJPJLGC ECOBMBNMDJE, int PMIGBJGNLLP, string NDIENANOGEK, MACDKELELIE MILNDCBAEON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BBLCJCCFNHA : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private LKGDCFDCBAP[] NBBFKLMNDHP;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LKGDCFDCBAP[] IFLHGKFPHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x29A3DD0", Offset = "0x29A23D0", VA = "0x1829A3DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x9152A70", Offset = "0x9151070", VA = "0x189152A70")]
	internal BBLCJCCFNHA(LKGDCFDCBAP[] BPDPIMEDHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x9152A10", Offset = "0x9151010", VA = "0x189152A10")]
	public LKGDCFDCBAP DFDEPPMNMKH(MACDKELELIE MILNDCBAEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A90680", Offset = "0x2A8EC80", VA = "0x182A90680", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class HMEGIAKHFCD
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private static bool DFHGDJOEDDK;

	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private static BBLCJCCFNHA KDBCFCKGAGL;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static BBLCJCCFNHA DFBHDNBCGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x915E9C0", Offset = "0x915CFC0", VA = "0x18915E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x915EED0", Offset = "0x915D4D0", VA = "0x18915EED0")]
	private static void LMPOEECHPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x915EAA0", Offset = "0x915D0A0", VA = "0x18915EAA0")]
	private static void GOFPACGPKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class AIKHOFOAIIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum OACOOKHHBEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		BusyFileWriting,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		BusyPostProcessing,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		CompletedDeleted,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		Completed
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private string GPANEOLDIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private int AHDAGIALEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private bool ILHDLGHFCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private DIIFGFIFLLF GJJLHNGEDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private JCMEEJMDEND.BECHCFKBNHA NEIOHBGIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ManualResetEvent NEBBNFNKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OACOOKHHBEM PHAOFOEHDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private string OMIPLNOGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool BGGFFGJMAKB;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal Action<AIKHOFOAIIL> IOLHOHABIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5520", Offset = "0xAA3B20", VA = "0x180AA5520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x91527D0", Offset = "0x9150DD0", VA = "0x1891527D0")]
	internal AIKHOFOAIIL(DIIFGFIFLLF HAKAPAEFLDN, string BFHDBHOMJKM, int MNHLJANEAIO, bool PEICFHMMHFP, string NAOLAABOPLP, bool NNGPCIADFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x91527B0", Offset = "0x9150DB0", VA = "0x1891527B0")]
	internal void HCGKDBHNBCK(JCMEEJMDEND.BECHCFKBNHA PJONICLDBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x9152080", Offset = "0x9150680", VA = "0x189152080")]
	private bool ABGEHDNLOGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x91525F0", Offset = "0x9150BF0", VA = "0x1891525F0")]
	public bool EBFIBEIOGOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x9152300", Offset = "0x9150900", VA = "0x189152300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class JCMEEJMDEND
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BECHCFKBNHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public bool BMLKMOAMCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public bool OBAJDMEPIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AECHOIMOGPC NONJMBOKCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public bool OGMKKMNGBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public KHCDKAIEPBB JJEMFALMEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public bool CMAAHOLEGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string CNHLACBGLPO;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9152B20", Offset = "0x9151120", VA = "0x189152B20")]
		public bool JIIMCFDENAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9152B00", Offset = "0x9151100", VA = "0x189152B00")]
		public bool FGJNPDHEFEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9152AE0", Offset = "0x91510E0", VA = "0x189152AE0")]
		public void CGPBHEIABEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class EOIADLBPNJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public uint NMILEMOAODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public long KCJLCGFEBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public long PIOCNHLFCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public long BDMENFNNBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public long NNGIPEPKHJP;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EOIADLBPNJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal enum CLBKLGMIPKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		Monoscopic,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		Stereoscopic_TopBottom,
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		Stereoscopic_LeftRight,
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		Stereoscopic_Custom,
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		Stereoscopic_RightLeft
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LLHGFBJBJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public string filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public bool keepBackup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public BECHCFKBNHA options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ManualResetEvent syncEvent;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LLHGFBJBJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9169A10", Offset = "0x9168010", VA = "0x189169A10")]
		internal void KHNGMBKIPFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly uint FFAOOKHILGA;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly uint AGBDENGHADC;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly uint JDJFNAPNBNJ;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly uint LPLLDCLPCDB;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly uint GJIONIFPMCJ;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly uint GIDMPHKMPEF;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly uint OFFJPEBBIMA;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly uint MLNCJFBEJPO;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly uint AOENOIFAKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly uint BMOAOCPFAOK;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly uint EGNHBOFLAAC;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly uint LHFIHCKKELI;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly uint BIIEIIMPMNM;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly uint NKCCBOPLOEG;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly uint LCMAKJMPGNM;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly uint ONPPFMCDLLK;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly uint DBINCOMELGO;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly uint LGHALAFGJOC;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly uint BNOIEMOHBMH;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly uint NEILAMBOMIN;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly uint MLIBDPFGCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private BinaryReader HKLBHPELMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Stream JEDPKAJNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private BECHCFKBNHA JEGDGGNBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool DGPGHBPJCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<EOIADLBPNJF> DCHIFMLIMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private List<EOIADLBPNJF> LLDKELJLHKO;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x9162760", Offset = "0x9160D60", VA = "0x189162760")]
	public static ManualResetEvent BBPHLMHKHOD(string FOJGLONLCLC, bool BMMFHKDDLMI, BECHCFKBNHA PLMLGIGGGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x9163040", Offset = "0x9161640", VA = "0x189163040")]
	public static bool CMBOKAEJNOJ(string FOJGLONLCLC, bool BMMFHKDDLMI, BECHCFKBNHA PLMLGIGGGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x9162D10", Offset = "0x9161310", VA = "0x189162D10")]
	public static bool CMBOKAEJNOJ(string KPFDMOOEJBL, string IABCLLGAPHG, BECHCFKBNHA PLMLGIGGGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x9167560", Offset = "0x9165B60", VA = "0x189167560")]
	public JCMEEJMDEND(BECHCFKBNHA PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x9163580", Offset = "0x9161B80", VA = "0x189163580")]
	public bool DFKNGAMPEEH(Stream JLNOHIHFAMH, Stream AINKLEFFOGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x91667B0", Offset = "0x9164DB0", VA = "0x1891667B0")]
	public void PADDBFOKNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x9163E80", Offset = "0x9162480", VA = "0x189163E80")]
	private static EOIADLBPNJF EBGECMIHKGC(uint NMILEMOAODL, List<EOIADLBPNJF> FNPJMPMDFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x9164200", Offset = "0x9162800", VA = "0x189164200")]
	private List<EOIADLBPNJF> ENNGHOBBPLI(EOIADLBPNJF MAPPMNHPFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x9164050", Offset = "0x9162650", VA = "0x189164050")]
	private List<EOIADLBPNJF> ENNGHOBBPLI(long IMIICFLIGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x9165640", Offset = "0x9163C40", VA = "0x189165640")]
	private EOIADLBPNJF IGLLIJMHGMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9165C60", Offset = "0x9164260", VA = "0x189165C60")]
	private bool LIPOPKJCJJI(EOIADLBPNJF KGGDFKHMCKC, uint NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x91659D0", Offset = "0x9163FD0", VA = "0x1891659D0")]
	private void ILMDAMGDALO(EOIADLBPNJF KGGDFKHMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x9162B30", Offset = "0x9161130", VA = "0x189162B30")]
	private void BOAHKFALHFL(EOIADLBPNJF KGGDFKHMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x91649E0", Offset = "0x9162FE0", VA = "0x1891649E0")]
	private void FKOKOLILKFL(EOIADLBPNJF KGGDFKHMCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x9165820", Offset = "0x9163E20", VA = "0x189165820")]
	private void IHDLCMLCECM(long OPMPDHABMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x91668A0", Offset = "0x9164EA0", VA = "0x1891668A0")]
	private void PMKNOKLCDDM(long OPMPDHABMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x91642D0", Offset = "0x91628D0", VA = "0x1891642D0")]
	private uint FADIDEMIGDO(EOIADLBPNJF MAPPMNHPFCB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x9163390", Offset = "0x9161990", VA = "0x189163390")]
	private bool DDKNIFBFBJP(EOIADLBPNJF FGJBHOAAJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x9162930", Offset = "0x9160F30", VA = "0x189162930")]
	private void BGFFJDICKHB(EOIADLBPNJF KGGDFKHMCKC, uint EDBPIEHMMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x9165DE0", Offset = "0x91643E0", VA = "0x189165DE0")]
	private void MEBICAMOICN(EOIADLBPNJF KGGDFKHMCKC, uint EDBPIEHMMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x9166410", Offset = "0x9164A10", VA = "0x189166410")]
	private void NHNFAOCFFDK(EOIADLBPNJF KGGDFKHMCKC, uint EDBPIEHMMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x91662C0", Offset = "0x91648C0", VA = "0x1891662C0")]
	private uint NFNOKCIICLK(EOIADLBPNJF KGGDFKHMCKC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x9164BE0", Offset = "0x91631E0", VA = "0x189164BE0")]
	private uint GPJJKLEJBML(EOIADLBPNJF KGGDFKHMCKC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x9165DC0", Offset = "0x91643C0", VA = "0x189165DC0")]
	private static CLBKLGMIPKG MDIJAMLBNPG(AECHOIMOGPC IBLGEJEKAPD)
	{
		return default(CLBKLGMIPKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x9164920", Offset = "0x9162F20", VA = "0x189164920")]
	private uint FDJHGFIFGLC(CLBKLGMIPKG NONJMBOKCGB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x9164A60", Offset = "0x9163060", VA = "0x189164A60")]
	private uint GIDGBMAHAMA(KHCDKAIEPBB BAKCACEJMAD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x9165F90", Offset = "0x9164590", VA = "0x189165F90")]
	private uint MJBDJKBBHOF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9165A40", Offset = "0x9164040", VA = "0x189165A40")]
	private uint KHFHHBNKEHM(string JJJOMMKIGOH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x91650F0", Offset = "0x91636F0", VA = "0x1891650F0")]
	private uint HMEKDCALHHF(KHCDKAIEPBB BAKCACEJMAD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x9162BA0", Offset = "0x91611A0", VA = "0x189162BA0")]
	private uint CCEGFMEBCNI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x9166630", Offset = "0x9164C30", VA = "0x189166630")]
	private uint OBMCKLHBHBC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x9166210", Offset = "0x9164810", VA = "0x189166210")]
	private void MJNJKHONIED(EOIADLBPNJF KGGDFKHMCKC, long MJAKOKLDPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x9166590", Offset = "0x9164B90", VA = "0x189166590")]
	private ushort NIGJAMPPIHE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x91626C0", Offset = "0x9160CC0", VA = "0x1891626C0")]
	private uint AAEDDNKOHPN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x9165930", Offset = "0x9163F30", VA = "0x189165930")]
	private ulong IJELMCADEDH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x91655A0", Offset = "0x9163BA0", VA = "0x1891655A0")]
	private void IEKDCPPMPGP(uint NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x9163DC0", Offset = "0x91623C0", VA = "0x189163DC0")]
	private void DIAHFJBJGDN(uint KOPHBHGIACG, bool PFAKAMFLJJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x91654F0", Offset = "0x9163AF0", VA = "0x1891654F0")]
	private void IBIIEPCPJKM(ulong KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x9163FC0", Offset = "0x91625C0", VA = "0x189163FC0")]
	private static uint EDJKFANCBIB(string NMILEMOAODL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum OCCCFCIMPAD
{
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum DCGKKEPDMEC
{
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	Unity,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Microphone,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Manual,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Wwise,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	UnityAudioMixer
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public enum AECHOIMOGPC
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum KHDFHKFOKAP
{
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Codec,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum KHCDKAIEPBB
{
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Equirectangular360,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Equirectangular180
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum FLJBPHCHANJ
{
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	FramesEncoded,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	SecondsEncoded,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	SecondsElapsed
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum MJNNONPHCFI
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Manual,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	OnStart
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum ONHGEDGBAKN
{
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	RealSeconds,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	GameSeconds,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public enum FMANPEBDBGO
{
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	PNG,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	JPEG,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	TIFF,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	HEIF
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum DIIFGFIFLLF
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	VideoFile,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	ImageSequence,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	NamedPipe
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum LBKILBJBEPF
{
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Portrait,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	PortraitUpsideDown,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	LandscapeLeft,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	LandscapeRight
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum CLFBNBLAJIO
{
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum NAGFGGPCDHG
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	Realtime,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Fixed,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	Nearest
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum OFKDPLFMHBD
{
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Rotate90,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Rotate180,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Rotate270
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JONCMAHIHFB
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static string[] OJABGGJOICM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static string[] PNMPECGOKJA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static string[] LMEIGKMCCCI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static string[] DBOCKIAGNGE;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x9168620", Offset = "0x9166C20", VA = "0x189168620")]
	public static string[] EHPHDDECJJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x9168DF0", Offset = "0x91673F0", VA = "0x189168DF0")]
	public static RenderTextureFormat NIONPIFAELA(bool IKHCNAECNHE, bool IDFFBDHIHAN, bool DGMHCMLCPLO)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x91683C0", Offset = "0x91669C0", VA = "0x1891683C0")]
	public static bool AMFHLBAJMPF(Camera KHOAKAJAFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x9168890", Offset = "0x9166E90", VA = "0x189168890")]
	public static Camera[] NEJJNKKMCPB(Camera KHOAKAJAFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x9169300", Offset = "0x9167900", VA = "0x189169300")]
	public static bool PNAAKMCHDGH(string JLAJDHBGALB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9168490", Offset = "0x9166A90", VA = "0x189168490")]
	public static bool BMKOAGJLPAD(string JLAJDHBGALB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x91686A0", Offset = "0x9166CA0", VA = "0x1891686A0")]
	public static bool FLKPBCCMBAP(string AMLPLFKHAGB, [Out] ulong GOBOBIFPKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x9168560", Offset = "0x9166B60", VA = "0x189168560")]
	public static string EAEHLBHCMLA(FMANPEBDBGO OFCLANOKPBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PLBBPKACHKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum DLJDJLOCLMH
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		PCM16 = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Float32 = 4
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static byte[] GFHGLLJACAL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private static byte[] IGEMIKDMIBG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private static byte[] BPCHNNADMJK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static byte[] OJNBCDOCEBP;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private static byte[] ODLNDOPBHGN;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private static byte[] LLNGDDNNMEL;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private static byte[] LBIGBBMKBGO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private const int MCMCAOBEBGP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FileStream CAIGOIDKLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private byte[] FFHAKEAGDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private int IALJOGNDFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private int CLNLICIGJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int JBEEGIADFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int PJLBAPMKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private DLJDJLOCLMH EHJHMKMGAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private int HLPFDAINJPD;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x916B820", Offset = "0x9169E20", VA = "0x18916B820")]
	public PLBBPKACHKG(string BFHDBHOMJKM, int MNLBIBCDEJH, int KBIICOGOBJL, DLJDJLOCLMH NIBIGELKBDF = DLJDJLOCLMH.Float32)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x916ABE0", Offset = "0x91691E0", VA = "0x18916ABE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x916B3D0", Offset = "0x91699D0", VA = "0x18916B3D0")]
	public void PFHMBILPOMF(float[] CDDIADBJAOB, int KIGAGEHDFOD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x916AD70", Offset = "0x9169370", VA = "0x18916AD70")]
	public void PFAFDABGMHC(int LFKDAOIDFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x916AC60", Offset = "0x9169260", VA = "0x18916AC60")]
	private static byte[] LAFFHGAFADK(int NGOJMGCIOHB, int NODGHDHCBPE = 2)
	{
		return null;
	}
}
namespace RenderHeads.Media.AVProMovieCapture.Editor
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class EditorCoroutine : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x916D780", Offset = "0x916BD80", VA = "0x18916D780")]
		public void RunCoroutine(IEnumerator AKCMCMAINJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public EditorCoroutine()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
