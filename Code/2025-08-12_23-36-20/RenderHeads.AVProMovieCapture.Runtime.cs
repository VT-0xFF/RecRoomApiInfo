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
		private Vector3 ONPCLHBMCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private KINFPLKNKJH JEEOPMIGFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private HHIMCJECHLD PKBDFACDMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CHGFEILFNCK IECHJNEOKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr HOBADPONPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int PFGIPCBDPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] PEKIHJIJCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> FAFMDEKNGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> EDLBGMDIJOG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD800", Offset = "0x8FAC600", VA = "0x188FAD800")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD580", Offset = "0x8FAC380", VA = "0x188FAD580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8FACC10", Offset = "0x8FABA10", VA = "0x188FACC10")]
		internal void OPKPDOIHOAP(KINFPLKNKJH MBIPCKLBHPE, HHIMCJECHLD HFKPJDGDCML, CHGFEILFNCK JJGHAGOKFIB, int ACLLMIKOCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD6E0", Offset = "0x8FAC4E0", VA = "0x188FAD6E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC8A0", Offset = "0x8FAB6A0", VA = "0x188FAC8A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC6D0", Offset = "0x8FAB4D0", VA = "0x188FAC6D0")]
		private void COFIHLAAAIJ(Vector3 FLAPAOJCDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC6F0", Offset = "0x8FAB4F0", VA = "0x188FAC6F0")]
		private void GDIKMNOOCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FACE00", Offset = "0x8FABC00", VA = "0x188FACE00")]
		private void OnAudioFilterRead(float[] KNIGABCLPKJ, int KMCPCDKHDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD980", Offset = "0x8FAC780", VA = "0x188FAD980")]
		internal void PBFALKKBJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8FACA00", Offset = "0x8FAB800", VA = "0x188FACA00")]
		internal int MIBMOICHDGM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FACA40", Offset = "0x8FAB840", VA = "0x188FACA40")]
		internal void NPFPLGAMJGK(bool OLECNJNIJPF, bool IIHAKCCDDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8FADBC0", Offset = "0x8FAC9C0", VA = "0x188FADBC0")]
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
		private KINFPLKNKJH _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private GGIKOOLMINL _format;

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
		private float[] HJDFMHCGNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private INDONAKNDCG JDOLBFMCIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> EECKHNAECOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int PLOFGCDBMHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KINFPLKNKJH IICMLMPBLOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
			get
			{
				return default(KINFPLKNKJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GGIKOOLMINL FIJDHCIEGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
			get
			{
				return default(GGIKOOLMINL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE420", Offset = "0x8FAD220", VA = "0x188FAE420")]
		internal void KKCALLHBDOH(AmbisonicSource MKPEOGPFEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE340", Offset = "0x8FAD140", VA = "0x188FAE340")]
		internal void JMJPJIKMPOO(AmbisonicSource MKPEOGPFEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE980", Offset = "0x8FAD780", VA = "0x188FAE980")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE120", Offset = "0x8FACF20", VA = "0x188FAE120")]
		private void DOOGLLICJBJ(AmbisonicSource MKPEOGPFEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE1D0", Offset = "0x8FACFD0", VA = "0x188FAE1D0")]
		private void EEBBPELEHFI(bool FILNGINHING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FADD00", Offset = "0x8FACB00", VA = "0x188FADD00")]
		private void CNFNBNCLJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE200", Offset = "0x8FAD000", VA = "0x188FAE200")]
		private void HLBLBCEKHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FADCE0", Offset = "0x8FACAE0", VA = "0x188FADCE0")]
		private bool BHOIFCIDKMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE680", Offset = "0x8FAD480", VA = "0x188FAE680")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE740", Offset = "0x8FAD540", VA = "0x188FAE740")]
		private void MABHOBJPAHO(bool IIHAKCCDDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE570", Offset = "0x8FAD370", VA = "0x188FAE570")]
		internal void KOGGGHMOJOH(float[] KNIGABCLPKJ, int BLJFLHLLHAB, bool IDMDBKBCKNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE300", Offset = "0x8FAD100", VA = "0x188FAE300")]
		private void ICODEBBKNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE990", Offset = "0x8FAD790", VA = "0x188FAE990")]
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
		private INDONAKNDCG JDOLBFMCIMO;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEAD0", Offset = "0x8FAD8D0", VA = "0x188FAEAD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEA90", Offset = "0x8FAD890", VA = "0x188FAEA90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEA60", Offset = "0x8FAD860", VA = "0x188FAEA60")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEC10", Offset = "0x8FADA10", VA = "0x188FAEC10")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum HLJAOIKEGNN
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
		public enum FHDOOKBLMLH
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
		private HLJAOIKEGNN _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private FHDOOKBLMLH _scanFrequency;

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
		private Camera[] JPOHNLJHIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int LMDPCMCLOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int CKOJFBJKIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool AECDHFOHHME;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera FFKNMKCLCGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF6D0", Offset = "0x8FAE4D0", VA = "0x188FAF6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HLJAOIKEGNN LPOLNLIODDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(HLJAOIKEGNN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF720", Offset = "0x8FAE520", VA = "0x188FAF720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public FHDOOKBLMLH EKJONLHCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			get
			{
				return default(FHDOOKBLMLH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF700", Offset = "0x8FAE500", VA = "0x188FAF700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HBLNHCNBAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF710", Offset = "0x8FAE510", VA = "0x188FAF710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string COFAMEGDOHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF750", Offset = "0x8FAE550", VA = "0x188FAF750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PGEBJPNAAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF730", Offset = "0x8FAE530", VA = "0x188FAF730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEDE0", Offset = "0x8FADBE0", VA = "0x188FAEDE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF510", Offset = "0x8FAE310", VA = "0x188FAF510")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEDE0", Offset = "0x8FADBE0", VA = "0x188FAEDE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF600", Offset = "0x8FAE400", VA = "0x188FAF600")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF3B0", Offset = "0x8FAE1B0", VA = "0x188FAF3B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEF00", Offset = "0x8FADD00", VA = "0x188FAEF00")]
		private void ENEPMOOPDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEEF0", Offset = "0x8FADCF0", VA = "0x188FAEEF0")]
		private void CMGHKNLCKJG(Scene OKCGKPEIJGC, LoadSceneMode KJLMJGOOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF450", Offset = "0x8FAE250", VA = "0x188FAF450")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF080", Offset = "0x8FADE80", VA = "0x188FAF080")]
		private Camera KHOOGHJJMLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF520", Offset = "0x8FAE320", VA = "0x188FAF520")]
		public void UpdateCameraCache(bool JFOJAINDKDE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEDF0", Offset = "0x8FADBF0", VA = "0x188FAEDF0")]
		private static Camera BPFJODOAAGJ(int MLAOOEFFIPE, Camera[] EMBBDGPFNAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEFF0", Offset = "0x8FADDF0", VA = "0x188FAEFF0")]
		private static Camera IFMLGFLJJIH(int MLAOOEFFIPE, Camera[] EMBBDGPFNAO, string MIBLFIHKNOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF310", Offset = "0x8FAE110", VA = "0x188FAF310")]
		private static Camera NAOAKDOAKBG(int MLAOOEFFIPE, Camera[] EMBBDGPFNAO, string PFLDDMDPCBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF620", Offset = "0x8FAE420", VA = "0x188FAF620")]
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
		private int GBKDLBKKEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int BDAEDFJECDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int NMAPPELODEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int ACBMAJCGCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] PMKNEBNOLBJ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFC80", Offset = "0x8FAEA80", VA = "0x188FAFC80")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF990", Offset = "0x8FAE790", VA = "0x188FAF990")]
		private void ILFKJINGIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF9B0", Offset = "0x8FAE7B0", VA = "0x188FAF9B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFCA0", Offset = "0x8FAEAA0", VA = "0x188FAFCA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF770", Offset = "0x8FAE570", VA = "0x188FAF770")]
		private float[] IDGINIHHOFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFD40", Offset = "0x8FAEB40", VA = "0x188FAFD40")]
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
		private const int OPILLIIJPJG = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] NNABGJIGEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] OIOLJNFNEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int NBMKAKIAHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle APCDCCGDHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int KFIPJEGHOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int FFBJBIFEBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object AMAEJMDPEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool CIHDGNHIEIJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] GEGOAEGAOON
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int BGMNEGJKLHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr LCENDNEONIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8FB07E0", Offset = "0x8FAF5E0", VA = "0x188FB07E0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int HHICCKHMALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xEA0FC0", Offset = "0xE9FDC0", VA = "0x180EA0FC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int DDLHFJCGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8FB07F0", Offset = "0x8FAF5F0", VA = "0x188FB07F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int PPIPAIDPLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8FB00B0", Offset = "0x8FAEEB0", VA = "0x188FB00B0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xFDB1F0", Offset = "0xFD9FF0", VA = "0x180FDB1F0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0640", Offset = "0x8FAF440", VA = "0x188FB0640", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8FB00A0", Offset = "0x8FAEEA0", VA = "0x188FB00A0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0590", Offset = "0x8FAF390", VA = "0x188FB0590", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB04A0", Offset = "0x8FAF2A0", VA = "0x188FB04A0", Slot = "13")]
		public override IntPtr ReadData([Out] int MCJGICKIGFF)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFD50", Offset = "0x8FAEB50", VA = "0x188FAFD50", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFDF0", Offset = "0x8FAEBF0", VA = "0x188FAFDF0")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0720", Offset = "0x8FAF520", VA = "0x188FB0720")]
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
		private int DNCELJDFKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool INDDDMEJNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> MAKHEEHJIBK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase OKFHDOJLIJO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int DDLHFJCGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8FB07F0", Offset = "0x8FAF5F0", VA = "0x188FB07F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int PPIPAIDPLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8FB09A0", Offset = "0x8FAF7A0", VA = "0x188FB09A0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0850", Offset = "0x8FAF650", VA = "0x188FB0850")]
		private NativeArray<float> PLDIMEEGDJF(int MCJGICKIGFF)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		private void EBLBAJPNLGA(NativeArray<float> ALPKAMHLIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8FB09C0", Offset = "0x8FAF7C0", VA = "0x188FB09C0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0AD0", Offset = "0x8FAF8D0", VA = "0x188FB0AD0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0800", Offset = "0x8FAF600", VA = "0x188FB0800", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0B30", Offset = "0x8FAF930", VA = "0x188FB0B30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAB1400", Offset = "0xAB0200", VA = "0x180AB1400")]
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
		private const int OPILLIIJPJG = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] NNABGJIGEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] OIOLJNFNEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int GHFIKAILGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int AGBJHEPPNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle APCDCCGDHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int KFIPJEGHOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool MFDHLAAIGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int JPHLKANHEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int FFBJBIFEBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object AMAEJMDPEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool NDJCJLLNBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CIHDGNHIEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int MGIJNHPBFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int GIGPLBPCNJK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> EKBJNIKDPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NDEEILHIBOF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA98B30", Offset = "0xA97930", VA = "0x180A98B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] GEGOAEGAOON
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int BGMNEGJKLHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr LCENDNEONIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8FB1F60", Offset = "0x8FB0D60", VA = "0x188FB1F60")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int HHICCKHMALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x12FCE00", Offset = "0x12FBC00", VA = "0x1812FCE00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int DDLHFJCGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FB07F0", Offset = "0x8FAF5F0", VA = "0x188FB07F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int PPIPAIDPLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB1E560", Offset = "0xB1D360", VA = "0x180B1E560", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1A10", Offset = "0x8FB0810", VA = "0x188FB1A10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1220", Offset = "0x8FB0020", VA = "0x188FB1220", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1820", Offset = "0x8FB0620", VA = "0x188FB1820", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1BF0", Offset = "0x8FB09F0", VA = "0x188FB1BF0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1210", Offset = "0x8FB0010", VA = "0x188FB1210", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1760", Offset = "0x8FB0560", VA = "0x188FB1760", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1610", Offset = "0x8FB0410", VA = "0x188FB1610", Slot = "13")]
		public override IntPtr ReadData([Out] int MCJGICKIGFF)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D00", Offset = "0x8FAFB00", VA = "0x188FB0D00", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0DA0", Offset = "0x8FAFBA0", VA = "0x188FB0DA0")]
		public void OnAudioFilterReadCombiner(float[] KANAIIDGHCH, int GBHDIJIKCIM, bool HCCJIBGMGLP, int FMAPGJELDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C20", Offset = "0x8FAFA20", VA = "0x188FB0C20")]
		private float[] BFMEDDIBHKG(float[] KANAIIDGHCH, int LJNHDJFMPEP, int KNEAHJEENLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1EA0", Offset = "0x8FB0CA0", VA = "0x188FB1EA0")]
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
		public CaptureBase OKFHDOJLIJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int DDLHFJCGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int PPIPAIDPLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1F70", Offset = "0x8FB0D70", VA = "0x188FB1F70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB1400", Offset = "0xAB0200", VA = "0x180AB1400")]
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
		private sealed class PKNDPDEAMFI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public PKNDPDEAMFI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8FC2450", Offset = "0x8FC1250", VA = "0x188FC2450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8FC24F0", Offset = "0x8FC12F0", VA = "0x188FC24F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PJFMEBCKHKL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public PJFMEBCKHKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8FC1FF0", Offset = "0x8FC0DF0", VA = "0x188FC1FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8FC2400", Offset = "0x8FC1200", VA = "0x188FC2400", Slot = "8")]
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
		private RenderTexture JNNODNECGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture NANCPOEFDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr MHIALAELNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture HGMCCFFAHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture DKFMKCJEKNJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector HKMNEEJAIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBA6AF0", Offset = "0xBA58F0", VA = "0x180BA6AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC0EAB0", Offset = "0xC0D8B0", VA = "0x180C0EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ELGGMOKGIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x25445C0", Offset = "0x25433C0", VA = "0x1825445C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2676430", Offset = "0x2675230", VA = "0x182676430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA360", Offset = "0x8FB9160", VA = "0x188FBA360")]
		public void SetCamera(Camera HIEBBCKDIPO, bool JCEAHADCDMP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA310", Offset = "0x8FB9110", VA = "0x188FBA310")]
		public void SetCamera(Camera HIEBBCKDIPO, Camera[] IACPMONPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8FB96A0", Offset = "0x8FB84A0", VA = "0x188FB96A0")]
		private bool KELFGDHPMNL(Texture JDNNGPGPIOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8DC0", Offset = "0x8FB7BC0", VA = "0x188FB8DC0")]
		private bool BEPKNEDHKAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8EA0", Offset = "0x8FB7CA0", VA = "0x188FB8EA0")]
		private bool EKGEMDHEHJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA5A0", Offset = "0x8FB93A0", VA = "0x188FBA5A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8FB94E0", Offset = "0x8FB82E0", VA = "0x188FB94E0")]
		[IteratorStateMachine(typeof(PKNDPDEAMFI))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8E20", Offset = "0x8FB7C20", VA = "0x188FB8E20")]
		[IteratorStateMachine(typeof(PJFMEBCKHKL))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9560", Offset = "0x8FB8360", VA = "0x188FB9560")]
		private bool JONPLNKMONO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB90A0", Offset = "0x8FB7EA0", VA = "0x188FB90A0")]
		private void HIEKBBDEGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA480", Offset = "0x8FB9280", VA = "0x188FBA480", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8ED0", Offset = "0x8FB7CD0", VA = "0x188FB8ED0")]
		private void FIEPHNBEDHO(int FIJCBEGFDBD, int HBJICDOMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC1E210", Offset = "0xC1D010", VA = "0x180C1E210", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9890", Offset = "0x8FB8690", VA = "0x188FB9890", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9780", Offset = "0x8FB8580", VA = "0x188FB9780", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA730", Offset = "0x8FB9530", VA = "0x188FBA730")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8FB94D0", Offset = "0x8FB82D0", VA = "0x188FB94D0")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void IPCDEMHAEDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum JNJPLGJLIDG
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
		private sealed class AFBEAPOCNMN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public AFBEAPOCNMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8FAC610", Offset = "0x8FAB410", VA = "0x188FAC610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8FAC680", Offset = "0x8FAB480", VA = "0x188FAC680", Slot = "8")]
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
		private DPKPEOJKJNO _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private MLJNOGJIKCL _cubemapDepth;

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
		private GHIAEMICGMB _stereoRendering;

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
		private RenderTexture BLDNGILLECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] KBFFILKGBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material IGIJOECHKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material KOOFFMIIPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture GNALENKGIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture BPCBLEEOLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr MHIALAELNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int POAHMEFHELP;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector HKMNEEJAIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBA6AF0", Offset = "0xBA58F0", VA = "0x180BA6AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC0EAB0", Offset = "0xC0D8B0", VA = "0x180C0EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DPKPEOJKJNO CBONFHOCFJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xBA6E90", Offset = "0xBA5C90", VA = "0x180BA6E90")]
			get
			{
				return default(DPKPEOJKJNO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D70", Offset = "0x8FB7B70", VA = "0x188FB8D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MLJNOGJIKCL KHNIKINGODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D20", Offset = "0x8FB7B20", VA = "0x188FB8D20")]
			get
			{
				return default(MLJNOGJIKCL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D60", Offset = "0x8FB7B60", VA = "0x188FB8D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AHFEAADGGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x25445C0", Offset = "0x25433C0", VA = "0x1825445C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2676430", Offset = "0x2675230", VA = "0x182676430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BEAMIOPLIDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D50", Offset = "0x8FB7B50", VA = "0x188FB8D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8DB0", Offset = "0x8FB7BB0", VA = "0x188FB8DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ILKBJMFLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D30", Offset = "0x8FB7B30", VA = "0x188FB8D30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D80", Offset = "0x8FB7B80", VA = "0x188FB8D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool NFFIPBCLFNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D40", Offset = "0x8FB7B40", VA = "0x188FB8D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8D90", Offset = "0x8FB7B90", VA = "0x188FB8D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public GHIAEMICGMB CFHLCFLPPJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x28E0100", Offset = "0x28DEF00", VA = "0x1828E0100")]
			get
			{
				return default(GHIAEMICGMB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8FB8DA0", Offset = "0x8FB7BA0", VA = "0x188FB8DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float KLADPHEAIBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x13ACFD0", Offset = "0x13ABDD0", VA = "0x1813ACFD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x13ACE80", Offset = "0x13ABC80", VA = "0x1813ACE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8C50", Offset = "0x8FB7A50", VA = "0x188FB8C50")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4970", Offset = "0x8FB3770", VA = "0x188FB4970")]
		private JNJPLGJLIDG DFEHNOIINEP()
		{
			return default(JNJPLGJLIDG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC108A0", Offset = "0xC0F6A0", VA = "0x180C108A0")]
		public void SetCamera(Camera HOHEOKHPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8AE0", Offset = "0x8FB78E0", VA = "0x188FB8AE0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5470", Offset = "0x8FB4270", VA = "0x188FB5470")]
		[IteratorStateMachine(typeof(AFBEAPOCNMN))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6EB0", Offset = "0x8FB5CB0", VA = "0x188FB6EB0")]
		private void OKFHDOJLIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB47E0", Offset = "0x8FB35E0", VA = "0x188FB47E0")]
		private static void BIIDIIDIAAP(RenderTexture JDNNGPGPIOL, Color BGBIPHDMBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB49A0", Offset = "0x8FB37A0", VA = "0x188FB49A0")]
		private void DLOPDFNIEBF(RenderTexture JBAECGDOLCC, RenderTexture BNIHAACOHPG, bool ILAHALIBEAP, Quaternion GKEKGHNHKDP, bool GGCKAHAJIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4ED0", Offset = "0x8FB3CD0", VA = "0x188FB4ED0")]
		private void HIEKBBDEGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB54F0", Offset = "0x8FB42F0", VA = "0x188FB54F0")]
		private void OIMILNMHDEO(Camera HOHEOKHPGEK, RenderTexture GNPLCCEGFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4DB0", Offset = "0x8FB3BB0", VA = "0x188FB4DB0")]
		private void ELPFDFBDPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FB74D0", Offset = "0x8FB62D0", VA = "0x188FB74D0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4E90", Offset = "0x8FB3C90", VA = "0x188FB4E90", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FB88E0", Offset = "0x8FB76E0", VA = "0x188FB88E0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7200", Offset = "0x8FB6000", VA = "0x188FB7200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8FC2540", Offset = "0x8FC1340", VA = "0x188FC2540")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class HLKPCKFEFOB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public HLKPCKFEFOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8FC1F30", Offset = "0x8FC0D30", VA = "0x188FC1F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8FC1FA0", Offset = "0x8FC0DA0", VA = "0x188FC1FA0", Slot = "8")]
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
		private int BACINPLMPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int BPGJMCIDOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform EEHBFCGEAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera BFPODIDJHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera GAPJBCPOHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera FPEFIAALDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera HHKDJEOHKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture KODOGGJFMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr MHIALAELNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material FKBKOIDHAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int NPEFFHEHDNB;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings OPKPDOIHOAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBA6AF0", Offset = "0xBA58F0", VA = "0x180BA6AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB46D0", Offset = "0x8FB34D0", VA = "0x188FB46D0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB43D0", Offset = "0x8FB31D0", VA = "0x188FB43D0")]
		public void SetCamera(Camera HOHEOKHPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4400", Offset = "0x8FB3200", VA = "0x188FB4400", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2790", Offset = "0x8FB1590", VA = "0x188FB2790")]
		private Camera IJKBPKOBGIC(Camera HOHEOKHPGEK, string FCPNGLGMJDM, float HJMMKMGFEMC, float DEDPDGLFLMJ, int MJDBGCLPCPL, int COMAGLANBAB, float MPMAHLJNEAI, float GEHBABBAODJ, int DLINLGAFFJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4540", Offset = "0x8FB3340", VA = "0x188FB4540", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2DE0", Offset = "0x8FB1BE0", VA = "0x188FB2DE0")]
		[IteratorStateMachine(typeof(HLKPCKFEFOB))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2F10", Offset = "0x8FB1D10", VA = "0x188FB2F10")]
		private void OKFHDOJLIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2670", Offset = "0x8FB1470", VA = "0x188FB2670")]
		private void ELPFDFBDPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1FD0", Offset = "0x8FB0DD0", VA = "0x188FB1FD0")]
		private void CCIILOLNFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2750", Offset = "0x8FB1550", VA = "0x188FB2750", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3440", Offset = "0x8FB2240", VA = "0x188FB3440", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2E60", Offset = "0x8FB1C60", VA = "0x188FB2E60")]
		private static void JHDFFDJFNIF(Camera HOHEOKHPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3200", Offset = "0x8FB2000", VA = "0x188FB3200", Slot = "6")]
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
		private sealed class BLMHMAPJAOE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public BLMHMAPJAOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8FAEC60", Offset = "0x8FADA60", VA = "0x188FAEC60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8FAED90", Offset = "0x8FADB90", VA = "0x188FAED90", Slot = "8")]
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
		private IntPtr MHIALAELNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture NANCPOEFDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer JMIMPAJHFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator PNMNFGFFOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool PLMKGAHJAOG;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KDODIHKFPPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBB9930", Offset = "0xBB8730", VA = "0x180BB9930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBBA060", Offset = "0xBB8E60", VA = "0x180BBA060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor FDHOFLBMDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBA6AE0", Offset = "0xBA58E0", VA = "0x180BA6AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC108A0", Offset = "0xC0F6A0", VA = "0x180C108A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FBAD60", Offset = "0x8FB9B60", VA = "0x188FBAD60", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA830", Offset = "0x8FB9630", VA = "0x188FBA830")]
		private void MNBGPBCANON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FBAC80", Offset = "0x8FB9A80", VA = "0x188FBAC80")]
		private void OOPGGBFJFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB170", Offset = "0x8FB9F70", VA = "0x188FBB170", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA7B0", Offset = "0x8FB95B0", VA = "0x188FBA7B0")]
		[IteratorStateMachine(typeof(BLMHMAPJAOE))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB2B0", Offset = "0x8FBA0B0", VA = "0x188FBB2B0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB2E0", Offset = "0x8FBA0E0", VA = "0x188FBB2E0")]
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
		private sealed class GCFLLGPADOL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public GCFLLGPADOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8FC1E70", Offset = "0x8FC0C70", VA = "0x188FC1E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8FC1EE0", Offset = "0x8FC0CE0", VA = "0x188FC1EE0", Slot = "8")]
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
		private Texture ANCOLEDKMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture NANCPOEFDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr MHIALAELNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool GOPAPMHBEAD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HLGJEBLLDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBB9930", Offset = "0xBB8730", VA = "0x180BB9930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBBA060", Offset = "0xBB8E60", VA = "0x180BBA060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xC108A0", Offset = "0xC0F6A0", VA = "0x180C108A0")]
		public void SetSourceTexture(Texture JDNNGPGPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB700", Offset = "0x8FBA500", VA = "0x188FBB700")]
		private bool KELFGDHPMNL(Texture JDNNGPGPIOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC3C0", Offset = "0x8FBB1C0", VA = "0x188FBC3C0")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB7E0", Offset = "0x8FBA5E0", VA = "0x188FBB7E0")]
		private bool NHBFLBPFNFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB850", Offset = "0x8FBA650", VA = "0x188FBB850")]
		private bool OJJNECPBHDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC310", Offset = "0x8FBB110", VA = "0x188FBC310", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB680", Offset = "0x8FBA480", VA = "0x188FBB680")]
		[IteratorStateMachine(typeof(GCFLLGPADOL))]
		private IEnumerator JFIIIAJPBGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB870", Offset = "0x8FBA670", VA = "0x188FBB870")]
		private void OKFHDOJLIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB400", Offset = "0x8FBA200", VA = "0x188FBB400")]
		private void FIEPHNBEDHO(int FIJCBEGFDBD, int HBJICDOMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB350", Offset = "0x8FBA150", VA = "0x188FBB350")]
		private void ELPFDFBDPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FBB590", Offset = "0x8FBA390", VA = "0x188FBB590", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8FBBDC0", Offset = "0x8FBABC0", VA = "0x188FBBDC0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC200", Offset = "0x8FBB000", VA = "0x188FBC200", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC3D0", Offset = "0x8FBB1D0", VA = "0x188FBC3D0")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC440", Offset = "0x8FBB240", VA = "0x188FBC440", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC3D0", Offset = "0x8FBB1D0", VA = "0x188FBC3D0")]
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
		private enum NBCMKEDDBCG
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
		private AudioListener CPGJCLKNGEL;

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
		private static readonly string[] EEDHAPFJNBB;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] KCFOOGNCHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private NBCMKEDDBCG AAOPBEOGIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] GKKHOGNOGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] DAFFLJDBHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] FAGHCCKJOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] LCIHKHGDDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] DHBBBHAGLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] MEHJACPFFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] LGOLOJHJLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int GNIEKOLKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle CBNDBFLKOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int JEPMCFBKJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 KAAPFBECJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 CEIIKELBGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 ODLNGMHEEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 CJCBHHJIBHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long OPLAHDHGPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float BNEDDEDEHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float FCFFHHFPOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint CPKAFINBNKD;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase BBDKBCPPLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ELJILCAILIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF5C830", Offset = "0xF5B630", VA = "0x180F5C830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xF5C840", Offset = "0xF5B640", VA = "0x180F5C840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool AKJFGGPDIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC1010", Offset = "0x8FBFE10", VA = "0x188FC1010")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBC4B0", Offset = "0x8FBB2B0", VA = "0x188FBC4B0")]
		private void BAEHJCBOAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC0B00", Offset = "0x8FBF900", VA = "0x188FC0B00")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8FBE900", Offset = "0x8FBD700", VA = "0x188FBE900")]
		private void NIMMKGFNJBF(int FMFDAFLDAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD420", Offset = "0x8FBC220", VA = "0x188FBD420")]
		private void LBLHGNDDLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8FBCE50", Offset = "0x8FBBC50", VA = "0x188FBCE50")]
		private void FHNOFGAFNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD280", Offset = "0x8FBC080", VA = "0x188FBD280")]
		private void FPJMGOLHPPM(string GENJGFGGINA, string KMNEIBIPMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8FBCD80", Offset = "0x8FBBB80", VA = "0x188FBCD80")]
		private void CNFNBNCLJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD310", Offset = "0x8FBC110", VA = "0x188FBD310")]
		private void HLBLBCEKHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD200", Offset = "0x8FBC000", VA = "0x188FBD200")]
		private void FOAJNCBLKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD3A0", Offset = "0x8FBC1A0", VA = "0x188FBD3A0")]
		private void JCFJGCDNDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8FBE880", Offset = "0x8FBD680", VA = "0x188FBE880")]
		private void NAPBMDJGJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8FC1080", Offset = "0x8FBFE80", VA = "0x188FC1080")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8FC18B0", Offset = "0x8FC06B0", VA = "0x188FC18B0")]
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
		private RenderTexture DLNKAMJKDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture ECLHGEOPOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material PEAKIGCENNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material AGLEIPMIOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int MALCGIFDJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int NKBDANGAKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int FLLIIJPNJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool IMMCADINOKP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int PHAKGFABONM;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int ILHAHIEGEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float CODGAJLAOIJ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool NMAKMHOELLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x12FCD30", Offset = "0x12FBB30", VA = "0x1812FCD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x17B15A0", Offset = "0x17B03A0", VA = "0x1817B15A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int FOFKDDBFOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xABCF70", Offset = "0xABBD70", VA = "0x180ABCF70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD54F0", Offset = "0x8FD42F0", VA = "0x188FD54F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int DLOOHEMBGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture LILFPGBBKCO
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4B00", Offset = "0x8FD3900", VA = "0x188FD4B00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8FD54A0", Offset = "0x8FD42A0", VA = "0x188FD54A0")]
		public void SetTargetSize(int FIJCBEGFDBD, int HBJICDOMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8FD54C0", Offset = "0x8FD42C0", VA = "0x188FD54C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5210", Offset = "0x8FD4010", VA = "0x188FD5210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4CD0", Offset = "0x8FD3AD0", VA = "0x188FD4CD0")]
		private void OPKPDOIHOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4C70", Offset = "0x8FD3A70", VA = "0x188FD4C70")]
		private void KLGIMCDDIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5030", Offset = "0x8FD3E30", VA = "0x188FD5030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5270", Offset = "0x8FD4070", VA = "0x188FD5270")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84DE500", Offset = "0x84DD300", VA = "0x1884DE500")]
		private static float PJHFLKMHGNG(float GENJGFGGINA, float KMNEIBIPMKI, float DDCPKPIHIOM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8FD4B90", Offset = "0x8FD3990", VA = "0x188FD4B90")]
		private void HGKHNGDFJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8FD49E0", Offset = "0x8FD37E0", VA = "0x188FD49E0")]
		public void Accumulate(Texture HNLFFLNNKGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5330", Offset = "0x8FD4130", VA = "0x188FD5330")]
		private void OnRenderImage(RenderTexture HNLFFLNNKGK, RenderTexture AGEFPDLPNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD54D0", Offset = "0x8FD42D0", VA = "0x188FD54D0")]
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
		private GUIContent EJJIKOANCEF;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5730", Offset = "0x8FD4530", VA = "0x188FD5730")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5670", Offset = "0x8FD4470", VA = "0x188FD5670")]
		public void SetTexture(Texture2D JDNNGPGPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5500", Offset = "0x8FD4300", VA = "0x188FD5500")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD57F0", Offset = "0x8FD45F0", VA = "0x188FD57F0")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> GJMFCJGJEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBB50", Offset = "0x8FDA950", VA = "0x188FDBB50")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum FKEOHHIPNFP
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class IEOFHMBBLDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector HGNELKBFJGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode PONKDAJEGDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool DKANDFCKOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool DDOGNDGILLN;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
			internal IEOFHMBBLDG(PlayableDirector EAPFIFDDLLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8FD3980", Offset = "0x8FD2780", VA = "0x188FD3980")]
			internal bool JADFFOFPMCL(PlayableDirector EAPFIFDDLLO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8FD37B0", Offset = "0x8FD25B0", VA = "0x188FD37B0")]
			internal void CNFNBNCLJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8FD38B0", Offset = "0x8FD26B0", VA = "0x188FD38B0")]
			internal void HLBLBCEKHOI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private FKEOHHIPNFP _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<IEOFHMBBLDG> GCEMPJNPJAE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public FKEOHHIPNFP EKJONLHCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(FKEOHHIPNFP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8FDC510", Offset = "0x8FDB310", VA = "0x188FDC510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBB80", Offset = "0x8FDA980", VA = "0x188FDBB80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBB80", Offset = "0x8FDA980", VA = "0x188FDBB80")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBEB0", Offset = "0x8FDACB0", VA = "0x188FDBEB0")]
		internal void GLEHKPDLPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBBA0", Offset = "0x8FDA9A0", VA = "0x188FDBBA0")]
		internal void CNFNBNCLJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBEC0", Offset = "0x8FDACC0", VA = "0x188FDBEC0")]
		internal void HLBLBCEKHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC150", Offset = "0x8FDAF50", VA = "0x188FDC150")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC0A0", Offset = "0x8FDAEA0", VA = "0x188FDC0A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBDC0", Offset = "0x8FDABC0", VA = "0x188FDBDC0")]
		private void ENEPMOOPDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBB90", Offset = "0x8FDA990", VA = "0x188FDBB90")]
		private void CMGHKNLCKJG(Scene OKCGKPEIJGC, LoadSceneMode KJLMJGOOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC480", Offset = "0x8FDB280", VA = "0x188FDC480")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int HHICCKHMALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int DDLHFJCGKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int PPIPAIDPLHM
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
		[Cpp2IlInjected.Address(RVA = "0x8FDCAD0", Offset = "0x8FDB8D0", VA = "0x188FDCAD0", Slot = "13")]
		public virtual IntPtr ReadData([Out] int MCJGICKIGFF)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC9B0", Offset = "0x8FDB7B0", VA = "0x188FDC9B0")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC940", Offset = "0x8FDB740", VA = "0x188FDC940")]
		private static int GDGAPNCHDBO(AudioSpeakerMode KJLMJGOOKJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum DEEGAMPMHCA
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class OGPKFCCAMPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer IIFKHAKGPOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool DDOGNDGILLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool DKANDFCKOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool BCDCFLPBGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double OIELIJFGIBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float DNHDOBDKGPN;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
			internal OGPKFCCAMPL(VideoPlayer ACILBPODKDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8430", Offset = "0x8FD7230", VA = "0x188FD8430")]
			internal bool JADFFOFPMCL(VideoPlayer ACILBPODKDN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7E50", Offset = "0x8FD6C50", VA = "0x188FD7E50")]
			internal void CNFNBNCLJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8360", Offset = "0x8FD7160", VA = "0x188FD8360")]
			internal bool FICLODLCKFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7ED0", Offset = "0x8FD6CD0", VA = "0x188FD7ED0")]
			internal void FALFODGLEPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8630", Offset = "0x8FD7430", VA = "0x188FD8630")]
			private void NFCBPPNHCMI(VideoPlayer MKPEOGPFEFH, long DOFBIKGEHIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8530", Offset = "0x8FD7330", VA = "0x188FD8530")]
			private void MDFHJACCDIC(VideoPlayer MKPEOGPFEFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8490", Offset = "0x8FD7290", VA = "0x188FD8490")]
			internal void JHLKAIBNOLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8FD7950", Offset = "0x8FD6750", VA = "0x188FD7950")]
			internal bool AFCEEABIEMI(float GCGEIJPOBEE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8FD83A0", Offset = "0x8FD71A0", VA = "0x188FD83A0")]
			internal void HLBLBCEKHOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class KDJOOBBJBJC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public KDJOOBBJBJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8FD4730", Offset = "0x8FD3530", VA = "0x188FD4730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8FD48A0", Offset = "0x8FD36A0", VA = "0x188FD48A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private DEEGAMPMHCA _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<OGPKFCCAMPL> MOECNAEPNPN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DEEGAMPMHCA EKJONLHCFBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			get
			{
				return default(DEEGAMPMHCA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8FDD9B0", Offset = "0x8FDC7B0", VA = "0x188FDD9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCBE0", Offset = "0x8FDB9E0", VA = "0x188FDCBE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCBE0", Offset = "0x8FDB9E0", VA = "0x188FDCBE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD180", Offset = "0x8FDBF80", VA = "0x188FDD180")]
		internal void GLEHKPDLPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCDB0", Offset = "0x8FDBBB0", VA = "0x188FDCDB0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD450", Offset = "0x8FDC250", VA = "0x188FDD450")]
		[IteratorStateMachine(typeof(KDJOOBBJBJC))]
		internal IEnumerator KGCAOGPGOEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCC00", Offset = "0x8FDBA00", VA = "0x188FDCC00")]
		internal void CNFNBNCLJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD2C0", Offset = "0x8FDC0C0", VA = "0x188FDD2C0")]
		internal void HLBLBCEKHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD580", Offset = "0x8FDC380", VA = "0x188FDD580")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD4D0", Offset = "0x8FDC2D0", VA = "0x188FDD4D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD090", Offset = "0x8FDBE90", VA = "0x188FDD090")]
		private void ENEPMOOPDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCBF0", Offset = "0x8FDB9F0", VA = "0x188FDCBF0")]
		private void CMGHKNLCKJG(Scene OKCGKPEIJGC, LoadSceneMode KJLMJGOOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD920", Offset = "0x8FDC720", VA = "0x188FDD920")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCF20", Offset = "0x8FDBD20", VA = "0x188FDCF20")]
		[CompilerGenerated]
		private bool EAHEHBNLEEC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum KINFPLKNKJH
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	First = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Second,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Third
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum GGIKOOLMINL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ACN_SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum HHIMCJECHLD
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ACN
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CHGFEILFNCK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OPIJDCAFCKI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum ANBLOJHFFDF
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
	public enum MDOBKBCGOKL
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
	public enum BMMNMEEHIOE
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		CaptureFrameBuffer,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeResources,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Setup
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static string[] MGGBPBBAGII;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly string[] MFKCBFLDKMK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string[] ADNIFEJGJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly string[] LCCCAIPBMEL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static readonly string[] IFNCKIDILBP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly string[] MFEHHOKJMFD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly string[] BADIJNIFOPO;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static IntPtr BNOMLOKIJAI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static IntPtr BPNKNNKGMMI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private static IntPtr DHKFKEBHALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8B80", Offset = "0x8FD7980", VA = "0x188FD8B80")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private static IntPtr HLKAPNDPFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA930", Offset = "0x8FD9730", VA = "0x188FDA930")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8CA0", Offset = "0x8FD7AA0", VA = "0x188FD8CA0")]
	public static extern IntPtr COBHHABAIGN(int EMMPGNPONDF);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9970", Offset = "0x8FD8770", VA = "0x188FD9970")]
	public static extern void HBHKIOAFNLJ(IntPtr HNKFODIAFKO);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA2F0", Offset = "0x8FD90F0", VA = "0x188FDA2F0")]
	public static extern void JHNFOJKJLNC(IntPtr HNKFODIAFKO, float HGKLIPGCHEL, float KEMGHPBIMCF, KINFPLKNKJH MBIPCKLBHPE, HHIMCJECHLD HFKPJDGDCML, float[] GFAIDJIOANJ);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8FDABA0", Offset = "0x8FD99A0", VA = "0x188FDABA0")]
	public static extern void OCOICPHHAIA(IntPtr HNKFODIAFKO, float[] PEPBNNIGFHC, int DOODPKLAOEO, int MGPLOILHPNH, int EHLALKBPEAE, float[] AJAPJEPDCCD, int JOIKBOGHGHO, int PHMOJEICKFJ, KINFPLKNKJH MBIPCKLBHPE);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAAD0", Offset = "0x8FD98D0", VA = "0x188FDAAD0")]
	public static string NLGMKHPDLBC(MDOBKBCGOKL KPCIPKKBEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9CA0", Offset = "0x8FD8AA0", VA = "0x188FD9CA0")]
	public static void HEPJJGBJMNP(BMMNMEEHIOE KPBCHEFJNMB, int MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA160", Offset = "0x8FD8F60", VA = "0x188FDA160")]
	private static extern IntPtr JAFOEBCLLLI();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8E90", Offset = "0x8FD7C90", VA = "0x188FD8E90")]
	private static extern IntPtr DMOJEEGOKEI();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA8C0", Offset = "0x8FD96C0", VA = "0x188FDA8C0")]
	public static extern bool MHDKBDCHLCM();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8F80", Offset = "0x8FD7D80", VA = "0x188FD8F80")]
	public static extern void DPGGAJAONAL();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8FD92E0", Offset = "0x8FD80E0", VA = "0x188FD92E0")]
	public static string EJLLHKJICFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9650", Offset = "0x8FD8450", VA = "0x188FD9650")]
	public static bool FFPBNEOJMAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8FD88C0", Offset = "0x8FD76C0", VA = "0x188FD88C0")]
	public static extern int BLILKAJKBNE();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8E10", Offset = "0x8FD7C10", VA = "0x188FD8E10")]
	public static extern bool DJGCOOIDOAH(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAA50", Offset = "0x8FD9850", VA = "0x188FDAA50")]
	public static extern MFMGDLPCADJ MNNKCJNEECC(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9FE0", Offset = "0x8FD8DE0", VA = "0x188FD9FE0")]
	public static extern void IGBPNNCNKNA(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8FF0", Offset = "0x8FD7DF0", VA = "0x188FD8FF0")]
	public static string EDNICOJPLAM(int FEKIPNJDOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8D20", Offset = "0x8FD7B20", VA = "0x188FD8D20")]
	public static extern int DFDPDMPKPND();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA730", Offset = "0x8FD9530", VA = "0x188FDA730")]
	public static extern bool LJOGENMBAKB(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA0E0", Offset = "0x8FD8EE0", VA = "0x188FDA0E0")]
	public static extern MFMGDLPCADJ INIOCBMPMJI(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA6B0", Offset = "0x8FD94B0", VA = "0x188FDA6B0")]
	public static extern void KEHEDPGNLKG(int FEKIPNJDOKE);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA460", Offset = "0x8FD9260", VA = "0x188FDA460")]
	public static string JLEOGIKKFLI(int FEKIPNJDOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAE00", Offset = "0x8FD9C00", VA = "0x188FDAE00")]
	public static extern int OMKMDCDLEBF();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8A00", Offset = "0x8FD7800", VA = "0x188FD8A00")]
	public static string CCCNOOGHIOC(int JJJJBEGKNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAF80", Offset = "0x8FD9D80", VA = "0x188FDAF80")]
	public static extern MFMGDLPCADJ PNJECAAOEGG(int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8FD99F0", Offset = "0x8FD87F0", VA = "0x188FD99F0")]
	public static string[] HDMGNIGLOHM(int CNGDGEPEIMO, int HKBPJHEEFML = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8FDACA0", Offset = "0x8FD9AA0", VA = "0x188FDACA0")]
	public static extern int OJDJKBGDIBA(string GJJBKNNMHFP, uint FIJCBEGFDBD, uint HBJICDOMHDE, float GGDLALIMJJM, int DILPKDIDKCM, bool HFNNIBMCEAH, bool DHGIJAAEDPO, int CNGDGEPEIMO, JJPKNNEKKJD FBABCNPBHOI, int OEAPPGPNEJH, int GBNAFNMOGOE, int ENCNKPBMBMD, int HKBPJHEEFML, bool FMDFMEELFLD, VideoEncoderHints ICJEEENIMIK);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9750", Offset = "0x8FD8550", VA = "0x188FD9750")]
	public static extern int GANCLEOGMED(string GJJBKNNMHFP, uint FIJCBEGFDBD, uint HBJICDOMHDE, float GGDLALIMJJM, int DILPKDIDKCM, bool HFNNIBMCEAH, bool DHGIJAAEDPO, int DPGJNDJCEKC, bool FMDFMEELFLD, int MCINEAINKBA, ImageEncoderHints ICJEEENIMIK);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8750", Offset = "0x8FD7550", VA = "0x188FD8750")]
	public static extern int BEBEHIEBNBO(string GJJBKNNMHFP, uint FIJCBEGFDBD, uint HBJICDOMHDE, float GGDLALIMJJM, int DILPKDIDKCM, bool DHGIJAAEDPO, int BMBMADMKHIJ, bool FMDFMEELFLD);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8D90", Offset = "0x8FD7B90", VA = "0x188FD8D90")]
	public static extern bool DGOFKDGOMGH(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8F00", Offset = "0x8FD7D00", VA = "0x188FD8F00")]
	public static extern bool DNAHNDPLBBF(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA3D0", Offset = "0x8FD91D0", VA = "0x188FDA3D0")]
	public static extern int JJNPEIBMKJC(int MJIBDELKIML, uint LEHJJMMOLKF);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA830", Offset = "0x8FD9630", VA = "0x188FDA830")]
	public static extern void MEMAMBMDLAM(int MJIBDELKIML, IntPtr KANAIIDGHCH);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA1D0", Offset = "0x8FD8FD0", VA = "0x188FDA1D0")]
	public static extern void JECACLLFBBC(int MJIBDELKIML, IntPtr KANAIIDGHCH, uint MCJGICKIGFF);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9240", Offset = "0x8FD8040", VA = "0x188FD9240")]
	public static extern void EIPLDNLOHFF(int MJIBDELKIML, IntPtr ADOJLHGAHBI, IntPtr PJLPHHNGJFC, uint JOIBNDLONHC);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8FD86D0", Offset = "0x8FD74D0", VA = "0x188FD86D0")]
	public static extern void BDCEPMMAHDG(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAEF0", Offset = "0x8FD9CF0", VA = "0x188FDAEF0")]
	public static extern void PMKEICCMJHA(int MJIBDELKIML, bool LFJFGADABOG);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9880", Offset = "0x8FD8680", VA = "0x188FD9880")]
	public static extern bool GFJDOMAIHLO(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	public static bool EDCEHKEBELC(int MJIBDELKIML, StringBuilder DFMNBKGODOK, int MCJGICKIGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9F50", Offset = "0x8FD8D50", VA = "0x188FD9F50")]
	public static extern void IELMJOMKNLF(int MJIBDELKIML, IntPtr JDNNGPGPIOL);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8FD96D0", Offset = "0x8FD84D0", VA = "0x188FD96D0")]
	public static extern void FOCCABFELNP(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA270", Offset = "0x8FD9070", VA = "0x188FDA270")]
	public static extern uint JEMECGNOOBC(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8FD95D0", Offset = "0x8FD83D0", VA = "0x188FD95D0")]
	public static extern uint FBAAHPAECMI(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAE70", Offset = "0x8FD9C70", VA = "0x188FDAE70")]
	public static extern uint PHGNAPOFPBG(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA060", Offset = "0x8FD8E60", VA = "0x188FDA060")]
	public static extern float IMGJFMPNGNE(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8840", Offset = "0x8FD7640", VA = "0x188FD8840")]
	public static extern uint BFNOCFEBMIL(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA7B0", Offset = "0x8FD95B0", VA = "0x188FDA7B0")]
	public static extern uint LLICIBHECLD(int MJIBDELKIML);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9900", Offset = "0x8FD8700", VA = "0x188FD9900")]
	private static extern IntPtr GNIIMBPPBOA();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9170", Offset = "0x8FD7F70", VA = "0x188FD9170")]
	private static extern bool EDNICOJPLAM(int JJJJBEGKNIN, StringBuilder PFLDDMDPCBI, int NNIBCLCCJAE);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA5E0", Offset = "0x8FD93E0", VA = "0x188FDA5E0")]
	private static extern bool JLEOGIKKFLI(int JJJJBEGKNIN, StringBuilder PFLDDMDPCBI, int NNIBCLCCJAE);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8930", Offset = "0x8FD7730", VA = "0x188FD8930")]
	private static extern bool CCCNOOGHIOC(int JJJJBEGKNIN, StringBuilder PFLDDMDPCBI, int NNIBCLCCJAE);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9BC0", Offset = "0x8FD89C0", VA = "0x188FD9BC0")]
	private static extern bool HDMGNIGLOHM(int CNGDGEPEIMO, int HKBPJHEEFML, StringBuilder PFHCHACJCPC, int HELGEMGELMD);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9510", Offset = "0x8FD8310", VA = "0x188FD9510")]
	private static extern bool ELJBHOCJLMI(string EINIMMDHNIA, [Out] ulong AEBJEAMMAKO, [Out] ulong JBDPJKFKPFH, [Out] ulong OLBODODJBBA);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8FD93B0", Offset = "0x8FD81B0", VA = "0x188FD93B0")]
	public static bool ELDALMAJPJO(string GHADMHNDJBK, [Out] ulong JICDOIHAMGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CAEJIGKNIBA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct LEGLAFKJGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public float HGKLIPGCHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float KEMGHPBIMCF;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FD48F0", Offset = "0x8FD36F0", VA = "0x188FD48F0")]
		public void BDMKKELHBGI(Vector3 FLAPAOJCDCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static float[] FHMIFOGMILD;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static float[] BCFLEAIAJID;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2D80", Offset = "0x8FC1B80", VA = "0x188FC2D80")]
	public static float[] JDOJFNOPAPN(CHGFEILFNCK JJGHAGOKFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8FC26A0", Offset = "0x8FC14A0", VA = "0x188FC26A0")]
	public static int AFAKKIIFGIG(KINFPLKNKJH MBIPCKLBHPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2E00", Offset = "0x8FC1C00", VA = "0x188FC2E00")]
	public static HHIMCJECHLD MCDGEMBJKLA(GGIKOOLMINL DILPKDIDKCM)
	{
		return default(HHIMCJECHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2E00", Offset = "0x8FC1C00", VA = "0x188FC2E00")]
	public static CHGFEILFNCK KKDBEFCBKIH(GGIKOOLMINL DILPKDIDKCM)
	{
		return default(CHGFEILFNCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3140", Offset = "0x8FC1F40", VA = "0x188FC3140")]
	static CAEJIGKNIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2AB0", Offset = "0x8FC18B0", VA = "0x188FC2AB0")]
	private static float[] EIIPJCHIJKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8FC30C0", Offset = "0x8FC1EC0", VA = "0x188FC30C0")]
	private static int PEKBENOJLFH(int PJGFEHKDEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8FC26D0", Offset = "0x8FC14D0", VA = "0x188FC26D0")]
	private static int AMEECODJIAF(int PJGFEHKDEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2730", Offset = "0x8FC1530", VA = "0x188FC2730")]
	private static int ANOMCFHMPFE(int DBBMOEGPNPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x8FC28C0", Offset = "0x8FC16C0", VA = "0x188FC28C0")]
	private static float CJANJJNLIFG(int PJGFEHKDEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2750", Offset = "0x8FC1550", VA = "0x188FC2750")]
	private static float CJANJJNLIFG(int DPBDKFEONOK, int EKLIICOPDPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2E10", Offset = "0x8FC1C10", VA = "0x188FC2E10")]
	private static float[] PAAMENIOIAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class EMDEPFKMOOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private uint LMMJLCAFCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private uint NECMLDOKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private uint OANOGFLNLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float JIDEDADKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private uint LHAOBKLODBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private uint BIPGAFKABDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private ulong DBCGGFBBPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int BAOOKOKCNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JJPKNNEKKJD DBKEBAFMIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int DDKAECDKGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private int DNCELJDFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float OEJKGLOOJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int OLPNFHHGOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private int MALCGIFDJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private float CKJHACMHBAO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float GODMFFEGFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5B910", Offset = "0xD5A710", VA = "0x180D5B910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public uint LNPLDDBJAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public uint GJOJLGMKEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public uint HECIGEKILEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float NCLKDPLJOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAE79E0", Offset = "0xAE67E0", VA = "0x180AE79E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEB8B40", Offset = "0xEB7940", VA = "0x180EB8B40")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	internal uint FKMJCPOBOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	internal uint GOOHKJAIFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JJPKNNEKKJD ODKFFOFKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0")]
		get
		{
			return default(JJPKNNEKKJD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAD5080", Offset = "0xAD3E80", VA = "0x180AD5080")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int EOJMDMEIDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xED3350", Offset = "0xED2150", VA = "0x180ED3350")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int GJKPDAPOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A00", Offset = "0xAB1800", VA = "0x180AB2A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x17380D0", Offset = "0x1736ED0", VA = "0x1817380D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8FCDD30", Offset = "0x8FCCB30", VA = "0x188FCDD30")]
	internal void ENLAIJPOOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8FCDD40", Offset = "0x8FCCB40", VA = "0x188FCDD40")]
	internal void HFFNAKAMNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x781D580", Offset = "0x781C380", VA = "0x18781D580")]
	public EMDEPFKMOOF()
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
		public enum MGBIGKGAPPG
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
		public HDBEAHHAHJE injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public GHIAEMICGMB stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public HDBEAHHAHJE injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public EBKMJADKKCA sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MGBIGKGAPPG colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public LKFILIEJJAO transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public JIENFAPKMJK androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public FKEEDMEPAPP colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public DICGFADEJPJ realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IDEEGMCCIPM orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCB70", Offset = "0x8FDB970", VA = "0x188FDCB70")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FDCB10", Offset = "0x8FDB910", VA = "0x188FDCB10")]
		public void DEHLKCNACJK()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum MFDNAMOHHHL
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
		public MFDNAMOHHHL colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public LKFILIEJJAO transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public JIENFAPKMJK androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FD46F0", Offset = "0x8FD34F0", VA = "0x188FD46F0")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FD46D0", Offset = "0x8FD34D0", VA = "0x188FD46D0")]
		public void DEHLKCNACJK()
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
		[Cpp2IlInjected.Address(RVA = "0x8FCDEB0", Offset = "0x8FCCCB0", VA = "0x188FCDEB0")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FCDD90", Offset = "0x8FCCB90", VA = "0x188FCDD90")]
		public void DEHLKCNACJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum HECAPFJKOJD
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
		public enum MLJNOGJIKCL
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum DPKPEOJKJNO
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
		public enum IAPDEOLDPHN
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
		public enum JDDOJNNMABD
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
		public enum GIDOMOMEJDE
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string MCLMDHHDEAE = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

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
		private MLHCAPJHGEL _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private HLGBFAEBJPP _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private ODNAKEHDANP _stopMode;

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
		private GIDOMOMEJDE _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private IAPDEOLDPHN _downScale;

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
		private JJPKNNEKKJD _audioCaptureSource;

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
		protected FDBCJLLKFLN _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const JDDOJNNMABD DefaultOutputFolderType = JDDOJNNMABD.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string HCIJDIGJOBJ = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private JDDOJNNMABD _outputFolderType;

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
		private BGPCFPEBKNN _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private BGPCFPEBKNN _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private BGPCFPEBKNN _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private BGPCFPEBKNN _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected HECAPFJKOJD _renderResolution;

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
		protected Texture2D KAOCINECGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int KLADOGLDHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int NBIBADFPAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int KOAFOFMMADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int NKBDANGAKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int FLLIIJPNJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool MFDHLAAIGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19D")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool CIHDGNHIEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string LNOKHFLJPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string CBDADMAMMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo LOGAGMCKBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected OPIJDCAFCKI.MDOBKBCGOKL HIFHPCKAKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private FHPECIHENHK CFHDAGKJLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private FHPECIHENHK MEGCAJNBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private BLIKGDDNEDI MIKHBKHPCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int JDIOCNBPCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float MGABNKGAKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool CLMAHIKPNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool LPGFKEPHKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E2")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool EAIKJJDAMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E3")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool BIJLAHMIFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float JGECIMDFHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float CEPJIPCOLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float GLNJBIALOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction IEMAKNCPPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long MCPOHPCPMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected LKFILIEJJAO POGJNAPFIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture IDOLGEPFLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material JKDOAJEIHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float BHFDDIICNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool KCLOELDJAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<CLHINBKBBGP> DCEBFNJMOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<CLHINBKBBGP> JFPMLPMOODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<CLHINBKBBGP> MEKMOFMDBBJ;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> GEGFJAKIHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent LPGNOIHBEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent ILKAJPEJGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private EMDEPFKMOOF DFHDPJJBGJL;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool DHNECNHJFNC;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool MPOKJIBFLCC;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public FDBCJLLKFLN DNKIJLPIEKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1753320", Offset = "0x1752120", VA = "0x181753320")]
			get
			{
				return default(FDBCJLLKFLN);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1753060", Offset = "0x1751E60", VA = "0x181753060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public JDDOJNNMABD CDFLLJJLLCO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xBF9680", Offset = "0xBF8480", VA = "0x180BF9680")]
			get
			{
				return default(JDDOJNNMABD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xBF9040", Offset = "0xBF7E40", VA = "0x180BF9040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string NNHPLICEMPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB2FB40", Offset = "0xB2E940", VA = "0x180B2FB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xB2AF20", Offset = "0xB29D20", VA = "0x180B2AF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string KNBOEOOKHDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x180B23880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB2B690", Offset = "0xB2A490", VA = "0x180B2B690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool FHIOLIHMADF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xB23870", Offset = "0xB22670", VA = "0x180B23870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4C8F0", Offset = "0xB4B6F0", VA = "0x180B4C8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool LAPOOHCLMDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2213D90", Offset = "0x2212B90", VA = "0x182213D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2210370", Offset = "0x220F170", VA = "0x182210370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string KEBGJNHDPGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB25420", Offset = "0xB24220", VA = "0x180B25420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB24080", Offset = "0xB22E80", VA = "0x180B24080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string HONLIIIEOBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAFA620", Offset = "0xAF9420", VA = "0x180AFA620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xB25880", Offset = "0xB24680", VA = "0x180B25880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool MEPODGDEDAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB57800", Offset = "0xB56600", VA = "0x180B57800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBB8130", Offset = "0xBB6F30", VA = "0x180BB8130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int PGHFNHIJBHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB25820", Offset = "0xB24620", VA = "0x180B25820")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xB805B0", Offset = "0xB7F3B0", VA = "0x180B805B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int IFKAFPLDDKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1823230", Offset = "0x1822030", VA = "0x181823230")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDA60", Offset = "0x8FCC860", VA = "0x188FCDA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool IOPJEPCLDJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD9A0", Offset = "0x8FCC7A0", VA = "0x188FCD9A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB40", Offset = "0x8FCC940", VA = "0x188FCDB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int PLAMGFLPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x104E5B0", Offset = "0x104D3B0", VA = "0x18104E5B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDAD0", Offset = "0x8FCC8D0", VA = "0x188FCDAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] LAOPILPHMMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC0FA30", Offset = "0xC0E830", VA = "0x180C0FA30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xD8FF70", Offset = "0xD8ED70", VA = "0x180D8FF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur DFAOJHGNMJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC0CAA0", Offset = "0xC0B8A0", VA = "0x180C0CAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBBCBF0", Offset = "0xBBB9F0", VA = "0x180BBCBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public LKFILIEJJAO KIBBKIIBGEK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xBA6E20", Offset = "0xBA5C20", VA = "0x180BA6E20")]
			get
			{
				return default(LKFILIEJJAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> LJINKNEKEGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD8D0", Offset = "0x8FCC6D0", VA = "0x188FCD8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string BNJNPAMDKEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB2FDB0", Offset = "0xB2EBB0", VA = "0x180B2FDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent ILFKJINGIIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xBA6B10", Offset = "0xBA5910", VA = "0x180BA6B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent ONOOCACFHPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBA6B30", Offset = "0xBA5930", VA = "0x180BA6B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<CLHINBKBBGP> DHIAEBMHDFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBC0380", Offset = "0xBBF180", VA = "0x180BC0380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBBCCC0", Offset = "0xBBBAC0", VA = "0x180BBCCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<CLHINBKBBGP> PLABKPECIFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBC1420", Offset = "0xBC0220", VA = "0x180BC1420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xBBC8B0", Offset = "0xBBB6B0", VA = "0x180BBC8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public HECAPFJKOJD MLMFLDHHHHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2370350", Offset = "0x236F150", VA = "0x182370350")]
			get
			{
				return default(HECAPFJKOJD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDA10", Offset = "0x8FCC810", VA = "0x188FCDA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 OMNEMKKJMKN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD920", Offset = "0x8FCC720", VA = "0x188FCD920")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2711400", Offset = "0x2710200", VA = "0x182711400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int FDJGPMCCHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x25EFC80", Offset = "0x25EEA80", VA = "0x1825EFC80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x25EF470", Offset = "0x25EE270", VA = "0x1825EF470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool BFPMBODPNMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", VA = "0x180FBC1B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1A0", Offset = "0xFBAFA0", VA = "0x180FBC1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IMPHMLKADFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xFBC1C0", Offset = "0xFBAFC0", VA = "0x180FBC1C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xFBC7B0", Offset = "0xFBB5B0", VA = "0x180FBC7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public JJPKNNEKKJD ODKFFOFKMMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB4DEA0", Offset = "0xB4CCA0", VA = "0x180B4DEA0")]
			get
			{
				return default(JJPKNNEKKJD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB4D720", Offset = "0xB4C520", VA = "0x180B4D720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int POMFLIDKHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCC00", Offset = "0x1EFBA00", VA = "0x181EFCC00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x281EBB0", Offset = "0x281D9B0", VA = "0x18281EBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int GMLAGHJLKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB36280", Offset = "0xB35080", VA = "0x180B36280")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xB359C0", Offset = "0xB347C0", VA = "0x180B359C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture PIFBOEDLBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAA30F0", Offset = "0xAA1EF0", VA = "0x180AA30F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAA30D0", Offset = "0xAA1ED0", VA = "0x180AA30D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int FGGNKMMHEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB550F0", Offset = "0xB53EF0", VA = "0x180B550F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDA20", Offset = "0x8FCC820", VA = "0x188FCDA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float NJMPIBLJHFO
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x160B2A0", Offset = "0x160A0A0", VA = "0x18160B2A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDA30", Offset = "0x8FCC830", VA = "0x188FCDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MLHCAPJHGEL JJLICJFKMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
			get
			{
				return default(MLHCAPJHGEL);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xB169F0", Offset = "0xB157F0", VA = "0x180B169F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public HLGBFAEBJPP GBPPDILFGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xEA0FC0", Offset = "0xE9FDC0", VA = "0x180EA0FC0")]
			get
			{
				return default(HLGBFAEBJPP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xFD2960", Offset = "0xFD1760", VA = "0x180FD2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float CIJEDGBEEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAE5FF0", Offset = "0xAE4DF0", VA = "0x180AE5FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB00", Offset = "0x8FCC900", VA = "0x188FCDB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ODNAKEHDANP PJBHHNNAANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x14AEA20", Offset = "0x14AD820", VA = "0x1814AEA20")]
			get
			{
				return default(ODNAKEHDANP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2317A50", Offset = "0x2316850", VA = "0x182317A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int FJFFOLDHDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB10", Offset = "0x8FCC910", VA = "0x188FCDB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float NLHBGHHIOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x10667F0", Offset = "0x10655F0", VA = "0x1810667F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB20", Offset = "0x8FCC920", VA = "0x188FCDB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool JAFDNHGICBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD5ADA0", Offset = "0xD59BA0", VA = "0x180D5ADA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD5A210", Offset = "0xD59010", VA = "0x180D5A210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public EMDEPFKMOOF GNDLDNDLMBF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xBA6B20", Offset = "0xBA5920", VA = "0x180BA6B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] GMIJKNKKMKC
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB90", Offset = "0x8FCC990", VA = "0x188FCDB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] IELNEOLLELM
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB60", Offset = "0x8FCC960", VA = "0x188FCDB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] KFLLBGANPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD9E0", Offset = "0x8FCC7E0", VA = "0x188FCD9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] DBCNFEFLJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD9B0", Offset = "0x8FCC7B0", VA = "0x188FCD9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int AGHPKLCPFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2F79FD0", Offset = "0x2F78DD0", VA = "0x182F79FD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x5C2BA00", Offset = "0x5C2A800", VA = "0x185C2BA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public GIDOMOMEJDE EAONJNBINKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xF3D3D0", Offset = "0xF3C1D0", VA = "0x180F3D3D0")]
			get
			{
				return default(GIDOMOMEJDE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xF3B990", Offset = "0xF3A790", VA = "0x180F3B990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public IAPDEOLDPHN OFOPOHMAKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xF3D3C0", Offset = "0xF3C1C0", VA = "0x180F3D3C0")]
			get
			{
				return default(IAPDEOLDPHN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF3B3C0", Offset = "0xF3A1C0", VA = "0x180F3B3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 AEHFKCPKAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x29EE330", Offset = "0x29ED130", VA = "0x1829EE330")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2A5ACB0", Offset = "0x2A59AB0", VA = "0x182A5ACB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool DNPELCBKKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x10B4290", Offset = "0x10B3090", VA = "0x1810B4290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1879B70", Offset = "0x1878970", VA = "0x181879B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool DONNBLOIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x8170A40", Offset = "0x816F840", VA = "0x188170A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB50", Offset = "0x8FCC950", VA = "0x188FCDB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool JLIPANJKLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x29FAAC0", Offset = "0x29F98C0", VA = "0x1829FAAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x29FB000", Offset = "0x29F9E00", VA = "0x1829FB000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool NOIIAFAEOIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1643700", Offset = "0x1642500", VA = "0x181643700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x163CCC0", Offset = "0x163BAC0", VA = "0x18163CCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool AIABFHDKCFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD990", Offset = "0x8FCC790", VA = "0x188FCD990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDB30", Offset = "0x8FCC930", VA = "0x188FCDB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController GIJPCPNAHAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC1D100", Offset = "0xC1BF00", VA = "0x180C1D100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB584D0", Offset = "0xB572D0", VA = "0x180B584D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController MNKIBFCGLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC0E3F0", Offset = "0xC0D1F0", VA = "0x180C0E3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x10700A0", Offset = "0x106EEA0", VA = "0x1810700A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public FHPECIHENHK IMPDIIMAODH
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xC01D00", Offset = "0xC00B00", VA = "0x180C01D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public FHPECIHENHK HJLBIMEOBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xBA6E30", Offset = "0xBA5C30", VA = "0x180BA6E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public BLIKGDDNEDI BNJDOAJEDNC
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB896C0", Offset = "0xB884C0", VA = "0x180B896C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int CPNKBEDCBME
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAA39F0", Offset = "0xAA27F0", VA = "0x180AA39F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAA39D0", Offset = "0xAA27D0", VA = "0x180AA39D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int OMJFEICKJDO
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB63410", Offset = "0xB62210", VA = "0x180B63410")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x10B0CF0", Offset = "0x10AFAF0", VA = "0x1810B0CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public BGPCFPEBKNN ENBNFAAPEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1823240", Offset = "0x1822040", VA = "0x181823240")]
			get
			{
				return default(BGPCFPEBKNN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x21354F0", Offset = "0x21342F0", VA = "0x1821354F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string FIILLHMFFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8FCD940", Offset = "0x8FCC740", VA = "0x188FCD940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8FCDA90", Offset = "0x8FCC890", VA = "0x188FCDA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
		protected static OPIJDCAFCKI.ANBLOJHFFDF OGGIABOKHED()
		{
			return default(OPIJDCAFCKI.ANBLOJHFFDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5B90", Offset = "0x8FC4990", VA = "0x188FC5B90")]
		public EncoderHints GetEncoderHints(OPIJDCAFCKI.ANBLOJHFFDF BMMNCBMEGCE = OPIJDCAFCKI.ANBLOJHFFDF.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB170", Offset = "0x8FC9F70", VA = "0x188FCB170")]
		public void SetEncoderHints(EncoderHints ICJEEENIMIK, OPIJDCAFCKI.ANBLOJHFFDF BMMNCBMEGCE = OPIJDCAFCKI.ANBLOJHFFDF.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		public static void UpdateMediaGallery(string KJGLMKCNDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3C60", Offset = "0x8FC2A60", VA = "0x188FC3C60", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8FCC4B0", Offset = "0x8FCB2B0", VA = "0x188FCC4B0")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB790", Offset = "0x8FCA590", VA = "0x188FCB790", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6AE0", Offset = "0x8FC58E0", VA = "0x188FC6AE0")]
		private static bool KDNHDGKPINJ(FHPECIHENHK EELEOCHDGAI, DCNKNIPCOAE BGDHGHHDCME, int NBJLDKOIONC, string[] KELLBDDLGKC, MFMGDLPCADJ CKKBIDBPGKB, bool MGKKBCMPFCC, bool LCGJOGJLPJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8FCAE50", Offset = "0x8FC9C50", VA = "0x188FCAE50")]
		public FHPECIHENHK SelectVideoCodec(bool BBBBCDGCMNC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCA7C0", Offset = "0x8FC95C0", VA = "0x188FCA7C0")]
		public FHPECIHENHK SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCAB20", Offset = "0x8FC9920", VA = "0x188FCAB20")]
		public BLIKGDDNEDI SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5D00", Offset = "0x8FC4B00", VA = "0x188FC5D00")]
		public static Vector2 GetRecordingResolution(int FIJCBEGFDBD, int HBJICDOMHDE, IAPDEOLDPHN NMHJCJBPPNM, Vector2 OJGLHAKPENN)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8FCAD40", Offset = "0x8FC9B40", VA = "0x188FCAD40")]
		public void SelectRecordingResolution(int FIJCBEGFDBD, int HBJICDOMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8FC7F80", Offset = "0x8FC6D80", VA = "0x188FC7F80", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8FC81B0", Offset = "0x8FC6FB0", VA = "0x188FC81B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4A10", Offset = "0x8FC3810", VA = "0x188FC4A10")]
		private void ECIMHBFGKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8FC7F30", Offset = "0x8FC6D30", VA = "0x188FC7F30")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4B70", Offset = "0x8FC3970", VA = "0x188FC4B70")]
		protected void EHCNPCGAPME(Texture2D JDNNGPGPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6DD0", Offset = "0x8FC5BD0", VA = "0x188FC6DD0")]
		protected bool KNIDJDLIIIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5420", Offset = "0x8FC4220", VA = "0x188FC5420")]
		protected bool FIFELCGGDOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5120", Offset = "0x8FC3F20", VA = "0x188FC5120", Slot = "7")]
		public virtual void EncodePointer(IntPtr LGPJFIDCEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6970", Offset = "0x8FC5770", VA = "0x188FC6970")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6950", Offset = "0x8FC5750", VA = "0x188FC6950")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6960", Offset = "0x8FC5760", VA = "0x188FC6960")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5DD0", Offset = "0x8FC4BD0", VA = "0x188FC5DD0")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E5D0", VA = "0x180B2F7D0")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8400", Offset = "0x8FC7200", VA = "0x188FC8400", Slot = "8")]
		protected virtual string PEBKKABLHIK(string OLFIODOHEFG, string NNCCNBIHJDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5930", Offset = "0x8FC4730", VA = "0x188FC5930")]
		private static string GLLPNFOCHGA(JDDOJNNMABD MIIFEDKKLEJ, string GHADMHNDJBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3A80", Offset = "0x8FC2880", VA = "0x188FC3A80")]
		private static string ABHDDAFHMKB(JDDOJNNMABD MIIFEDKKLEJ, string GHADMHNDJBK, string GJJBKNNMHFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4CD0", Offset = "0x8FC3AD0", VA = "0x188FC4CD0")]
		protected static bool EKFGKBBFBPI(string GHADMHNDJBK, string FBPOKJGGEMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8FC7780", Offset = "0x8FC6580", VA = "0x188FC7780")]
		protected void OFCDNFMNFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5490", Offset = "0x8FC4290", VA = "0x188FC5490")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool JBMMHCCODLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6100", Offset = "0x8FC4F00", VA = "0x188FC6100")]
		private bool HHAKANJKCBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8A20", Offset = "0x8FC7820", VA = "0x188FC8A20", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8FCA650", Offset = "0x8FC9450", VA = "0x188FCA650")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x15FBFF0", Offset = "0x15FADF0", VA = "0x1815FBFF0")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5F60", Offset = "0x8FC4D60", VA = "0x188FC5F60")]
		protected void HDPFDLIIIAL(GHIAEMICGMB BOJDODIDDAF, EBKMJADKKCA MHGDKLIOBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB210", Offset = "0x8FCA010", VA = "0x188FCB210")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8FC87E0", Offset = "0x8FC75E0", VA = "0x188FC87E0")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCA6D0", Offset = "0x8FC94D0", VA = "0x188FCA6D0")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4790", Offset = "0x8FC3590", VA = "0x188FC4790")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4900", Offset = "0x8FC3700", VA = "0x188FC4900")]
		public static void DeleteCapture(FDBCJLLKFLN DMGIAIFLEBF, string GHADMHNDJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8FC60A0", Offset = "0x8FC4EA0", VA = "0x188FC60A0")]
		protected void HEPJJGBJMNP(OPIJDCAFCKI.BMMNMEEHIOE KPBCHEFJNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB840", Offset = "0x8FCA640", VA = "0x188FCB840", Slot = "11")]
		public virtual void StopCapture(bool LFJFGADABOG = false, bool LCFOBEHOKML = false, bool JIFBCFCNLEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4500", Offset = "0x8FC3300", VA = "0x188FC4500")]
		private static FINFNONHPOC.FHIBOADHKBL CAGFPJILIKK(VideoEncoderHints ICJEEENIMIK, string HDKIFPCAAHD)
		{
			return default(FINFNONHPOC.FHIBOADHKBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4590", Offset = "0x8FC3390", VA = "0x188FC4590")]
		private static bool CMBAABADINE(string GLIMJFLPLJE, VideoEncoderHints ICJEEENIMIK, string HDKIFPCAAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8FC71E0", Offset = "0x8FC5FE0", VA = "0x188FC71E0")]
		protected void MJPPOJIJFGN(string GLIMJFLPLJE, VideoEncoderHints ICJEEENIMIK, string HDKIFPCAAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8FC48C0", Offset = "0x8FC36C0", VA = "0x188FC48C0")]
		private void DJAJHEJINEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6830", Offset = "0x8FC5630", VA = "0x188FC6830")]
		private bool IELDEFCJLKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5FF0", Offset = "0x8FC4DF0", VA = "0x188FC5FF0")]
		protected bool HECDONEAGDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8FCC450", Offset = "0x8FCB250", VA = "0x188FCC450")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6E50", Offset = "0x8FC5C50", VA = "0x188FC6E50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6770", Offset = "0x8FC5570", VA = "0x188FC6770")]
		private void HPAAHNLBCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5380", Offset = "0x8FC4180", VA = "0x188FC5380")]
		private void FBMGGMJIGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC71B0", Offset = "0x8FC5FB0", VA = "0x188FC71B0")]
		protected bool MGPEFGDOFHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4BF0", Offset = "0x8FC39F0", VA = "0x188FC4BF0")]
		protected bool EJHAGJNCHPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5C40", Offset = "0x8FC4A40", VA = "0x188FC5C40")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4D10", Offset = "0x8FC3B10", VA = "0x188FC4D10")]
		protected float EMANKFIHBIE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4D40", Offset = "0x8FC3B40", VA = "0x188FC4D40")]
		protected bool EMMDFLIAABJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4880", Offset = "0x8FC3680", VA = "0x188FC4880")]
		protected void DHMKOIJNALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D80", Offset = "0x8FC5B80", VA = "0x188FC6D80")]
		protected void KMNFDIFPNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xBC1150", Offset = "0xBBFF50", VA = "0x180BC1150", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8FC47C0", Offset = "0x8FC35C0", VA = "0x188FC47C0")]
		protected void DGBMEOLEPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5070", Offset = "0x8FC3E70", VA = "0x188FC5070")]
		public void EncodeAudio(NativeArray<float> PJLPHHNGJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4F50", Offset = "0x8FC3D50", VA = "0x188FC4F50")]
		public void EncodeAudio(float[] PJLPHHNGJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8920", Offset = "0x8FC7720", VA = "0x188FC8920", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8FCC050", Offset = "0x8FCAE50", VA = "0x188FCC050", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC73C0", Offset = "0x8FC61C0", VA = "0x188FC73C0")]
		protected bool NMIBHOIDFMG(int FIJCBEGFDBD, int HBJICDOMHDE, bool OHMBGKPHKND = false, int PGHOOLFIMIM = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8240", Offset = "0x8FC7040", VA = "0x188FC8240")]
		protected RenderTexture PAAMJAAGHNG(Texture MCIKHHKODON, bool OHMBGKPHKND = false, int PGHOOLFIMIM = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC4F20", Offset = "0x8FC3D20", VA = "0x188FC4F20")]
		protected void ENLAIJPOOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8FCBFF0", Offset = "0x8FCADF0", VA = "0x188FCBFF0")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6980", Offset = "0x8FC5780", VA = "0x188FC6980")]
		protected int JHIGADECIOO(Camera HOHEOKHPGEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5A90", Offset = "0x8FC4890", VA = "0x188FC5A90")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5DE0", Offset = "0x8FC4BE0", VA = "0x188FC5DE0")]
		public static void GetResolution(HECAPFJKOJD NCJLDBCONMG, int FIJCBEGFDBD, int HBJICDOMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3C50", Offset = "0x8FC2A50", VA = "0x188FC3C50")]
		protected static int AOBOOFDBDHD(int HGMAIPELJHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8FCD3D0", Offset = "0x8FCC1D0", VA = "0x188FCD3D0")]
		public CaptureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum MFMGDLPCADJ
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
public enum LBINJAEDCKC
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Audio
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FHPECIHENHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private LBINJAEDCKC CIKGCPCPMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private int OELCJBJLMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private bool KIDEKCFNCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MFMGDLPCADJ MIOLEOJFCDL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public MFMGDLPCADJ HNNHDIJJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810", Slot = "6")]
		get
		{
			return default(MFMGDLPCADJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GONEJMEPAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE040", Offset = "0x8FCCE40", VA = "0x188FCE040")]
	public void PJACKNLMMKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE1A0", Offset = "0x8FCCFA0", VA = "0x188FCE1A0")]
	internal FHPECIHENHK(LBINJAEDCKC NFLMLELFHPH, int JJJJBEGKNIN, string PFLDDMDPCBI, MFMGDLPCADJ EKGBMHHIGAI, bool DDOGEFJJNGI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DCNKNIPCOAE : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private FHPECIHENHK[] FBEIGNPLFHC;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public FHPECIHENHK[] LHEDIEPMPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x290F670", Offset = "0x290E470", VA = "0x18290F670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8FCDCC0", Offset = "0x8FCCAC0", VA = "0x188FCDCC0")]
	internal DCNKNIPCOAE(FHPECIHENHK[] KFAGMEINGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8FCDBC0", Offset = "0x8FCC9C0", VA = "0x188FCDBC0")]
	public FHPECIHENHK AOMAPDHCAEA(string PFLDDMDPCBI, MFMGDLPCADJ LGJEOACNAII = MFMGDLPCADJ.Unknown)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x8FCDC60", Offset = "0x8FCCA60", VA = "0x188FCDC60")]
	public FHPECIHENHK ODLKOFEMMBE(MFMGDLPCADJ EKGBMHHIGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A350", Offset = "0x2A09150", VA = "0x182A0A350", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NHKMIPAONKD
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static bool EALDCFEODPD;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static DCNKNIPCOAE EOKHJDAGODE;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static DCNKNIPCOAE BGAGICKOEDO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public static DCNKNIPCOAE PEOCHLLOFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5850", Offset = "0x8FD4650", VA = "0x188FD5850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static DCNKNIPCOAE FMPFJLPAFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6100", Offset = "0x8FD4F00", VA = "0x188FD6100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6150", Offset = "0x8FD4F50", VA = "0x188FD6150")]
	private static void PPNHCHBFOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FD58A0", Offset = "0x8FD46A0", VA = "0x188FD58A0")]
	private static void OBAGFAFLGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum MIDNPIDLBAM
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	AudioInput
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BLIKGDDNEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private MIDNPIDLBAM ILIHDDLHNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private int OELCJBJLMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private MFMGDLPCADJ MIOLEOJFCDL;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public MFMGDLPCADJ HNNHDIJJBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "6")]
		get
		{
			return default(MFMGDLPCADJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2640", Offset = "0x8FC1440", VA = "0x188FC2640")]
	internal BLIKGDDNEDI(MIDNPIDLBAM DABBBNKCDHM, int JJJJBEGKNIN, string PFLDDMDPCBI, MFMGDLPCADJ EKGBMHHIGAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BAGHAPHHGJG : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private BLIKGDDNEDI[] MGJGMJFNOAF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BLIKGDDNEDI[] DGLJCHDEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x290F670", Offset = "0x290E470", VA = "0x18290F670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8FC25D0", Offset = "0x8FC13D0", VA = "0x188FC25D0")]
	internal BAGHAPHHGJG(BLIKGDDNEDI[] DJEIHLLJCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2570", Offset = "0x8FC1370", VA = "0x188FC2570")]
	public BLIKGDDNEDI ODLKOFEMMBE(MFMGDLPCADJ EKGBMHHIGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A350", Offset = "0x2A09150", VA = "0x182A0A350", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class HMCPKMHHBCF
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private static bool EALDCFEODPD;

	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private static BAGHAPHHGJG BHMICGHMDFO;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static BAGHAPHHGJG KIDJPLBHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3100", Offset = "0x8FD1F00", VA = "0x188FD3100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3610", Offset = "0x8FD2410", VA = "0x188FD3610")]
	private static void PPNHCHBFOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8FD31E0", Offset = "0x8FD1FE0", VA = "0x188FD31E0")]
	private static void CFKHNOGAFNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CLHINBKBBGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum DGGMGCPCHMD
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
	private string KNFFFINPNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private int KLADOGLDHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private bool DMAHJMPCPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private FDBCJLLKFLN EPEDOCOBNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private FINFNONHPOC.FHIBOADHKBL NEOLDHIDLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ManualResetEvent CJEADLKDELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private DGGMGCPCHMD JJBJEFKAOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private string CBDADMAMMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool MDBEGHBDGLM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal Action<CLHINBKBBGP> PLABKPECIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3910", Offset = "0x8FC2710", VA = "0x188FC3910")]
	internal CLHINBKBBGP(FDBCJLLKFLN DMGIAIFLEBF, string GHADMHNDJBK, int MJIBDELKIML, bool NIOALNJHEDP, string HDKIFPCAAHD, bool BNFAOOHAMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3670", Offset = "0x8FC2470", VA = "0x188FC3670")]
	internal void KOJEBDKKEFG(FINFNONHPOC.FHIBOADHKBL PJPBHKPNLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3690", Offset = "0x8FC2490", VA = "0x188FC3690")]
	private bool PPIEHGOBOII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8FC34B0", Offset = "0x8FC22B0", VA = "0x188FC34B0")]
	public bool JHPGJAABBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8FC31C0", Offset = "0x8FC1FC0", VA = "0x188FC31C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FINFNONHPOC
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FHIBOADHKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public bool LPBDEOLHPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public bool DLJGOPJFJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public GHIAEMICGMB OIHJDAEHJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public bool PEKGMINBMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EBKMJADKKCA MHGDKLIOBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public bool FODHHMNMMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string PMMNALGEJDG;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE000", Offset = "0x8FCCE00", VA = "0x188FCE000")]
		public bool FPKKCJICJCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE020", Offset = "0x8FCCE20", VA = "0x188FCE020")]
		public bool ONODFKDBHIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FCDFE0", Offset = "0x8FCCDE0", VA = "0x188FCDFE0")]
		public void BCLOPFGDLAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DJNKICGIMLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public uint FMFDAFLDAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public long BCMFMCHGEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public long IBOFMHFOKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public long KHHHBKPBPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public long HNLHELLDBHD;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DJNKICGIMLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal enum BCBCBKHLONJ
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
	private sealed class CMHJIENDNMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public string filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public bool keepBackup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public FHIBOADHKBL options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ManualResetEvent syncEvent;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CMHJIENDNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3990", Offset = "0x8FC2790", VA = "0x188FC3990")]
		internal void JOLDGJGEOAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly uint APONDKOLNNH;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly uint LBFJLAOOGLB;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly uint NIBIONHEIGD;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly uint GOJHOEGDLOM;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly uint KJJNDAIBPGE;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly uint JJCCBJDHPME;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly uint FIDICIFOBBK;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly uint NHGJMDDAPCE;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly uint EHPCGBCMOAP;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly uint KOHNIKICCMD;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly uint ODFIKFDNHIP;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly uint IFMFALEOPEP;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly uint HLFKDBGFHIE;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly uint GHILEMNKPIP;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly uint DCFMCOOODGG;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly uint EGFEEANDBCA;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly uint PEDEHNAFPGE;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly uint FODHDGICEEG;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly uint PFDDEPMGBPD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly uint FNGBFCMFJAJ;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly uint NLFHJELDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private BinaryReader JLEBLCMPHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Stream GDOPAKEGOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private FHIBOADHKBL KPPDJDDHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool MIEAOHOPLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<DJNKICGIMLO> ABNCKJNONDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private List<DJNKICGIMLO> PFMKLOJKKDD;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8FCED30", Offset = "0x8FCDB30", VA = "0x188FCED30")]
	public static ManualResetEvent CFJICPDNODM(string GLIMJFLPLJE, bool LJNGDFGDFHO, FHIBOADHKBL PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8FD0B00", Offset = "0x8FCF900", VA = "0x188FD0B00")]
	public static bool IJGHGGPBLMO(string GLIMJFLPLJE, bool LJNGDFGDFHO, FHIBOADHKBL PMEODJMCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8FD0E50", Offset = "0x8FCFC50", VA = "0x188FD0E50")]
	public static bool IJGHGGPBLMO(string BIPEMEBMHDE, string LDBONHGPPJM, FHIBOADHKBL PMEODJMCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3020", Offset = "0x8FD1E20", VA = "0x188FD3020")]
	public FINFNONHPOC(FHIBOADHKBL PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1200", Offset = "0x8FD0000", VA = "0x188FD1200")]
	public bool JIOJDNIMGCD(Stream IADLBHEOBFH, Stream FCDMNGLNNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8FD04B0", Offset = "0x8FCF2B0", VA = "0x188FD04B0")]
	public void HAOKAFOACHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8FD05A0", Offset = "0x8FCF3A0", VA = "0x188FD05A0")]
	private static DJNKICGIMLO HGFHPNFBKDF(uint FMFDAFLDAAK, List<DJNKICGIMLO> JKHAKJHCFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE8B0", Offset = "0x8FCD6B0", VA = "0x188FCE8B0")]
	private List<DJNKICGIMLO> CBPJODFLBIB(DJNKICGIMLO KLAPJFIMNJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE980", Offset = "0x8FCD780", VA = "0x188FCE980")]
	private List<DJNKICGIMLO> CBPJODFLBIB(long FJGFDGIAGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE200", Offset = "0x8FCD000", VA = "0x188FCE200")]
	private DJNKICGIMLO AOKOBFPOEGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8FCEF00", Offset = "0x8FCDD00", VA = "0x188FCEF00")]
	private bool CGAAJIGCFCD(DJNKICGIMLO FLFGHPEEGLF, uint FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8FD0770", Offset = "0x8FCF570", VA = "0x188FD0770")]
	private void HNAJAMAODDJ(DJNKICGIMLO FLFGHPEEGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1E70", Offset = "0x8FD0C70", VA = "0x188FD1E70")]
	private void NLAALMLFLAB(DJNKICGIMLO FLFGHPEEGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1180", Offset = "0x8FCFF80", VA = "0x188FD1180")]
	private void IMJMHEPAPGE(DJNKICGIMLO FLFGHPEEGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8FCF1D0", Offset = "0x8FCDFD0", VA = "0x188FCF1D0")]
	private void CPJKMHPBAMC(long PNMBEFNOJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE530", Offset = "0x8FCD330", VA = "0x188FCE530")]
	private void BGFGLPJDADA(long PNMBEFNOJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8FCFE70", Offset = "0x8FCEC70", VA = "0x188FCFE70")]
	private uint GPDHCFKFMGK(DJNKICGIMLO KLAPJFIMNJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8FCF950", Offset = "0x8FCE750", VA = "0x188FCF950")]
	private bool EEONNDGALCK(DJNKICGIMLO DOBGGCPIEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8FCEB30", Offset = "0x8FCD930", VA = "0x188FCEB30")]
	private void CCDBPDKJJDN(DJNKICGIMLO FLFGHPEEGLF, uint DHOPHFBOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8FCFC00", Offset = "0x8FCEA00", VA = "0x188FCFC00")]
	private void GCOGPIEPOEP(DJNKICGIMLO FLFGHPEEGLF, uint DHOPHFBOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1A40", Offset = "0x8FD0840", VA = "0x188FD1A40")]
	private void JKKLNJMDFBG(DJNKICGIMLO FLFGHPEEGLF, uint DHOPHFBOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE3E0", Offset = "0x8FCD1E0", VA = "0x188FCE3E0")]
	private uint BFIAFDONOLL(DJNKICGIMLO FLFGHPEEGLF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8FCF2E0", Offset = "0x8FCE0E0", VA = "0x188FCF2E0")]
	private uint DECNEPGJKPA(DJNKICGIMLO FLFGHPEEGLF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1DB0", Offset = "0x8FD0BB0", VA = "0x188FD1DB0")]
	private static BCBCBKHLONJ MKHFAJKAMFD(GHIAEMICGMB KJLMJGOOKJM)
	{
		return default(BCBCBKHLONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8FCFB40", Offset = "0x8FCE940", VA = "0x188FCFB40")]
	private uint EGJNEHLNCGJ(BCBCBKHLONJ OIHJDAEHJLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8FD22D0", Offset = "0x8FD10D0", VA = "0x188FD22D0")]
	private uint PHGKPCCNLFM(EBKMJADKKCA BKNKAEDPIMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8FD0880", Offset = "0x8FCF680", VA = "0x188FD0880")]
	private uint IFBNIJEKOGJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE690", Offset = "0x8FCD490", VA = "0x188FCE690")]
	private uint BOBIDPEIJFM(string IHKCFIPDPKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1EE0", Offset = "0x8FD0CE0", VA = "0x188FD1EE0")]
	private uint ODDHCFEHHFL(EBKMJADKKCA BKNKAEDPIMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8FCF060", Offset = "0x8FCDE60", VA = "0x188FCF060")]
	private uint CICIPNLEFFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8FCF7D0", Offset = "0x8FCE5D0", VA = "0x188FCF7D0")]
	private uint DNNFINDEFEP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1BC0", Offset = "0x8FD09C0", VA = "0x188FD1BC0")]
	private void JLOPILGJKFM(DJNKICGIMLO FLFGHPEEGLF, long PBPOCMHAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1D10", Offset = "0x8FD0B10", VA = "0x188FD1D10")]
	private ushort LCHEBKLEDJP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x8FD07E0", Offset = "0x8FCF5E0", VA = "0x188FD07E0")]
	private uint ICHDNDFOEJF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1DD0", Offset = "0x8FD0BD0", VA = "0x188FD1DD0")]
	private ulong MOGBHNCACIC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x8FD1C70", Offset = "0x8FD0A70", VA = "0x188FD1C70")]
	private void KGMBNCJEKKD(uint FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x8FCFDB0", Offset = "0x8FCEBB0", VA = "0x188FCFDB0")]
	private void GJJLNGABILG(uint HGMAIPELJHM, bool NEEGFACLLIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE5E0", Offset = "0x8FCD3E0", VA = "0x188FCE5E0")]
	private void BJGCFPMCDGG(ulong HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8FD06E0", Offset = "0x8FCF4E0", VA = "0x188FD06E0")]
	private static uint HKLHAEKLMGI(string FMFDAFLDAAK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum HDBEAHHAHJE
{
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum JJPKNNEKKJD
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
public enum GHIAEMICGMB
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum LKFILIEJJAO
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
public enum EBKMJADKKCA
{
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Equirectangular360,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Equirectangular180
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum ODNAKEHDANP
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
public enum MLHCAPJHGEL
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Manual,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	OnStart
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum HLGBFAEBJPP
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
public enum BGPCFPEBKNN
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
public enum FDBCJLLKFLN
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	VideoFile,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	ImageSequence,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	NamedPipe
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum JIENFAPKMJK
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
public enum FKEEDMEPAPP
{
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DICGFADEJPJ
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	Realtime,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Fixed,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	Nearest
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum IDEEGMCCIPM
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
public class NLLECEJJPFK
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static string[] BHBPAKPMKHP;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static string[] FNCEMCJHGLD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static string[] NACLHDIGDLD;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static string[] HHIHGJBDOPG;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6C20", Offset = "0x8FD5A20", VA = "0x188FD6C20")]
	public static string[] GDONJNMFFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6590", Offset = "0x8FD5390", VA = "0x188FD6590")]
	public static RenderTextureFormat CDPCDPFEOCI(bool FFJDCDMEPBA, bool OPMIBJNCIKD, bool GGDEFECFDLO)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6B50", Offset = "0x8FD5950", VA = "0x188FD6B50")]
	public static bool EKGEMDHEHJI(Camera KBNICFAJHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6C90", Offset = "0x8FD5A90", VA = "0x188FD6C90")]
	public static Camera[] HEILMEFPKJE(Camera KBNICFAJHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x8FD71E0", Offset = "0x8FD5FE0", VA = "0x188FD71E0")]
	public static bool KIFPIGDGJEM(string DBEJIJLJAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8FD7300", Offset = "0x8FD6100", VA = "0x188FD7300")]
	public static bool LBNLAHIPMFO(string DBEJIJLJAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8FD63A0", Offset = "0x8FD51A0", VA = "0x188FD63A0")]
	public static bool CBLNKJELHNC(string NLEKMMGEABK, [Out] ulong IBOIOJFMHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8FD6AA0", Offset = "0x8FD58A0", VA = "0x188FD6AA0")]
	public static string DBICAABEHGP(BGPCFPEBKNN DILPKDIDKCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class INDONAKNDCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum DAPOIMCGPDO
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		PCM16 = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Float32 = 4
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static byte[] CDAAKBGDANJ;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private static byte[] DBJFHGDDCDA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private static byte[] DMGDOHMMEPG;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static byte[] DJGDCPPDENA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private static byte[] LIFCNMJDLIP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private static byte[] OEGGFOPDAFH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private static byte[] JBBPNNDAOEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private const int NJDEJBLEBID = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FileStream KMKHGAGLIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private byte[] IGONFKFBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private int IAPHIMLDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private int PIHNOHGBCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int IKHAHMOCMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int JPHLKANHEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private DAPOIMCGPDO CLNCMJLHEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private int KFBOCAMMBLE;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x8FD45D0", Offset = "0x8FD33D0", VA = "0x188FD45D0")]
	public INDONAKNDCG(string GHADMHNDJBK, int KMCPCDKHDCK, int FMAPGJELDND, DAPOIMCGPDO GPCKLLOBACA = DAPOIMCGPDO.Float32)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x8FD39E0", Offset = "0x8FD27E0", VA = "0x188FD39E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x8FD40A0", Offset = "0x8FD2EA0", VA = "0x188FD40A0")]
	public void OBOJEKJLKNG(float[] KANAIIDGHCH, int MCDAGMKGPKP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3A60", Offset = "0x8FD2860", VA = "0x188FD3A60")]
	public void MKCIBHBGCEO(int KABPPGGMIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8FD4230", Offset = "0x8FD3030", VA = "0x188FD4230")]
	private static byte[] PIEFPDPHDIC(int MKPEOGPFEFH, int MCJGICKIGFF = 2)
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
		[Cpp2IlInjected.Address(RVA = "0x8FDD9C0", Offset = "0x8FDC7C0", VA = "0x188FDD9C0")]
		public void RunCoroutine(IEnumerator PMOBKOJPPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
