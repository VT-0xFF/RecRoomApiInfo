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
		private Vector3 CLFJEJEKEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ALEAIDEBAIP JIAFEJHDPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private FIPOGPHKAAM LFNOOLMLGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MHGDENPJEEA CMIMJMKPENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr DPBLJGEJJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int MFNAECDHJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] HMLFJALMKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> HALEEMKMDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> NIFANDEBKNP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x90A1FB0", Offset = "0x90A05B0", VA = "0x1890A1FB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x90A1D20", Offset = "0x90A0320", VA = "0x1890A1D20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x90A13A0", Offset = "0x909F9A0", VA = "0x1890A13A0")]
		internal void OJBDAEJKGJC(ALEAIDEBAIP OGFNFILHJOI, FIPOGPHKAAM KAJENIDGKID, MHGDENPJEEA CDKEAAOBFBC, int MNMEJBNLKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x90A1E90", Offset = "0x90A0490", VA = "0x1890A1E90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x90A1240", Offset = "0x909F840", VA = "0x1890A1240")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x90A0E10", Offset = "0x909F410", VA = "0x1890A0E10")]
		private void DIBFDIBLBIN(Vector3 AANGPKCDGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x90A2130", Offset = "0x90A0730", VA = "0x1890A2130")]
		private void PNAHIMDNLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x90A1590", Offset = "0x909FB90", VA = "0x1890A1590")]
		private void OnAudioFilterRead(float[] OLGJNFNONNO, int FPNDCHNJFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x90A0E30", Offset = "0x909F430", VA = "0x1890A0E30")]
		internal void KNNDKGLHOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90A0DD0", Offset = "0x909F3D0", VA = "0x1890A0DD0")]
		internal int DBLJOAEEKMN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x90A1070", Offset = "0x909F670", VA = "0x1890A1070")]
		internal void LNHLLMCBFDD(bool JKHJCJIDDNG, bool LFMENDJGFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x90A22E0", Offset = "0x90A08E0", VA = "0x1890A22E0")]
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
		private ALEAIDEBAIP _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EMBKDCOEMGF _format;

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
		private float[] JJEEJAPKPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IMANFEHLNPE AMPCMPFKADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> AGNJNBAGHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int ELKGMHMKFMF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ALEAIDEBAIP HBFGFFLJNDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			get
			{
				return default(ALEAIDEBAIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EMBKDCOEMGF AIJCJONLLDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			get
			{
				return default(EMBKDCOEMGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x90A2510", Offset = "0x90A0B10", VA = "0x1890A2510")]
		internal void BDDDKJPKNAI(AmbisonicSource LBHNPIBFMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x90A2FC0", Offset = "0x90A15C0", VA = "0x1890A2FC0")]
		internal void OPAMKKDGPGF(AmbisonicSource LBHNPIBFMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90A30A0", Offset = "0x90A16A0", VA = "0x1890A30A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90A2BF0", Offset = "0x90A11F0", VA = "0x1890A2BF0")]
		private void KOODEGGOMLA(AmbisonicSource LBHNPIBFMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90A2660", Offset = "0x90A0C60", VA = "0x1890A2660")]
		private void BMBMLIEALLE(bool PHANBKONNBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x90A2690", Offset = "0x90A0C90", VA = "0x1890A2690")]
		private void FCPIMFGNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x90A2AF0", Offset = "0x90A10F0", VA = "0x1890A2AF0")]
		private void KJMHBCMOEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90A2D60", Offset = "0x90A1360", VA = "0x1890A2D60")]
		private bool MDIAHDLMHPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90A2CA0", Offset = "0x90A12A0", VA = "0x1890A2CA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90A2D80", Offset = "0x90A1380", VA = "0x1890A2D80")]
		private void OMHKOAGPINP(bool LFMENDJGFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x90A2400", Offset = "0x90A0A00", VA = "0x1890A2400")]
		internal void AEDOIHEGICK(float[] OLGJNFNONNO, int HDOPDCPGECL, bool HNEGBNBPDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90A2AB0", Offset = "0x90A10B0", VA = "0x1890A2AB0")]
		private void KEJKLPLPONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90A30B0", Offset = "0x90A16B0", VA = "0x1890A30B0")]
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
		private IMANFEHLNPE AMPCMPFKADO;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x90A31F0", Offset = "0x90A17F0", VA = "0x1890A31F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90A31B0", Offset = "0x90A17B0", VA = "0x1890A31B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x90A3180", Offset = "0x90A1780", VA = "0x1890A3180")]
		private void OnAudioFilterRead(float[] DAJAOHIJHHL, int FPJPLDGHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x90A3330", Offset = "0x90A1930", VA = "0x1890A3330")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum MCHFGFHNKGB
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
		public enum NGMBJNEPNLE
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
		private MCHFGFHNKGB _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private NGMBJNEPNLE _scanFrequency;

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
		private Camera[] HBMOPHKLKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int ICGJOJKPGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int DHBJIFKMIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool GIFLMJGFMDD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera DAAEDMEDGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x90A3C70", Offset = "0x90A2270", VA = "0x1890A3C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MCHFGFHNKGB AOHIAGBDEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(MCHFGFHNKGB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x90A3CC0", Offset = "0x90A22C0", VA = "0x1890A3CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public NGMBJNEPNLE DJDEKKMFKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			get
			{
				return default(NGMBJNEPNLE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x90A3CA0", Offset = "0x90A22A0", VA = "0x1890A3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GDDDFHAAGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x90A3CB0", Offset = "0x90A22B0", VA = "0x1890A3CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string ADHDHLKBBGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x90A3CF0", Offset = "0x90A22F0", VA = "0x1890A3CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GFCIJGNDGEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x90A3CD0", Offset = "0x90A22D0", VA = "0x1890A3CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x90A3390", Offset = "0x90A1990", VA = "0x1890A3390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90A3AB0", Offset = "0x90A20B0", VA = "0x1890A3AB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x90A3390", Offset = "0x90A1990", VA = "0x1890A3390")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x90A3BA0", Offset = "0x90A21A0", VA = "0x1890A3BA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90A3950", Offset = "0x90A1F50", VA = "0x1890A3950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90A35D0", Offset = "0x90A1BD0", VA = "0x1890A35D0")]
		private void HKNEHPNHNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x90A3380", Offset = "0x90A1980", VA = "0x1890A3380")]
		private void ALMICEOKCKB(Scene PDFMOBOALJB, LoadSceneMode JDJJDFOGKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90A39F0", Offset = "0x90A1FF0", VA = "0x1890A39F0")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90A36C0", Offset = "0x90A1CC0", VA = "0x1890A36C0")]
		private Camera JACGIDMJALJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x90A3AC0", Offset = "0x90A20C0", VA = "0x1890A3AC0")]
		public void UpdateCameraCache(bool AKANBAOKNIH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90A3430", Offset = "0x90A1A30", VA = "0x1890A3430")]
		private static Camera DODPEBJJCKO(int OLHEPLFLOGL, Camera[] JLPCDCKMOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90A33A0", Offset = "0x90A19A0", VA = "0x1890A33A0")]
		private static Camera BDMBODPNOPH(int OLHEPLFLOGL, Camera[] JLPCDCKMOPE, string BBLDJOHEJKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x90A3530", Offset = "0x90A1B30", VA = "0x1890A3530")]
		private static Camera FICFNPNPJPF(int OLHEPLFLOGL, Camera[] JLPCDCKMOPE, string DJFMCHMDHGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x90A3BC0", Offset = "0x90A21C0", VA = "0x1890A3BC0")]
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
		private int NHPPJCMFFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ALNOHBKOHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int HANHOILDAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int ENEHABGLKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] HJLEGMBDJIF;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x90A4220", Offset = "0x90A2820", VA = "0x1890A4220")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x90A3F30", Offset = "0x90A2530", VA = "0x1890A3F30")]
		private void HOCFAHCGAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90A3F50", Offset = "0x90A2550", VA = "0x1890A3F50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x90A4240", Offset = "0x90A2840", VA = "0x1890A4240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x90A3D10", Offset = "0x90A2310", VA = "0x1890A3D10")]
		private float[] FJFHNNCOGHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90A42E0", Offset = "0x90A28E0", VA = "0x1890A42E0")]
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
		private const int NIDCMBNBLDP = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] PEIJCAMFPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] JBCPNFFGKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int OJJIOAKIJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle BANFEABPKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int NPHIBBBLCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int HPILFFKACFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object OLKFHOHOGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool NIPHHJIHAHL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] NMIEOGGCANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MMDPHDIINNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F10", Offset = "0xAA0510", VA = "0x180AA1F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr JILMPDDJIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x90A4D90", Offset = "0x90A3390", VA = "0x1890A4D90")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int JIOMCFIIPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xEAD280", Offset = "0xEAB880", VA = "0x180EAD280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int BBBMADAGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x90A4DA0", Offset = "0x90A33A0", VA = "0x1890A4DA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int EKFJMFOBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x90A4650", Offset = "0x90A2C50", VA = "0x1890A4650", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xFE2890", Offset = "0xFE0E90", VA = "0x180FE2890", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x90A4BF0", Offset = "0x90A31F0", VA = "0x1890A4BF0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x90A4640", Offset = "0x90A2C40", VA = "0x1890A4640", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x90A4B40", Offset = "0x90A3140", VA = "0x1890A4B40", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90A4A50", Offset = "0x90A3050", VA = "0x1890A4A50", Slot = "13")]
		public override IntPtr ReadData([Out] int FODNOPLPBPI)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90A42F0", Offset = "0x90A28F0", VA = "0x1890A42F0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90A4390", Offset = "0x90A2990", VA = "0x1890A4390")]
		private void OnAudioFilterRead(float[] DAJAOHIJHHL, int FPJPLDGHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90A4CD0", Offset = "0x90A32D0", VA = "0x1890A4CD0")]
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
		private int LDHFFOCADDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool NOCOGMIBKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> MCDFFAEBHHE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase MGALAAFKLLM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int BBBMADAGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x90A4DA0", Offset = "0x90A33A0", VA = "0x1890A4DA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int EKFJMFOBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x90A4F50", Offset = "0x90A3550", VA = "0x1890A4F50", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x90A4DB0", Offset = "0x90A33B0", VA = "0x1890A4DB0")]
		private NativeArray<float> EPKAGEKEOPC(int FODNOPLPBPI)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		private void FNIKHFEKBLJ(NativeArray<float> COEFMBJKIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x90A4F70", Offset = "0x90A3570", VA = "0x1890A4F70", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x90A5080", Offset = "0x90A3680", VA = "0x1890A5080", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x90A4F00", Offset = "0x90A3500", VA = "0x1890A4F00", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x90A50E0", Offset = "0x90A36E0", VA = "0x1890A50E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
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
		private const int NIDCMBNBLDP = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] PEIJCAMFPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] JBCPNFFGKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int EHAOEMALAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int HILNPMHPDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle BANFEABPKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int NPHIBBBLCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool LIPAKGBDINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int EKHJFPINAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int HPILFFKACFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object OLKFHOHOGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool GAJKGDANADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool NIPHHJIHAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int DKFIGKGBCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int KKDPINFIFHJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> HPCDNJLGMPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OCHMMAMIGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA99260", Offset = "0xA97860", VA = "0x180A99260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] NMIEOGGCANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int MMDPHDIINNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr JILMPDDJIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x90A6520", Offset = "0x90A4B20", VA = "0x1890A6520")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int JIOMCFIIPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x130D2A0", Offset = "0x130B8A0", VA = "0x18130D2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int BBBMADAGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x90A4DA0", Offset = "0x90A33A0", VA = "0x1890A4DA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int EKFJMFOBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB19E90", Offset = "0xB18490", VA = "0x180B19E90", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x90A5FD0", Offset = "0x90A45D0", VA = "0x1890A5FD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x90A57D0", Offset = "0x90A3DD0", VA = "0x1890A57D0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90A5DE0", Offset = "0x90A43E0", VA = "0x1890A5DE0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90A61B0", Offset = "0x90A47B0", VA = "0x1890A61B0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x90A57C0", Offset = "0x90A3DC0", VA = "0x1890A57C0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x90A5D20", Offset = "0x90A4320", VA = "0x1890A5D20", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90A5BD0", Offset = "0x90A41D0", VA = "0x1890A5BD0", Slot = "13")]
		public override IntPtr ReadData([Out] int FODNOPLPBPI)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90A52B0", Offset = "0x90A38B0", VA = "0x1890A52B0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x90A5350", Offset = "0x90A3950", VA = "0x1890A5350")]
		public void OnAudioFilterReadCombiner(float[] DAJAOHIJHHL, int FPJPLDGHLOG, bool NGNLHFONEKO, int LGGEJMJANBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90A51D0", Offset = "0x90A37D0", VA = "0x1890A51D0")]
		private float[] ANGKLDFGGLC(float[] DAJAOHIJHHL, int AEJBGLBCEOG, int LOECGKDGAPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90A6460", Offset = "0x90A4A60", VA = "0x1890A6460")]
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
		public CaptureBase MGALAAFKLLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int BBBMADAGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int EKFJMFOBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90A6530", Offset = "0x90A4B30", VA = "0x1890A6530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
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
		private sealed class LLHLPKAGODE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public LLHLPKAGODE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x90B6900", Offset = "0x90B4F00", VA = "0x1890B6900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x90B69A0", Offset = "0x90B4FA0", VA = "0x1890B69A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PFCMJOCMMFN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public PFCMJOCMMFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x90B69F0", Offset = "0x90B4FF0", VA = "0x1890B69F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x90B6E00", Offset = "0x90B5400", VA = "0x1890B6E00", Slot = "8")]
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
		private RenderTexture DGLMDGINMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture JLBOICBGEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr DFBKEOEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture IDLBMAAIMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture LHBJGHMJPNF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector LGOOCCGBGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBA81E0", Offset = "0xBA67E0", VA = "0x180BA81E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC11190", Offset = "0xC0F790", VA = "0x180C11190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool LIPPJCHCOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2552080", Offset = "0x2550680", VA = "0x182552080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2699900", Offset = "0x2697F00", VA = "0x182699900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x90AE9A0", Offset = "0x90ACFA0", VA = "0x1890AE9A0")]
		public void SetCamera(Camera PIGKDOJICBF, bool ABPBNCEHKIL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x90AE950", Offset = "0x90ACF50", VA = "0x1890AE950")]
		public void SetCamera(Camera PIGKDOJICBF, Camera[] HPPCIMFKMJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x90AD3F0", Offset = "0x90AB9F0", VA = "0x1890AD3F0")]
		private bool BFLBJGAFMEJ(Texture BHNOPLHICEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x90AD590", Offset = "0x90ABB90", VA = "0x1890AD590")]
		private bool HHIKNCCDMIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x90AD4D0", Offset = "0x90ABAD0", VA = "0x1890AD4D0")]
		private bool BHDNCGDHHAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x90AEBF0", Offset = "0x90AD1F0", VA = "0x1890AEBF0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x90AD730", Offset = "0x90ABD30", VA = "0x1890AD730")]
		[IteratorStateMachine(typeof(LLHLPKAGODE))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x90AD500", Offset = "0x90ABB00", VA = "0x1890AD500")]
		[IteratorStateMachine(typeof(PFCMJOCMMFN))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x90AD5F0", Offset = "0x90ABBF0", VA = "0x1890AD5F0")]
		private bool MDFELALKLGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x90AD7B0", Offset = "0x90ABDB0", VA = "0x1890AD7B0")]
		private void OGAABBNOPAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x90AEAC0", Offset = "0x90AD0C0", VA = "0x1890AEAC0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x90ADBE0", Offset = "0x90AC1E0", VA = "0x1890ADBE0")]
		private void OPHKKHDLNEP(int JCJCKGHEDMK, int PDKDGENFDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC20070", Offset = "0xC1E670", VA = "0x180C20070", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90ADEC0", Offset = "0x90AC4C0", VA = "0x1890ADEC0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90ADDB0", Offset = "0x90AC3B0", VA = "0x1890ADDB0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90AED80", Offset = "0x90AD380", VA = "0x1890AED80")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90AD580", Offset = "0x90ABB80", VA = "0x1890AD580")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void FCJJCDDHANE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum HHFNEPILDHN
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
		private sealed class DCJKOAAABJG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public DCJKOAAABJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x90B6600", Offset = "0x90B4C00", VA = "0x1890B6600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x90B6670", Offset = "0x90B4C70", VA = "0x1890B6670", Slot = "8")]
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
		private GGJJLJJKDCG _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private CJLMPNMBJBF _cubemapDepth;

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
		private FLNPEBMLIOK _stereoRendering;

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
		private RenderTexture PPCLDEBOPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] PJOLIPKHPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material PFHKHHAOONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material PJPNIPGEIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture ECOHGCJNECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture KBKLGBIEKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr DFBKEOEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int OEHPGCCHDPP;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector LGOOCCGBGCE
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBA81E0", Offset = "0xBA67E0", VA = "0x180BA81E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC11190", Offset = "0xC0F790", VA = "0x180C11190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public GGJJLJJKDCG OKONKGHKOFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xBA8580", Offset = "0xBA6B80", VA = "0x180BA8580")]
			get
			{
				return default(GGJJLJJKDCG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x90AD3A0", Offset = "0x90AB9A0", VA = "0x1890AD3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CJLMPNMBJBF MNONHGDAIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x90AD350", Offset = "0x90AB950", VA = "0x1890AD350")]
			get
			{
				return default(CJLMPNMBJBF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x90AD390", Offset = "0x90AB990", VA = "0x1890AD390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool DPNKLFGEANO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2552080", Offset = "0x2550680", VA = "0x182552080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2699900", Offset = "0x2697F00", VA = "0x182699900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EAHDFIHKOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x90AD380", Offset = "0x90AB980", VA = "0x1890AD380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x90AD3E0", Offset = "0x90AB9E0", VA = "0x1890AD3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ABJOJFFBMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x90AD360", Offset = "0x90AB960", VA = "0x1890AD360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x90AD3B0", Offset = "0x90AB9B0", VA = "0x1890AD3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool EONJGMMFPJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x90AD370", Offset = "0x90AB970", VA = "0x1890AD370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x90AD3C0", Offset = "0x90AB9C0", VA = "0x1890AD3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public FLNPEBMLIOK HAHKLCBHNHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x28FEA90", Offset = "0x28FD090", VA = "0x1828FEA90")]
			get
			{
				return default(FLNPEBMLIOK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x90AD3D0", Offset = "0x90AB9D0", VA = "0x1890AD3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float HLJELNCDIJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x13B3DA0", Offset = "0x13B23A0", VA = "0x1813B3DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x13B3F50", Offset = "0x13B2550", VA = "0x1813B3F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x90AD280", Offset = "0x90AB880", VA = "0x1890AD280")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x90A9470", Offset = "0x90A7A70", VA = "0x1890A9470")]
		private HHFNEPILDHN IPJLHNPKEBA()
		{
			return default(HHFNEPILDHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC0ED10", Offset = "0xC0D310", VA = "0x180C0ED10")]
		public void SetCamera(Camera GBGEPBILLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x90AD110", Offset = "0x90AB710", VA = "0x1890AD110", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x90AB200", Offset = "0x90A9800", VA = "0x1890AB200")]
		[IteratorStateMachine(typeof(DCJKOAAABJG))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x90A94A0", Offset = "0x90A7AA0", VA = "0x1890A94A0")]
		private void MGALAAFKLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x90A9200", Offset = "0x90A7800", VA = "0x1890A9200")]
		private static void HKJNEDDFMDE(RenderTexture BHNOPLHICEP, Color ONDGBPEOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x90A8DB0", Offset = "0x90A73B0", VA = "0x1890A8DB0")]
		private void FANCFPKHFBF(RenderTexture FDAMOLLONCL, RenderTexture LKEAKCADNOO, bool DOKOAEAIPIK, Quaternion NEOIPHFFLHF, bool EOCAFCOONFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x90AB280", Offset = "0x90A9880", VA = "0x1890AB280")]
		private void OGAABBNOPAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x90A97F0", Offset = "0x90A7DF0", VA = "0x1890A97F0")]
		private void MPKBOCCNLIM(Camera GBGEPBILLFN, RenderTexture JACGGFJMNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x90A9390", Offset = "0x90A7990", VA = "0x1890A9390")]
		private void IAPIOPGFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x90ABB00", Offset = "0x90AA100", VA = "0x1890ABB00", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x90A91C0", Offset = "0x90A77C0", VA = "0x1890A91C0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x90ACF10", Offset = "0x90AB510", VA = "0x1890ACF10", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x90AB830", Offset = "0x90A9E30", VA = "0x1890AB830", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x90B6E50", Offset = "0x90B5450", VA = "0x1890B6E50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KBAADPNBIHI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public KBAADPNBIHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x90B6840", Offset = "0x90B4E40", VA = "0x1890B6840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x90B68B0", Offset = "0x90B4EB0", VA = "0x1890B68B0", Slot = "8")]
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
		private int OAMNFKOOOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int OALFNPJALDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform FHNKNBIPFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera PKPOBBMKNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera KFLOPFHDAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera JDOOJLJOPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera FGHEMKMDHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture CNBINAMEMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr DFBKEOEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material HFAPEJDJMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int MHNMMPALHAG;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings OJBDAEJKGJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBA81E0", Offset = "0xBA67E0", VA = "0x180BA81E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x90A8CA0", Offset = "0x90A72A0", VA = "0x1890A8CA0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x90A89A0", Offset = "0x90A6FA0", VA = "0x1890A89A0")]
		public void SetCamera(Camera GBGEPBILLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x90A89D0", Offset = "0x90A6FD0", VA = "0x1890A89D0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x90A7170", Offset = "0x90A5770", VA = "0x1890A7170")]
		private Camera OPNOEHAEEAO(Camera GBGEPBILLFN, string PFCLLCPDKHK, float HPELFBDPPOP, float FPJCLPAHDIM, int ICKPELMDJBM, int EPGJOCOOIBI, float FIOODFIIGBM, float LKALHBEFAMA, int NHAMNEAKCAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x90A8B10", Offset = "0x90A7110", VA = "0x1890A8B10", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x90A7040", Offset = "0x90A5640", VA = "0x1890A7040")]
		[IteratorStateMachine(typeof(KBAADPNBIHI))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90A6D50", Offset = "0x90A5350", VA = "0x1890A6D50")]
		private void MGALAAFKLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x90A6C70", Offset = "0x90A5270", VA = "0x1890A6C70")]
		private void IAPIOPGFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x90A65D0", Offset = "0x90A4BD0", VA = "0x1890A65D0")]
		private void IAPIHBJENKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x90A6590", Offset = "0x90A4B90", VA = "0x1890A6590", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x90A7A00", Offset = "0x90A6000", VA = "0x1890A7A00", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x90A70C0", Offset = "0x90A56C0", VA = "0x1890A70C0")]
		private static void OJEPOAKMKOL(Camera GBGEPBILLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x90A77C0", Offset = "0x90A5DC0", VA = "0x1890A77C0", Slot = "6")]
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
		private sealed class EANEMKLCIBA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public EANEMKLCIBA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x90B66C0", Offset = "0x90B4CC0", VA = "0x1890B66C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x90B67F0", Offset = "0x90B4DF0", VA = "0x1890B67F0", Slot = "8")]
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
		private IntPtr DFBKEOEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture JLBOICBGEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer EJBCBNCDGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator HLPNMAEKOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool HLOFJLPGODL;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ENEJCIOCIHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBBE320", Offset = "0xBBC920", VA = "0x180BBE320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBB9BB0", Offset = "0xBB81B0", VA = "0x180BB9BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor JKPICDHMOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBA81D0", Offset = "0xBA67D0", VA = "0x180BA81D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC0ED10", Offset = "0xC0D310", VA = "0x180C0ED10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x90AF3B0", Offset = "0x90AD9B0", VA = "0x1890AF3B0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x90AEF60", Offset = "0x90AD560", VA = "0x1890AEF60")]
		private void PMCLIKLEJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x90AEE00", Offset = "0x90AD400", VA = "0x1890AEE00")]
		private void DIGJLDANFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x90AF7C0", Offset = "0x90ADDC0", VA = "0x1890AF7C0", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x90AEEE0", Offset = "0x90AD4E0", VA = "0x1890AEEE0")]
		[IteratorStateMachine(typeof(EANEMKLCIBA))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x90AF910", Offset = "0x90ADF10", VA = "0x1890AF910", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x90AF940", Offset = "0x90ADF40", VA = "0x1890AF940")]
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
		private sealed class AGLJNHBKJPJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public AGLJNHBKJPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x90A0D10", Offset = "0x909F310", VA = "0x1890A0D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x90A0D80", Offset = "0x909F380", VA = "0x1890A0D80", Slot = "8")]
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
		private Texture GCPOAKPILMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture JLBOICBGEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr DFBKEOEHMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool CMBODNHLNLP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LOBFDEALFDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBBE320", Offset = "0xBBC920", VA = "0x180BBE320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBB9BB0", Offset = "0xBB81B0", VA = "0x180BB9BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xC0ED10", Offset = "0xC0D310", VA = "0x180C0ED10")]
		public void SetSourceTexture(Texture BHNOPLHICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x90AF9B0", Offset = "0x90ADFB0", VA = "0x1890AF9B0")]
		private bool BFLBJGAFMEJ(Texture BHNOPLHICEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x90B0A40", Offset = "0x90AF040", VA = "0x1890B0A40")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x90AFA90", Offset = "0x90AE090", VA = "0x1890AFA90")]
		private bool CEOAKCFIFNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90B0210", Offset = "0x90AE810", VA = "0x1890B0210")]
		private bool NPKMOHEKFMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90B0990", Offset = "0x90AEF90", VA = "0x1890B0990", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x90B0230", Offset = "0x90AE830", VA = "0x1890B0230")]
		[IteratorStateMachine(typeof(AGLJNHBKJPJ))]
		private IEnumerator OEDOHHKGIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x90AFCB0", Offset = "0x90AE2B0", VA = "0x1890AFCB0")]
		private void MGALAAFKLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x90B02B0", Offset = "0x90AE8B0", VA = "0x1890B02B0")]
		private void OPHKKHDLNEP(int JCJCKGHEDMK, int PDKDGENFDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x90AFC00", Offset = "0x90AE200", VA = "0x1890AFC00")]
		private void IAPIOPGFDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x90AFB00", Offset = "0x90AE100", VA = "0x1890AFB00", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x90B0440", Offset = "0x90AEA40", VA = "0x1890B0440", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x90B0880", Offset = "0x90AEE80", VA = "0x1890B0880", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x90B0A50", Offset = "0x90AF050", VA = "0x1890B0A50")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x90B0AC0", Offset = "0x90AF0C0", VA = "0x1890B0AC0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x90B0A50", Offset = "0x90AF050", VA = "0x1890B0A50")]
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
		private enum NDGDNAKJMBB
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
		private AudioListener AKKIOJHGGLF;

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
		private static readonly string[] HOJGGAPDBDI;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] KIBHHGDLHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private NDGDNAKJMBB GENHFGOMFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] FFNENMMGPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] HAMLMCCECPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] CCKLFLIMPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] IDOEABPBGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] NAHMEKNJPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] LAOCOCEEHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] MALKEJAIAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int BHOPMBIGNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle HBLOLJADDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int ACDKCMBIENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 OCOPMEMDMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 IAMHOGHDJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 LCHPJPJHHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 DNOEHGHPAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long EOHGIEMEEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float IBADONKGAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float LEPJDDMIMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint LOJLBDLBGHO;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase GIPEJOHAMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool OIPGMKGHFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF65250", Offset = "0xF63850", VA = "0x180F65250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xF65260", Offset = "0xF63860", VA = "0x180F65260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool AGHAIAMMPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x90B5740", Offset = "0x90B3D40", VA = "0x1890B5740")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x90B4510", Offset = "0x90B2B10", VA = "0x1890B4510")]
		private void NMDOOJFBFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x90B4DF0", Offset = "0x90B33F0", VA = "0x1890B4DF0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x90B1FC0", Offset = "0x90B05C0", VA = "0x1890B1FC0")]
		private void EHDLMBCPKDP(int JIEJOKBHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x90B0B30", Offset = "0x90AF130", VA = "0x1890B0B30")]
		private void CODFJBKMCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x90B5310", Offset = "0x90B3910", VA = "0x1890B5310")]
		private void PFHOIDDAGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x90B4480", Offset = "0x90B2A80", VA = "0x1890B4480")]
		private void MNOPPNIJFNF(string IAFDMJDNHDH, string DFKKOPOBCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x90B4220", Offset = "0x90B2820", VA = "0x1890B4220")]
		private void FCPIMFGNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x90B43F0", Offset = "0x90B29F0", VA = "0x1890B43F0")]
		private void KJMHBCMOEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x90B42F0", Offset = "0x90B28F0", VA = "0x1890B42F0")]
		private void HFIIJEHFFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x90B4370", Offset = "0x90B2970", VA = "0x1890B4370")]
		private void HKMNFPACJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x90B56C0", Offset = "0x90B3CC0", VA = "0x1890B56C0")]
		private void PKMDACPMOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x90B57B0", Offset = "0x90B3DB0", VA = "0x1890B57B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x90B6020", Offset = "0x90B4620", VA = "0x1890B6020")]
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
		private RenderTexture HHCHHNACLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture LFCHPLKCFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material MALINNPLPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material CGBAFJJJMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int DHBELJFMFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int JGMALJLHEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int FKOLKOFKANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool MIFDGBBCOBA;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int NJLFCOOAGNL;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int OMBGEAIDNEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float BOLLCFDPGHI;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool KIPAAALKJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x130D1D0", Offset = "0x130B7D0", VA = "0x18130D1D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x17BE2D0", Offset = "0x17BC8D0", VA = "0x1817BE2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int GAKLAAABDJG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x90CCF10", Offset = "0x90CB510", VA = "0x1890CCF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int AECKHLKAKIM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture MIKOMKKAENC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x90CC510", Offset = "0x90CAB10", VA = "0x1890CC510")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x90CCEC0", Offset = "0x90CB4C0", VA = "0x1890CCEC0")]
		public void SetTargetSize(int JCJCKGHEDMK, int PDKDGENFDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x90CCEE0", Offset = "0x90CB4E0", VA = "0x1890CCEE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x90CCC20", Offset = "0x90CB220", VA = "0x1890CCC20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x90CC6E0", Offset = "0x90CACE0", VA = "0x1890CC6E0")]
		private void OJBDAEJKGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x90CC680", Offset = "0x90CAC80", VA = "0x1890CC680")]
		private void GEAGFEFHMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x90CCA40", Offset = "0x90CB040", VA = "0x1890CCA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x90CCC80", Offset = "0x90CB280", VA = "0x1890CCC80")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x85BB520", Offset = "0x85B9B20", VA = "0x1885BB520")]
		private static float ODLEHCPICPD(float IAFDMJDNHDH, float DFKKOPOBCBA, float IHNLGGEEIFC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x90CC5A0", Offset = "0x90CABA0", VA = "0x1890CC5A0")]
		private void BKDOKEHDAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x90CC3F0", Offset = "0x90CA9F0", VA = "0x1890CC3F0")]
		public void Accumulate(Texture JHGKHIGHBBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x90CCD50", Offset = "0x90CB350", VA = "0x1890CCD50")]
		private void OnRenderImage(RenderTexture JHGKHIGHBBL, RenderTexture BDHPLBBJNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x90CCEF0", Offset = "0x90CB4F0", VA = "0x1890CCEF0")]
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
		private GUIContent HLEHOCCLJKG;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x90CD150", Offset = "0x90CB750", VA = "0x1890CD150")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x90CD090", Offset = "0x90CB690", VA = "0x1890CD090")]
		public void SetTexture(Texture2D BHNOPLHICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x90CCF20", Offset = "0x90CB520", VA = "0x1890CCF20")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x90CD210", Offset = "0x90CB810", VA = "0x1890CD210")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> PAIDKGKGPNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x90D0880", Offset = "0x90CEE80", VA = "0x1890D0880")]
		private void OnAudioFilterRead(float[] DAJAOHIJHHL, int FPJPLDGHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum JBPNFIADGMP
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class EFDGBPILLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector DFOHBNCKGFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode NCLKDGBALNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool MJBEJPLEMOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool GNCIIBOPCJO;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
			internal EFDGBPILLLA(PlayableDirector JIJCAMHPEHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x90C3710", Offset = "0x90C1D10", VA = "0x1890C3710")]
			internal bool DICCAIDOMPH(PlayableDirector JIJCAMHPEHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x90C3770", Offset = "0x90C1D70", VA = "0x1890C3770")]
			internal void FCPIMFGNGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x90C3870", Offset = "0x90C1E70", VA = "0x1890C3870")]
			internal void KJMHBCMOEFM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private JBPNFIADGMP _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<EFDGBPILLLA> MBCFDOPABDO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public JBPNFIADGMP DJDEKKMFKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(JBPNFIADGMP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x90D1240", Offset = "0x90CF840", VA = "0x1890D1240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x90D08C0", Offset = "0x90CEEC0", VA = "0x1890D08C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x90D08C0", Offset = "0x90CEEC0", VA = "0x1890D08C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x90D0E70", Offset = "0x90CF470", VA = "0x1890D0E70")]
		internal void PDAOFPOMEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x90D08D0", Offset = "0x90CEED0", VA = "0x1890D08D0")]
		internal void FCPIMFGNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x90D0BE0", Offset = "0x90CF1E0", VA = "0x1890D0BE0")]
		internal void KJMHBCMOEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90D0E80", Offset = "0x90CF480", VA = "0x1890D0E80")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90D0DC0", Offset = "0x90CF3C0", VA = "0x1890D0DC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90D0AF0", Offset = "0x90CF0F0", VA = "0x1890D0AF0")]
		private void HKNEHPNHNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x90D08B0", Offset = "0x90CEEB0", VA = "0x1890D08B0")]
		private void ALMICEOKCKB(Scene PDFMOBOALJB, LoadSceneMode JDJJDFOGKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90D11B0", Offset = "0x90CF7B0", VA = "0x1890D11B0")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int JIOMCFIIPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int BBBMADAGCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int EKFJMFOBHIL
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
		[Cpp2IlInjected.Address(RVA = "0x90D1820", Offset = "0x90CFE20", VA = "0x1890D1820", Slot = "13")]
		public virtual IntPtr ReadData([Out] int FODNOPLPBPI)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x90D1700", Offset = "0x90CFD00", VA = "0x1890D1700")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x90D1690", Offset = "0x90CFC90", VA = "0x1890D1690")]
		private static int GDBAAFNAPPH(AudioSpeakerMode JDJJDFOGKAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum DPGHCMJIGEM
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class BHIPOFEFIPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer MJOAJCGFBEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool GNCIIBOPCJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool MJBEJPLEMOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool HLMBJNHJNFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double BMOPCKDEKAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float KIDFGFNHNKC;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
			internal BHIPOFEFIPE(VideoPlayer DMEGJALPIDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x90B70E0", Offset = "0x90B56E0", VA = "0x1890B70E0")]
			internal bool DICCAIDOMPH(VideoPlayer DMEGJALPIDL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x90B75E0", Offset = "0x90B5BE0", VA = "0x1890B75E0")]
			internal void FCPIMFGNGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x90B7B80", Offset = "0x90B6180", VA = "0x1890B7B80")]
			internal bool HCAKMGCKLBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x90B7140", Offset = "0x90B5740", VA = "0x1890B7140")]
			internal void DIDOJCPACGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x90B7040", Offset = "0x90B5640", VA = "0x1890B7040")]
			private void DCNHMPOPAEI(VideoPlayer LBHNPIBFMBH, long PLKPFEKJAPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x90B7C60", Offset = "0x90B6260", VA = "0x1890B7C60")]
			private void KCBCHLDGBIL(VideoPlayer LBHNPIBFMBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x90B7BC0", Offset = "0x90B61C0", VA = "0x1890B7BC0")]
			internal void IEMCEPDMPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x90B7660", Offset = "0x90B5C60", VA = "0x1890B7660")]
			internal bool FLHPFKIPOFF(float KNMJNADDDID)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x90B7D60", Offset = "0x90B6360", VA = "0x1890B7D60")]
			internal void KJMHBCMOEFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class ELLKDPMGODB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public ELLKDPMGODB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x90C3940", Offset = "0x90C1F40", VA = "0x1890C3940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x90C3AB0", Offset = "0x90C20B0", VA = "0x1890C3AB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private DPGHCMJIGEM _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<BHIPOFEFIPE> BJEKGDPOFEP;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DPGHCMJIGEM DJDEKKMFKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(DPGHCMJIGEM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x90D2710", Offset = "0x90D0D10", VA = "0x1890D2710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x90D1950", Offset = "0x90CFF50", VA = "0x1890D1950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x90D1950", Offset = "0x90CFF50", VA = "0x1890D1950")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x90D21A0", Offset = "0x90D07A0", VA = "0x1890D21A0")]
		internal void PDAOFPOMEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x90D1960", Offset = "0x90CFF60", VA = "0x1890D1960")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x90D2070", Offset = "0x90D0670", VA = "0x1890D2070")]
		[IteratorStateMachine(typeof(ELLKDPMGODB))]
		internal IEnumerator OIJELDEOCMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90D1AD0", Offset = "0x90D00D0", VA = "0x1890D1AD0")]
		internal void FCPIMFGNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x90D1EE0", Offset = "0x90D04E0", VA = "0x1890D1EE0")]
		internal void KJMHBCMOEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x90D22E0", Offset = "0x90D08E0", VA = "0x1890D22E0")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x90D20F0", Offset = "0x90D06F0", VA = "0x1890D20F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x90D1C80", Offset = "0x90D0280", VA = "0x1890D1C80")]
		private void HKNEHPNHNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90D1940", Offset = "0x90CFF40", VA = "0x1890D1940")]
		private void ALMICEOKCKB(Scene PDFMOBOALJB, LoadSceneMode JDJJDFOGKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x90D2680", Offset = "0x90D0C80", VA = "0x1890D2680")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x90D1D70", Offset = "0x90D0370", VA = "0x1890D1D70")]
		[CompilerGenerated]
		private bool IJGAEPLOBGP()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum ALEAIDEBAIP
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	First = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Second,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Third
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum EMBKDCOEMGF
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ACN_SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum FIPOGPHKAAM
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ACN
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum MHGDENPJEEA
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OMPMOPKELKB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum KAMOAMOOLNO
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
	public enum MNPKDGJGFED
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
	public enum LFIBMBOBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		CaptureFrameBuffer,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeResources,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Setup
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static string[] NDHGDMMICCH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly string[] JABEMKGCBDH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string[] LFNILMPAIMC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly string[] LHLDOJFKCII;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static readonly string[] DKODEPJKFLN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly string[] NMEKIIHFPAK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly string[] AONCFODGGNN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static IntPtr AFJNLPAAOBF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static IntPtr IPJKEIKDEFI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private static IntPtr CNPHNHNEMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x90CE900", Offset = "0x90CCF00", VA = "0x1890CE900")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private static IntPtr NNJEPNCAAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x90CDC60", Offset = "0x90CC260", VA = "0x1890CDC60")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x90CF630", Offset = "0x90CDC30", VA = "0x1890CF630")]
	public static extern IntPtr NFGLNFGOOHB(int HAGEAFMGLEN);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x90CF5B0", Offset = "0x90CDBB0", VA = "0x1890CF5B0")]
	public static extern void NFBFELKJPPP(IntPtr PLKOLLOCKHK);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x90CE040", Offset = "0x90CC640", VA = "0x1890CE040")]
	public static extern void HFLFNDIKAJL(IntPtr PLKOLLOCKHK, float FMHPONPDIJG, float KANBFLNLIAF, ALEAIDEBAIP OGFNFILHJOI, FIPOGPHKAAM KAJENIDGKID, float[] GHJFOKKKIJH);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x90CE220", Offset = "0x90CC820", VA = "0x1890CE220")]
	public static extern void IJEIFCDKIKD(IntPtr PLKOLLOCKHK, float[] JGMMJEDNPNK, int BNNCFPNFEDD, int BPEHFEFIPND, int AJMNBNHNNIC, float[] IAJKNGJEGFC, int DOFCBAMLBDI, int PHLPBPGHHGN, ALEAIDEBAIP OGFNFILHJOI);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x90CDD90", Offset = "0x90CC390", VA = "0x1890CDD90")]
	public static string FBEILAANMHN(MNPKDGJGFED IGKOIFGGODF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x90CF030", Offset = "0x90CD630", VA = "0x1890CF030")]
	public static void MCHEGGCLFGA(LFIBMBOBDFL MHKDGGILNGE, int IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x90CDE60", Offset = "0x90CC460", VA = "0x1890CDE60")]
	private static extern IntPtr FBNPAGDKNBJ();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x90CD840", Offset = "0x90CBE40", VA = "0x1890CD840")]
	private static extern IntPtr DHEMPGJNNAM();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x90CFAF0", Offset = "0x90CE0F0", VA = "0x1890CFAF0")]
	public static extern bool PNHKIAJGEDI();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x90CD8B0", Offset = "0x90CBEB0", VA = "0x1890CD8B0")]
	public static extern void DLIHAMJBKBP();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x90CEC10", Offset = "0x90CD210", VA = "0x1890CEC10")]
	public static string LDMGLCCJEEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x90CED60", Offset = "0x90CD360", VA = "0x1890CED60")]
	public static bool LGNMENKIKNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x90CDF60", Offset = "0x90CC560", VA = "0x1890CDF60")]
	public static extern int GGEOKGLGMAG();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x90CE420", Offset = "0x90CCA20", VA = "0x1890CE420")]
	public static extern bool JOIGJMPKEJB(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x90CE880", Offset = "0x90CCE80", VA = "0x1890CE880")]
	public static extern KLBHDCMNABO KKPLENABGEN(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x90CF8D0", Offset = "0x90CDED0", VA = "0x1890CF8D0")]
	public static extern void OPJEGBJJHEA(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x90CDAE0", Offset = "0x90CC0E0", VA = "0x1890CDAE0")]
	public static string DNHNNPPLHIN(int HPEEKEICEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x90CF370", Offset = "0x90CD970", VA = "0x1890CF370")]
	public static extern int MKNJAMPNAHH();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x90CF530", Offset = "0x90CDB30", VA = "0x1890CF530")]
	public static extern bool NEKNADABJNP(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x90CD410", Offset = "0x90CBA10", VA = "0x1890CD410")]
	public static extern KLBHDCMNABO CLFANGGJNOL(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x90CF9D0", Offset = "0x90CDFD0", VA = "0x1890CF9D0")]
	public static extern void PCPBPOIHBJC(int HPEEKEICEKK);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x90CEEB0", Offset = "0x90CD4B0", VA = "0x1890CEEB0")]
	public static string LOMOGJLMIMP(int HPEEKEICEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x90CDFD0", Offset = "0x90CC5D0", VA = "0x1890CDFD0")]
	public static extern int GNNLFJLMEAP();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x90CD560", Offset = "0x90CBB60", VA = "0x1890CD560")]
	public static string CMNNAHMMDHB(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x90CEA30", Offset = "0x90CD030", VA = "0x1890CEA30")]
	public static extern KLBHDCMNABO LCHONPNFLGJ(int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x90CE580", Offset = "0x90CCB80", VA = "0x1890CE580")]
	public static string[] KBFLEBIEOEP(int MOAEJIGKGJF, int MJPJHDMKGMA = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x90CD6E0", Offset = "0x90CBCE0", VA = "0x1890CD6E0")]
	public static extern int DENAJANANGD(string LIMCNPKEPJF, uint JCJCKGHEDMK, uint PDKDGENFDGI, float AIEKFOBKHNC, int IENFMLICFPK, bool OPOJEIMNPCD, bool BIEGPBKNHEE, int MOAEJIGKGJF, JIFEIELAHML FDHHMJDPGCH, int IMDCHBODLCM, int PDJAKLOEBHK, int PHLOHMAFIEK, int MJPJHDMKGMA, bool KKJCBFHDGKL, VideoEncoderHints AKIMDDEIGDG);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x90CE750", Offset = "0x90CCD50", VA = "0x1890CE750")]
	public static extern int KDKCKDFPIIM(string LIMCNPKEPJF, uint JCJCKGHEDMK, uint PDKDGENFDGI, float AIEKFOBKHNC, int IENFMLICFPK, bool OPOJEIMNPCD, bool BIEGPBKNHEE, int MEOFFKIINEN, bool KKJCBFHDGKL, int GCJFNJIGMIP, ImageEncoderHints AKIMDDEIGDG);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x90CD920", Offset = "0x90CBF20", VA = "0x1890CD920")]
	public static extern int DMJHGFEEPAC(string LIMCNPKEPJF, uint JCJCKGHEDMK, uint PDKDGENFDGI, float AIEKFOBKHNC, int IENFMLICFPK, bool BIEGPBKNHEE, int GNPLDEFCHFK, bool KKJCBFHDGKL);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x90CE3A0", Offset = "0x90CC9A0", VA = "0x1890CE3A0")]
	public static extern bool JKGHENBEODP(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x90CF740", Offset = "0x90CDD40", VA = "0x1890CF740")]
	public static extern bool NNJLLBCBOPL(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x90CF6B0", Offset = "0x90CDCB0", VA = "0x1890CF6B0")]
	public static extern int NHEPLJNCELA(int IINGFCBPPPE, uint CBFJBBJDMAJ);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x90CDED0", Offset = "0x90CC4D0", VA = "0x1890CDED0")]
	public static extern void FGGNBDIGEEA(int IINGFCBPPPE, IntPtr DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x90CD280", Offset = "0x90CB880", VA = "0x1890CD280")]
	public static extern void ABCKJDLOBLI(int IINGFCBPPPE, IntPtr DAJAOHIJHHL, uint FODNOPLPBPI);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA50", Offset = "0x90CE050", VA = "0x1890CFA50")]
	public static extern void PHEJECGJBBC(int IINGFCBPPPE, IntPtr EBHKNIFFGHK, IntPtr CGFMINAMLCP, uint OCPAGGDJLNK);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x90CF950", Offset = "0x90CDF50", VA = "0x1890CF950")]
	public static extern void PCEOJEMCNIE(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x90CF3E0", Offset = "0x90CD9E0", VA = "0x1890CF3E0")]
	public static extern void MNEFMGBPPHF(int IINGFCBPPPE, bool CLOBDOCNNFH);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x90CECE0", Offset = "0x90CD2E0", VA = "0x1890CECE0")]
	public static extern bool LGFAACJEDGF(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	public static bool OPDCPHDMGPF(int IINGFCBPPPE, StringBuilder HFDCCKNJMMJ, int FODNOPLPBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x90CF7C0", Offset = "0x90CDDC0", VA = "0x1890CF7C0")]
	public static extern void ODEKNBMNLBF(int IINGFCBPPPE, IntPtr BHNOPLHICEP);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x90CE320", Offset = "0x90CC920", VA = "0x1890CE320")]
	public static extern void JDDEGPNJJAP(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x90CE1A0", Offset = "0x90CC7A0", VA = "0x1890CE1A0")]
	public static extern uint IDHIIHLENBE(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x90CF2F0", Offset = "0x90CD8F0", VA = "0x1890CF2F0")]
	public static extern uint MKHPDFBJDLL(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x90CF850", Offset = "0x90CDE50", VA = "0x1890CF850")]
	public static extern uint OJDOLBKDKPM(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x90CD390", Offset = "0x90CB990", VA = "0x1890CD390")]
	public static extern float BBAINKELCNK(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x90CE120", Offset = "0x90CC720", VA = "0x1890CE120")]
	public static extern uint HLCPEEAIHOF(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x90CFB60", Offset = "0x90CE160", VA = "0x1890CFB60")]
	public static extern uint PPBKOGPGKLA(int IINGFCBPPPE);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x90CD320", Offset = "0x90CB920", VA = "0x1890CD320")]
	private static extern IntPtr BAHAONCCFFJ();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x90CDA10", Offset = "0x90CC010", VA = "0x1890CDA10")]
	private static extern bool DNHNNPPLHIN(int LEPAEEGOBDO, StringBuilder DJFMCHMDHGK, int LINIPMBFBEK);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x90CEDE0", Offset = "0x90CD3E0", VA = "0x1890CEDE0")]
	private static extern bool LOMOGJLMIMP(int LEPAEEGOBDO, StringBuilder DJFMCHMDHGK, int LINIPMBFBEK);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x90CD490", Offset = "0x90CBA90", VA = "0x1890CD490")]
	private static extern bool CMNNAHMMDHB(int LEPAEEGOBDO, StringBuilder DJFMCHMDHGK, int LINIPMBFBEK);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x90CE4A0", Offset = "0x90CCAA0", VA = "0x1890CE4A0")]
	private static extern bool KBFLEBIEOEP(int MOAEJIGKGJF, int MJPJHDMKGMA, StringBuilder AOLCJGHLEJP, int EIACMJCGEGI);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x90CF470", Offset = "0x90CDA70", VA = "0x1890CF470")]
	private static extern bool NDJPNKAPFKM(string BKGGOFLGLFB, [Out] ulong JJCAHKKJFGL, [Out] ulong CIJAOHCIHDH, [Out] ulong DGGCFOCJEEC);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x90CEAB0", Offset = "0x90CD0B0", VA = "0x1890CEAB0")]
	public static bool LCOLHKILENB(string JKCPEHCGLIK, [Out] ulong NCMOHOAIBBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MEOEFMCGLOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct GEGBLMBOGHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public float FMHPONPDIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float KANBFLNLIAF;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x90C3EA0", Offset = "0x90C24A0", VA = "0x1890C3EA0")]
		public void FHMLNCEAAFC(Vector3 AANGPKCDGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static float[] BIBECAOKEJP;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static float[] MHFDENCPIDA;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x90CBC80", Offset = "0x90CA280", VA = "0x1890CBC80")]
	public static float[] GLADLLKMHEH(MHGDENPJEEA CDKEAAOBFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x90CC290", Offset = "0x90CA890", VA = "0x1890CC290")]
	public static int KBAALOAEJIH(ALEAIDEBAIP OGFNFILHJOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x90CC280", Offset = "0x90CA880", VA = "0x1890CC280")]
	public static FIPOGPHKAAM HEMLMLONABF(EMBKDCOEMGF IENFMLICFPK)
	{
		return default(FIPOGPHKAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x90CC280", Offset = "0x90CA880", VA = "0x1890CC280")]
	public static MHGDENPJEEA LAPGFPLHCMM(EMBKDCOEMGF IENFMLICFPK)
	{
		return default(MHGDENPJEEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x90CC360", Offset = "0x90CA960", VA = "0x1890CC360")]
	static MEOEFMCGLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x90CBD00", Offset = "0x90CA300", VA = "0x1890CBD00")]
	private static float[] HCFMOBIHBFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x90CC2C0", Offset = "0x90CA8C0", VA = "0x1890CC2C0")]
	private static int LOBEOLADHJL(int NMEGFNHDCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x90CBC20", Offset = "0x90CA220", VA = "0x1890CBC20")]
	private static int FEIBPDLNLDD(int NMEGFNHDCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x90CC340", Offset = "0x90CA940", VA = "0x1890CC340")]
	private static int NJPPNAKHLOO(int POMPNNDHCKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x90CB8C0", Offset = "0x90C9EC0", VA = "0x1890CB8C0")]
	private static float DHFPMNBOBBJ(int NMEGFNHDCHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x90CBAB0", Offset = "0x90CA0B0", VA = "0x1890CBAB0")]
	private static float DHFPMNBOBBJ(int IODKHMMPFHJ, int PFCMAMCIDIC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x90CBFD0", Offset = "0x90CA5D0", VA = "0x1890CBFD0")]
	private static float[] HDGNIKJLOOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HOAHICOJLFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private uint IJLGJBLINKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private uint PIFPOAOIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private uint MAAAEGEBGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float LDNHKKHJEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private uint MCHAABPGKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private uint INAFOINFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private ulong NMLDHPOIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int FHNOPIKFBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JIFEIELAHML PJIDGEMADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int LGHMCIPHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private int LDHFFOCADDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float DDKHMIPMMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int INJHAJCJKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private int DHBELJFMFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private float MEEDMOHKPGC;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BDFFGGHGONO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5D9C0", Offset = "0xD5BFC0", VA = "0x180D5D9C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public uint OAPGGAPGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public uint CHMHMBCFMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB91EF0", Offset = "0xB904F0", VA = "0x180B91EF0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public uint FPGFJPICGGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float CKONDAPOCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEBD6A0", Offset = "0xEBBCA0", VA = "0x180EBD6A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	internal uint OCPMHJEKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	internal uint EIMMLFPNEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JIFEIELAHML GIOOEDKELPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAD6F80", Offset = "0xAD5580", VA = "0x180AD6F80")]
		get
		{
			return default(JIFEIELAHML);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAD6580", Offset = "0xAD4B80", VA = "0x180AD6580")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int DBMKMDFNDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xED8000", Offset = "0xED6600", VA = "0x180ED8000")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int NMJINKBEIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB3890", Offset = "0xAB1E90", VA = "0x180AB3890")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1745450", Offset = "0x1743A50", VA = "0x181745450")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x90C5340", Offset = "0x90C3940", VA = "0x1890C5340")]
	internal void LPGJGNDKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x90C52F0", Offset = "0x90C38F0", VA = "0x1890C52F0")]
	internal void BMFBKMPNPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x78DC580", Offset = "0x78DAB80", VA = "0x1878DC580")]
	public HOAHICOJLFE()
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
		public enum HIBAICBHPEH
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
		public EDBBHPKPBLN injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public FLNPEBMLIOK stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public EDBBHPKPBLN injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public CIHLBBNEKFM sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public HIBAICBHPEH colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public FDMMBKFPKBE transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public HKPENMAKCAD androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public KICOKLPNGEM colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public PANPKIMLECE realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public NHACPEBBMFL orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x90D18D0", Offset = "0x90CFED0", VA = "0x1890D18D0")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90D1870", Offset = "0x90CFE70", VA = "0x1890D1870")]
		public void GLPLHJLPNHN()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum LNOAGLJCANP
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
		public LNOAGLJCANP colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public FDMMBKFPKBE transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public HKPENMAKCAD androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x90C6780", Offset = "0x90C4D80", VA = "0x1890C6780")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x90C6760", Offset = "0x90C4D60", VA = "0x1890C6760")]
		public void GLPLHJLPNHN()
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
		[Cpp2IlInjected.Address(RVA = "0x90C3C80", Offset = "0x90C2280", VA = "0x1890C3C80")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x90C3B60", Offset = "0x90C2160", VA = "0x1890C3B60")]
		public void GLPLHJLPNHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum CIPFENMJBLH
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
		public enum CJLMPNMBJBF
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum GGJJLJJKDCG
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
		public enum IEGGPDBIMDI
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
		public enum LHEDDEIGHHD
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
		public enum EGHHAPICBEH
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string GIPFPPMJNCN = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

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
		private JEJKDLIPLGM _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private OKEIIKJJJME _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private CBFLMEOLLMG _stopMode;

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
		private EGHHAPICBEH _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private IEGGPDBIMDI _downScale;

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
		private JIFEIELAHML _audioCaptureSource;

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
		protected BOAELONNIHO _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const LHEDDEIGHHD DefaultOutputFolderType = LHEDDEIGHHD.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string NGJGNOPHJOO = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private LHEDDEIGHHD _outputFolderType;

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
		private BINJGCDHBGE _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private BINJGCDHBGE _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private BINJGCDHBGE _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private BINJGCDHBGE _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected CIPFENMJBLH _renderResolution;

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
		protected Texture2D CLBCKCBCLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int ABKOHNNGKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int DFOFMIBNMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int BNPIJJOBAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int JGMALJLHEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int FKOLKOFKANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool LIPAKGBDINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19D")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool NIPHHJIHAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string LJOINKELGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string NDBNBNFDAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo CPGEPMNJJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected OMPMOPKELKB.MNPKDGJGFED EBCILNFDHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private BGLECGHCLFN MKAMEJACMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private BGLECGHCLFN BINLKKIIFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CCBJJGPOJKB BMCBHAGFDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int PEKCPFNGKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float ENNMLPMPOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool NDFANMFEBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool CEBGAOEJCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E2")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool AELOMNMNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E3")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool OJDMFBDCCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float BBLJBDMIBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float DLPGJOEEGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float LPJLCCKDJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction JFJINILIFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long IKJGNNMKALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected FDMMBKFPKBE CGFCIABEPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture HMBPFDOMKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material BNIADLCAFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float OFMAMECJGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool GJCOKCEGIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<HDJPBNOFHLN> PFCPKJCFBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<HDJPBNOFHLN> GLELFOAMJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<HDJPBNOFHLN> PJDFANDNBML;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> NDMBAIAIOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent DECAADDKCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent AOLOGPGDOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private HOAHICOJLFE NLGJBCAKIOK;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool IFDBEPECFLF;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool ENDCCMLPMLC;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public BOAELONNIHO DLHEHEMOKOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x17608F0", Offset = "0x175EEF0", VA = "0x1817608F0")]
			get
			{
				return default(BOAELONNIHO);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x175FF80", Offset = "0x175E580", VA = "0x18175FF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public LHEDDEIGHHD LBPFJKHFHEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xBFB370", Offset = "0xBF9970", VA = "0x180BFB370")]
			get
			{
				return default(LHEDDEIGHHD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF88C0", VA = "0x180BFA2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string BCBJFLNOMMM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB30CF0", Offset = "0xB2F2F0", VA = "0x180B30CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xB2A480", Offset = "0xB28A80", VA = "0x180B2A480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string ONCJIMOIIHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xB24920", Offset = "0xB22F20", VA = "0x180B24920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB2CB50", Offset = "0xB2B150", VA = "0x180B2CB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool PBBBHJAKNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xB24910", Offset = "0xB22F10", VA = "0x180B24910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4DE70", Offset = "0xB4C470", VA = "0x180B4DE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool FPCLDFBLDCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x222DC40", Offset = "0x222C240", VA = "0x18222DC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x222CB00", Offset = "0x222B100", VA = "0x18222CB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string GFKNGKIKGPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB26510", Offset = "0xB24B10", VA = "0x180B26510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB24E40", Offset = "0xB23440", VA = "0x180B24E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string JGFPLDPBADG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAFB5F0", Offset = "0xAF9BF0", VA = "0x180AFB5F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xB26970", Offset = "0xB24F70", VA = "0x180B26970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool HNBJGGAMPHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB57FF0", Offset = "0xB565F0", VA = "0x180B57FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBBE2B0", Offset = "0xBBC8B0", VA = "0x180BBE2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ADGPILCGGPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB26910", Offset = "0xB24F10", VA = "0x180B26910")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xB81660", Offset = "0xB7FC60", VA = "0x180B81660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int NKBEDIKKKDN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1830B80", Offset = "0x182F180", VA = "0x181830B80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x90C1F80", Offset = "0x90C0580", VA = "0x1890C1F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool APMPBBGMLIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x90C1EC0", Offset = "0x90C04C0", VA = "0x1890C1EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x90C2060", Offset = "0x90C0660", VA = "0x1890C2060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int NOKGCMGGJOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x104E950", Offset = "0x104CF50", VA = "0x18104E950")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x90C1FF0", Offset = "0x90C05F0", VA = "0x1890C1FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] AHCCKBAOJBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC0CC70", Offset = "0xC0B270", VA = "0x180C0CC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xD93260", Offset = "0xD91860", VA = "0x180D93260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur MJDAAIHPMIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC0F9A0", Offset = "0xC0DFA0", VA = "0x180C0F9A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBBC360", Offset = "0xBBA960", VA = "0x180BBC360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public FDMMBKFPKBE MAJFPDAGFBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xBA8510", Offset = "0xBA6B10", VA = "0x180BA8510")]
			get
			{
				return default(FDMMBKFPKBE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> CHPHOMGKLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x90C1DF0", Offset = "0x90C03F0", VA = "0x1890C1DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string HDPKKJNCLNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2F560", VA = "0x180B30F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent HOCFAHCGAHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xBA8200", Offset = "0xBA6800", VA = "0x180BA8200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent AKCFJEKMGNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBA8220", Offset = "0xBA6820", VA = "0x180BA8220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<HDJPBNOFHLN> BBNPBHGFMCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBC1AF0", Offset = "0xBC00F0", VA = "0x180BC1AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBB92A0", Offset = "0xBB78A0", VA = "0x180BB92A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<HDJPBNOFHLN> EAENDHIOAHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBC2B90", Offset = "0xBC1190", VA = "0x180BC2B90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xBBE0C0", Offset = "0xBBC6C0", VA = "0x180BBE0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public CIPFENMJBLH KEKJPFGCOJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2388B70", Offset = "0x2387170", VA = "0x182388B70")]
			get
			{
				return default(CIPFENMJBLH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x90C1F30", Offset = "0x90C0530", VA = "0x1890C1F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 KHFJCDIKGFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x90C1E40", Offset = "0x90C0440", VA = "0x1890C1E40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2729D90", Offset = "0x2728390", VA = "0x182729D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int DHCEKJABIAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x260EDA0", Offset = "0x260D3A0", VA = "0x18260EDA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x260A870", Offset = "0x2608E70", VA = "0x18260A870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool FAHOLHNGKGE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xFC0810", Offset = "0xFBEE10", VA = "0x180FC0810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFC0910", Offset = "0xFBEF10", VA = "0x180FC0910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool KCIIDEIEEBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xFC0ED0", Offset = "0xFBF4D0", VA = "0x180FC0ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E70", Offset = "0xFBF470", VA = "0x180FC0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public JIFEIELAHML GIOOEDKELPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB4F190", Offset = "0xB4D790", VA = "0x180B4F190")]
			get
			{
				return default(JIFEIELAHML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB4E860", Offset = "0xB4CE60", VA = "0x180B4E860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int MLMOAPHDEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F106E0", Offset = "0x1F0ECE0", VA = "0x181F106E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x283C890", Offset = "0x283AE90", VA = "0x18283C890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int KCBDKFMANEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB38A40", Offset = "0xB37040", VA = "0x180B38A40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xB38170", Offset = "0xB36770", VA = "0x180B38170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture PPPACLHINGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA9F130", Offset = "0xA9D730", VA = "0x180A9F130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xA9F160", Offset = "0xA9D760", VA = "0x180A9F160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int ENCOPONDJKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB56FA0", Offset = "0xB555A0", VA = "0x180B56FA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x90C1F40", Offset = "0x90C0540", VA = "0x1890C1F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float OKMGNLNHKGA
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x162AAC0", Offset = "0x16290C0", VA = "0x18162AAC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x90C1F50", Offset = "0x90C0550", VA = "0x1890C1F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public JEJKDLIPLGM HMLHPIFNKNN
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
			get
			{
				return default(JEJKDLIPLGM);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xB18030", Offset = "0xB16630", VA = "0x180B18030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public OKEIIKJJJME NGEOOFFEOCP
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xEAD280", Offset = "0xEAB880", VA = "0x180EAD280")]
			get
			{
				return default(OKEIIKJJJME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xFDBE70", Offset = "0xFDA470", VA = "0x180FDBE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float GKHJEGCDMEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAE7030", Offset = "0xAE5630", VA = "0x180AE7030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x90C2020", Offset = "0x90C0620", VA = "0x1890C2020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public CBFLMEOLLMG PACIGELEOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x14B8A00", Offset = "0x14B7000", VA = "0x1814B8A00")]
			get
			{
				return default(CBFLMEOLLMG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2330C10", Offset = "0x232F210", VA = "0x182330C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int GHHBBLEAKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x90C2030", Offset = "0x90C0630", VA = "0x1890C2030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float DLNJFNKAPFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x106F840", Offset = "0x106DE40", VA = "0x18106F840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x90C2040", Offset = "0x90C0640", VA = "0x1890C2040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool BNJLNIHDPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD59A60", Offset = "0xD58060", VA = "0x180D59A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD58D60", Offset = "0xD57360", VA = "0x180D58D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public HOAHICOJLFE AIJJBHNAFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xBA8210", Offset = "0xBA6810", VA = "0x180BA8210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] OOEGGLPLPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x90C20B0", Offset = "0x90C06B0", VA = "0x1890C20B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] HDOPMEMGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x90C2080", Offset = "0x90C0680", VA = "0x1890C2080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] JHDKDJOBACI
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x90C1F00", Offset = "0x90C0500", VA = "0x1890C1F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] DHMMNEIBDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x90C1ED0", Offset = "0x90C04D0", VA = "0x1890C1ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int OALJGNGMEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2FAA2B0", Offset = "0x2FA88B0", VA = "0x182FAA2B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x5CB1DC0", Offset = "0x5CB03C0", VA = "0x185CB1DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public EGHHAPICBEH NLHBPAPPHPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xF42860", Offset = "0xF40E60", VA = "0x180F42860")]
			get
			{
				return default(EGHHAPICBEH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xF406A0", Offset = "0xF3ECA0", VA = "0x180F406A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public IEGGPDBIMDI NOPBHILDMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xF42850", Offset = "0xF40E50", VA = "0x180F42850")]
			get
			{
				return default(IEGGPDBIMDI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF412B0", Offset = "0xF3F8B0", VA = "0x180F412B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JKFFLFLEEFD
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E0C0", Offset = "0x2A0C6C0", VA = "0x182A0E0C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7EC30", Offset = "0x2A7D230", VA = "0x182A7EC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool DDEBNJGBKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x10C4170", Offset = "0x10C2770", VA = "0x1810C4170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1886F90", Offset = "0x1885590", VA = "0x181886F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool ECFJFBDIOKP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8245250", Offset = "0x8243850", VA = "0x188245250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x90C2070", Offset = "0x90C0670", VA = "0x1890C2070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool HDOAOOFFOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B460", Offset = "0x2A19A60", VA = "0x182A1B460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2A1B9A0", Offset = "0x2A19FA0", VA = "0x182A1B9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool HDCNJBGJJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x164F690", Offset = "0x164DC90", VA = "0x18164F690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x164A350", Offset = "0x1648950", VA = "0x18164A350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool HEIOGGOKPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x90C1EB0", Offset = "0x90C04B0", VA = "0x1890C1EB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x90C2050", Offset = "0x90C0650", VA = "0x1890C2050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController PIFLIEEMBNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC1EF60", Offset = "0xC1D560", VA = "0x180C1EF60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB5A310", Offset = "0xB58910", VA = "0x180B5A310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController KLKJGGHBBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC045E0", Offset = "0xC02BE0", VA = "0x180C045E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1077560", Offset = "0x1075B60", VA = "0x181077560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public BGLECGHCLFN DFDLKBDGCIB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xC031A0", Offset = "0xC017A0", VA = "0x180C031A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public BGLECGHCLFN JFCNFIEIJCH
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xBA8520", Offset = "0xBA6B20", VA = "0x180BA8520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public CCBJJGPOJKB DCBKPOCNMOG
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB8AB80", Offset = "0xB89180", VA = "0x180B8AB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int PFENNONMADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA9EBE0", Offset = "0xA9D1E0", VA = "0x180A9EBE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA9EB80", Offset = "0xA9D180", VA = "0x180A9EB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int OFHBFIGLJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB66060", Offset = "0xB64660", VA = "0x180B66060")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x10B7CA0", Offset = "0x10B62A0", VA = "0x1810B7CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public BINJGCDHBGE GFGOBNCLLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1830B90", Offset = "0x182F190", VA = "0x181830B90")]
			get
			{
				return default(BINJGCDHBGE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x214C1B0", Offset = "0x214A7B0", VA = "0x18214C1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string GHOPHCANMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x90C1E60", Offset = "0x90C0460", VA = "0x1890C1E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x90C1FB0", Offset = "0x90C05B0", VA = "0x1890C1FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
		protected static OMPMOPKELKB.KAMOAMOOLNO PIBJCMGCNOB()
		{
			return default(OMPMOPKELKB.KAMOAMOOLNO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x90BA410", Offset = "0x90B8A10", VA = "0x1890BA410")]
		public EncoderHints GetEncoderHints(OMPMOPKELKB.KAMOAMOOLNO PJKNLKPIIFP = OMPMOPKELKB.KAMOAMOOLNO.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x90BF5D0", Offset = "0x90BDBD0", VA = "0x1890BF5D0")]
		public void SetEncoderHints(EncoderHints AKIMDDEIGDG, OMPMOPKELKB.KAMOAMOOLNO PJKNLKPIIFP = OMPMOPKELKB.KAMOAMOOLNO.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public static void UpdateMediaGallery(string CNFHMJNELKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x90B8030", Offset = "0x90B6630", VA = "0x1890B8030", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x90C0910", Offset = "0x90BEF10", VA = "0x1890C0910")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x90BFBF0", Offset = "0x90BE1F0", VA = "0x1890BFBF0", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x90BC910", Offset = "0x90BAF10", VA = "0x1890BC910")]
		private static bool PLELNIOBMMP(BGLECGHCLFN NPAKOGBPJIK, JILFKJBIHCO AIIMHMEDAJK, int EKKCMNNPJHK, string[] KLBKKEDHMKJ, KLBHDCMNABO NHDPMILMDNM, bool LFGFEPLJHHM, bool HHCEFEBPDAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x90BF2B0", Offset = "0x90BD8B0", VA = "0x1890BF2B0")]
		public BGLECGHCLFN SelectVideoCodec(bool BLBJIACPDMK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x90BEC10", Offset = "0x90BD210", VA = "0x1890BEC10")]
		public BGLECGHCLFN SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x90BEF80", Offset = "0x90BD580", VA = "0x1890BEF80")]
		public CCBJJGPOJKB SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x90BA580", Offset = "0x90B8B80", VA = "0x1890BA580")]
		public static Vector2 GetRecordingResolution(int JCJCKGHEDMK, int PDKDGENFDGI, IEGGPDBIMDI OJJFMGOCJLN, Vector2 MOJJKBOBLGJ)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x90BF1A0", Offset = "0x90BD7A0", VA = "0x1890BF1A0")]
		public void SelectRecordingResolution(int JCJCKGHEDMK, int PDKDGENFDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90BC4D0", Offset = "0x90BAAD0", VA = "0x1890BC4D0", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x90BC710", Offset = "0x90BAD10", VA = "0x1890BC710")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x90BBB60", Offset = "0x90BA160", VA = "0x1890BBB60")]
		private void OKHJNOGFMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x90BC480", Offset = "0x90BAA80", VA = "0x1890BC480")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x90BCBB0", Offset = "0x90BB1B0", VA = "0x1890BCBB0")]
		protected void PMIKADNPAKK(Texture2D BHNOPLHICEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x90BB2C0", Offset = "0x90B98C0", VA = "0x1890BB2C0")]
		protected bool LFPNHNPCJIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x90B9190", Offset = "0x90B7790", VA = "0x1890B9190")]
		protected bool EABHMPPIIGH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x90B9480", Offset = "0x90B7A80", VA = "0x1890B9480", Slot = "7")]
		public virtual void EncodePointer(IntPtr MOLHMKKLMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x90BAC00", Offset = "0x90B9200", VA = "0x1890BAC00")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x90BABE0", Offset = "0x90B91E0", VA = "0x1890BABE0")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x90BABF0", Offset = "0x90B91F0", VA = "0x1890BABF0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x90BA650", Offset = "0x90B8C50", VA = "0x1890BA650")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB30970", Offset = "0xB2EF70", VA = "0x180B30970")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x90BAEE0", Offset = "0x90B94E0", VA = "0x1890BAEE0", Slot = "8")]
		protected virtual string LCCOGJCHBGB(string FIAGCPBOPMK, string AOMDNPHPEHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x90B8E00", Offset = "0x90B7400", VA = "0x1890B8E00")]
		private static string DGNMODLKALK(LHEDDEIGHHD MPMGBIEMEOO, string JKCPEHCGLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x90B7E50", Offset = "0x90B6450", VA = "0x1890B7E50")]
		private static string AEKGJDHPOFJ(LHEDDEIGHHD MPMGBIEMEOO, string JKCPEHCGLIK, string LIMCNPKEPJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x90BBB20", Offset = "0x90BA120", VA = "0x1890BBB20")]
		protected static bool OJBCAMNGDCA(string JKCPEHCGLIK, string IHHHGNCFCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x90BBCC0", Offset = "0x90BA2C0", VA = "0x1890BBCC0")]
		protected void OPCFJDDJAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x90B9D90", Offset = "0x90B8390", VA = "0x1890B9D90")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool GDKHAECKLDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x90B9710", Offset = "0x90B7D10", VA = "0x1890B9710")]
		private bool FDGAFGEMFJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x90BCE70", Offset = "0x90BB470", VA = "0x1890BCE70", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x90BEAA0", Offset = "0x90BD0A0", VA = "0x1890BEAA0")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x16072B0", Offset = "0x16058B0", VA = "0x1816072B0")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x90BA240", Offset = "0x90B8840", VA = "0x1890BA240")]
		protected void GAAGGAEBEAC(FLNPEBMLIOK IODMGGHPAHK, CIHLBBNEKFM NGKBGFLHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x90BF670", Offset = "0x90BDC70", VA = "0x1890BF670")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x90BCC30", Offset = "0x90BB230", VA = "0x1890BCC30")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x90BEB20", Offset = "0x90BD120", VA = "0x1890BEB20")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x90B8DD0", Offset = "0x90B73D0", VA = "0x1890B8DD0")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x90B9080", Offset = "0x90B7680", VA = "0x1890B9080")]
		public static void DeleteCapture(BOAELONNIHO GNDEAKMJJMB, string JKCPEHCGLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x90BB6D0", Offset = "0x90B9CD0", VA = "0x1890BB6D0")]
		protected void MCHEGGCLFGA(OMPMOPKELKB.LFIBMBOBDFL MHKDGGILNGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x90BFCA0", Offset = "0x90BE2A0", VA = "0x1890BFCA0", Slot = "11")]
		public virtual void StopCapture(bool CLOBDOCNNFH = false, bool FEAHCPLPOOM = false, bool LDAEHKBKCBB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x90BC880", Offset = "0x90BAE80", VA = "0x1890BC880")]
		private static JFFKDMCCDHB.EMMKCKMKJOH PJHBNDOGELA(VideoEncoderHints AKIMDDEIGDG, string GADHGOPOLBF)
		{
			return default(JFFKDMCCDHB.EMMKCKMKJOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x90BA9E0", Offset = "0x90B8FE0", VA = "0x1890BA9E0")]
		private static bool IOBPJBNJGNM(string FJDLJPAACPO, VideoEncoderHints AKIMDDEIGDG, string GADHGOPOLBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x90BB910", Offset = "0x90B9F10", VA = "0x1890BB910")]
		protected void MHPHMEHNHFK(string FJDLJPAACPO, VideoEncoderHints AKIMDDEIGDG, string GADHGOPOLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x90B8D90", Offset = "0x90B7390", VA = "0x1890B8D90")]
		private void CJCOFOBAMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x90B8F60", Offset = "0x90B7560", VA = "0x1890B8F60")]
		private bool DIEBNDBFDHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x90B9200", Offset = "0x90B7800", VA = "0x1890B9200")]
		protected bool EMGFFMNHGKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x90C08B0", Offset = "0x90BEEB0", VA = "0x1890C08B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x90BB370", Offset = "0x90B9970", VA = "0x1890BB370")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x90B8910", Offset = "0x90B6F10", VA = "0x1890B8910")]
		private void BEDKHGIIMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x90BA7E0", Offset = "0x90B8DE0", VA = "0x1890BA7E0")]
		private void HBHMCMGPABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x90BBAF0", Offset = "0x90BA0F0", VA = "0x1890BBAF0")]
		protected bool NEPBGNJIKGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x90BC7A0", Offset = "0x90BADA0", VA = "0x1890BC7A0")]
		protected bool PFMNJGGAECK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x90BA4C0", Offset = "0x90B8AC0", VA = "0x1890BA4C0")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x90B96E0", Offset = "0x90B7CE0", VA = "0x1890B96E0")]
		protected float FBIDDBAAICM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x90BB730", Offset = "0x90B9D30", VA = "0x1890BB730")]
		protected bool MFFFANLPKKE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x90BA2D0", Offset = "0x90B88D0", VA = "0x1890BA2D0")]
		protected void GCPGHHBCLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x90BAC10", Offset = "0x90B9210", VA = "0x1890BAC10")]
		protected void JNDPKIGFFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xBC28C0", Offset = "0xBC0EC0", VA = "0x180BC28C0", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x90BAC60", Offset = "0x90B9260", VA = "0x1890BAC60")]
		protected void KOCMJGBBKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x90B93D0", Offset = "0x90B79D0", VA = "0x1890B93D0")]
		public void EncodeAudio(NativeArray<float> CGFMINAMLCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x90B92B0", Offset = "0x90B78B0", VA = "0x1890B92B0")]
		public void EncodeAudio(float[] CGFMINAMLCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x90BCD70", Offset = "0x90BB370", VA = "0x1890BCD70", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x90C04B0", Offset = "0x90BEAB0", VA = "0x1890C04B0", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x90B89D0", Offset = "0x90B6FD0", VA = "0x1890B89D0")]
		protected bool BHHLMHGKAKC(int JCJCKGHEDMK, int PDKDGENFDGI, bool AFMEEIKDAOA = false, int ELICALHFBBF = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x90BAD20", Offset = "0x90B9320", VA = "0x1890BAD20")]
		protected RenderTexture LAEEDPJDAAE(Texture DFIHMBNCPHF, bool AFMEEIKDAOA = false, int ELICALHFBBF = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x90BB340", Offset = "0x90B9940", VA = "0x1890BB340")]
		protected void LPGJGNDKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x90C0450", Offset = "0x90BEA50", VA = "0x1890C0450")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x90BA880", Offset = "0x90B8E80", VA = "0x1890BA880")]
		protected int HKFNJDDLOOD(Camera GBGEPBILLFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x90BA310", Offset = "0x90B8910", VA = "0x1890BA310")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x90BA660", Offset = "0x90B8C60", VA = "0x1890BA660")]
		public static void GetResolution(CIPFENMJBLH MBFKCEFNJOJ, int JCJCKGHEDMK, int PDKDGENFDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x90B8020", Offset = "0x90B6620", VA = "0x1890B8020")]
		protected static int ALGJNIMIEGI(int FKMNCAKIOFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x90C18E0", Offset = "0x90BFEE0", VA = "0x1890C18E0")]
		public CaptureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum KLBHDCMNABO
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
public enum AIGPAKBGFFG
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Audio
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BGLECGHCLFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private AIGPAKBGFFG JDLOFJPKCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private int CBJBFOFELBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private bool AEMPLANNKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private KLBHDCMNABO GMIMKGJGMJJ;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KLBHDCMNABO MICMGEANKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0", Slot = "6")]
		get
		{
			return default(KLBHDCMNABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JLOGPEPLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x90B6E80", Offset = "0x90B5480", VA = "0x1890B6E80")]
	public void EIHLDHJJHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x90B6FE0", Offset = "0x90B55E0", VA = "0x1890B6FE0")]
	internal BGLECGHCLFN(AIGPAKBGFFG GMINJKNNGHK, int LEPAEEGOBDO, string DJFMCHMDHGK, KLBHDCMNABO DADIDJBJHDH, bool MCKMPFKEDOL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JILFKJBIHCO : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private BGLECGHCLFN[] CHKJMGJPFDP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public BGLECGHCLFN[] PIGANELJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x292D5F0", Offset = "0x292BBF0", VA = "0x18292D5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x90CB850", Offset = "0x90C9E50", VA = "0x1890CB850")]
	internal JILFKJBIHCO(BGLECGHCLFN[] DEDBHIANMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x90CB750", Offset = "0x90C9D50", VA = "0x1890CB750")]
	public BGLECGHCLFN CMGDPNIEGPI(string DJFMCHMDHGK, KLBHDCMNABO DAGMLHEEPMN = KLBHDCMNABO.Unknown)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x90CB7F0", Offset = "0x90C9DF0", VA = "0x1890CB7F0")]
	public BGLECGHCLFN NOHGAPPKNBP(KLBHDCMNABO DADIDJBJHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A21710", Offset = "0x2A1FD10", VA = "0x182A21710", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HKLGLONIOEN
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static bool KJNNIDMDOAO;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static JILFKJBIHCO JAOICJDKAAA;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static JILFKJBIHCO PLAGOHOBHHB;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public static JILFKJBIHCO ACNCHBCJNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x90C47C0", Offset = "0x90C2DC0", VA = "0x1890C47C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static JILFKJBIHCO IGPADIKHICK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x90C4760", Offset = "0x90C2D60", VA = "0x1890C4760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x90C5090", Offset = "0x90C3690", VA = "0x1890C5090")]
	private static void NFCIGPECNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x90C4820", Offset = "0x90C2E20", VA = "0x1890C4820")]
	private static void NDFLFFLHPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum EMBLMMAKIKI
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	AudioInput
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CCBJJGPOJKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private EMBLMMAKIKI IMAJEFNIJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private int CBJBFOFELBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private string KHEFOKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private KLBHDCMNABO GMIMKGJGMJJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAAE0", Offset = "0xAE90E0", VA = "0x180AEAAE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public KLBHDCMNABO MICMGEANKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830", Slot = "6")]
		get
		{
			return default(KLBHDCMNABO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x90B7DF0", Offset = "0x90B63F0", VA = "0x1890B7DF0")]
	internal CCBJJGPOJKB(EMBLMMAKIKI HOCBDMFPGLM, int LEPAEEGOBDO, string DJFMCHMDHGK, KLBHDCMNABO DADIDJBJHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class ONENPIJMDBJ : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private CCBJJGPOJKB[] NAIJOAAKDNF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public CCBJJGPOJKB[] FLJJCCIOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x292D5F0", Offset = "0x292BBF0", VA = "0x18292D5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x90D0810", Offset = "0x90CEE10", VA = "0x1890D0810")]
	internal ONENPIJMDBJ(CCBJJGPOJKB[] GEDFNCICMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x90D07B0", Offset = "0x90CEDB0", VA = "0x1890D07B0")]
	public CCBJJGPOJKB NOHGAPPKNBP(KLBHDCMNABO DADIDJBJHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A21710", Offset = "0x2A1FD10", VA = "0x182A21710", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IPLPEPHMGEN
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private static bool KJNNIDMDOAO;

	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private static ONENPIJMDBJ KNKOGBHKAGB;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static ONENPIJMDBJ JEIKNJBALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x90C6570", Offset = "0x90C4B70", VA = "0x1890C6570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x90C64D0", Offset = "0x90C4AD0", VA = "0x1890C64D0")]
	private static void NFCIGPECNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x90C6090", Offset = "0x90C4690", VA = "0x1890C6090")]
	private static void IFKJGALLLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HDJPBNOFHLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum AHJOLGGPOPO
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
	private string ADPLMLBGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private int ABKOHNNGKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private bool JCGAHEBDFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private BOAELONNIHO HDLPCHPAHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private JFFKDMCCDHB.EMMKCKMKJOH KLPGOKCMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ManualResetEvent EHAGEGHMDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private AHJOLGGPOPO CFCIFPKDACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private string NDBNBNFDAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool AAGJIODEDFK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal Action<HDJPBNOFHLN> EAENDHIOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA962E0", Offset = "0xA948E0", VA = "0x180A962E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x90C46E0", Offset = "0x90C2CE0", VA = "0x1890C46E0")]
	internal HDJPBNOFHLN(BOAELONNIHO GNDEAKMJJMB, string JKCPEHCGLIK, int IINGFCBPPPE, bool APFHAOACEHN, string GADHGOPOLBF, bool PKPIAPKGMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x90C4150", Offset = "0x90C2750", VA = "0x1890C4150")]
	internal void BMKEGNIPJED(JFFKDMCCDHB.EMMKCKMKJOH HDHFCLEKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x90C4460", Offset = "0x90C2A60", VA = "0x1890C4460")]
	private bool LFNPGODGIOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x90C3F90", Offset = "0x90C2590", VA = "0x1890C3F90")]
	public bool AMJIBBNANME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x90C4170", Offset = "0x90C2770", VA = "0x1890C4170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class JFFKDMCCDHB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct EMMKCKMKJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public bool CFOMNJGFKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public bool HKMJKELOCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public FLNPEBMLIOK CCFMDNBABEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public bool OIANIKOAICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public CIHLBBNEKFM NGKBGFLHIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public bool ABODGDKPFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string HBCNINDDPLJ;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x90C3B40", Offset = "0x90C2140", VA = "0x1890C3B40")]
		public bool LEBKHEECEOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x90C3B20", Offset = "0x90C2120", VA = "0x1890C3B20")]
		public bool GPCENGKHBGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x90C3B00", Offset = "0x90C2100", VA = "0x1890C3B00")]
		public void FEBNNOPIHOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GGENEFIDPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public uint JIEJOKBHEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public long MLMBLBFOLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public long EFCGAKGCCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public long EBKIKKEDHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public long NNGGDMCDEIA;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GGENEFIDPNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal enum OIGAKDDAHFF
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
	private sealed class FHPMGLHEBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public string filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public bool keepBackup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EMMKCKMKJOH options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ManualResetEvent syncEvent;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public FHPMGLHEBHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x90C3DB0", Offset = "0x90C23B0", VA = "0x1890C3DB0")]
		internal void EOEKDPAKFMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly uint FCNMDOHEDHN;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly uint CIJGHJBPBKN;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly uint EPJENKCIJJJ;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly uint BDNJBJMGAOH;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly uint CPLNJAIINLE;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly uint NNABHHHIMFC;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly uint IIJDMJDMHGH;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly uint ABHNDFKKAHO;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly uint ELAALNDBLFB;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly uint HCPFJNGBGID;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly uint JFAOPIABHNA;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly uint KKCBDOIEJDH;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly uint MGFNNIOLHIB;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly uint IGLNJBBHKLA;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly uint OANENPBCFHM;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly uint LAIJPDCPFJD;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly uint MPCJGHJPOIG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly uint LCAOFNLFIPI;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly uint MLIPEPEJJMB;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly uint MPAKHDNANHL;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly uint OONNAEMLAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private BinaryReader CFBGLBAGMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Stream HCMDCNJCMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private EMMKCKMKJOH NPBMNALNHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool KPKMHPJFCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<GGENEFIDPNL> LINNNDBMHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private List<GGENEFIDPNL> JOCOHEJNGNL;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x90C74F0", Offset = "0x90C5AF0", VA = "0x1890C74F0")]
	public static ManualResetEvent EPCCMHLALKI(string FJDLJPAACPO, bool LFIIKFGKOPK, EMMKCKMKJOH EEPOAHLOJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x90C82E0", Offset = "0x90C68E0", VA = "0x1890C82E0")]
	public static bool IPCNJDFKHJG(string FJDLJPAACPO, bool LFIIKFGKOPK, EMMKCKMKJOH EEPOAHLOJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x90C7FB0", Offset = "0x90C65B0", VA = "0x1890C7FB0")]
	public static bool IPCNJDFKHJG(string PDMMLIKIAEC, string LEEIKGGCKAG, EMMKCKMKJOH EEPOAHLOJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x90CB670", Offset = "0x90C9C70", VA = "0x1890CB670")]
	public JFFKDMCCDHB(EMMKCKMKJOH EEPOAHLOJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x90C68D0", Offset = "0x90C4ED0", VA = "0x1890C68D0")]
	public bool CHNAFCJOMPA(Stream EHBBODMPCDL, Stream LAGJHILJGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x90C7CE0", Offset = "0x90C62E0", VA = "0x1890C7CE0")]
	public void HBFHKNLBLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x90C9D00", Offset = "0x90C8300", VA = "0x1890C9D00")]
	private static GGENEFIDPNL MPDOOJAOACC(uint JIEJOKBHEMF, List<GGENEFIDPNL> GLLICPBENFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x90CA500", Offset = "0x90C8B00", VA = "0x1890CA500")]
	private List<GGENEFIDPNL> PBKJGPJKDMF(GGENEFIDPNL PMPNELDDGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x90CA350", Offset = "0x90C8950", VA = "0x1890CA350")]
	private List<GGENEFIDPNL> PBKJGPJKDMF(long ABPKOALGNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x90C7DD0", Offset = "0x90C63D0", VA = "0x1890C7DD0")]
	private GGENEFIDPNL HPNCGPKCAJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x90CA710", Offset = "0x90C8D10", VA = "0x1890CA710")]
	private bool PDGIJDJPCBH(GGENEFIDPNL MHJLEDKHHBE, uint JIEJOKBHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x90C76C0", Offset = "0x90C5CC0", VA = "0x1890C76C0")]
	private void GAPGOCLMHOP(GGENEFIDPNL MHJLEDKHHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x90C7480", Offset = "0x90C5A80", VA = "0x1890C7480")]
	private void EEEKHIPENIP(GGENEFIDPNL MHJLEDKHHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x90CA690", Offset = "0x90C8C90", VA = "0x1890CA690")]
	private void PCHKPJJDFFC(GGENEFIDPNL MHJLEDKHHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x90C67C0", Offset = "0x90C4DC0", VA = "0x1890C67C0")]
	private void AKKCFGNMBPN(long BIHDLLLGAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x90C9740", Offset = "0x90C7D40", VA = "0x1890C9740")]
	private void MFIGILGKJCF(long BIHDLLLGAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x90C8B80", Offset = "0x90C7180", VA = "0x1890C8B80")]
	private uint KMIOFFPCPDA(GGENEFIDPNL PMPNELDDGJM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x90C8990", Offset = "0x90C6F90", VA = "0x1890C8990")]
	private bool KEJHHPONBHA(GGENEFIDPNL GCCHJJOINNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x90C86F0", Offset = "0x90C6CF0", VA = "0x1890C86F0")]
	private void JHGJGJOHBBP(GGENEFIDPNL MHJLEDKHHBE, uint HGKBDJKCKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x90C7B30", Offset = "0x90C6130", VA = "0x1890C7B30")]
	private void GKJNFKDOPMA(GGENEFIDPNL MHJLEDKHHBE, uint HGKBDJKCKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x90C71B0", Offset = "0x90C57B0", VA = "0x1890C71B0")]
	private void DELPJPEOELE(GGENEFIDPNL MHJLEDKHHBE, uint HGKBDJKCKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x90C7330", Offset = "0x90C5930", VA = "0x1890C7330")]
	private uint EBMEFPBIGAI(GGENEFIDPNL MHJLEDKHHBE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x90C97F0", Offset = "0x90C7DF0", VA = "0x1890C97F0")]
	private uint MPCEMFGLKDH(GGENEFIDPNL MHJLEDKHHBE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x90CA870", Offset = "0x90C8E70", VA = "0x1890CA870")]
	private static OIGAKDDAHFF PJNEKJECPPO(FLNPEBMLIOK JDJJDFOGKAI)
	{
		return default(OIGAKDDAHFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x90CA070", Offset = "0x90C8670", VA = "0x1890CA070")]
	private uint OMIGBALIPAI(OIGAKDDAHFF CCFMDNBABEJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x90C9EF0", Offset = "0x90C84F0", VA = "0x1890C9EF0")]
	private uint OEHAGIIBIJI(CIHLBBNEKFM CGPBIADONIE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x90C91D0", Offset = "0x90C77D0", VA = "0x1890C91D0")]
	private uint LKEGABBHCCG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x90CA130", Offset = "0x90C8730", VA = "0x1890CA130")]
	private uint PBCNANPPAFC(string MOJDKPGCKHN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x90C7730", Offset = "0x90C5D30", VA = "0x1890C7730")]
	private uint GFHIJDFNEOE(CIHLBBNEKFM CGPBIADONIE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x90C9450", Offset = "0x90C7A50", VA = "0x1890C9450")]
	private uint LMPMFJJGKDG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x90C95C0", Offset = "0x90C7BC0", VA = "0x1890C95C0")]
	private uint MEPJAPHJFIF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x90C9E40", Offset = "0x90C8440", VA = "0x1890C9E40")]
	private void NPMLFHPHJCO(GGENEFIDPNL MHJLEDKHHBE, long MCPBDIMHFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x90C88F0", Offset = "0x90C6EF0", VA = "0x1890C88F0")]
	private ushort JKHHKGNBCCL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x90CA890", Offset = "0x90C8E90", VA = "0x1890CA890")]
	private uint PNPHKGBFFOF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x90C7110", Offset = "0x90C5710", VA = "0x1890C7110")]
	private ulong DALJKMJOAJP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x90CA9C0", Offset = "0x90C8FC0", VA = "0x1890CA9C0")]
	private void PPPMPACDCHJ(uint JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x90CA5D0", Offset = "0x90C8BD0", VA = "0x1890CA5D0")]
	private void PCFDOGNDHLO(uint FKMNCAKIOFK, bool PAECHAPLIJC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x90C8640", Offset = "0x90C6C40", VA = "0x1890C8640")]
	private void JGHGMFGIDFH(ulong FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x90CA930", Offset = "0x90C8F30", VA = "0x1890CA930")]
	private static uint PPIIDJNHKKB(string JIEJOKBHEMF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum EDBBHPKPBLN
{
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum JIFEIELAHML
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
public enum FLNPEBMLIOK
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum FDMMBKFPKBE
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
public enum CIHLBBNEKFM
{
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Equirectangular360,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Equirectangular180
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum CBFLMEOLLMG
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
public enum JEJKDLIPLGM
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Manual,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	OnStart
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum OKEIIKJJJME
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
public enum BINJGCDHBGE
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
public enum BOAELONNIHO
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	VideoFile,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	ImageSequence,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	NamedPipe
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum HKPENMAKCAD
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
public enum KICOKLPNGEM
{
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum PANPKIMLECE
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	Realtime,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Fixed,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	Nearest
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum NHACPEBBMFL
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
public class DHMFKJPBMLP
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static string[] KIBLJBLPCLJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static string[] OPCACDJAPFN;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static string[] BPJOJFHPODP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static string[] BNBGGBCBHEA;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x90C2EF0", Offset = "0x90C14F0", VA = "0x1890C2EF0")]
	public static string[] MFFDKCIEEFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x90C21B0", Offset = "0x90C07B0", VA = "0x1890C21B0")]
	public static RenderTextureFormat CEMBHMJMIHJ(bool BJJFCNFAGBE, bool IFCIOAFLDMJ, bool KBFKPOHNKCP)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x90C20E0", Offset = "0x90C06E0", VA = "0x1890C20E0")]
	public static bool BHDNCGDHHAD(Camera IHFKCIKKHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x90C26E0", Offset = "0x90C0CE0", VA = "0x1890C26E0")]
	public static Camera[] HPOLMCCNHAD(Camera IHFKCIKKHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x90C2F70", Offset = "0x90C1570", VA = "0x1890C2F70")]
	public static bool NIOOJBNNHMF(string GNONHKGIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x90C3090", Offset = "0x90C1690", VA = "0x1890C3090")]
	public static bool OFCHCDEIODE(string GNONHKGIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x90C2D00", Offset = "0x90C1300", VA = "0x1890C2D00")]
	public static bool LGLIJDKBOBJ(string CHLAGHOAIDF, [Out] ulong AKOJADPNHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x90C2C40", Offset = "0x90C1240", VA = "0x1890C2C40")]
	public static string JKKAFAMGBCN(BINJGCDHBGE IENFMLICFPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class IMANFEHLNPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum NBKPDNLIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		PCM16 = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Float32 = 4
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static byte[] COHKLBKNIGH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private static byte[] FOGDAFKMPCG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private static byte[] GMNINCMAJBL;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static byte[] LJLMFJNOJKA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private static byte[] AAKEGOOOPLJ;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private static byte[] KOCCNLMCPAF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private static byte[] KJGJLMGHJNF;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private const int IDADLMJNEIA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FileStream PBLEOPKACHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private byte[] IDPBOAFAHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private int ANCJEBKDAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private int FPBFAODPBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int CDJIOHKDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int EKHJFPINAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private NBKPDNLIBOH CODDFHHOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private int LPKMDDNCJBM;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x90C5F90", Offset = "0x90C4590", VA = "0x1890C5F90")]
	public IMANFEHLNPE(string JKCPEHCGLIK, int FPNDCHNJFNF, int LGGEJMJANBC, NBKPDNLIBOH NGHPJMOHMEM = NBKPDNLIBOH.Float32)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x90C5350", Offset = "0x90C3950", VA = "0x1890C5350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x90C53D0", Offset = "0x90C39D0", VA = "0x1890C53D0")]
	public void GGBAHALIJLC(float[] DAJAOHIJHHL, int JGGELGGFPJF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x90C5670", Offset = "0x90C3C70", VA = "0x1890C5670")]
	public void POKIHPHPNGH(int NAKOOEBMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x90C5560", Offset = "0x90C3B60", VA = "0x1890C5560")]
	private static byte[] ILEJMIKFNPA(int LBHNPIBFMBH, int FODNOPLPBPI = 2)
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
		[Cpp2IlInjected.Address(RVA = "0x90D2720", Offset = "0x90D0D20", VA = "0x1890D2720")]
		public void RunCoroutine(IEnumerator JLNMEONNLHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
