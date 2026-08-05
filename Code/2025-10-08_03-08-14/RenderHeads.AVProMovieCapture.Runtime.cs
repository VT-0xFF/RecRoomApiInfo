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
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AmbisonicWavWriter _sink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Tooltip("Listener is optional but allows positions to be calculated relative to a transform.  This is useful if the listener is not located at 0,0,0.")]
		[SerializeField]
		private Transform _listener;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Vector3 KEDWXZSAMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AmbisonicOrder CBZGXJJQBWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AmbisonicChannelOrder YLANHZHTCXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AmbisonicNormalisation USQOGYHQMYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr VFDGRXAWPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int RDSNXAHXEKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] GXHUZNUCQEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> VUYELJKERGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> UTBILOCJYJC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x914BB30", Offset = "0x914A930", VA = "0x18914BB30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x914B8D0", Offset = "0x914A6D0", VA = "0x18914B8D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x914AFC0", Offset = "0x9149DC0", VA = "0x18914AFC0")]
		internal void DCTLUGMAEQY(AmbisonicOrder a, AmbisonicChannelOrder b, AmbisonicNormalisation c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x914BA10", Offset = "0x914A810", VA = "0x18914BA10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x914B1B0", Offset = "0x9149FB0", VA = "0x18914B1B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x914BEF0", Offset = "0x914ACF0", VA = "0x18914BEF0")]
		private void UBLFFTLZFDE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x914BF10", Offset = "0x914AD10", VA = "0x18914BF10")]
		private void WPQBGWIITHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x914B310", Offset = "0x914A110", VA = "0x18914B310")]
		private void OnAudioFilterRead(float[] samples, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x914BCB0", Offset = "0x914AAB0", VA = "0x18914BCB0")]
		internal void RELEUBRVTXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x914C0C0", Offset = "0x914AEC0", VA = "0x18914C0C0")]
		internal int XOHQZVHOEYJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x914C100", Offset = "0x914AF00", VA = "0x18914C100")]
		internal void XPTSBPKNQUG(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x914C2D0", Offset = "0x914B0D0", VA = "0x18914C2D0")]
		public AmbisonicSource()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Ambisonic WAV Writer", 601)]
	public class AmbisonicWavWriter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private AmbisonicOrder _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private AmbisonicFormat _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Range(4f, 32f)]
		private int _bufferCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private float[] MZOWNSTSLWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EYMRQRSFHUE LSUQSTBAEMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> JISYWGTSISG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int CKWKEOYGOOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmbisonicOrder ZFMCEUROCTT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
			get
			{
				return default(AmbisonicOrder);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AmbisonicFormat NNOEGRAVIVW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC56CD0", Offset = "0xC55AD0", VA = "0x180C56CD0")]
			get
			{
				return default(AmbisonicFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x914C930", Offset = "0x914B730", VA = "0x18914C930")]
		internal void QPJCGTZBRLF(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x914C400", Offset = "0x914B200", VA = "0x18914C400")]
		internal void FWSKCWSCUPY(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x914C6E0", Offset = "0x914B4E0", VA = "0x18914C6E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x914CEA0", Offset = "0x914BCA0", VA = "0x18914CEA0")]
		private void TOISQTNCVWN(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x914C6B0", Offset = "0x914B4B0", VA = "0x18914C6B0")]
		private void OISSXZRFEMU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x914CA70", Offset = "0x914B870", VA = "0x18914CA70")]
		private void RLOBNCISAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x914CF50", Offset = "0x914BD50", VA = "0x18914CF50")]
		private void VCLHYUVGHCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x914D050", Offset = "0x914BE50", VA = "0x18914D050")]
		private bool XLDCTFVFQCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x914C5F0", Offset = "0x914B3F0", VA = "0x18914C5F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x914C6F0", Offset = "0x914B4F0", VA = "0x18914C6F0")]
		private void QMMYHUAKIFE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x914C4E0", Offset = "0x914B2E0", VA = "0x18914C4E0")]
		internal void IUEJGFRGIVQ(float[] a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x914C3C0", Offset = "0x914B1C0", VA = "0x18914C3C0")]
		private void ESCFKUCXDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x914D070", Offset = "0x914BE70", VA = "0x18914D070")]
		public AmbisonicWavWriter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AddComponentMenu("AVPro Movie Capture/Audio/AudioSource To WAV", 701)]
	public class AudioSourceToWav : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private string _filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private EYMRQRSFHUE LSUQSTBAEMR;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x914D1A0", Offset = "0x914BFA0", VA = "0x18914D1A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x914D160", Offset = "0x914BF60", VA = "0x18914D160")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x914D130", Offset = "0x914BF30", VA = "0x18914D130")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x914D300", Offset = "0x914C100", VA = "0x18914D300")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum SelectByMode
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
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Frame
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private SelectByMode _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool _scanHiddenCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string _tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Camera[] VGBLTBPRPZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int RGGLJMVVXFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int AVJMCYKJFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool MNHLDGMNGSS;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera ZRYGNZIGVQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x914DC20", Offset = "0x914CA20", VA = "0x18914DC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SelectByMode MPGXUTCBJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(SelectByMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x914DC70", Offset = "0x914CA70", VA = "0x18914DC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScanFrequencyMode JWSSNHUEFBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x914DC50", Offset = "0x914CA50", VA = "0x18914DC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AULWYFLAMOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD79680", Offset = "0xD78480", VA = "0x180D79680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x914DC60", Offset = "0x914CA60", VA = "0x18914DC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string IZDFCAQIVNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x914DCA0", Offset = "0x914CAA0", VA = "0x18914DCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FXOZVKXGAQU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x914DC80", Offset = "0x914CA80", VA = "0x18914DC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x914D350", Offset = "0x914C150", VA = "0x18914D350")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x914D8C0", Offset = "0x914C6C0", VA = "0x18914D8C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x914D350", Offset = "0x914C150", VA = "0x18914D350")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x914DB50", Offset = "0x914C950", VA = "0x18914DB50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x914D690", Offset = "0x914C490", VA = "0x18914D690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x914D720", Offset = "0x914C520", VA = "0x18914D720")]
		private void SSSPHFDCFTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x914D680", Offset = "0x914C480", VA = "0x18914D680")]
		private void MLTXSHTOGZJ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x914D800", Offset = "0x914C600", VA = "0x18914D800")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x914D3F0", Offset = "0x914C1F0", VA = "0x18914D3F0")]
		private Camera GNPHYXJOMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x914DA70", Offset = "0x914C870", VA = "0x18914DA70")]
		public void UpdateCameraCache(bool forceScanHiddenCameras = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x914D8D0", Offset = "0x914C6D0", VA = "0x18914D8D0")]
		private static Camera UGDTCCLRXHN(int a, Camera[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x914D360", Offset = "0x914C160", VA = "0x18914D360")]
		private static Camera CCBNXHZNMMG(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x914D9D0", Offset = "0x914C7D0", VA = "0x18914D9D0")]
		private static Camera UOAKETOVWQV(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x914DB70", Offset = "0x914C970", VA = "0x18914DB70")]
		public CameraSelector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioClip)", 500)]
	public class CaptureAudioFromAudioClip : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private AudioClip _audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool _restartAudioClipOnCaptureStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int HMCGCTIJRSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int VUVZSZQMNKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int SGTJQPKOATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int WTQEFACEIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] WHHBPJAVDDZ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x914DF90", Offset = "0x914CD90", VA = "0x18914DF90")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x914E1D0", Offset = "0x914CFD0", VA = "0x18914E1D0")]
		private void TKXMBQPPGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x914DCC0", Offset = "0x914CAC0", VA = "0x18914DCC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x914E1F0", Offset = "0x914CFF0", VA = "0x18914E1F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x914DFB0", Offset = "0x914CDB0", VA = "0x18914DFB0")]
		private float[] SFDQXVJLOAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x914E290", Offset = "0x914D090", VA = "0x18914E290")]
		public CaptureAudioFromAudioClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioListener)", 500)]
	[RequireComponent(typeof(AudioListener))]
	public class CaptureAudioFromAudioListener : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int BTKGMCGTEBC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] WMTPFWGRVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] RXAMESSUJJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int BMCWBQIKCQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle KMFWMPBQMRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int JURSPGYUBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int AGGOJLWNEKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object ZFBNAWYKIEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool NONSHWRRUBY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] FCRDNWDTDUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int OFWMBHNHZWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr CPWTJKBQYWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x914ED10", Offset = "0x914DB10", VA = "0x18914ED10")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int UKASYVZFPVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x15040E0", Offset = "0x1502EE0", VA = "0x1815040E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ZAPIEVSDPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x914ED20", Offset = "0x914DB20", VA = "0x18914ED20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int BLZTSJKNLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44DA0", VA = "0x180B45FA0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x914E600", Offset = "0x914D400", VA = "0x18914E600", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xFFA590", Offset = "0xFF9390", VA = "0x180FFA590", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x914EB90", Offset = "0x914D990", VA = "0x18914EB90", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x914E5F0", Offset = "0x914D3F0", VA = "0x18914E5F0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x914EAE0", Offset = "0x914D8E0", VA = "0x18914EAE0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x914E9F0", Offset = "0x914D7F0", VA = "0x18914E9F0", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x914E2A0", Offset = "0x914D0A0", VA = "0x18914E2A0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x914E340", Offset = "0x914D140", VA = "0x18914E340")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x914EC60", Offset = "0x914DA60", VA = "0x18914EC60")]
		public CaptureAudioFromAudioListener()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From AudioRenderer)", 500)]
	public class CaptureAudioFromAudioRenderer : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int YSKNGLJXHFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool WOIOUHYZQZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> GQKLDGPHPSU;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase NPFGNQYRQPR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int ZAPIEVSDPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x914ED20", Offset = "0x914DB20", VA = "0x18914ED20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int BLZTSJKNLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x914EED0", Offset = "0x914DCD0", VA = "0x18914EED0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x914ED80", Offset = "0x914DB80", VA = "0x18914ED80")]
		private NativeArray<float> JRNPAGHERXA(int a)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void DLABHSBXNAA(NativeArray<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x914EEF0", Offset = "0x914DCF0", VA = "0x18914EEF0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x914F000", Offset = "0x914DE00", VA = "0x18914F000", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x914ED30", Offset = "0x914DB30", VA = "0x18914ED30", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x914F060", Offset = "0x914DE60", VA = "0x18914F060")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xADA950", Offset = "0xAD9750", VA = "0x180ADA950")]
		public CaptureAudioFromAudioRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CaptureAudioFromMultipleSources : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private bool _debugLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private bool _muteAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private List<OnAudioFilterReadForwarder> _onAudioFilterReadForwarders;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const int BTKGMCGTEBC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] WMTPFWGRVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] RXAMESSUJJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int WUQKEEITTGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int RIBVXFQXSDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle KMFWMPBQMRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int JURSPGYUBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool TQGLTOXMKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int DRSVXMCSUAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int AGGOJLWNEKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object ZFBNAWYKIEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool NMMMZVEGNFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool NONSHWRRUBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int AOKZQVXQAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int WVTVIYCJPHK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> OOYQZJGPOUU
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ONRYHCOPRRI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xACF6D0", Offset = "0xACE4D0", VA = "0x180ACF6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] FCRDNWDTDUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int OFWMBHNHZWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr CPWTJKBQYWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9150450", Offset = "0x914F250", VA = "0x189150450")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int UKASYVZFPVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1E817E0", Offset = "0x1E805E0", VA = "0x181E817E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int ZAPIEVSDPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x914ED20", Offset = "0x914DB20", VA = "0x18914ED20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int BLZTSJKNLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xECA790", Offset = "0xEC9590", VA = "0x180ECA790", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x914FF30", Offset = "0x914ED30", VA = "0x18914FF30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x914F750", Offset = "0x914E550", VA = "0x18914F750", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x914FD50", Offset = "0x914EB50", VA = "0x18914FD50", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9150100", Offset = "0x914EF00", VA = "0x189150100", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x914F740", Offset = "0x914E540", VA = "0x18914F740", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x914FC90", Offset = "0x914EA90", VA = "0x18914FC90", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x914FB40", Offset = "0x914E940", VA = "0x18914FB40", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x914F150", Offset = "0x914DF50", VA = "0x18914F150", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x914F2D0", Offset = "0x914E0D0", VA = "0x18914F2D0")]
		public void OnAudioFilterReadCombiner(float[] data, int channels, bool isMicrophone, int sampleRate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x914F1F0", Offset = "0x914DFF0", VA = "0x18914F1F0")]
		private float[] OQHEWSFJQVC(float[] a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x91503A0", Offset = "0x914F1A0", VA = "0x1891503A0")]
		public CaptureAudioFromMultipleSources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("AVPro Movie Capture/Audio/Capture Audio (From Wwise)", 500)]
	public class CaptureAudioFromWwise : UnityAudioCapture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private CaptureBase _capture;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CaptureBase NPFGNQYRQPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int ZAPIEVSDPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int BLZTSJKNLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9150460", Offset = "0x914F260", VA = "0x189150460")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xADA950", Offset = "0xAD9750", VA = "0x180ADA950")]
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
		private sealed class JCOUQIPADFH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CaptureFromCamera WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public JCOUQIPADFH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x915F470", Offset = "0x915E270", VA = "0x18915F470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x915F430", Offset = "0x915E230", VA = "0x18915F430", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ITIRJHQIHUS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CaptureFromCamera WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public ITIRJHQIHUS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x915F2E0", Offset = "0x915E0E0", VA = "0x18915F2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x915F2A0", Offset = "0x915E0A0", VA = "0x18915F2A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Camera _lastCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Camera[] _contribCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private bool _useContributingCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private RenderTexture NGRXBMCECER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture DBXIPXOEDQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr QBVWFNLGXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture LHXWVCUQTZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture HGEFSLGMFAD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector EXATLXTMPTT
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBD01E0", Offset = "0xBCEFE0", VA = "0x180BD01E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC41B60", Offset = "0xC40960", VA = "0x180C41B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool CBRZMKQWMWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xF763E0", Offset = "0xF751E0", VA = "0x180F763E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xF76450", Offset = "0xF75250", VA = "0x180F76450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9158380", Offset = "0x9157180", VA = "0x189158380")]
		public void SetCamera(Camera topCamera, bool useContributingCameras = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9158330", Offset = "0x9157130", VA = "0x189158330")]
		public void SetCamera(Camera topCamera, Camera[] contributingCameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9157580", Offset = "0x9156380", VA = "0x189157580")]
		private bool NGEUDDEGYXH(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x91570E0", Offset = "0x9155EE0", VA = "0x1891570E0")]
		private bool AFMBOGYAQDQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x91588B0", Offset = "0x91576B0", VA = "0x1891588B0")]
		private bool XDMXIZUBZJZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x91585A0", Offset = "0x91573A0", VA = "0x1891585A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x91588E0", Offset = "0x91576E0", VA = "0x1891588E0")]
		[IteratorStateMachine(typeof(ITIRJHQIHUS))]
		private IEnumerator XZQIUSKANYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9157510", Offset = "0x9156310", VA = "0x189157510")]
		[IteratorStateMachine(typeof(JCOUQIPADFH))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9158770", Offset = "0x9157570", VA = "0x189158770")]
		private bool VDOKEUDFALR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9157140", Offset = "0x9155F40", VA = "0x189157140")]
		private void BMVONOVTEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x91584B0", Offset = "0x91572B0", VA = "0x1891584B0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9157660", Offset = "0x9156460", VA = "0x189157660")]
		private void NVPPYTNLDUM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC3D490", Offset = "0xC3C290", VA = "0x180C3D490", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9157920", Offset = "0x9156720", VA = "0x189157920", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9157830", Offset = "0x9156630", VA = "0x189157830", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9158950", Offset = "0x9157750", VA = "0x189158950")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x91584A0", Offset = "0x91572A0", VA = "0x1891584A0")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void UJCCGQOSJGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum CubemapRenderMethod
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
		private sealed class QQQSTSGVZJT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CaptureFromCamera360 WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public QQQSTSGVZJT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x915FAE0", Offset = "0x915E8E0", VA = "0x18915FAE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x915FAA0", Offset = "0x915E8A0", VA = "0x18915FAA0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private CameraSelector _cameraSelector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private CubemapResolution _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private CubemapDepth _cubemapDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private bool _supportGUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private bool _supportCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private bool _onlyLeftRightRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x273")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Render 180 degree equirectangular instead of 360 degrees")]
		[SerializeField]
		private bool _render180Degrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private StereoPacking _stereoRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Makes assumption that 1 Unity unit is 1m")]
		[SerializeField]
		private float _ipd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Percentage cube faces are overdrawn each edge then blended to alleviate screen space FX seams")]
		[SerializeField]
		private float _blendOverlapPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private RenderTexture PAHPCLHXKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] LXLPUYILXDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material OSPTTXFGRZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material ZLGJLEYBRSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture FQLQGEZIXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture RELHMZICIKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr QBVWFNLGXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int OBPIUJNMNRY;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector EXATLXTMPTT
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBD01E0", Offset = "0xBCEFE0", VA = "0x180BD01E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC41B60", Offset = "0xC40960", VA = "0x180C41B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CubemapResolution PMJSHNTQCFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xBD0560", Offset = "0xBCF360", VA = "0x180BD0560")]
			get
			{
				return default(CubemapResolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9157090", Offset = "0x9155E90", VA = "0x189157090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CubemapDepth PXHNZGGFAOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9157040", Offset = "0x9155E40", VA = "0x189157040")]
			get
			{
				return default(CubemapDepth);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9157080", Offset = "0x9155E80", VA = "0x189157080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool TJESSAEUDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xF763E0", Offset = "0xF751E0", VA = "0x180F763E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xF76450", Offset = "0xF75250", VA = "0x180F76450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool AZNINPWYILV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xF763D0", Offset = "0xF751D0", VA = "0x180F763D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xF76440", Offset = "0xF75240", VA = "0x180F76440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ABGVCKWQOKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9157060", Offset = "0x9155E60", VA = "0x189157060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x91570B0", Offset = "0x9155EB0", VA = "0x1891570B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool EHZBXVGTRID
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9157070", Offset = "0x9155E70", VA = "0x189157070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x91570C0", Offset = "0x9155EC0", VA = "0x1891570C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public StereoPacking MOXGMYMCPFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2902BA0", Offset = "0x29019A0", VA = "0x182902BA0")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x91570D0", Offset = "0x9155ED0", VA = "0x1891570D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EVMPNOZHQXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9157050", Offset = "0x9155E50", VA = "0x189157050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x91570A0", Offset = "0x9155EA0", VA = "0x1891570A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9156F90", Offset = "0x9155D90", VA = "0x189156F90")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9153380", Offset = "0x9152180", VA = "0x189153380")]
		private CubemapRenderMethod JKNMKMUWCPZ()
		{
			return default(CubemapRenderMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC40120", Offset = "0xC3EF20", VA = "0x180C40120")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9156DB0", Offset = "0x9155BB0", VA = "0x189156DB0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9156F20", Offset = "0x9155D20", VA = "0x189156F20")]
		[IteratorStateMachine(typeof(QQQSTSGVZJT))]
		private IEnumerator XZQIUSKANYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9153490", Offset = "0x9152290", VA = "0x189153490")]
		private void NPFGNQYRQPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x91531B0", Offset = "0x9151FB0", VA = "0x1891531B0")]
		private static void CFYSDAUCAVX(RenderTexture a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9154E00", Offset = "0x9153C00", VA = "0x189154E00")]
		private void QPGHFJRPFTF(RenderTexture a, RenderTexture b, bool c, Quaternion d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9152C50", Offset = "0x9151A50", VA = "0x189152C50")]
		private void BMVONOVTEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9155210", Offset = "0x9154010", VA = "0x189155210")]
		private void QTEHJKZHFJQ(Camera a, RenderTexture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x91533B0", Offset = "0x91521B0", VA = "0x1891533B0")]
		private void NJQZDKLOCLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9153A70", Offset = "0x9152870", VA = "0x189153A70", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9153340", Offset = "0x9152140", VA = "0x189153340", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9156BD0", Offset = "0x91559D0", VA = "0x189156BD0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x91537C0", Offset = "0x91525C0", VA = "0x1891537C0", Slot = "6")]
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
			[SerializeField]
			[Tooltip("Render 180 degree equirectangular instead of 360 degrees.  Also faster rendering")]
			public bool render180Degrees;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			[SerializeField]
			[Tooltip("Makes assumption that 1 Unity unit is 1m")]
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
			[Cpp2IlInjected.Address(RVA = "0x915FB50", Offset = "0x915E950", VA = "0x18915FB50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ITNYGOKFRGB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CaptureFromCamera360ODS WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public ITNYGOKFRGB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x915F3C0", Offset = "0x915E1C0", VA = "0x18915F3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x915F380", Offset = "0x915E180", VA = "0x18915F380", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Settings _settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int DRGYFEEPHWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int ZGLLWJFBPDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform ZYADOOHSSXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera JTGFLZERIKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera CTIUPHWMDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera UVWQYKDINHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera SEBHEUQYGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture OHINMDTQYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr QBVWFNLGXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material AZXWWJERLXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int XKQITULMIOA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings DCTLUGMAEQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBD01E0", Offset = "0xBCEFE0", VA = "0x180BD01E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9152B60", Offset = "0x9151960", VA = "0x189152B60")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9152800", Offset = "0x9151600", VA = "0x189152800")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9152830", Offset = "0x9151630", VA = "0x189152830", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x91504C0", Offset = "0x914F2C0", VA = "0x1891504C0")]
		private Camera DDTNDVCZUJO(Camera a, string b, float c, float d, int e, int f, float g, float h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9152960", Offset = "0x9151760", VA = "0x189152960", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9152AF0", Offset = "0x91518F0", VA = "0x189152AF0")]
		[IteratorStateMachine(typeof(ITNYGOKFRGB))]
		private IEnumerator XZQIUSKANYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9150C30", Offset = "0x914FA30", VA = "0x189150C30")]
		private void NPFGNQYRQPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9150B50", Offset = "0x914F950", VA = "0x189150B50")]
		private void NJQZDKLOCLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9150F00", Offset = "0x914FD00", VA = "0x189150F00")]
		private void NPVHLEEXMXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9150B10", Offset = "0x914F910", VA = "0x189150B10", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x91518B0", Offset = "0x91506B0", VA = "0x1891518B0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x91517E0", Offset = "0x91505E0", VA = "0x1891517E0")]
		private static void PWXXDHNAQCE(Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x91515A0", Offset = "0x91503A0", VA = "0x1891515A0", Slot = "6")]
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
		private sealed class OTGWFQXUZXJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CaptureFromScreen WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public OTGWFQXUZXJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x915F8C0", Offset = "0x915E6C0", VA = "0x18915F8C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x915F880", Offset = "0x915E680", VA = "0x18915F880", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private bool _captureMouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private MouseCursor _mouseCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IntPtr QBVWFNLGXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture DBXIPXOEDQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer GEPVQRXGYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator AJRPWPNIFWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool UQGFJAMWIAP;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JJLWSCAMXHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBDDFF0", Offset = "0xBDCDF0", VA = "0x180BDDFF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBE3A40", Offset = "0xBE2840", VA = "0x180BE3A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor FRFSKWZEDVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBD01D0", Offset = "0xBCEFD0", VA = "0x180BD01D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC40120", Offset = "0xC3EF20", VA = "0x180C40120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9158EA0", Offset = "0x9157CA0", VA = "0x189158EA0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x91589B0", Offset = "0x91577B0", VA = "0x1891589B0")]
		private void EMATABKGPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9158DD0", Offset = "0x9157BD0", VA = "0x189158DD0")]
		private void PRUSTZSAWYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x91592A0", Offset = "0x91580A0", VA = "0x1891592A0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x91593E0", Offset = "0x91581E0", VA = "0x1891593E0")]
		[IteratorStateMachine(typeof(OTGWFQXUZXJ))]
		private IEnumerator XZQIUSKANYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x91593B0", Offset = "0x91581B0", VA = "0x1891593B0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9159450", Offset = "0x9158250", VA = "0x189159450")]
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
		private sealed class OTMDCXRSJIS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public CaptureFromTexture WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public OTMDCXRSJIS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x915FA30", Offset = "0x915E830", VA = "0x18915FA30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x915F9F0", Offset = "0x915E7F0", VA = "0x18915F9F0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("If enabled the method the encoder will only process frames each time UpdateSourceTexture() is called. This is useful if the texture is updating at a different rate compared to Unity, eg for webcam capture.")]
		[SerializeField]
		private bool _manualUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Texture PDITCOZSIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture DBXIPXOEDQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr QBVWFNLGXTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool AZSEPDRYGLK;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool CWCLJDODAUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBDDFF0", Offset = "0xBDCDF0", VA = "0x180BDDFF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBE3A40", Offset = "0xBE2840", VA = "0x180BE3A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xC40120", Offset = "0xC3EF20", VA = "0x180C40120")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x91595C0", Offset = "0x91583C0", VA = "0x1891595C0")]
		private bool NGEUDDEGYXH(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x915A440", Offset = "0x9159240", VA = "0x18915A440")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9159750", Offset = "0x9158550", VA = "0x189159750")]
		private bool NLWPXTKDHAT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x91594B0", Offset = "0x91582B0", VA = "0x1891594B0")]
		private bool FYQVOENRAHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x915A3A0", Offset = "0x91591A0", VA = "0x18915A3A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x915A450", Offset = "0x9159250", VA = "0x18915A450")]
		[IteratorStateMachine(typeof(OTMDCXRSJIS))]
		private IEnumerator XZQIUSKANYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x91597C0", Offset = "0x91585C0", VA = "0x1891597C0")]
		private void NPFGNQYRQPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9159CF0", Offset = "0x9158AF0", VA = "0x189159CF0")]
		private void NVPPYTNLDUM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x91596A0", Offset = "0x91584A0", VA = "0x1891596A0")]
		private void NJQZDKLOCLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x91594D0", Offset = "0x91582D0", VA = "0x1891594D0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9159E80", Offset = "0x9158C80", VA = "0x189159E80", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x915A2C0", Offset = "0x91590C0", VA = "0x18915A2C0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x915A4C0", Offset = "0x91592C0", VA = "0x18915A4C0")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x915A520", Offset = "0x9159320", VA = "0x18915A520", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x915A4C0", Offset = "0x91592C0", VA = "0x18915A4C0")]
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
		private enum Section
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private AudioListener ZVVWWQBLBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private CaptureBase _movieCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private bool _showUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private bool _whenRecordingAutoHideUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GUISkin _guiSkin;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly string[] QIOOFBRDQQH;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] MOLWZMPJNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Section IYQSIUGGSSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] ERDJZKHUIBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] WILVPTEWOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] CSFVKNURNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] KRDQJQYCTQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] VWFRQHXTYZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] DZPUQOOAEIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] RORMHCGHHIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int ZJFPLMZENNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle RLHHMEBUCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int EPIPQHGBVJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 CSZNUTVDVBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 DXYMSAYTTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 IXKEWUNFNSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 GAXRBTYWNWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long JWARHHBVWWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float WRVXSEHYDIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float MCLSTTHYYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint DNXLTULMPLJ;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase XLKHVYBIYEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool OYLIRWGHITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF6D050", Offset = "0xF6BE50", VA = "0x180F6D050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xFB6170", Offset = "0xFB4F70", VA = "0x180FB6170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool CZRKVFDCMSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC12EC0", Offset = "0xC11CC0", VA = "0x180C12EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC56AC0", Offset = "0xC558C0", VA = "0x180C56AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x915B060", Offset = "0x9159E60", VA = "0x18915B060")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x915B350", Offset = "0x915A150", VA = "0x18915B350")]
		private void WAVKCIWNRBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x915AAC0", Offset = "0x91598C0", VA = "0x18915AAC0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x915CD80", Offset = "0x915BB80", VA = "0x18915CD80")]
		private void YDVADSGVMAV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x915BC20", Offset = "0x915AA20", VA = "0x18915BC20")]
		private void XASRSDSHKRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x915A590", Offset = "0x9159390", VA = "0x18915A590")]
		private void EYKRHDSXJRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x915BB90", Offset = "0x915A990", VA = "0x18915BB90")]
		private void WJUZEKJVHBO(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x915AF90", Offset = "0x9159D90", VA = "0x18915AF90")]
		private void RLOBNCISAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x915B2C0", Offset = "0x915A0C0", VA = "0x18915B2C0")]
		private void VCLHYUVGHCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x915AA40", Offset = "0x9159840", VA = "0x18915AA40")]
		private void ORDIPSHHWGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x915A9C0", Offset = "0x91597C0", VA = "0x18915A9C0")]
		private void KFASWKJTQPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x915A940", Offset = "0x9159740", VA = "0x18915A940")]
		private void JJEHFCTKKQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x915B0D0", Offset = "0x9159ED0", VA = "0x18915B0D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x915EED0", Offset = "0x915DCD0", VA = "0x18915EED0")]
		public CaptureGUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Motion Blur", 301)]
	public class MotionBlur : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private RenderTextureFormat _format;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private int _numSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private RenderTexture RYMLCPUCYBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture LEHUVHSYLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material FPKHWHTRWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material JAYYRFUQOZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int TROQFLIGCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int IDLQBQHHAYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int EEFUQHBJSKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool ULWPMZKIAZG;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int YDYVTLLNPEW;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int ESNGKGFAZSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float BFVZVFFRYVI;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool ELMUABWPJJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2235810", Offset = "0x2234610", VA = "0x182235810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x22358C0", Offset = "0x22346C0", VA = "0x1822358C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int BFATGPZEVOM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x916CBC0", Offset = "0x916B9C0", VA = "0x18916CBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SAMQVFXOBXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44DA0", VA = "0x180B45FA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture YAXJOPBWFTK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x916C1F0", Offset = "0x916AFF0", VA = "0x18916C1F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x916CB70", Offset = "0x916B970", VA = "0x18916CB70")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x916CB90", Offset = "0x916B990", VA = "0x18916CB90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x916C8E0", Offset = "0x916B6E0", VA = "0x18916C8E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x916C360", Offset = "0x916B160", VA = "0x18916C360")]
		private void DCTLUGMAEQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x916C6A0", Offset = "0x916B4A0", VA = "0x18916C6A0")]
		private void JTPOMIAQPUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x916C700", Offset = "0x916B500", VA = "0x18916C700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x916C940", Offset = "0x916B740", VA = "0x18916C940")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86DEB40", Offset = "0x86DD940", VA = "0x1886DEB40")]
		private static float CMGDSSDNEHH(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x916C280", Offset = "0x916B080", VA = "0x18916C280")]
		private void CODGRCEVWVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x916C0D0", Offset = "0x916AED0", VA = "0x18916C0D0")]
		public void Accumulate(Texture src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x916CA00", Offset = "0x916B800", VA = "0x18916CA00")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x916CBA0", Offset = "0x916B9A0", VA = "0x18916CBA0")]
		public MotionBlur()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Render Mouse Cursor", 302)]
	public class MouseCursor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[Range(1f, 16f)]
		private int _sizeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private int _depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GUIContent VEWMSHKYHRH;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x916CDD0", Offset = "0x916BBD0", VA = "0x18916CDD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x916CD20", Offset = "0x916BB20", VA = "0x18916CD20")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x916CBD0", Offset = "0x916B9D0", VA = "0x18916CBD0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x916CE90", Offset = "0x916BC90", VA = "0x18916CE90")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> XXPZJSKNYHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x916CEF0", Offset = "0x916BCF0", VA = "0x18916CEF0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class QACUHEDJKEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector XNRTEKXLFXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode REVPEAIZBHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool DRNUEUWMTZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool GXVIWLEKDVX;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
			internal QACUHEDJKEP(PlayableDirector a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x916D070", Offset = "0x916BE70", VA = "0x18916D070")]
			internal bool QTPBYHKSCWX(PlayableDirector a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x916D0D0", Offset = "0x916BED0", VA = "0x18916D0D0")]
			internal void RLOBNCISAJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x916D1D0", Offset = "0x916BFD0", VA = "0x18916D1D0")]
			internal void VCLHYUVGHCX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<QACUHEDJKEP> DBRBCHLLVXW;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ScanFrequencyMode JWSSNHUEFBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9173D20", Offset = "0x9172B20", VA = "0x189173D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x91733C0", Offset = "0x91721C0", VA = "0x1891733C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x91733C0", Offset = "0x91721C0", VA = "0x1891733C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9173C90", Offset = "0x9172A90", VA = "0x189173C90")]
		internal void WODUZODMFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9173480", Offset = "0x9172280", VA = "0x189173480")]
		internal void RLOBNCISAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9173AB0", Offset = "0x91728B0", VA = "0x189173AB0")]
		internal void VCLHYUVGHCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9173780", Offset = "0x9172580", VA = "0x189173780")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x91733E0", Offset = "0x91721E0", VA = "0x1891733E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x91736A0", Offset = "0x91724A0", VA = "0x1891736A0")]
		private void SSSPHFDCFTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x91733D0", Offset = "0x91721D0", VA = "0x1891733D0")]
		private void MLTXSHTOGZJ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9173CA0", Offset = "0x9172AA0", VA = "0x189173CA0")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int UKASYVZFPVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int ZAPIEVSDPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int BLZTSJKNLMJ
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
		[Cpp2IlInjected.Address(RVA = "0x9174C30", Offset = "0x9173A30", VA = "0x189174C30", Slot = "13")]
		public virtual IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9174AA0", Offset = "0x91738A0", VA = "0x189174AA0")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9174BC0", Offset = "0x91739C0", VA = "0x189174BC0")]
		private static int ODCSPRBGEKT(AudioSpeakerMode a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum ScanFrequencyMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class UYQNTGTTRUM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer CQQTNQVLWJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool GXVIWLEKDVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool DRNUEUWMTZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool LVSJSPXQJOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double KQSAZKETSDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float GGFWZRVXVWD;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
			internal UYQNTGTTRUM(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9174490", Offset = "0x9173290", VA = "0x189174490")]
			internal bool QTPBYHKSCWX(VideoPlayer a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x91744F0", Offset = "0x91732F0", VA = "0x1891744F0")]
			internal void RLOBNCISAJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9174010", Offset = "0x9172E10", VA = "0x189174010")]
			internal bool AIRIJBIRGCS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9174050", Offset = "0x9172E50", VA = "0x189174050")]
			internal void HNEFORTVSJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9174570", Offset = "0x9173370", VA = "0x189174570")]
			private void ULSQUUULOZI(VideoPlayer a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9174390", Offset = "0x9173190", VA = "0x189174390")]
			private void PQMUQEOEZTV(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9174A10", Offset = "0x9173810", VA = "0x189174A10")]
			internal void ZGDJSEWRLYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9174610", Offset = "0x9173410", VA = "0x189174610")]
			internal bool Update(float deltaTime)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9174980", Offset = "0x9173780", VA = "0x189174980")]
			internal void VCLHYUVGHCX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class EHYOABLJFLT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private object QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public VideoPlayerController WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			private object ETUWFOJXVII
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public EHYOABLJFLT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x9169420", Offset = "0x9168220", VA = "0x189169420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x91693E0", Offset = "0x91681E0", VA = "0x1891693E0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<UYQNTGTTRUM> MHNPXHMEIVO;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ScanFrequencyMode JWSSNHUEFBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9179B30", Offset = "0x9178930", VA = "0x189179B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9178DA0", Offset = "0x9177BA0", VA = "0x189178DA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9178DA0", Offset = "0x9177BA0", VA = "0x189178DA0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9179970", Offset = "0x9178770", VA = "0x189179970")]
		internal void WODUZODMFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9178DB0", Offset = "0x9177BB0", VA = "0x189178DB0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9178F20", Offset = "0x9177D20", VA = "0x189178F20")]
		[IteratorStateMachine(typeof(EHYOABLJFLT))]
		internal IEnumerator IAMZIPNEBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x91791B0", Offset = "0x9177FB0", VA = "0x1891791B0")]
		internal void RLOBNCISAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x91797E0", Offset = "0x91785E0", VA = "0x1891797E0")]
		internal void VCLHYUVGHCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9179440", Offset = "0x9178240", VA = "0x189179440")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9179110", Offset = "0x9177F10", VA = "0x189179110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9179360", Offset = "0x9178160", VA = "0x189179360")]
		private void SSSPHFDCFTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9179100", Offset = "0x9177F00", VA = "0x189179100")]
		private void MLTXSHTOGZJ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9179AB0", Offset = "0x91788B0", VA = "0x189179AB0")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9178F90", Offset = "0x9177D90", VA = "0x189178F90")]
		[CompilerGenerated]
		private bool IHDFGVVVXOE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum AmbisonicOrder
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		First = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Second,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Third
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum AmbisonicFormat
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		ACN_SN3D
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum AmbisonicChannelOrder
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		ACN
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum AmbisonicNormalisation
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FuMa,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		SN3D
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class VKMVIOMHNFZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum Platform
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
		public enum PixelFormat
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
		public enum PluginEvent
		{
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			CaptureFrameBuffer,
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			FreeResources,
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			Setup
		}

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static string[] APMQSNRQJVS;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly string[] MYTVDRRAYPD;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly string[] MTHESWYGZHE;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly string[] JMASVXMIAMR;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly string[] IDLSRCVXKHE;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly string[] JWIJITEIJCT;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly string[] VWVFMUQNVOA;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static IntPtr MEINSVQZLYE;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static IntPtr DYWJYKLGGDA;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private static IntPtr QZUPNIVPTAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9177D70", Offset = "0x9176B70", VA = "0x189177D70")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private static IntPtr ASKHRHPPDYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x91767B0", Offset = "0x91755B0", VA = "0x1891767B0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9175DF0", Offset = "0x9174BF0", VA = "0x189175DF0")]
		public static extern IntPtr AddAmbisonicSourceInstance(int maxCoefficients);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9177E70", Offset = "0x9176C70", VA = "0x189177E70")]
		public static extern void RemoveAmbisonicSourceInstance(IntPtr instance);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x91782A0", Offset = "0x91770A0", VA = "0x1891782A0")]
		public static extern void UpdateAmbisonicWeights(IntPtr instance, float azimuth, float elevation, AmbisonicOrder order, AmbisonicChannelOrder channelOrder, float[] normalisationWeights);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x91766B0", Offset = "0x91754B0", VA = "0x1891766B0")]
		public static extern void EncodeMonoToAmbisonic(IntPtr instance, float[] inSamples, int inSamplesOffset, int inFrameCount, int inChannelCount, float[] outSamples, int outSamplesOffset, int outSamplesLength, AmbisonicOrder order);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x91779B0", Offset = "0x91767B0", VA = "0x1891779B0")]
		public static string MYKKYBRBSBF(PixelFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9177A80", Offset = "0x9176880", VA = "0x189177A80")]
		public static void PPVYLJRKSYJ(PluginEvent a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9177390", Offset = "0x9176190", VA = "0x189177390")]
		private static extern IntPtr GetRenderEventFunc();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9177130", Offset = "0x9175F30", VA = "0x189177130")]
		private static extern IntPtr GetFreeResourcesEventFunc();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x91775C0", Offset = "0x91763C0", VA = "0x1891775C0")]
		public static extern bool Init();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9176470", Offset = "0x9175270", VA = "0x189176470")]
		public static extern void Deinit();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9178400", Offset = "0x9177200", VA = "0x189178400")]
		public static string ZIJLAJCJYDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9178380", Offset = "0x9177180", VA = "0x189178380")]
		public static bool VSUHTTEBATN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9177400", Offset = "0x9176200", VA = "0x189177400")]
		public static extern int GetVideoCodecCount();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x91776B0", Offset = "0x91764B0", VA = "0x1891776B0")]
		public static extern bool IsConfigureVideoCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9177470", Offset = "0x9176270", VA = "0x189177470")]
		public static extern MediaApi GetVideoCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9176070", Offset = "0x9174E70", VA = "0x189176070")]
		public static extern void ConfigureVideoCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9175E70", Offset = "0x9174C70", VA = "0x189175E70")]
		public static string CVEASCWIALL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9176A90", Offset = "0x9175890", VA = "0x189176A90")]
		public static extern int GetAudioCodecCount();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9177630", Offset = "0x9176430", VA = "0x189177630")]
		public static extern bool IsConfigureAudioCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9176B00", Offset = "0x9175900", VA = "0x189176B00")]
		public static extern MediaApi GetAudioCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9175FF0", Offset = "0x9174DF0", VA = "0x189175FF0")]
		public static extern void ConfigureAudioCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9177EF0", Offset = "0x9176CF0", VA = "0x189177EF0")]
		public static string SXRDUFNTCIW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9176C50", Offset = "0x9175A50", VA = "0x189176C50")]
		public static extern int GetAudioInputDeviceCount();

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9177830", Offset = "0x9176630", VA = "0x189177830")]
		public static string LMXHQDVZSGO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9176CC0", Offset = "0x9175AC0", VA = "0x189176CC0")]
		public static extern MediaApi GetAudioInputDeviceMediaApi(int index);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x91784D0", Offset = "0x91772D0", VA = "0x1891784D0")]
		public static string[] ZOELUMMKFMU(int a, int b = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9176310", Offset = "0x9175110", VA = "0x189176310")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int videoCodecIndex, AudioCaptureSource audioSource, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool forceGpuFlush, VideoEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x91760F0", Offset = "0x9174EF0", VA = "0x1891760F0")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int imageFormatType, bool forceGpuFlush, int startFrame, ImageEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9176220", Offset = "0x9175020", VA = "0x189176220")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, float frameRate, int format, bool isTopDown, int transparencyMode, bool forceGpuFlush);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9178190", Offset = "0x9176F90", VA = "0x189178190")]
		public static extern bool Start(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x91777B0", Offset = "0x91765B0", VA = "0x1891777B0")]
		public static extern bool IsNewFrameDue(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9178070", Offset = "0x9176E70", VA = "0x189178070")]
		public static extern int SetEncodedFrameLimit(int handle, uint encodedFrameLimit);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9176620", Offset = "0x9175420", VA = "0x189176620")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x91764E0", Offset = "0x91752E0", VA = "0x1891764E0")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9176580", Offset = "0x9175380", VA = "0x189176580")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9177CF0", Offset = "0x9176AF0", VA = "0x189177CF0")]
		public static extern void Pause(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9178210", Offset = "0x9177010", VA = "0x189178210")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9177730", Offset = "0x9176530", VA = "0x189177730")]
		public static extern bool IsFileWritingComplete(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		public static bool IAWYYCXHMZE(int a, StringBuilder b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9178100", Offset = "0x9176F00", VA = "0x189178100")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9176A10", Offset = "0x9175810", VA = "0x189176A10")]
		public static extern void FreeRecorder(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9177220", Offset = "0x9176020", VA = "0x189177220")]
		public static extern uint GetNumDroppedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x91771A0", Offset = "0x9175FA0", VA = "0x1891771A0")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x91772A0", Offset = "0x91760A0", VA = "0x1891772A0")]
		public static extern uint GetNumEncodedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x91770B0", Offset = "0x9175EB0", VA = "0x1891770B0")]
		public static extern float GetEncodedSeconds(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9176E10", Offset = "0x9175C10", VA = "0x189176E10")]
		public static extern uint GetBufferSize(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9176E90", Offset = "0x9175C90", VA = "0x189176E90")]
		public static extern uint GetBufferedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9177320", Offset = "0x9176120", VA = "0x189177320")]
		private static extern IntPtr GetPluginVersion();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x91774F0", Offset = "0x91762F0", VA = "0x1891774F0")]
		private static extern bool GetVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9176B80", Offset = "0x9175980", VA = "0x189176B80")]
		private static extern bool GetAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9176D40", Offset = "0x9175B40", VA = "0x189176D40")]
		private static extern bool GetAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9176F10", Offset = "0x9175D10", VA = "0x189176F10")]
		private static extern bool GetContainerFileExtensions(int videoCodecIndex, int audioCodecIndex, StringBuilder extensions, int extensionsBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9176FF0", Offset = "0x9175DF0", VA = "0x189176FF0")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, [Out] ulong lpFreeBytesAvailable, [Out] ulong lpTotalNumberOfBytes, [Out] ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x91768B0", Offset = "0x91756B0", VA = "0x1891768B0")]
		public static bool FZHUMIHHDGN(string a, [Out] ulong b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class GYTXWYHYESM
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		internal struct PolarCoord
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public float azimuth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public float elevation;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x916CF80", Offset = "0x916BD80", VA = "0x18916CF80")]
			public void HRNNLLRGFVX(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static float[] IMMLOEPFCJY;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static float[] BZMCATLIEDB;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x916A460", Offset = "0x9169260", VA = "0x18916A460")]
		public static float[] GIHBNXRDMME(AmbisonicNormalisation a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x916A790", Offset = "0x9169590", VA = "0x18916A790")]
		public static int OIHJZRLLGPP(AmbisonicOrder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x916A7C0", Offset = "0x91695C0", VA = "0x18916A7C0")]
		public static AmbisonicChannelOrder RMLQXGPYIBW(AmbisonicFormat a)
		{
			return default(AmbisonicChannelOrder);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x916A7C0", Offset = "0x91695C0", VA = "0x18916A7C0")]
		public static AmbisonicNormalisation ZIQVGRNTOLV(AmbisonicFormat a)
		{
			return default(AmbisonicNormalisation);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x916AF00", Offset = "0x9169D00", VA = "0x18916AF00")]
		static GYTXWYHYESM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x916A8D0", Offset = "0x91696D0", VA = "0x18916A8D0")]
		private static float[] WUDNSAOLFVX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x916A850", Offset = "0x9169650", VA = "0x18916A850")]
		private static int VNMAECBKVEB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x916A7F0", Offset = "0x91695F0", VA = "0x18916A7F0")]
		private static int VMWFMHTSSWA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x916A7D0", Offset = "0x91695D0", VA = "0x18916A7D0")]
		private static int UJQCGTAALFQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x916AD10", Offset = "0x9169B10", VA = "0x18916AD10")]
		private static float ZZGYTZPHOAN(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x916ABA0", Offset = "0x91699A0", VA = "0x18916ABA0")]
		private static float ZZGYTZPHOAN(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x916A4E0", Offset = "0x91692E0", VA = "0x18916A4E0")]
		private static float[] JZWFBZUMNJO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class LMSUECQABWS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private uint QWDMCKHHMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private uint MWXYDWAOZAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private uint BJHIBXLKXPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private float XNKIHLVSSYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private uint DTJUPGDITWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private uint TASCUJDOOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ulong WEMYSXBQAKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int ROMBTENUPQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private AudioCaptureSource KONYUAKRDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int CIAMGDJCLUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int YSKNGLJXHFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float CLJISQXJSOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int SHIPDYWURKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int TROQFLIGCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float OCGQAJZCOBG;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float UUQCLTUOBRA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB0F560", Offset = "0xB0E360", VA = "0x180B0F560")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public uint ZCXJEEWNKMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public uint GHLQCCYBHDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public uint AHUDFHSNNWD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float ALMINFTSRUM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB1AB70", Offset = "0xB19970", VA = "0x180B1AB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x13EAEB0", Offset = "0x13E9CB0", VA = "0x1813EAEB0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal uint OKKKFJNSJXX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal uint GBDQXAZDRKY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xEF6710", Offset = "0xEF5510", VA = "0x180EF6710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AudioCaptureSource WIPMUOIDCSK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB0D1F0", Offset = "0xB0BFF0", VA = "0x180B0D1F0")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x16C3590", Offset = "0x16C2390", VA = "0x1816C3590")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int OWGJQHZWRKW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int YMBDSERHUCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAFE430", Offset = "0xAFD230", VA = "0x180AFE430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAFD5C0", Offset = "0xAFC3C0", VA = "0x180AFD5C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x916B7E0", Offset = "0x916A5E0", VA = "0x18916B7E0")]
		internal void TZUBHULRIBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x916B7F0", Offset = "0x916A5F0", VA = "0x18916B7F0")]
		internal void WVTJYOHRIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A59070", Offset = "0x7A57E70", VA = "0x187A59070")]
		public LMSUECQABWS()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 80)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class VideoEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum ColourSpace
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
		public NoneAutoCustom injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public StereoPacking stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public NoneAutoCustom injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public SphericalVideoLayout sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ColourSpace colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public Transparency transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AndroidVulkanPreTransform androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public ColourRange colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public RealtimeFramePresentationTimestampOptions realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public OrientationMetadata orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9178D30", Offset = "0x9177B30", VA = "0x189178D30")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9178CD0", Offset = "0x9177AD0", VA = "0x189178CD0")]
		public void FIVSODSLSPJ()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum ColourSpace
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
		public ColourSpace colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public Transparency transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AndroidVulkanPreTransform androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x916B630", Offset = "0x916A430", VA = "0x18916B630")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x916B610", Offset = "0x916A410", VA = "0x18916B610")]
		public void FIVSODSLSPJ()
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
		[Cpp2IlInjected.Address(RVA = "0x916A350", Offset = "0x9169150", VA = "0x18916A350")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x916A240", Offset = "0x9169040", VA = "0x18916A240")]
		public void FIVSODSLSPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum Resolution
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
		public enum CubemapDepth
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum CubemapResolution
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
		public enum DownScale
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
		public enum OutputPath
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
		public enum FrameUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string TANTTBRTQCN = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private EncoderHints _encoderHintsWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private EncoderHints _encoderHintsMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private EncoderHints _encoderHintsIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private EncoderHints _encoderHintsAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private KeyCode _captureKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private bool _isRealTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private StartTriggerMode _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private StartDelayMode _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private StopMode _stopMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private int _stopFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float _stopSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private string[] _videoCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private string[] _videoCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private string[] _videoCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private string[] _audioCodecPriorityWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private string[] _audioCodecPriorityMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private string[] _audioCodecPriorityAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private float _frameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[Tooltip("Timelapse scale makes the frame capture run at a fraction of the target frame rate.  Default value is 1")]
		[SerializeField]
		private int _timelapseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[Tooltip("Manual update mode requires user to call FrameUpdate() each time a frame is ready")]
		[SerializeField]
		private FrameUpdateMode _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private DownScale _downScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private Vector2 _maxVideoSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceVideoCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceVideoCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceVideoCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceAudioCodecIndexWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[Range(-1f, 128f)]
		private int _forceAudioCodecIndexMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		[Range(0f, 128f)]
		private int _forceAudioCodecIndexAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private bool _flipVertically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[Tooltip("Flushing the GPU during each capture results in less latency, but can slow down rendering performance for complex scenes.")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD2")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[Tooltip("This option can help issues where skinning is used, or other animation/rendering effects that only complete later in the frame.")]
		[SerializeField]
		protected bool _useWaitForEndOfFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD3")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[Tooltip("Update the media gallery")]
		[SerializeField]
		protected bool _androidUpdateMediaGallery;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Tooltip("Portrait captures may be rotated 90° to better utilise the encoder, check this to disable the rotation at the risk of not being able to capture the full vertical resolution.")]
		[SerializeField]
		private bool _androidNoCaptureRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private bool _iOSSaveCaptureWhenAppLosesFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Tooltip("Log the start and stop of the capture.  Disable this for less garbage generation.")]
		[SerializeField]
		private bool _logCaptureStartStop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private AudioCaptureSource _audioCaptureSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private UnityAudioCapture _unityAudioCapture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		[Range(0f, 32f)]
		private int _forceAudioInputDeviceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		[Range(8000f, 96000f)]
		private int _manualAudioSampleRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		[Range(1f, 8f)]
		private int _manualAudioChannelCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		protected OutputTarget _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const OutputPath DefaultOutputFolderType = OutputPath.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string JDVURCLUHEC = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private OutputPath _outputFolderType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string _outputFolderPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string _filenamePrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private bool _appendFilenameTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private bool _allowManualFileExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string _filenameExtension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string _namedPipePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool _writeOrientationMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private int _imageSequenceStartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		[Range(2f, 12f)]
		private int _imageSequenceZeroDigits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private ImageSequenceFormat _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected Resolution _renderResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		protected Vector2 _renderSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		protected int _renderAntiAliasing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		protected bool _useMotionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		[Range(0f, 64f)]
		protected int _motionBlurSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		protected Camera[] _motionBlurCameras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		protected MotionBlur _motionBlur;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool _allowVSyncDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private int _minimumDiskSpaceMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private TimelineController _timelineController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private VideoPlayerController _videoPlayerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		protected Texture2D VKGDAOEVNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int BVAFOTZVRUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int EIURLBBVGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int VHKTCUMFTPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int IDLQBQHHAYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int EEFUQHBJSKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool TQGLTOXMKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A5")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool NONSHWRRUBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string YQPKCRSADTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string OYKKWSZUBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo PZGYKYUOOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected VKMVIOMHNFZ.PixelFormat IVKPWTERLXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Codec REXKFDKBFKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Codec FAJHEKPVWAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private VKZITRDABPD NHGLSQCTTCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int DTRAUSFKVHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float VTKIXOBNESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool IXTOQSXPCYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool ELUOYXYERUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool UWWVRKWLUFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool ZLCEALZJRAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float HUCOPDWCGXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float WFHVBCCQTGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float IPPMUEWBDXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction BSBXFUGUDLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long WEWPGQBJPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected Transparency MUHKWUPORSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture EBYSNPFNKUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material XPJFCGWNEQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float IGXLNRKEOLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool IXBOLJQNPES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<LWYEVZTVXVH> ZUZJICIGRXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<LWYEVZTVXVH> BRWQHXZQPNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<LWYEVZTVXVH> ZVMTSYZUZEJ;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> TYKQKAQXFNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent ZPEFXJZYQSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent KHPRVDXWZUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private LMSUECQABWS DGAAQIXXWCH;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool VBVILRZAZLL;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool IQDDERRFKQL;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public OutputTarget XMSIHCEZLYX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x17A7850", Offset = "0x17A6650", VA = "0x1817A7850")]
			get
			{
				return default(OutputTarget);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x17A73D0", Offset = "0x17A61D0", VA = "0x1817A73D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public OutputPath EXBNVBKHWPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC29AD0", Offset = "0xC288D0", VA = "0x180C29AD0")]
			get
			{
				return default(OutputPath);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC28FA0", Offset = "0xC27DA0", VA = "0x180C28FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string BTWFPXKWIZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB57170", Offset = "0xB55F70", VA = "0x180B57170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xB51DD0", Offset = "0xB50BD0", VA = "0x180B51DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string BYCDDFDOYNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xB4AE60", Offset = "0xB49C60", VA = "0x180B4AE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB561D0", Offset = "0xB54FD0", VA = "0x180B561D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool QZMUREHPBUO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xB4AE50", Offset = "0xB49C50", VA = "0x180B4AE50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB71F30", Offset = "0xB70D30", VA = "0x180B71F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool DTAIMCEHFBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x10ABB70", Offset = "0x10AA970", VA = "0x1810ABB70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2230050", Offset = "0x222EE50", VA = "0x182230050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string ULAWJVVDYJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21270", VA = "0x180B22470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB4B730", Offset = "0xB4A530", VA = "0x180B4B730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string CTGBVCXXHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xB4CBC0", Offset = "0xB4B9C0", VA = "0x180B4CBC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xB4CDD0", Offset = "0xB4BBD0", VA = "0x180B4CDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UKXFKCVKEYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB80790", Offset = "0xB7F590", VA = "0x180B80790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBE20B0", Offset = "0xBE0EB0", VA = "0x180BE20B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int FDQKBHVXHAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB4CD70", Offset = "0xB4BB70", VA = "0x180B4CD70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xBAA180", Offset = "0xBA8F80", VA = "0x180BAA180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int DODECGSULCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x12B3430", Offset = "0x12B2230", VA = "0x1812B3430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x91690C0", Offset = "0x9167EC0", VA = "0x1891690C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool WUVESLUZNUR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18EC420", Offset = "0x18EB220", VA = "0x1818EC420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x91691A0", Offset = "0x9167FA0", VA = "0x1891691A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int LSKOJRBXRXR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x107E180", Offset = "0x107CF80", VA = "0x18107E180")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9169130", Offset = "0x9167F30", VA = "0x189169130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] QQUNKBMOUVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC3C180", Offset = "0xC3AF80", VA = "0x180C3C180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x170C430", Offset = "0x170B230", VA = "0x18170C430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur AYCFOYMRLJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC3C0E0", Offset = "0xC3AEE0", VA = "0x180C3C0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD9510", Offset = "0xBD8310", VA = "0x180BD9510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transparency NXQXBGOITNT
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xBD0500", Offset = "0xBCF300", VA = "0x180BD0500")]
			get
			{
				return default(Transparency);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> IVZHBRWNEWN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x9168F50", Offset = "0x9167D50", VA = "0x189168F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string EIXPARMUYMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB573E0", Offset = "0xB561E0", VA = "0x180B573E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent TKXMBQPPGHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xBD0200", Offset = "0xBCF000", VA = "0x180BD0200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent GGZIDUALLOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBD0220", Offset = "0xBCF020", VA = "0x180BD0220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<LWYEVZTVXVH> SQOKYDEAOEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBE4090", Offset = "0xBE2E90", VA = "0x180BE4090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBE33F0", Offset = "0xBE21F0", VA = "0x180BE33F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<LWYEVZTVXVH> EQHELJFDNNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBE4F10", Offset = "0xBE3D10", VA = "0x180BE4F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xBDA610", Offset = "0xBD9410", VA = "0x180BDA610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Resolution LMGTQMPYRSC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x238F920", Offset = "0x238E720", VA = "0x18238F920")]
			get
			{
				return default(Resolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x9169070", Offset = "0x9167E70", VA = "0x189169070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 NHETFNVOJFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x9168FA0", Offset = "0x9167DA0", VA = "0x189168FA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x27366E0", Offset = "0x27354E0", VA = "0x1827366E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int IUOHCQPFZGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x18EC460", Offset = "0x18EB260", VA = "0x1818EC460")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x26173B0", Offset = "0x26161B0", VA = "0x1826173B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool TCYIXWPWRHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x19B7770", Offset = "0x19B6570", VA = "0x1819B7770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x19B7760", Offset = "0x19B6560", VA = "0x1819B7760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool HFBDLYPZEOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AB00", Offset = "0x2A19900", VA = "0x182A1AB00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B150", Offset = "0x2A19F50", VA = "0x182A1B150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AudioCaptureSource WIPMUOIDCSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB72C80", Offset = "0xB71A80", VA = "0x180B72C80")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB72570", Offset = "0xB71370", VA = "0x180B72570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int DBTVHYQVOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F22520", Offset = "0x1F21320", VA = "0x181F22520")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x28415B0", Offset = "0x28403B0", VA = "0x1828415B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int SWRQRWUHCNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB5FC90", Offset = "0xB5EA90", VA = "0x180B5FC90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xB5EB40", Offset = "0xB5D940", VA = "0x180B5EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture QSOMSVZZZBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xB4EAC0", Offset = "0xB4D8C0", VA = "0x180B4EAC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xB4DDE0", Offset = "0xB4CBE0", VA = "0x180B4DDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int ORMOUKQKRKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB7E570", Offset = "0xB7D370", VA = "0x180B7E570")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x9169080", Offset = "0x9167E80", VA = "0x189169080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float UTZHQDBSMSK
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1665AE0", Offset = "0x16648E0", VA = "0x181665AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x9169090", Offset = "0x9167E90", VA = "0x189169090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public StartTriggerMode XOKVHXKSAHV
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xB45FA0", Offset = "0xB44DA0", VA = "0x180B45FA0")]
			get
			{
				return default(StartTriggerMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x10073B0", Offset = "0x10061B0", VA = "0x1810073B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public StartDelayMode DACACBUYMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x15040E0", Offset = "0x1502EE0", VA = "0x1815040E0")]
			get
			{
				return default(StartDelayMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1C2EDA0", Offset = "0x1C2DBA0", VA = "0x181C2EDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float ILFDYHBXPER
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xB0E1D0", Offset = "0xB0CFD0", VA = "0x180B0E1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9169160", Offset = "0x9167F60", VA = "0x189169160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public StopMode VBVCQCOYKZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1323F70", Offset = "0x1322D70", VA = "0x181323F70")]
			get
			{
				return default(StopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x23375E0", Offset = "0x23363E0", VA = "0x1823375E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int QKPJONGMWBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7E0", Offset = "0xF1A5E0", VA = "0x180F1B7E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x9169170", Offset = "0x9167F70", VA = "0x189169170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float VHMTJQHLEJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x12B35B0", Offset = "0x12B23B0", VA = "0x1812B35B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x9169180", Offset = "0x9167F80", VA = "0x189169180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool PACGBJNTMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAC50F0", Offset = "0xAC3EF0", VA = "0x180AC50F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAC5100", Offset = "0xAC3F00", VA = "0x180AC5100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public LMSUECQABWS LMSUECQABWS
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xBD0210", Offset = "0xBCF010", VA = "0x180BD0210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] ACLIVHLITQF
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x91691F0", Offset = "0x9167FF0", VA = "0x1891691F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] IGHNCGJQYQR
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x91691C0", Offset = "0x9167FC0", VA = "0x1891691C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] YXFSOOVQCJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9169040", Offset = "0x9167E40", VA = "0x189169040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] PYDNWGAZSKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9169010", Offset = "0x9167E10", VA = "0x189169010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int QEXUEAHUKXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2D95BC0", Offset = "0x2D949C0", VA = "0x182D95BC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x78A1140", Offset = "0x789FF40", VA = "0x1878A1140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FrameUpdateMode YLUCFIUYRKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B10", Offset = "0xAC6910", VA = "0x180AC7B10")]
			get
			{
				return default(FrameUpdateMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B40", Offset = "0xAC6940", VA = "0x180AC7B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DownScale VWTOOGACEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB18980", Offset = "0xB17780", VA = "0x180B18980")]
			get
			{
				return default(DownScale);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF55EB0", Offset = "0xF54CB0", VA = "0x180F55EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 UQMCDOBLLUO
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2A0EB40", Offset = "0x2A0D940", VA = "0x182A0EB40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x78066A0", Offset = "0x78054A0", VA = "0x1878066A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool WFOEVGTUYGR
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x15E6880", Offset = "0x15E5680", VA = "0x1815E6880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x18AD550", Offset = "0x18AC350", VA = "0x1818AD550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool SJQFHDNFOFV
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x836A140", Offset = "0x8368F40", VA = "0x18836A140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x91691B0", Offset = "0x9167FB0", VA = "0x1891691B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool UHVTSLGCBRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2A1AC70", Offset = "0x2A19A70", VA = "0x182A1AC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B1E0", Offset = "0x2A19FE0", VA = "0x182A1B1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool ETCRAHHXQJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xC4CAE0", Offset = "0xC4B8E0", VA = "0x180C4CAE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD2C1E0", Offset = "0xD2AFE0", VA = "0x180D2C1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool GYDRGJJIFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xC78A80", Offset = "0xC77880", VA = "0x180C78A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x9169190", Offset = "0x9167F90", VA = "0x189169190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController AZDVAYZNUTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC3C320", Offset = "0xC3B120", VA = "0x180C3C320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB7F9F0", Offset = "0xB7E7F0", VA = "0x180B7F9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController XDVGYIOAHLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC3C150", Offset = "0xC3AF50", VA = "0x180C3C150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1092D20", Offset = "0x1091B20", VA = "0x181092D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Codec JAXDGTNDMRD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB91450", Offset = "0xB90250", VA = "0x180B91450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Codec HHUDMSTWGMC
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB91480", Offset = "0xB90280", VA = "0x180B91480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public VKZITRDABPD PXDQRTIEJKW
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xC3C380", Offset = "0xC3B180", VA = "0x180C3C380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int QEMKMEENIDS
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1509810", Offset = "0x1508610", VA = "0x181509810")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1509800", Offset = "0x1508600", VA = "0x181509800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int LMLOEDPBFSR
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xF19BA0", Offset = "0xF189A0", VA = "0x180F19BA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2466ED0", Offset = "0x2465CD0", VA = "0x182466ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ImageSequenceFormat PSCTXENUASL
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1855D90", Offset = "0x1854B90", VA = "0x181855D90")]
			get
			{
				return default(ImageSequenceFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22ACC70", Offset = "0x22ABA70", VA = "0x1822ACC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string YUTJAFBFWKE
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9168FC0", Offset = "0x9167DC0", VA = "0x189168FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x91690F0", Offset = "0x9167EF0", VA = "0x1891690F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0")]
		protected static VKMVIOMHNFZ.Platform WCMOLDYLKCZ()
		{
			return default(VKMVIOMHNFZ.Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x91610E0", Offset = "0x915FEE0", VA = "0x1891610E0")]
		public EncoderHints GetEncoderHints(VKMVIOMHNFZ.Platform platform = VKMVIOMHNFZ.Platform.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9166060", Offset = "0x9164E60", VA = "0x189166060")]
		public void SetEncoderHints(EncoderHints hints, VKMVIOMHNFZ.Platform platform = VKMVIOMHNFZ.Platform.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void UpdateMediaGallery(string videoFilePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x915FBC0", Offset = "0x915E9C0", VA = "0x18915FBC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9168250", Offset = "0x9167050", VA = "0x189168250")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9166610", Offset = "0x9165410", VA = "0x189166610", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x91614B0", Offset = "0x91602B0", VA = "0x1891614B0")]
		private static bool HGNBJOXDAAH(Codec a, JUQYJKNPQFN b, int c, string[] d, MediaApi e, bool f, bool g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9165D40", Offset = "0x9164B40", VA = "0x189165D40")]
		public Codec SelectVideoCodec(bool isStartingCapture = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x91656A0", Offset = "0x91644A0", VA = "0x1891656A0")]
		public Codec SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x9165A10", Offset = "0x9164810", VA = "0x189165A10")]
		public VKZITRDABPD SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9161250", Offset = "0x9160050", VA = "0x189161250")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9165C30", Offset = "0x9164A30", VA = "0x189165C30")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9162F70", Offset = "0x9161D70", VA = "0x189162F70", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x91631A0", Offset = "0x9161FA0", VA = "0x1891631A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9165370", Offset = "0x9164170", VA = "0x189165370")]
		private void RFDFRFXVWVQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9162F20", Offset = "0x9161D20", VA = "0x189162F20")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9162A00", Offset = "0x9161800", VA = "0x189162A00")]
		protected void NLZPPKXXZQQ(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9161D70", Offset = "0x9160B70", VA = "0x189161D70")]
		protected bool JUWGEMACBZN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9160140", Offset = "0x915EF40", VA = "0x189160140")]
		protected bool BWRKTUTSLJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9160730", Offset = "0x915F530", VA = "0x189160730", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9161BC0", Offset = "0x91609C0", VA = "0x189161BC0")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10CFAD0", Offset = "0x10CE8D0", VA = "0x1810CFAD0")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10D00D0", Offset = "0x10CEED0", VA = "0x1810D00D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9161320", Offset = "0x9160120", VA = "0x189161320")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB56DF0", Offset = "0xB55BF0", VA = "0x180B56DF0")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9161750", Offset = "0x9160550", VA = "0x189161750", Slot = "8")]
		protected virtual string IBMYVXHZKAE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9161BD0", Offset = "0x91609D0", VA = "0x189161BD0")]
		private static string JJZLQIVGMRX(OutputPath a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9168040", Offset = "0x9166E40", VA = "0x189168040")]
		private static string ZFQZTQAKLEJ(OutputPath a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9163410", Offset = "0x9162210", VA = "0x189163410")]
		protected static bool PLYNWSORNOC(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9166EE0", Offset = "0x9165CE0", VA = "0x189166EE0")]
		protected void TPCVQKUIJOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9160990", Offset = "0x915F790", VA = "0x189160990")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool logWarnings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9161E20", Offset = "0x9160C20", VA = "0x189161E20")]
		private bool KHIVRCCCORI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x91636F0", Offset = "0x91624F0", VA = "0x1891636F0", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x91652F0", Offset = "0x91640F0", VA = "0x1891652F0")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10D0EB0", Offset = "0x10CFCB0", VA = "0x1810D0EB0")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9161B30", Offset = "0x9160930", VA = "0x189161B30")]
		protected void IEIDTLYOJIP(StereoPacking a, SphericalVideoLayout b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9166100", Offset = "0x9164F00", VA = "0x189166100")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x91634B0", Offset = "0x91622B0", VA = "0x1891634B0")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9165580", Offset = "0x9164380", VA = "0x189165580")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9160420", Offset = "0x915F220", VA = "0x189160420")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9160450", Offset = "0x915F250", VA = "0x189160450")]
		public static void DeleteCapture(OutputTarget outputTarget, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9163450", Offset = "0x9162250", VA = "0x189163450")]
		protected void PPVYLJRKSYJ(VKMVIOMHNFZ.PluginEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x91666D0", Offset = "0x91654D0", VA = "0x1891666D0", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false, bool ignorePendingFileWrites = false, bool deleteCapture = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x91601B0", Offset = "0x915EFB0", VA = "0x1891601B0")]
		private static TIQWNPUXWZF.Options CBPOHPUILKX(VideoEncoderHints a, string b)
		{
			return default(TIQWNPUXWZF.Options);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9160DF0", Offset = "0x915FBF0", VA = "0x189160DF0")]
		private static bool GTDBXPQQDDD(string a, VideoEncoderHints b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9160240", Offset = "0x915F040", VA = "0x189160240")]
		protected void CXEVEXQUIYR(string a, VideoEncoderHints b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x91676B0", Offset = "0x91664B0", VA = "0x1891676B0")]
		private void TZVYLQHORRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9167F20", Offset = "0x9166D20", VA = "0x189167F20")]
		private bool XPLXWIBRBFW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x91654D0", Offset = "0x91642D0", VA = "0x1891654D0")]
		protected bool RJSGRTUKSFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9167C40", Offset = "0x9166A40", VA = "0x189167C40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9162540", Offset = "0x9161340", VA = "0x189162540")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9167CA0", Offset = "0x9166AA0", VA = "0x189167CA0")]
		private void VHIKPRHDGRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x91676F0", Offset = "0x91664F0", VA = "0x1891676F0")]
		private void UISYSBAKXGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9165670", Offset = "0x9164470", VA = "0x189165670")]
		protected bool SKKEKPEUMUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9162A80", Offset = "0x9161880", VA = "0x189162A80")]
		protected bool NMFLSRXZNBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9161190", Offset = "0x915FF90", VA = "0x189161190")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9161DF0", Offset = "0x9160BF0", VA = "0x189161DF0")]
		protected float JWZZYJYRATU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9163230", Offset = "0x9162030", VA = "0x189163230")]
		protected bool PAOPXNHYOIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x915FB80", Offset = "0x915E980", VA = "0x18915FB80")]
		protected void AVIAJSVGFWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9167790", Offset = "0x9166590", VA = "0x189167790")]
		protected void UWQLZLMKKYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB90D60", Offset = "0xB8FB60", VA = "0x180B90D60", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9162480", Offset = "0x9161280", VA = "0x189162480")]
		protected void KJLIJVMJBOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9160680", Offset = "0x915F480", VA = "0x189160680")]
		public void EncodeAudio(NativeArray<float> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9160560", Offset = "0x915F360", VA = "0x189160560")]
		public void EncodeAudio(float[] audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x91635F0", Offset = "0x91623F0", VA = "0x1891635F0", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9167840", Offset = "0x9166640", VA = "0x189167840", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9162B60", Offset = "0x9161960", VA = "0x189162B60")]
		protected bool NOLJZFLHBYL(int a, int b, bool c = false, int d = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9167D60", Offset = "0x9166B60", VA = "0x189167D60")]
		protected RenderTexture VJJBSLRCEMK(Texture a, bool b = false, int c = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9167680", Offset = "0x9166480", VA = "0x189167680")]
		protected void TZUBHULRIBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x91677E0", Offset = "0x91665E0", VA = "0x1891677E0")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x91628A0", Offset = "0x91616A0", VA = "0x1891628A0")]
		protected int MEINMOXCUME(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9160FF0", Offset = "0x915FDF0", VA = "0x189160FF0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9161330", Offset = "0x9160130", VA = "0x189161330")]
		public static void GetResolution(Resolution res, int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x91629F0", Offset = "0x91617F0", VA = "0x1891629F0")]
		protected static int NGRZLJWESHH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9168A90", Offset = "0x9167890", VA = "0x189168A90")]
		public CaptureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum MediaApi
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
	public enum CodecType
	{
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Video,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Audio
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class Codec
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CodecType URIFKECQVAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int IDTULQAZBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private string VQYZTKPVZLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool FCTHGACOXAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MediaApi RKYEJQPLOXS;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int ABEZYRMIUQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public MediaApi KUOPBTBFAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x180AE6400", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool KVJHDXSEIYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9169220", Offset = "0x9168020", VA = "0x189169220")]
		public void ORMYWTLDAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9169380", Offset = "0x9168180", VA = "0x189169380")]
		internal Codec(CodecType codecType, int index, string name, MediaApi api, bool hasConfigWindow = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class JUQYJKNPQFN : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private Codec[] BGTFBAYWLZF;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Codec[] NJOUBLKVJMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x2936F90", Offset = "0x2935D90", VA = "0x182936F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x916B770", Offset = "0x916A570", VA = "0x18916B770")]
		internal JUQYJKNPQFN(Codec[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x916B6D0", Offset = "0x916A4D0", VA = "0x18916B6D0")]
		public Codec PXSROOCXLAK(string a, MediaApi b = MediaApi.Unknown)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x916B670", Offset = "0x916A470", VA = "0x18916B670")]
		public Codec GWMDRMMTYCB(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2A270A0", Offset = "0x2A25EA0", VA = "0x182A270A0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class RYIKJLZFFYK
	{
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static bool PHBVFAQPAQC;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static JUQYJKNPQFN GPFNNKDDDJS;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static JUQYJKNPQFN TIXJWCXIZHL;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public static JUQYJKNPQFN NTJPAZRUXGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x916DBD0", Offset = "0x916C9D0", VA = "0x18916DBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public static JUQYJKNPQFN LQXKUFPRWUA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x916DB80", Offset = "0x916C980", VA = "0x18916DB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x916D2A0", Offset = "0x916C0A0", VA = "0x18916D2A0")]
		private static void HCMEMUSTIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x916D340", Offset = "0x916C140", VA = "0x18916D340")]
		private static void KUGSNFTCVGY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum DeviceType
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		AudioInput
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class VKZITRDABPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DeviceType PKJIGNVFCXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private int IDTULQAZBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private string VQYZTKPVZLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MediaApi RKYEJQPLOXS;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public int ABEZYRMIUQN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public MediaApi KUOPBTBFAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9178C70", Offset = "0x9177A70", VA = "0x189178C70")]
		internal VKZITRDABPD(DeviceType a, int b, string c, MediaApi d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class MRZHSFSLNPH : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private VKZITRDABPD[] PCHQWCBRPRF;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public VKZITRDABPD[] DCYNFMSAVCC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x2936F90", Offset = "0x2935D90", VA = "0x182936F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x916C060", Offset = "0x916AE60", VA = "0x18916C060")]
		internal MRZHSFSLNPH(VKZITRDABPD[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x916C000", Offset = "0x916AE00", VA = "0x18916C000")]
		public VKZITRDABPD GWMDRMMTYCB(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A270A0", Offset = "0x2A25EA0", VA = "0x182A270A0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class HVDHEFSTOQE
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static bool PHBVFAQPAQC;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static MRZHSFSLNPH SYAVUYFBROJ;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static MRZHSFSLNPH PDYCUIQGDHC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x916B440", Offset = "0x916A240", VA = "0x18916B440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x916B3A0", Offset = "0x916A1A0", VA = "0x18916B3A0")]
		private static void HCMEMUSTIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x916AF80", Offset = "0x9169D80", VA = "0x18916AF80")]
		private static void CJBNNAYSFKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class LWYEVZTVXVH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public enum CompletionStatus
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
		private string JSKGHMMCNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private int BVAFOTZVRUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool JNFWZHGJYPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OutputTarget OHDEJVRDJQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TIQWNPUXWZF.Options KWNRNPXFTEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ManualResetEvent JHHFNDDBZWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CompletionStatus TOMDRJRZVGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string OYKKWSZUBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool QXNWYBMSUCH;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		internal Action<LWYEVZTVXVH> EQHELJFDNNS
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x916BF80", Offset = "0x916AD80", VA = "0x18916BF80")]
		internal LWYEVZTVXVH(OutputTarget a, string b, int c, bool d, string e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x916BCF0", Offset = "0x916AAF0", VA = "0x18916BCF0")]
		internal void MJQSCFPZAXE(TIQWNPUXWZF.Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x916BD10", Offset = "0x916AB10", VA = "0x18916BD10")]
		private bool XJNSSJPBGKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x916B840", Offset = "0x916A640", VA = "0x18916B840")]
		public bool BXRYDIAFPBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x916BA00", Offset = "0x916A800", VA = "0x18916BA00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class TIQWNPUXWZF
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct Options
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public bool applyFastStart;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public bool applyStereoMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public StereoPacking stereoMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public bool applySphericalVideoLayout;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public SphericalVideoLayout sphericalVideoLayout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public bool applyMoveCaptureFile;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			public string finalCaptureFilePath;

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x916CF60", Offset = "0x916BD60", VA = "0x18916CF60")]
			public bool YXHGRKBVGYV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x916CF40", Offset = "0x916BD40", VA = "0x18916CF40")]
			public bool OXSLCRBSPVS()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x916CF20", Offset = "0x916BD20", VA = "0x18916CF20")]
			public void HLJMEYDPJBS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class JCOGUVIPYQE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public uint HPCDEAFZVKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public long YKHCGRNSOZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public long LQGGHNFPOQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public long TYTIKNVWEVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public long UFYXHPMTFRH;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JCOGUVIPYQE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		internal enum StereoMode_st3d
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
		private sealed class VBZDFZLFUJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public string WTVWVHWXLBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public bool APMZSOSFGLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public Options SNLHOFQDXBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public ManualResetEvent UHEORQJZLAU;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VBZDFZLFUJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x9175D00", Offset = "0x9174B00", VA = "0x189175D00")]
			internal void MIPVDHPDPIS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly uint YNUXKKSTTGS;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly uint LEMOYBMVIZN;

		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static readonly uint MEGEUGOSAKG;

		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly uint PNSBSLXNOEN;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly uint JOFVLOILQUI;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly uint YSJUNEAKQZX;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly uint OCBLQONFKKF;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly uint DETDLHVCJUG;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly uint JKOAGFHQPNY;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly uint HFWETFHYDCP;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly uint OWUCEJTMLHZ;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly uint IHGWOUKQICU;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly uint SYCQEYQREBL;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly uint VTPXBMRIOQR;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly uint FOLGHGIPIWX;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly uint WHIXOUNMZUU;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly uint QUFSFFXBYPX;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly uint NLMAZSSKXBY;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly uint XIYJSJNYFME;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly uint POWOQDDUIWR;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly uint BBLRJEJDHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BinaryReader FNAHCYRNFWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private Stream ZGIJSPNJVLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private Options ITNPRSOXLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private bool DLEHYAYAIAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private List<JCOGUVIPYQE> CJXKXSHTFTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private List<JCOGUVIPYQE> HGDOIYPIYMH;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9170A50", Offset = "0x916F850", VA = "0x189170A50")]
		public static ManualResetEvent NKATABXZVCG(string a, bool b, Options c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x916F2A0", Offset = "0x916E0A0", VA = "0x18916F2A0")]
		public static bool IGAQMFXMGZA(string a, bool b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x916F600", Offset = "0x916E400", VA = "0x18916F600")]
		public static bool IGAQMFXMGZA(string a, string b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x91732F0", Offset = "0x91720F0", VA = "0x1891732F0")]
		public TIQWNPUXWZF(Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x916F960", Offset = "0x916E760", VA = "0x18916F960")]
		public bool IUNAOGJOVVO(Stream a, Stream b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x916E980", Offset = "0x916D780", VA = "0x18916E980")]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x916E5A0", Offset = "0x916D3A0", VA = "0x18916E5A0")]
		private static JCOGUVIPYQE BLSCXAVQUFJ(uint a, List<JCOGUVIPYQE> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9171350", Offset = "0x9170150", VA = "0x189171350")]
		private List<JCOGUVIPYQE> QEMTUYYXRKJ(JCOGUVIPYQE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9171420", Offset = "0x9170220", VA = "0x189171420")]
		private List<JCOGUVIPYQE> QEMTUYYXRKJ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9170870", Offset = "0x916F670", VA = "0x189170870")]
		private JCOGUVIPYQE MILZUSKFRTT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9170FE0", Offset = "0x916FDE0", VA = "0x189170FE0")]
		private bool OXQMFBRWEXF(JCOGUVIPYQE a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x916E530", Offset = "0x916D330", VA = "0x18916E530")]
		private void BFGGDGKSCCT(JCOGUVIPYQE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9171630", Offset = "0x9170430", VA = "0x189171630")]
		private void RORPSFVCXXQ(JCOGUVIPYQE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9170770", Offset = "0x916F570", VA = "0x189170770")]
		private void LFNVIPQKMJU(JCOGUVIPYQE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9171C70", Offset = "0x9170A70", VA = "0x189171C70")]
		private void TGEQWKOVVQR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x9170420", Offset = "0x916F220", VA = "0x189170420")]
		private void KNMCHXCNXMF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x916DEC0", Offset = "0x916CCC0", VA = "0x18916DEC0")]
		private uint ANVYUHJALDN(JCOGUVIPYQE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x916EF40", Offset = "0x916DD40", VA = "0x18916EF40")]
		private bool FAMLMRJKIAF(JCOGUVIPYQE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9171140", Offset = "0x916FF40", VA = "0x189171140")]
		private void PMNZYHBHAGV(JCOGUVIPYQE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9170560", Offset = "0x916F360", VA = "0x189170560")]
		private void KYSLZPCCCUT(JCOGUVIPYQE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x91724A0", Offset = "0x91712A0", VA = "0x1891724A0")]
		private void YLZFMERDWAY(JCOGUVIPYQE a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x91722D0", Offset = "0x91710D0", VA = "0x1891722D0")]
		private uint VKULMVPJKFR(JCOGUVIPYQE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9171D80", Offset = "0x9170B80", VA = "0x189171D80")]
		private uint TLMQHZAULJS(JCOGUVIPYQE a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9172480", Offset = "0x9171280", VA = "0x189172480")]
		private static StereoMode_st3d XBZMXDNLRVU(StereoPacking a)
		{
			return default(StereoMode_st3d);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x916F130", Offset = "0x916DF30", VA = "0x18916F130")]
		private uint FQRBXVMSAAQ(StereoMode_st3d a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9171A70", Offset = "0x9170870", VA = "0x189171A70")]
		private uint SOYFEEQLHTQ(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x916EA60", Offset = "0x916D860", VA = "0x18916EA60")]
		private uint EFXGGWXDHXO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x916E6E0", Offset = "0x916D4E0", VA = "0x18916E6E0")]
		private uint BSFUZNQUBYV(string a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9170230", Offset = "0x916F030", VA = "0x189170230")]
		private uint JULNJWLCCGH(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x91716A0", Offset = "0x91704A0", VA = "0x1891716A0")]
		private uint RQYNFGAAIBY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9170C10", Offset = "0x916FA10", VA = "0x189170C10")]
		private uint OTYGSWTACSI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x916DDB0", Offset = "0x916CBB0", VA = "0x18916DDB0")]
		private void AACTOXCVECM(JCOGUVIPYQE a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x916EED0", Offset = "0x916DCD0", VA = "0x18916EED0")]
		private ushort EZDIXTLGIMY()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9171A00", Offset = "0x9170800", VA = "0x189171A00")]
		private uint RZJARSXGMLI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x91726B0", Offset = "0x91714B0", VA = "0x1891726B0")]
		private ulong ZBPNBBYIKQJ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x916F8E0", Offset = "0x916E6E0", VA = "0x18916F8E0")]
		private void IGXYFXKFLOS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x9170190", Offset = "0x916EF90", VA = "0x189170190")]
		private void JCGWFKRKBYT(uint a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x916E4A0", Offset = "0x916D2A0", VA = "0x18916E4A0")]
		private void BACLITRHRXK(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x91704D0", Offset = "0x916F2D0", VA = "0x1891704D0")]
		private static uint KVDTSQPMDUN(string a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public enum NoneAutoCustom
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Custom
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum AudioCaptureSource
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
	public enum StereoPacking
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		TopBottom,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		LeftRight
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum Transparency
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
	public enum SphericalVideoLayout
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		Equirectangular360,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		Equirectangular180
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum StopMode
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
	public enum StartTriggerMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		Manual,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		OnStart
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum StartDelayMode
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
	public enum ImageSequenceFormat
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
	public enum OutputTarget
	{
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		VideoFile,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		ImageSequence,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		NamedPipe
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum AndroidVulkanPreTransform
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
	public enum ColourRange
	{
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		Limited,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		Full
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum RealtimeFramePresentationTimestampOptions
	{
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		Realtime,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		Fixed,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		Nearest
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OrientationMetadata
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
	public class Utils
	{
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static string[] RJDILJKNKCR;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static string[] LEDRUMJLMFD;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static string[] ZANRRITBYCR;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static string[] YYFRHTDGHUP;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9175910", Offset = "0x9174710", VA = "0x189175910")]
		public static string[] WBURBLIUJBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9174C40", Offset = "0x9173A40", VA = "0x189174C40")]
		public static RenderTextureFormat ABIMRASQEIV(bool a, bool b, bool c)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9175980", Offset = "0x9174780", VA = "0x189175980")]
		public static bool XDMXIZUBZJZ(Camera a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9175190", Offset = "0x9173F90", VA = "0x189175190")]
		public static Camera[] IONMCPJMHIA(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9175720", Offset = "0x9174520", VA = "0x189175720")]
		public static bool PYYWRPEVRHY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9175630", Offset = "0x9174430", VA = "0x189175630")]
		public static bool ODZNMXPATRW(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9174FA0", Offset = "0x9173DA0", VA = "0x189174FA0")]
		public static bool CWTSFRAJMAO(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9175860", Offset = "0x9174660", VA = "0x189175860")]
		public static string SYESFGCVNRH(ImageSequenceFormat a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class EYMRQRSFHUE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public enum SampleFormat
		{
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			PCM16 = 2,
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			Float32 = 4
		}

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private static byte[] DUQREQBYGZQ;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static byte[] ELRUWPXHCGQ;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static byte[] JDCKNLAEORZ;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static byte[] OTPXNKGIKUE;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static byte[] LTDVYEYVXDA;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static byte[] LKDAJQJHFEM;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static byte[] QQEKTOFWQVU;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private const int LGNQWJTKHFH = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private FileStream JBYBPVEOKTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private byte[] UKXSEDJDXFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int KMBJLXGUGMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private int DGUKJJXRMZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int DLSQBRXVTAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int DRSVXMCSUAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private SampleFormat RPXSWVJKIXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private int EHCKRECTYDO;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x916A150", Offset = "0x9168F50", VA = "0x18916A150")]
		public EYMRQRSFHUE(string a, int b, int c, SampleFormat d = SampleFormat.Float32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9169BA0", Offset = "0x91689A0", VA = "0x189169BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9169C20", Offset = "0x9168A20", VA = "0x189169C20")]
		public void NXMGOQPEPQV(float[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9169560", Offset = "0x9168360", VA = "0x189169560")]
		public void BSAAZPYCLST(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9169DB0", Offset = "0x9168BB0", VA = "0x189169DB0")]
		private static byte[] WKQUNQPJOXQ(int a, int b = 2)
		{
			return null;
		}
	}
}
namespace RenderHeads.Media.AVProMovieCapture.Editor
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class EditorCoroutine : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9179B40", Offset = "0x9178940", VA = "0x189179B40")]
		public void RunCoroutine(IEnumerator routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
