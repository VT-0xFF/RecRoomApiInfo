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
		private Vector3 FDFKLCIEKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LPCFANLNJGP KBBCBADMFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LGGDOOKOMNI PPIFKJOCIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private LPHJKIBGOHE HPCILNIKPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr HOIDALEKPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int CKPDAPCLLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] OLKGIOJJEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> CNFEGDBHNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> GNFNCFOOPMD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9136950", Offset = "0x9135350", VA = "0x189136950")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91366C0", Offset = "0x91350C0", VA = "0x1891366C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91359C0", Offset = "0x91343C0", VA = "0x1891359C0")]
		internal void JKJEBPBIKPO(LPCFANLNJGP MOKDONKKJGG, LGGDOOKOMNI IDGDEIBHPJC, LPHJKIBGOHE NAMBJAAIKHL, int NLJJPHIBBCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9136830", Offset = "0x9135230", VA = "0x189136830")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9135BD0", Offset = "0x91345D0", VA = "0x189135BD0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9135BB0", Offset = "0x91345B0", VA = "0x189135BB0")]
		private void LALIFGAIDPD(Vector3 KFJFDPLEJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x91355D0", Offset = "0x9133FD0", VA = "0x1891355D0")]
		private void ENPIMOBNINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9135F40", Offset = "0x9134940", VA = "0x189135F40")]
		private void OnAudioFilterRead(float[] EFNPFAIMEFP, int MCJPLGCDCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9135780", Offset = "0x9134180", VA = "0x189135780")]
		internal void IFDGCBDGLON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9135F00", Offset = "0x9134900", VA = "0x189135F00")]
		internal int MFBHGLGAKEE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9135D30", Offset = "0x9134730", VA = "0x189135D30")]
		internal void MABBEEBPNIM(bool ANIGDKNMIJK, bool KJKLGLKJFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9136AD0", Offset = "0x91354D0", VA = "0x189136AD0")]
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
		private LPCFANLNJGP _order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private MBBLBCEACNL _format;

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
		private float[] MIKNBPLMONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FPCDIFDBCDL GEMJGBKJOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> FNKENKJAFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int FAPGFHFLAIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LPCFANLNJGP ALCDHGPIINE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			get
			{
				return default(LPCFANLNJGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MBBLBCEACNL DBFLIDEOLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			get
			{
				return default(MBBLBCEACNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9136DA0", Offset = "0x91357A0", VA = "0x189136DA0")]
		internal void EGAAEPJIMCA(AmbisonicSource PBOCDEMNFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9136C10", Offset = "0x9135610", VA = "0x189136C10")]
		internal void CCIMBDPINFN(AmbisonicSource PBOCDEMNFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9137890", Offset = "0x9136290", VA = "0x189137890")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9136CF0", Offset = "0x91356F0", VA = "0x189136CF0")]
		private void COIFPHKFFGL(AmbisonicSource PBOCDEMNFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9136EF0", Offset = "0x91358F0", VA = "0x189136EF0")]
		private void GMDNKEBKJDL(bool HAMCDLLKGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9137020", Offset = "0x9135A20", VA = "0x189137020")]
		private void JGNNBFLFIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9136F20", Offset = "0x9135920", VA = "0x189136F20")]
		private void IKCMLMJKKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9136BF0", Offset = "0x91355F0", VA = "0x189136BF0")]
		private bool AIEIKMKPAAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9137550", Offset = "0x9135F50", VA = "0x189137550")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9137610", Offset = "0x9136010", VA = "0x189137610")]
		private void MDJKFPBJDLB(bool KJKLGLKJFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9137440", Offset = "0x9135E40", VA = "0x189137440")]
		internal void KFCKNEJBNAE(float[] EFNPFAIMEFP, int BJFMLIOLMJE, bool IAOPJLLPGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9137850", Offset = "0x9136250", VA = "0x189137850")]
		private void OPKLAHGNOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x91378A0", Offset = "0x91362A0", VA = "0x1891378A0")]
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
		private FPCDIFDBCDL GEMJGBKJOMJ;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x91379E0", Offset = "0x91363E0", VA = "0x1891379E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91379A0", Offset = "0x91363A0", VA = "0x1891379A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9137970", Offset = "0x9136370", VA = "0x189137970")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9137B20", Offset = "0x9136520", VA = "0x189137B20")]
		public AudioSourceToWav()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Camera Selector", 300)]
	public class CameraSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum JPBMHLMFDJH
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
		public enum ABPMLKDCAAF
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
		private JPBMHLMFDJH _selectBy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ABPMLKDCAAF _scanFrequency;

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
		private Camera[] HNELFCOGNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int POMCIEINEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int KINDCGFHACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool CBHMLOBONLB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera AMAFDKGJECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9138520", Offset = "0x9136F20", VA = "0x189138520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public JPBMHLMFDJH GIBIAAKKAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(JPBMHLMFDJH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9138570", Offset = "0x9136F70", VA = "0x189138570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ABPMLKDCAAF GELLKHGAJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			get
			{
				return default(ABPMLKDCAAF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9138550", Offset = "0x9136F50", VA = "0x189138550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PMHCGLNPGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9138560", Offset = "0x9136F60", VA = "0x189138560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string OIOFIJPAAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x91385A0", Offset = "0x9136FA0", VA = "0x1891385A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string DPFKDDBOMGO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9138580", Offset = "0x9136F80", VA = "0x189138580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9137C30", Offset = "0x9136630", VA = "0x189137C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9138360", Offset = "0x9136D60", VA = "0x189138360")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9137C30", Offset = "0x9136630", VA = "0x189137C30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9138450", Offset = "0x9136E50", VA = "0x189138450")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9138110", Offset = "0x9136B10", VA = "0x189138110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x91381B0", Offset = "0x9136BB0", VA = "0x1891381B0")]
		private void PLPAGHIMPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9138100", Offset = "0x9136B00", VA = "0x189138100")]
		private void LIKKPMDGBKL(Scene LDEJAMJEHAA, LoadSceneMode GDIJNLEACAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x91382A0", Offset = "0x9136CA0", VA = "0x1891382A0")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9137DD0", Offset = "0x91367D0", VA = "0x189137DD0")]
		private Camera DGDAPJCJECM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9138370", Offset = "0x9136D70", VA = "0x189138370")]
		public void UpdateCameraCache(bool ENMKCFOCPJJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9137C40", Offset = "0x9136640", VA = "0x189137C40")]
		private static Camera BLCLADPIFDL(int IOKFHDAEEKA, Camera[] PDGANMOMPPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9137D40", Offset = "0x9136740", VA = "0x189137D40")]
		private static Camera DAJJIHHJONC(int IOKFHDAEEKA, Camera[] PDGANMOMPPL, string CKJPANLJIKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9138060", Offset = "0x9136A60", VA = "0x189138060")]
		private static Camera GHEEOMMFIII(int IOKFHDAEEKA, Camera[] PDGANMOMPPL, string IELIBBNCJAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9138470", Offset = "0x9136E70", VA = "0x189138470")]
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
		private int JMPBKNHIADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int JKEPAEOPKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int EHDOOCBJJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int POFBNBALHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] GGOJKPLAGPJ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9138AD0", Offset = "0x91374D0", VA = "0x189138AD0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x91387E0", Offset = "0x91371E0", VA = "0x1891387E0")]
		private void EOMIKNPIMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9138800", Offset = "0x9137200", VA = "0x189138800")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9138AF0", Offset = "0x91374F0", VA = "0x189138AF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x91385C0", Offset = "0x9136FC0", VA = "0x1891385C0")]
		private float[] ELGHPOHBKIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9138B90", Offset = "0x9137590", VA = "0x189138B90")]
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
		private const int PIKFDNMCBDC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] EALKMFOFJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] NOKIGLNBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int MHLKEKLDPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle LHCCCOGDNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int HOHDCGIJBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int AIAHAFFACHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object FJPFMLGOIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool JOMINLDODMI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] IOACHLKNGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int AEKMNDEBOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr FJHINPIGNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9139630", Offset = "0x9138030", VA = "0x189139630")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int CDJOANFEAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A70", Offset = "0xEC8470", VA = "0x180EC9A70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int LMBMFCEPJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9139640", Offset = "0x9138040", VA = "0x189139640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int MPJAMNNECBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9138F00", Offset = "0x9137900", VA = "0x189138F00", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x100EA60", Offset = "0x100D460", VA = "0x18100EA60", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9139490", Offset = "0x9137E90", VA = "0x189139490", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9138EF0", Offset = "0x91378F0", VA = "0x189138EF0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x91393E0", Offset = "0x9137DE0", VA = "0x1891393E0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x91392F0", Offset = "0x9137CF0", VA = "0x1891392F0", Slot = "13")]
		public override IntPtr ReadData([Out] int AJDEGEPLAEO)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9138BA0", Offset = "0x91375A0", VA = "0x189138BA0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9138C40", Offset = "0x9137640", VA = "0x189138C40")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9139570", Offset = "0x9137F70", VA = "0x189139570")]
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
		private int KPNCMEJPKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool LGEAANJEMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> ANFOFCKBGOL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase HHCKIIBCOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int LMBMFCEPJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9139640", Offset = "0x9138040", VA = "0x189139640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int MPJAMNNECBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x91397F0", Offset = "0x91381F0", VA = "0x1891397F0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9139650", Offset = "0x9138050", VA = "0x189139650")]
		private NativeArray<float> FCKMFCNLDKH(int AJDEGEPLAEO)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void JOCCKJPEAFP(NativeArray<float> FPGJFOLEKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9139810", Offset = "0x9138210", VA = "0x189139810", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9139920", Offset = "0x9138320", VA = "0x189139920", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x91397A0", Offset = "0x91381A0", VA = "0x1891397A0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9139980", Offset = "0x9138380", VA = "0x189139980")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAC9DF0", Offset = "0xAC87F0", VA = "0x180AC9DF0")]
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
		private const int PIKFDNMCBDC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] EALKMFOFJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] NOKIGLNBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int FGFGCDABPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int PMFLKLJBANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle LHCCCOGDNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int HOHDCGIJBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool DBHIJPDLHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int FKMPMCNMHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int AIAHAFFACHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object FJPFMLGOIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool GJKIBOGCCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JOMINLDODMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int HHDAEKKGFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int IOFKAFPIPOM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> NDIIDCKICIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GOFLJPKAKHN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] IOACHLKNGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int AEKMNDEBOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr FJHINPIGNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x913ADB0", Offset = "0x91397B0", VA = "0x18913ADB0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int CDJOANFEAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x13412A0", Offset = "0x133FCA0", VA = "0x1813412A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int LMBMFCEPJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9139640", Offset = "0x9138040", VA = "0x189139640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int MPJAMNNECBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB2F870", Offset = "0xB2E270", VA = "0x180B2F870", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x913A860", Offset = "0x9139260", VA = "0x18913A860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x913A070", Offset = "0x9138A70", VA = "0x18913A070", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x913A670", Offset = "0x9139070", VA = "0x18913A670", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x913AA40", Offset = "0x9139440", VA = "0x18913AA40", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x913A060", Offset = "0x9138A60", VA = "0x18913A060", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x913A5B0", Offset = "0x9138FB0", VA = "0x18913A5B0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x913A460", Offset = "0x9138E60", VA = "0x18913A460", Slot = "13")]
		public override IntPtr ReadData([Out] int AJDEGEPLAEO)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9139B50", Offset = "0x9138550", VA = "0x189139B50", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9139BF0", Offset = "0x91385F0", VA = "0x189139BF0")]
		public void OnAudioFilterReadCombiner(float[] BLPDDGCLNPE, int MCAKEJBBCAG, bool ALPIDFIKCLN, int HGCOIPKMAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9139A70", Offset = "0x9138470", VA = "0x189139A70")]
		private float[] EOLAHOBGGEN(float[] BLPDDGCLNPE, int OENBGMNMDNJ, int OKJMNFLPAAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x913ACF0", Offset = "0x91396F0", VA = "0x18913ACF0")]
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
		public CaptureBase HHCKIIBCOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int LMBMFCEPJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int MPJAMNNECBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x913ADC0", Offset = "0x91397C0", VA = "0x18913ADC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC9DF0", Offset = "0xAC87F0", VA = "0x180AC9DF0")]
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
		private sealed class OIAKCNJLCFA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public OIAKCNJLCFA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x914B3A0", Offset = "0x9149DA0", VA = "0x18914B3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x914B440", Offset = "0x9149E40", VA = "0x18914B440", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HIHGBBBCIAP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public HIHGBBBCIAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x914AF40", Offset = "0x9149940", VA = "0x18914AF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x914B350", Offset = "0x9149D50", VA = "0x18914B350", Slot = "8")]
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
		private RenderTexture JDLEDILKGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture CMJLMIJIEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr CENLPGCOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture OEIJOMMNAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture BDLHBINPIHN;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector AGLJGANALPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBC1AE0", Offset = "0xBC04E0", VA = "0x180BC1AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC24650", Offset = "0xC23050", VA = "0x180C24650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool FOKDHCGCCEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x25B4970", Offset = "0x25B3370", VA = "0x1825B4970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9141CA0", Offset = "0x91406A0", VA = "0x189141CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9143250", Offset = "0x9141C50", VA = "0x189143250")]
		public void SetCamera(Camera BHPJMHCIGDE, bool DEKGOMPGCKC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9143200", Offset = "0x9141C00", VA = "0x189143200")]
		public void SetCamera(Camera BHPJMHCIGDE, Camera[] CLFJDCJFLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9141E20", Offset = "0x9140820", VA = "0x189141E20")]
		private bool KBJKFKOBJCI(Texture JBOOEIGKOID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9141D40", Offset = "0x9140740", VA = "0x189141D40")]
		private bool GNOOKAHNLDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9142210", Offset = "0x9140C10", VA = "0x189142210")]
		private bool LPHHFJCKCBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x91434A0", Offset = "0x9141EA0", VA = "0x1891434A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9141DA0", Offset = "0x91407A0", VA = "0x189141DA0")]
		[IteratorStateMachine(typeof(OIAKCNJLCFA))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9141CB0", Offset = "0x91406B0", VA = "0x189141CB0")]
		[IteratorStateMachine(typeof(HIHGBBBCIAP))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x91420D0", Offset = "0x9140AD0", VA = "0x1891420D0")]
		private bool KJGAMOGHOLC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9142240", Offset = "0x9140C40", VA = "0x189142240")]
		private void MKHCKHBCJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9143370", Offset = "0x9141D70", VA = "0x189143370", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9141F00", Offset = "0x9140900", VA = "0x189141F00")]
		private void KFDLDMPNEHF(int ANOHMOCFGAJ, int NJLBPEGOCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC42210", Offset = "0xC40C10", VA = "0x180C42210", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9142780", Offset = "0x9141180", VA = "0x189142780", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9142670", Offset = "0x9141070", VA = "0x189142670", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9143630", Offset = "0x9142030", VA = "0x189143630")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9141D30", Offset = "0x9140730", VA = "0x189141D30")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void GMHPEMPPAMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private enum DEMKEIEKMCA
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
		private sealed class GADMANCBFDC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public GADMANCBFDC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x914AE80", Offset = "0x9149880", VA = "0x18914AE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x914AEF0", Offset = "0x91498F0", VA = "0x18914AEF0", Slot = "8")]
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
		private EOOKDENKLDJ _cubemapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private EMMCJMEONFK _cubemapDepth;

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
		private LNGPEFHKNMF _stereoRendering;

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
		private RenderTexture AEMMJBMMLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] BGCEOCLMIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material HNMMDDIJCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material LHKPGFAPKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture LIPIACPNEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture JNENFCNKCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr CENLPGCOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int JDNGLLHJCMF;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector AGLJGANALPD
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1AE0", Offset = "0xBC04E0", VA = "0x180BC1AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC24650", Offset = "0xC23050", VA = "0x180C24650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EOOKDENKLDJ DNIHDIJFKOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xBC1E60", Offset = "0xBC0860", VA = "0x180BC1E60")]
			get
			{
				return default(EOOKDENKLDJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9141C40", Offset = "0x9140640", VA = "0x189141C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EMMCJMEONFK GEDOCEGKPJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9141BE0", Offset = "0x91405E0", VA = "0x189141BE0")]
			get
			{
				return default(EMMCJMEONFK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9141C30", Offset = "0x9140630", VA = "0x189141C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AFKFCAGELEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x25B4970", Offset = "0x25B3370", VA = "0x1825B4970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9141CA0", Offset = "0x91406A0", VA = "0x189141CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KNJPOFKFFDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9141C20", Offset = "0x9140620", VA = "0x189141C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9141C90", Offset = "0x9140690", VA = "0x189141C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FICPOIFAGHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9141C00", Offset = "0x9140600", VA = "0x189141C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9141C60", Offset = "0x9140660", VA = "0x189141C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DLPGFAGIFML
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9141C10", Offset = "0x9140610", VA = "0x189141C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9141C70", Offset = "0x9140670", VA = "0x189141C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public LNGPEFHKNMF AEIMJOBNOIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x296C0D0", Offset = "0x296AAD0", VA = "0x18296C0D0")]
			get
			{
				return default(LNGPEFHKNMF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9141C80", Offset = "0x9140680", VA = "0x189141C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EEMADJAKHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9141BF0", Offset = "0x91405F0", VA = "0x189141BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9141C50", Offset = "0x9140650", VA = "0x189141C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9141B10", Offset = "0x9140510", VA = "0x189141B10")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x913E680", Offset = "0x913D080", VA = "0x18913E680")]
		private DEMKEIEKMCA OFHGCEDMFDL()
		{
			return default(DEMKEIEKMCA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xC32890", Offset = "0xC31290", VA = "0x180C32890")]
		public void SetCamera(Camera GDINMNFHIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x91419A0", Offset = "0x91403A0", VA = "0x1891419A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x913DDE0", Offset = "0x913C7E0", VA = "0x18913DDE0")]
		[IteratorStateMachine(typeof(GADMANCBFDC))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x913DA90", Offset = "0x913C490", VA = "0x18913DA90")]
		private void HHCKIIBCOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x913DF40", Offset = "0x913C940", VA = "0x18913DF40")]
		private static void LBHAPHKAABF(RenderTexture JBOOEIGKOID, Color EOGEFFOIIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x913D640", Offset = "0x913C040", VA = "0x18913D640")]
		private void FNPKKIKDEME(RenderTexture EKAEJABFIAN, RenderTexture JFBLIPHGGPK, bool CIPJFDGKPJH, Quaternion AMHDLJKDJBK, bool DAPHOMMFDEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x913E0D0", Offset = "0x913CAD0", VA = "0x18913E0D0")]
		private void MKHCKHBCJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x913E980", Offset = "0x913D380", VA = "0x18913E980")]
		private void PAANDMGHMBL(Camera GDINMNFHIGJ, RenderTexture PPOFADAHAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x913DE60", Offset = "0x913C860", VA = "0x18913DE60")]
		private void KNMJDALNCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9140390", Offset = "0x913ED90", VA = "0x189140390", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x913DA50", Offset = "0x913C450", VA = "0x18913DA50", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x91417A0", Offset = "0x91401A0", VA = "0x1891417A0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x913E6B0", Offset = "0x913D0B0", VA = "0x18913E6B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x914B610", Offset = "0x914A010", VA = "0x18914B610")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BMHKCAJCIBF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public BMHKCAJCIBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9137B70", Offset = "0x9136570", VA = "0x189137B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9137BE0", Offset = "0x91365E0", VA = "0x189137BE0", Slot = "8")]
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
		private int JEJEMGOKIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int HAENMCPIBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform ONMJFNKDCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera ONEDEIFGLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera CHDODAMLPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera DMHFFAKKGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera NPGCDPIDDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture OAAJOCILJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr CENLPGCOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material LAKHHGCKCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int NFAJIJGIEAG;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings JKJEBPBIKPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xBC1AE0", Offset = "0xBC04E0", VA = "0x180BC1AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x913D530", Offset = "0x913BF30", VA = "0x18913D530")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x913D230", Offset = "0x913BC30", VA = "0x18913D230")]
		public void SetCamera(Camera GDINMNFHIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x913D260", Offset = "0x913BC60", VA = "0x18913D260", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x913B4C0", Offset = "0x9139EC0", VA = "0x18913B4C0")]
		private Camera FGLILGLIFIE(Camera GDINMNFHIGJ, string AOCBOGDMEGN, float JHICHOFBGMG, float FAOAECMNONL, int JINPDPHEAGJ, int HDNBENONCKM, float IBFOBJLAGJN, float DEDMEALJJPH, int NKBFDPMIMEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x913D3A0", Offset = "0x913BDA0", VA = "0x18913D3A0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x913BE40", Offset = "0x913A840", VA = "0x18913BE40")]
		[IteratorStateMachine(typeof(BMHKCAJCIBF))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x913BB50", Offset = "0x913A550", VA = "0x18913BB50")]
		private void HHCKIIBCOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x913BEC0", Offset = "0x913A8C0", VA = "0x18913BEC0")]
		private void KNMJDALNCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x913AE20", Offset = "0x9139820", VA = "0x18913AE20")]
		private void CBMEHPDODOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x913BB10", Offset = "0x913A510", VA = "0x18913BB10", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x913C290", Offset = "0x913AC90", VA = "0x18913C290", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x913C1E0", Offset = "0x913ABE0", VA = "0x18913C1E0")]
		private static void PGPFFLDBNOJ(Camera GDINMNFHIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x913BFA0", Offset = "0x913A9A0", VA = "0x18913BFA0", Slot = "6")]
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
		private sealed class PNBKCCNOPKJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public PNBKCCNOPKJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x914B490", Offset = "0x9149E90", VA = "0x18914B490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x914B5C0", Offset = "0x9149FC0", VA = "0x18914B5C0", Slot = "8")]
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
		private IntPtr CENLPGCOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture CMJLMIJIEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer MLNMOGFELAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator OBONJDJBOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool MFOMPDMLIEK;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AHJMPONBBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBD5970", Offset = "0xBD4370", VA = "0x180BD5970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBD2960", Offset = "0xBD1360", VA = "0x180BD2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor FBGKDLAOFJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBC1AD0", Offset = "0xBC04D0", VA = "0x180BC1AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC32890", Offset = "0xC31290", VA = "0x180C32890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9143C60", Offset = "0x9142660", VA = "0x189143C60", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x91436B0", Offset = "0x91420B0", VA = "0x1891436B0")]
		private void GFMAGFKKIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9143B80", Offset = "0x9142580", VA = "0x189143B80")]
		private void LILIGBJPNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9144070", Offset = "0x9142A70", VA = "0x189144070", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9143B00", Offset = "0x9142500", VA = "0x189143B00")]
		[IteratorStateMachine(typeof(PNBKCCNOPKJ))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x91441C0", Offset = "0x9142BC0", VA = "0x1891441C0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x91441F0", Offset = "0x9142BF0", VA = "0x1891441F0")]
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
		private sealed class FOFACBAIBJJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public FOFACBAIBJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x914ADC0", Offset = "0x91497C0", VA = "0x18914ADC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x914AE30", Offset = "0x9149830", VA = "0x18914AE30", Slot = "8")]
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
		private Texture GIJGNIDNKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture CMJLMIJIEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr CENLPGCOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool PDDCJMBLHFE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IMLDOLMAANG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBD5970", Offset = "0xBD4370", VA = "0x180BD5970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD2960", Offset = "0xBD1360", VA = "0x180BD2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xC32890", Offset = "0xC31290", VA = "0x180C32890")]
		public void SetSourceTexture(Texture JBOOEIGKOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x91449B0", Offset = "0x91433B0", VA = "0x1891449B0")]
		private bool KBJKFKOBJCI(Texture JBOOEIGKOID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x91452D0", Offset = "0x9143CD0", VA = "0x1891452D0")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9144940", Offset = "0x9143340", VA = "0x189144940")]
		private bool KBGBEJNILDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9144260", Offset = "0x9142C60", VA = "0x189144260")]
		private bool CPLIBKDJCLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9145220", Offset = "0x9143C20", VA = "0x189145220", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x91448C0", Offset = "0x91432C0", VA = "0x1891448C0")]
		[IteratorStateMachine(typeof(FOFACBAIBJJ))]
		private IEnumerator IFICLJEHOCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9144370", Offset = "0x9142D70", VA = "0x189144370")]
		private void HHCKIIBCOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9144A90", Offset = "0x9143490", VA = "0x189144A90")]
		private void KFDLDMPNEHF(int ANOHMOCFGAJ, int NJLBPEGOCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9144C20", Offset = "0x9143620", VA = "0x189144C20")]
		private void KNMJDALNCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9144280", Offset = "0x9142C80", VA = "0x189144280", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9144CD0", Offset = "0x91436D0", VA = "0x189144CD0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9145110", Offset = "0x9143B10", VA = "0x189145110", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x91452E0", Offset = "0x9143CE0", VA = "0x1891452E0")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9145350", Offset = "0x9143D50", VA = "0x189145350", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x91452E0", Offset = "0x9143CE0", VA = "0x1891452E0")]
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
		private enum EJOCDKIDDAC
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
		private AudioListener DIIPHJOACJC;

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
		private static readonly string[] KCBKFHHIGKL;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] ENGOLGGGDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private EJOCDKIDDAC GPMFLMOKEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] NGCJPIKBNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] IGNMDGOCGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] AFHIMPHOEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] NENCNHBMPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] HPOHKBKCMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] BJJNCFIPNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] KOMBMOMLLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int CAEDKBMHLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle FFNKNOMDFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int AABDCGLOMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 OJHDBDLGAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 BPDAKILDDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 FIJAGBNPMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 JJNDGFPMHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long BIOJKCEBPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float PBMFCKGAGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float AACCJMFPGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint LIALPFNKEIA;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase LOCLNFMEHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool DMDEJIIIMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF915E0", Offset = "0xF8FFE0", VA = "0x180F915E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xF915F0", Offset = "0xF8FFF0", VA = "0x180F915F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool HIOGAHGNAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9149F40", Offset = "0x9148940", VA = "0x189149F40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x91469B0", Offset = "0x91453B0", VA = "0x1891469B0")]
		private void FMCFNMAICEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9149A20", Offset = "0x9148420", VA = "0x189149A20")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9147810", Offset = "0x9146210", VA = "0x189147810")]
		private void OCKJGLCKLJA(int NMAIBBDGPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x91454D0", Offset = "0x9143ED0", VA = "0x1891454D0")]
		private void DEKFCLOBFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x91473E0", Offset = "0x9145DE0", VA = "0x1891473E0")]
		private void NDLJHFAMGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9145440", Offset = "0x9143E40", VA = "0x189145440")]
		private void CNHFDNLCHOE(string EICJFDNFOCB, string MIBIEOGGIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9147310", Offset = "0x9145D10", VA = "0x189147310")]
		private void JGNNBFLFIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9147280", Offset = "0x9145C80", VA = "0x189147280")]
		private void IKCMLMJKKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9146930", Offset = "0x9145330", VA = "0x189146930")]
		private void DIBBNDMLPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9147790", Offset = "0x9146190", VA = "0x189147790")]
		private void NKCBCHHDDHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x91453C0", Offset = "0x9143DC0", VA = "0x1891453C0")]
		private void AIIPLKPHHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9149FB0", Offset = "0x91489B0", VA = "0x189149FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x914A7F0", Offset = "0x91491F0", VA = "0x18914A7F0")]
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
		private RenderTexture ENELCPMPOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture EIILEKMECCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material PHAOJOHLFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material BEFBOHAJMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int NAMPMDIMAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int PNKGLFOGBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int JBFKMHEAPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool CFFFGDEFCCC;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int JANNPPHHKNF;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int CKCAOBFLKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float NDKMLAEIINN;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool NJAJMCPDKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x13411D0", Offset = "0x133FBD0", VA = "0x1813411D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1810E10", Offset = "0x180F810", VA = "0x181810E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JHPPEDMFHBL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9163530", Offset = "0x9161F30", VA = "0x189163530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int IMIJNPEFAAG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture HIKMOLONLNN
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9162B30", Offset = "0x9161530", VA = "0x189162B30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x91634E0", Offset = "0x9161EE0", VA = "0x1891634E0")]
		public void SetTargetSize(int ANOHMOCFGAJ, int NJLBPEGOCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9163500", Offset = "0x9161F00", VA = "0x189163500")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9163240", Offset = "0x9161C40", VA = "0x189163240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9162CA0", Offset = "0x91616A0", VA = "0x189162CA0")]
		private void JKJEBPBIKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9163000", Offset = "0x9161A00", VA = "0x189163000")]
		private void MDBKKFAACEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9163060", Offset = "0x9161A60", VA = "0x189163060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x91632A0", Offset = "0x9161CA0", VA = "0x1891632A0")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8650420", Offset = "0x864EE20", VA = "0x188650420")]
		private static float LLKBBFMCLAF(float EICJFDNFOCB, float MIBIEOGGIAP, float GGMLEPFJHKP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9162BC0", Offset = "0x91615C0", VA = "0x189162BC0")]
		private void DNCPCJNHDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9162A10", Offset = "0x9161410", VA = "0x189162A10")]
		public void Accumulate(Texture KGCMICBGABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9163370", Offset = "0x9161D70", VA = "0x189163370")]
		private void OnRenderImage(RenderTexture KGCMICBGABJ, RenderTexture MPGFNEFLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9163510", Offset = "0x9161F10", VA = "0x189163510")]
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
		private GUIContent JKKGAEIDPDB;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9163770", Offset = "0x9162170", VA = "0x189163770")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x91636B0", Offset = "0x91620B0", VA = "0x1891636B0")]
		public void SetTexture(Texture2D JBOOEIGKOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9163540", Offset = "0x9161F40", VA = "0x189163540")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9163830", Offset = "0x9162230", VA = "0x189163830")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> ELIDMODCIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9164E90", Offset = "0x9163890", VA = "0x189164E90")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public OnAudioFilterReadForwarder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("AVPro Movie Capture/Utils/Timeline Controller", 300)]
	public class TimelineController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum BGOHEEFKCBD
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		internal class MOOIHGIOEHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector HOEPPENFEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode GJKKLCDOFLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool POCMAFCKHGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool KBEKIDCMJBB;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
			internal MOOIHGIOEHG(PlayableDirector GHMNGNDPHAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x91629B0", Offset = "0x91613B0", VA = "0x1891629B0")]
			internal bool OKIBIFJLPPJ(PlayableDirector GHMNGNDPHAG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x91628B0", Offset = "0x91612B0", VA = "0x1891628B0")]
			internal void JGNNBFLFIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x91627E0", Offset = "0x91611E0", VA = "0x1891627E0")]
			internal void IKCMLMJKKPH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private BGOHEEFKCBD _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<MOOIHGIOEHG> BPANBHKKNAH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public BGOHEEFKCBD GELLKHGAJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(BGOHEEFKCBD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9165850", Offset = "0x9164250", VA = "0x189165850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9164EC0", Offset = "0x91638C0", VA = "0x189164EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9164EC0", Offset = "0x91638C0", VA = "0x189164EC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9165390", Offset = "0x9163D90", VA = "0x189165390")]
		internal void PKGCGCMLAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x91650B0", Offset = "0x9163AB0", VA = "0x1891650B0")]
		internal void JGNNBFLFIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9164ED0", Offset = "0x91638D0", VA = "0x189164ED0")]
		internal void IKCMLMJKKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9165490", Offset = "0x9163E90", VA = "0x189165490")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x91652E0", Offset = "0x9163CE0", VA = "0x1891652E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x91653A0", Offset = "0x9163DA0", VA = "0x1891653A0")]
		private void PLPAGHIMPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x91652D0", Offset = "0x9163CD0", VA = "0x1891652D0")]
		private void LIKKPMDGBKL(Scene LDEJAMJEHAA, LoadSceneMode GDIJNLEACAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x91657C0", Offset = "0x91641C0", VA = "0x1891657C0")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int CDJOANFEAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int LMBMFCEPJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int MPJAMNNECBN
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
		[Cpp2IlInjected.Address(RVA = "0x9165E20", Offset = "0x9164820", VA = "0x189165E20", Slot = "13")]
		public virtual IntPtr ReadData([Out] int AJDEGEPLAEO)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9165C90", Offset = "0x9164690", VA = "0x189165C90")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9165DB0", Offset = "0x91647B0", VA = "0x189165DB0")]
		private static int NFLOMCNKFKH(AudioSpeakerMode GDIJNLEACAN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		protected UnityAudioCapture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[AddComponentMenu("AVPro Movie Capture/Utils/VideoPlayer Controller", 300)]
	public class VideoPlayerController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public enum EAMGLAIIAEA
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SceneLoad,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Frame
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		internal class MKIDJPBBHIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer BMDEHNDGPMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool KBEKIDCMJBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool POCMAFCKHGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool ANLEEHAAMKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double FPACDPKIMIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float IIGJHFPGIKH;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
			internal MKIDJPBBHIO(VideoPlayer CIBPPKEGDDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x915F290", Offset = "0x915DC90", VA = "0x18915F290")]
			internal bool OKIBIFJLPPJ(VideoPlayer CIBPPKEGDDD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x915ECE0", Offset = "0x915D6E0", VA = "0x18915ECE0")]
			internal void JGNNBFLFIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x915EC10", Offset = "0x915D610", VA = "0x18915EC10")]
			internal bool HGLLPBMJKAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x915ED60", Offset = "0x915D760", VA = "0x18915ED60")]
			internal void KJAADBFNNCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x915EB70", Offset = "0x915D570", VA = "0x18915EB70")]
			private void GBOOJHALDFN(VideoPlayer PBOCDEMNFLD, long CCADJLBHFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x915EA70", Offset = "0x915D470", VA = "0x18915EA70")]
			private void EFFGGCKLOBM(VideoPlayer PBOCDEMNFLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x915F1F0", Offset = "0x915DBF0", VA = "0x18915F1F0")]
			internal void OAANEMLJGCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x915E570", Offset = "0x915CF70", VA = "0x18915E570")]
			internal bool DBIPLKHEHMB(float LHPALOIPBAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x915EC50", Offset = "0x915D650", VA = "0x18915EC50")]
			internal void IKCMLMJKKPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class ADLPDNGNDLJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public ADLPDNGNDLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x914B640", Offset = "0x914A040", VA = "0x18914B640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x914B7B0", Offset = "0x914A1B0", VA = "0x18914B7B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private EAMGLAIIAEA _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<MKIDJPBBHIO> GIBIMKGFBLN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public EAMGLAIIAEA GELLKHGAJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return default(EAMGLAIIAEA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9166D10", Offset = "0x9165710", VA = "0x189166D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9165F40", Offset = "0x9164940", VA = "0x189165F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9165F40", Offset = "0x9164940", VA = "0x189165F40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x91666B0", Offset = "0x91650B0", VA = "0x1891666B0")]
		internal void PKGCGCMLAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9165F50", Offset = "0x9164950", VA = "0x189165F50")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x91660C0", Offset = "0x9164AC0", VA = "0x1891660C0")]
		[IteratorStateMachine(typeof(ADLPDNGNDLJ))]
		internal IEnumerator DDMMFMEBAHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9166440", Offset = "0x9164E40", VA = "0x189166440")]
		internal void JGNNBFLFIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x91662B0", Offset = "0x9164CB0", VA = "0x1891662B0")]
		internal void IKCMLMJKKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x91668E0", Offset = "0x91652E0", VA = "0x1891668E0")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9166600", Offset = "0x9165000", VA = "0x189166600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x91667F0", Offset = "0x91651F0", VA = "0x1891667F0")]
		private void PLPAGHIMPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x91665F0", Offset = "0x9164FF0", VA = "0x1891665F0")]
		private void LIKKPMDGBKL(Scene LDEJAMJEHAA, LoadSceneMode GDIJNLEACAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9166C80", Offset = "0x9165680", VA = "0x189166C80")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9166140", Offset = "0x9164B40", VA = "0x189166140")]
		[CompilerGenerated]
		private bool HBADKKHDHKL()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LPCFANLNJGP
{
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	First = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Second,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Third
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum MBBLBCEACNL
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ACN_SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum LGGDOOKOMNI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	ACN
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum LPHJKIBGOHE
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	FuMa,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	SN3D
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MNEBBNFFCMP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum AAOBNKKKEKO
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
	public enum MIFJDACDJGF
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
	public enum GFABGBBNCNA
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		CaptureFrameBuffer,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeResources,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Setup
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static string[] NLHFFLOLMHE;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly string[] CBKIBLLLOML;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string[] KBBEDNPALDA;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly string[] IKKFNBEMEMC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public static readonly string[] IDEBOMJNKKE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly string[] OOHHOCCLKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly string[] LINHBNHHKJN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static IntPtr GFFDCOEHBPO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static IntPtr CFPGPBLIDEM;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private static IntPtr EHKIBPOJJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9160170", Offset = "0x915EB70", VA = "0x189160170")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private static IntPtr KMDNFECOLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9160600", Offset = "0x915F000", VA = "0x189160600")]
		get
		{
			return default(IntPtr);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x915F810", Offset = "0x915E210", VA = "0x18915F810")]
	public static extern IntPtr CLBEMJDJCIN(int HHLPFPKGLBP);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x9161B40", Offset = "0x9160540", VA = "0x189161B40")]
	public static extern void PDGOAAKBOLH(IntPtr GMFHHDBKLAN);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x91617B0", Offset = "0x91601B0", VA = "0x1891617B0")]
	public static extern void MLEMDGEJLFF(IntPtr GMFHHDBKLAN, float CPDENLIPJOA, float OLKIIHGCAFK, LPCFANLNJGP MOKDONKKJGG, LGGDOOKOMNI IDGDEIBHPJC, float[] CBECNDPOPMI);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x91602A0", Offset = "0x915ECA0", VA = "0x1891602A0")]
	public static extern void FPEABCJOPFN(IntPtr GMFHHDBKLAN, float[] PELJJDMJPIF, int EFMMFJDBPLL, int FNEBBOAMFKO, int CBIIIONHCHP, float[] FIDGJAAPFHH, int CFMFJGKBKAG, int LKBIMJHPMJL, LPCFANLNJGP MOKDONKKJGG);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x915F440", Offset = "0x915DE40", VA = "0x18915F440")]
	public static string ABCCJLMJPJG(MIFJDACDJGF GHHLIDBIFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x91613E0", Offset = "0x915FDE0", VA = "0x1891613E0")]
	public static void LCEACBIDLIP(GFABGBBNCNA DFEGNOMHEBB, int NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x91603A0", Offset = "0x915EDA0", VA = "0x1891603A0")]
	private static extern IntPtr GGCMEIKEPPK();

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x915FB40", Offset = "0x915E540", VA = "0x18915FB40")]
	private static extern IntPtr DKNHGEAGIMB();

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x91616A0", Offset = "0x91600A0", VA = "0x1891616A0")]
	public static extern bool LHEJPJMHOBO();

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x91607B0", Offset = "0x915F1B0", VA = "0x1891607B0")]
	public static extern void IDNAFMBEEMH();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x915F2F0", Offset = "0x915DCF0", VA = "0x18915F2F0")]
	public static string AADBBGCKHJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x9160730", Offset = "0x915F130", VA = "0x189160730")]
	public static bool HMPPDFJKJDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x9160F20", Offset = "0x915F920", VA = "0x189160F20")]
	public static extern int JOKHDAJFDOD();

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x9161360", Offset = "0x915FD60", VA = "0x189161360")]
	public static extern bool KKJOPEJKBHG(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9160580", Offset = "0x915EF80", VA = "0x189160580")]
	public static extern IGIGHCGDBHL GPJHJKHAHNL(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x9160D40", Offset = "0x915F740", VA = "0x189160D40")]
	public static extern void JKHINCBEOJL(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9160A80", Offset = "0x915F480", VA = "0x189160A80")]
	public static string IOCCLLAENAH(int CGAEPDMFMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x915FE30", Offset = "0x915E830", VA = "0x18915FE30")]
	public static extern int EMGBBHACOIC();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x915F990", Offset = "0x915E390", VA = "0x18915F990")]
	public static extern bool DCBFDJHOBPE(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x9160820", Offset = "0x915F220", VA = "0x189160820")]
	public static extern IGIGHCGDBHL IFJDJCPEMBJ(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x91612E0", Offset = "0x915FCE0", VA = "0x1891612E0")]
	public static extern void KJDLJDIMFBF(int CGAEPDMFMGM);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x915FEA0", Offset = "0x915E8A0", VA = "0x18915FEA0")]
	public static string FAGNDKJKNDB(int CGAEPDMFMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9160CD0", Offset = "0x915F6D0", VA = "0x189160CD0")]
	public static extern int JAPOLBHIGLE();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x91610E0", Offset = "0x915FAE0", VA = "0x1891610E0")]
	public static string KELIGOBPGMI(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x915F5A0", Offset = "0x915DFA0", VA = "0x18915F5A0")]
	public static extern IGIGHCGDBHL BHMJPOCKEHB(int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x9161970", Offset = "0x9160370", VA = "0x189161970")]
	public static string[] OLFHLKJJHID(int GDMDNKMBIPD, int PKLPJLMDIDF = -1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x9160DC0", Offset = "0x915F7C0", VA = "0x189160DC0")]
	public static extern int JNFLHMHFIEG(string LJJHGOFCFDE, uint ANOHMOCFGAJ, uint NJLBPEGOCCN, float MLJOONJEMAJ, int JBHFIGLCFLB, bool JBFNFDENONJ, bool JEOKMIGMMFM, int GDMDNKMBIPD, KACMFLLIFDM FNBEJKIAEFA, int LPMJNGJKIGI, int KACMJGAMACL, int FBCDGGFCFNO, int PKLPJLMDIDF, bool PAELFPOMMHA, VideoEncoderHints GONHDPDLLLD);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x915FC70", Offset = "0x915E670", VA = "0x18915FC70")]
	public static extern int ECCCCANCCFB(string LJJHGOFCFDE, uint ANOHMOCFGAJ, uint NJLBPEGOCCN, float MLJOONJEMAJ, int JBHFIGLCFLB, bool JBFNFDENONJ, bool JEOKMIGMMFM, int IKJEOALMKPK, bool PAELFPOMMHA, int NDKEOPOAEBO, ImageEncoderHints GONHDPDLLLD);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x9160410", Offset = "0x915EE10", VA = "0x189160410")]
	public static extern int GKNLIOKKJFA(string LJJHGOFCFDE, uint ANOHMOCFGAJ, uint NJLBPEGOCCN, float MLJOONJEMAJ, int JBHFIGLCFLB, bool JEOKMIGMMFM, int DHEHCLDCCJB, bool PAELFPOMMHA);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x9160500", Offset = "0x915EF00", VA = "0x189160500")]
	public static extern bool GLFALCCJJDG(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x9161260", Offset = "0x915FC60", VA = "0x189161260")]
	public static extern bool KGBMDEKPMNK(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x915F510", Offset = "0x915DF10", VA = "0x18915F510")]
	public static extern int AFJIEBBCEHO(int NOJLBGFGHBD, uint FKLPEEMPCMH);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x915FAB0", Offset = "0x915E4B0", VA = "0x18915FAB0")]
	public static extern void DJDKOAPDLJJ(int NOJLBGFGHBD, IntPtr BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x915FA10", Offset = "0x915E410", VA = "0x18915FA10")]
	public static extern void DHGACKEOFFE(int NOJLBGFGHBD, IntPtr BLPDDGCLNPE, uint AJDEGEPLAEO);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x9161710", Offset = "0x9160110", VA = "0x189161710")]
	public static extern void MAJFKDHNFFC(int NOJLBGFGHBD, IntPtr DMMJJNNEMCB, IntPtr AOPHCOCAFFL, uint MDNMNJMICLE);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x9160F90", Offset = "0x915F990", VA = "0x189160F90")]
	public static extern void KBBEAMBLPCO(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x915FDA0", Offset = "0x915E7A0", VA = "0x18915FDA0")]
	public static extern void ECGOBBCGDJE(int NOJLBGFGHBD, bool KOFDDHNHNJB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x915F890", Offset = "0x915E290", VA = "0x18915F890")]
	public static extern bool CONLLCJMNMO(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	public static bool HLCLLFDOIML(int NOJLBGFGHBD, StringBuilder NKKAFDOCLPF, int AJDEGEPLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x9161BC0", Offset = "0x91605C0", VA = "0x189161BC0")]
	public static extern void PNIOLEBKICO(int NOJLBGFGHBD, IntPtr JBOOEIGKOID);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x915F690", Offset = "0x915E090", VA = "0x18915F690")]
	public static extern void CBKKBJHJDNP(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x915F710", Offset = "0x915E110", VA = "0x18915F710")]
	public static extern uint CFEJHPDPBFN(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x915F3C0", Offset = "0x915DDC0", VA = "0x18915F3C0")]
	public static extern uint AAJAFDHLHFD(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x91600F0", Offset = "0x915EAF0", VA = "0x1891600F0")]
	public static extern uint FBIGKLNDFNA(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x91608A0", Offset = "0x915F2A0", VA = "0x1891608A0")]
	public static extern float IIEMMKLBPBP(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x915F790", Offset = "0x915E190", VA = "0x18915F790")]
	public static extern uint CKHIAPBEMJJ(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x915F910", Offset = "0x915E310", VA = "0x18915F910")]
	public static extern uint CPNBBCGACIE(int NOJLBGFGHBD);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x915F620", Offset = "0x915E020", VA = "0x18915F620")]
	private static extern IntPtr BOBAONBLINL();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x9160C00", Offset = "0x915F600", VA = "0x189160C00")]
	private static extern bool IOCCLLAENAH(int KABGMIEBEFC, StringBuilder IELIBBNCJAC, int BCLHNNACBFE);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9160020", Offset = "0x915EA20", VA = "0x189160020")]
	private static extern bool FAGNDKJKNDB(int KABGMIEBEFC, StringBuilder IELIBBNCJAC, int BCLHNNACBFE);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9161010", Offset = "0x915FA10", VA = "0x189161010")]
	private static extern bool KELIGOBPGMI(int KABGMIEBEFC, StringBuilder IELIBBNCJAC, int BCLHNNACBFE);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x9161890", Offset = "0x9160290", VA = "0x189161890")]
	private static extern bool OLFHLKJJHID(int GDMDNKMBIPD, int PKLPJLMDIDF, StringBuilder HOGGGJFPIFF, int HHPGJMEIGEI);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x915FBB0", Offset = "0x915E5B0", VA = "0x18915FBB0")]
	private static extern bool DPICBNJGHPA(string MAMIPJMIGMA, [Out] ulong KAGGHHCHFAH, [Out] ulong PAKEADHOEOH, [Out] ulong HMNFJOBPJCJ);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x9160920", Offset = "0x915F320", VA = "0x189160920")]
	public static bool ILEOEMJAKHG(string HEEMGKHJLID, [Out] ulong BNICMFHPCJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class JIAOINEEAPP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct HAKBIDFPBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public float CPDENLIPJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public float OLKIIHGCAFK;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x915C8D0", Offset = "0x915B2D0", VA = "0x18915C8D0")]
		public void DGCPBOBJCJC(Vector3 KFJFDPLEJOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static float[] GHHBHPDEMBF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static float[] KIKJMGGCKEJ;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x915CA80", Offset = "0x915B480", VA = "0x18915CA80")]
	public static float[] AEGFIDLIIDA(LPHJKIBGOHE NAMBJAAIKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x915CDE0", Offset = "0x915B7E0", VA = "0x18915CDE0")]
	public static int EKLMAPMGAJO(LPCFANLNJGP MOKDONKKJGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x915CB00", Offset = "0x915B500", VA = "0x18915CB00")]
	public static LGGDOOKOMNI AIJJLDAKMAH(MBBLBCEACNL JBHFIGLCFLB)
	{
		return default(LGGDOOKOMNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x915CB00", Offset = "0x915B500", VA = "0x18915CB00")]
	public static LPHJKIBGOHE EACCJNEFIBH(MBBLBCEACNL JBHFIGLCFLB)
	{
		return default(LPHJKIBGOHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x915D520", Offset = "0x915BF20", VA = "0x18915D520")]
	static JIAOINEEAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x915CB10", Offset = "0x915B510", VA = "0x18915CB10")]
	private static float[] CCHPIBDBGFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x915CE10", Offset = "0x915B810", VA = "0x18915CE10")]
	private static int FOCHDIPGDEE(int PBJBLANLGOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x915D4A0", Offset = "0x915BEA0", VA = "0x18915D4A0")]
	private static int NCMILGNBCFP(int PBJBLANLGOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x915D500", Offset = "0x915BF00", VA = "0x18915D500")]
	private static int PIBHBPLGAKH(int FKPKEFAKAOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x915D2B0", Offset = "0x915BCB0", VA = "0x18915D2B0")]
	private static float MGMBOHHLKDC(int PBJBLANLGOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x915D140", Offset = "0x915BB40", VA = "0x18915D140")]
	private static float MGMBOHHLKDC(int AFDFHFKFCKE, int CNMGFEMFMLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x915CE90", Offset = "0x915B890", VA = "0x18915CE90")]
	private static float[] KLJFJGKEGHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LKMBLOPBHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private uint DGMFPICDONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private uint EDBLJDJCDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private uint HCEADOAEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float MDLBJIMLJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private uint MLJCCPBALLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private uint CKJKAGKPIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private ulong HKOCOCHFIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int MKIAGFHBOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private KACMFLLIFDM IKFNBIOMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int LAMFGMGDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private int KPNCMEJPKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float OEBPAKINENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private int OHNMFKNOACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private int NAMPMDIMAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private float JFDLNLKAMHO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float NKKKMOEHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD84490", Offset = "0xD82E90", VA = "0x180D84490")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public uint HHDCNOPFCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public uint JHECMNJPGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public uint CPJJEMIHOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public float BBKCEBFKLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	internal uint BOPENIIDJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	internal uint JOELBBFAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public KACMFLLIFDM MGLHLGDOKND
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAEE7D0", Offset = "0xAED1D0", VA = "0x180AEE7D0")]
		get
		{
			return default(KACMFLLIFDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAED910", Offset = "0xAEC310", VA = "0x180AED910")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int OAPALBMOLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int OLIBDIMNBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1794EA0", Offset = "0x17938A0", VA = "0x181794EA0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x915DD80", Offset = "0x915C780", VA = "0x18915DD80")]
	internal void EHGLPHFOLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x915DD90", Offset = "0x915C790", VA = "0x18915DD90")]
	internal void KNACODANNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7954710", Offset = "0x7953110", VA = "0x187954710")]
	public LKMBLOPBHEP()
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
		public enum HPPPABCNBLG
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
		public CEIAEPEMNDI injectStereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[Tooltip("Inject atoms to define stereo video mode")]
		public LNGPEFHKNMF stereoPacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public CEIAEPEMNDI injectSphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[Tooltip("Inject atoms to define spherical video layout")]
		public AGIMMEOACOE sphericalVideoLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[Tooltip("The interval at which to write movie fragments in seconds")]
		[Range(0f, 300f)]
		public double movieFragmentInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public HPPPABCNBLG colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[Tooltip("Transparency mode")]
		public JOGLKOHLBBF transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public JFCBLILFAGH androidVulkanPreTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[Tooltip("Use Limited range for maximum compatibility")]
		public BHJCPGPDGDE colourRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Tooltip("Options for controlling the presentation timestamp for each frame that is captured")]
		public KONKEBKFIFJ realtimeFramePresentationTimestampOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public IEDFIIPEGEB orientationMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9165ED0", Offset = "0x91648D0", VA = "0x189165ED0")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9165E70", Offset = "0x9164870", VA = "0x189165E70")]
		public void LJMCHNKFODE()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)0, Pack = 1, Size = 25)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ImageEncoderHints
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public enum BHNMAMBJLNA
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
		public BHNMAMBJLNA colourSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int sourceWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int sourceHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[Tooltip("Transparency mode")]
		public JOGLKOHLBBF transparency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public JFCBLILFAGH androidVulkanPreTransform;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x915CA40", Offset = "0x915B440", VA = "0x18915CA40")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x915CA20", Offset = "0x915B420", VA = "0x18915CA20")]
		public void LJMCHNKFODE()
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
		[Cpp2IlInjected.Address(RVA = "0x915AEE0", Offset = "0x91598E0", VA = "0x18915AEE0")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x915ADC0", Offset = "0x91597C0", VA = "0x18915ADC0")]
		public void LJMCHNKFODE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CaptureBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public enum OIMOAPLNLPL
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
		public enum EMMCJMEONFK
		{
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			Depth_24 = 24,
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			Depth_16 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			Depth_Zero = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum EOOKDENKLDJ
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
		public enum KJAHDKFEKHG
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
		public enum EEMBOAPPHBE
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
		public enum ELNMBIAPFGC
		{
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			Automatic,
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			Manual
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string EEOKCENNPHI = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

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
		private HHAABGKGALF _startTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private BFIGKDJNKIK _startDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float _startDelaySeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private ILEFKEDANNF _stopMode;

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
		private ELNMBIAPFGC _frameUpdateMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private KJAHDKFEKHG _downScale;

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
		private KACMFLLIFDM _audioCaptureSource;

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
		protected IMHJIIKOMKA _outputTarget;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const EEMBOAPPHBE DefaultOutputFolderType = EEMBOAPPHBE.RelativeToProject;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string MILLIIJIHPA = "Captures";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private EEMBOAPPHBE _outputFolderType;

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
		private OOIMICNMAEE _imageSequenceFormatWindows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private OOIMICNMAEE _imageSequenceFormatMacOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private OOIMICNMAEE _imageSequenceFormatIOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private OOIMICNMAEE _imageSequenceFormatAndroid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		protected OIMOAPLNLPL _renderResolution;

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
		protected Texture2D NCLANJHOCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int HICPONHKDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int GCGLGCPPDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int OGEGJEANMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int PNKGLFOGBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int JBFKMHEAPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool DBHIJPDLHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19D")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool JOMINLDODMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string BACKBLDGDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string POKNPEFPOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo ICBPLLKKBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected MNEBBNFFCMP.MIFJDACDJGF ENFBOBMHHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CNAGDINACLD LBBIDKJKAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CNAGDINACLD HOFDLIFBNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private HLHOAFPOKCK HLDDBHAPLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int FHPJBNBJKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float NLNIBBIEACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool IJCLCLPFCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool OIAGNHEJDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E2")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool KNBPBPPMDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E3")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool IHMPCBLAPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float IPINBKHIAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float EEGHBAHGFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float DIKHKIMKKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction OIHPMKJCFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long EEAEGCFODKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected JOGLKOHLBBF COEHDAGHLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture HPLKLMIPNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material LEHNNGAEOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float CJFCHDLPDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool BNBPJKGEIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<LJONEGICIFF> IJDOEMMMKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<LJONEGICIFF> MIOPCJDDGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<LJONEGICIFF> MNPJLCNPCEH;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> KHLJFNBBHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent MBHOLLFEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent KGNBBMKDJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private LKMBLOPBHEP CKICIPKEFPJ;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool EBKCFHIBMHM;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool KNIGCKNOHEF;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public IMHJIIKOMKA MIOOLFMJJJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x17D0420", Offset = "0x17CEE20", VA = "0x1817D0420")]
			get
			{
				return default(IMHJIIKOMKA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x17CFF40", Offset = "0x17CE940", VA = "0x1817CFF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public EEMBOAPPHBE GEBJHPOBOKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC1D5C0", Offset = "0xC1BFC0", VA = "0x180C1D5C0")]
			get
			{
				return default(EEMBOAPPHBE);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC1CB50", Offset = "0xC1B550", VA = "0x180C1CB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string LPKLGMKALHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB49720", Offset = "0xB48120", VA = "0x180B49720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xB42C70", Offset = "0xB41670", VA = "0x180B42C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string ODACAINAPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xB3D0B0", Offset = "0xB3BAB0", VA = "0x180B3D0B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB435A0", Offset = "0xB41FA0", VA = "0x180B435A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool ONJCHILJAJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xB3D0A0", Offset = "0xB3BAA0", VA = "0x180B3D0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB678A0", Offset = "0xB662A0", VA = "0x180B678A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool LGBOANLICKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2283BB0", Offset = "0x22825B0", VA = "0x182283BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x227DCE0", Offset = "0x227C6E0", VA = "0x18227DCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string CNNJBLOPGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB3ECA0", Offset = "0xB3D6A0", VA = "0x180B3ECA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB3DA30", Offset = "0xB3C430", VA = "0x180B3DA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string FFHDDPBKBBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xB11EE0", Offset = "0xB108E0", VA = "0x180B11EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xB3F100", Offset = "0xB3DB00", VA = "0x180B3F100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool NIJIFCNMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xB724B0", Offset = "0xB70EB0", VA = "0x180B724B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBD7800", Offset = "0xBD6200", VA = "0x180BD7800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int JFAFMAEJDEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB3F0A0", Offset = "0xB3DAA0", VA = "0x180B3F0A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xB9CAF0", Offset = "0xB9B4F0", VA = "0x180B9CAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int GBLCENDICDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1882E80", Offset = "0x1881880", VA = "0x181882E80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x915AC00", Offset = "0x9159600", VA = "0x18915AC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool OIHILEAIAAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x19219D0", Offset = "0x19203D0", VA = "0x1819219D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x915ACE0", Offset = "0x91596E0", VA = "0x18915ACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int KKEEPFGIPHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2121710", Offset = "0x2120110", VA = "0x182121710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x915AC70", Offset = "0x9159670", VA = "0x18915AC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] EPGKJDDFALP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC29330", Offset = "0xC27D30", VA = "0x180C29330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xDB7170", Offset = "0xDB5B70", VA = "0x180DB7170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur FMPLDNLABHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xC2F450", Offset = "0xC2DE50", VA = "0x180C2F450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD2000", Offset = "0xBD0A00", VA = "0x180BD2000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public JOGLKOHLBBF LKKIHCGOHBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xBC1E00", Offset = "0xBC0800", VA = "0x180BC1E00")]
			get
			{
				return default(JOGLKOHLBBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> LINPCCINLCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x915AA90", Offset = "0x9159490", VA = "0x18915AA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string AJHBFDDKFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB49990", Offset = "0xB48390", VA = "0x180B49990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent EOMIKNPIMHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xBC1B00", Offset = "0xBC0500", VA = "0x180BC1B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent CMIAKBNNLKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBC1B20", Offset = "0xBC0520", VA = "0x180BC1B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<LJONEGICIFF> LIFBOJMMAJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBDBF80", Offset = "0xBDA980", VA = "0x180BDBF80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xBD2530", Offset = "0xBD0F30", VA = "0x180BD2530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<LJONEGICIFF> GBDKLEPNNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xBDCE80", Offset = "0xBDB880", VA = "0x180BDCE80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xBD3080", Offset = "0xBD1A80", VA = "0x180BD3080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public OIMOAPLNLPL DKMJGOELOMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x23E2D60", Offset = "0x23E1760", VA = "0x1823E2D60")]
			get
			{
				return default(OIMOAPLNLPL);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x915ABB0", Offset = "0x91595B0", VA = "0x18915ABB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 OEFDKACKNIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x915AAE0", Offset = "0x91594E0", VA = "0x18915AAE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2792910", Offset = "0x2791310", VA = "0x182792910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int FPBLHKECKKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1921A10", Offset = "0x1920410", VA = "0x181921A10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x2672B90", Offset = "0x2671590", VA = "0x182672B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool NFAHEOHKKJP
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xFEB810", Offset = "0xFEA210", VA = "0x180FEB810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xFEB700", Offset = "0xFEA100", VA = "0x180FEB700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool LOMLGLEJNON
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xFEB7F0", Offset = "0xFEA1F0", VA = "0x180FEB7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xFEB0F0", Offset = "0xFE9AF0", VA = "0x180FEB0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public KACMFLLIFDM MGLHLGDOKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB68B60", Offset = "0xB67560", VA = "0x180B68B60")]
			get
			{
				return default(KACMFLLIFDM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB68A10", Offset = "0xB67410", VA = "0x180B68A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int FOCANDLONDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F672D0", Offset = "0x1F65CD0", VA = "0x181F672D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x28A99F0", Offset = "0x28A83F0", VA = "0x1828A99F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int KEMEDMFGKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xB50850", Offset = "0xB4F250", VA = "0x180B50850")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xB4FE80", Offset = "0xB4E880", VA = "0x180B4FE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture GAFFONFGNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAB94F0", Offset = "0xAB7EF0", VA = "0x180AB94F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAB94B0", Offset = "0xAB7EB0", VA = "0x180AB94B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int BPCFEONMKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB70EA0", Offset = "0xB6F8A0", VA = "0x180B70EA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x915ABC0", Offset = "0x91595C0", VA = "0x18915ABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float INLCNKJDIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x167CBA0", Offset = "0x167B5A0", VA = "0x18167CBA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x915ABD0", Offset = "0x91595D0", VA = "0x18915ABD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public HHAABGKGALF HAJEDADCIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
			get
			{
				return default(HHAABGKGALF);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public BFIGKDJNKIK AGEKOKLDDCG
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A70", Offset = "0xEC8470", VA = "0x180EC9A70")]
			get
			{
				return default(BFIGKDJNKIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1001770", Offset = "0x1000170", VA = "0x181001770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float EJNMAFHMPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAFE5D0", Offset = "0xAFCFD0", VA = "0x180AFE5D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x915ACA0", Offset = "0x91596A0", VA = "0x18915ACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ILEFKEDANNF BDJMLKIIHGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1538210", Offset = "0x1536C10", VA = "0x181538210")]
			get
			{
				return default(ILEFKEDANNF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x23894E0", Offset = "0x2387EE0", VA = "0x1823894E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int BDPEFBMJGGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x915ACB0", Offset = "0x91596B0", VA = "0x18915ACB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float JIAOJMAFDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x109DCA0", Offset = "0x109C6A0", VA = "0x18109DCA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x915ACC0", Offset = "0x91596C0", VA = "0x18915ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool IPGGOLKMNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xD7DEA0", Offset = "0xD7C8A0", VA = "0x180D7DEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xD7D250", Offset = "0xD7BC50", VA = "0x180D7D250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public LKMBLOPBHEP NAMNGLDNDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xBC1B10", Offset = "0xBC0510", VA = "0x180BC1B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] LEAEFBCIMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x915AD30", Offset = "0x9159730", VA = "0x18915AD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] IPDAHDFPMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x915AD00", Offset = "0x9159700", VA = "0x18915AD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] LCHMONJFAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x915AB80", Offset = "0x9159580", VA = "0x18915AB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] LDOMGPBAOFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x915AB50", Offset = "0x9159550", VA = "0x18915AB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int LFFJPDBAMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x3012430", Offset = "0x3010E30", VA = "0x183012430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x5CE7B10", Offset = "0x5CE6510", VA = "0x185CE7B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public ELNMBIAPFGC FEELPEDPLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xF68C90", Offset = "0xF67690", VA = "0x180F68C90")]
			get
			{
				return default(ELNMBIAPFGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xF67D80", Offset = "0xF66780", VA = "0x180F67D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public KJAHDKFEKHG MDLDOAAOCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xF68C80", Offset = "0xF67680", VA = "0x180F68C80")]
			get
			{
				return default(KJAHDKFEKHG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF67580", Offset = "0xF65F80", VA = "0x180F67580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 DDEAHKHLLEM
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC30", Offset = "0x2A7A630", VA = "0x182A7BC30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2AEB580", Offset = "0x2AE9F80", VA = "0x182AEB580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool PCJPAHIOAOE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x10F1F90", Offset = "0x10F0990", VA = "0x1810F1F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x18D9EE0", Offset = "0x18D88E0", VA = "0x1818D9EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool DGKODFFEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x82C7000", Offset = "0x82C5A00", VA = "0x1882C7000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x915ACF0", Offset = "0x91596F0", VA = "0x18915ACF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool OIAKDDAPMCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CC0", Offset = "0x2A876C0", VA = "0x182A88CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2A89200", Offset = "0x2A87C00", VA = "0x182A89200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool LANPNLGBBFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x16A1640", Offset = "0x16A0040", VA = "0x1816A1640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x169B5F0", Offset = "0x1699FF0", VA = "0x18169B5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool ALJPNLGDAAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x23BBAC0", Offset = "0x23BA4C0", VA = "0x1823BBAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x915ACD0", Offset = "0x91596D0", VA = "0x18915ACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController NJNPFPPCPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xC410F0", Offset = "0xC3FAF0", VA = "0x180C410F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB73670", Offset = "0xB72070", VA = "0x180B73670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController DNKEKGOLDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24080", VA = "0x180C25680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x10A9AC0", Offset = "0x10A84C0", VA = "0x1810A9AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public CNAGDINACLD JNLOBKLHOIG
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB87990", Offset = "0xB86390", VA = "0x180B87990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public CNAGDINACLD LCEAHOAJJEN
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB879C0", Offset = "0xB863C0", VA = "0x180B879C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public HLHOAFPOKCK ILILLOFGAKO
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xC41150", Offset = "0xC3FB50", VA = "0x180C41150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int AOPECOJMKKE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC190", Offset = "0xAAAB90", VA = "0x180AAC190")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC1B0", Offset = "0xAAABB0", VA = "0x180AAC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int HPGJBBOIOBD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB79590", Offset = "0xB77F90", VA = "0x180B79590")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x10E6E90", Offset = "0x10E5890", VA = "0x1810E6E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public OOIMICNMAEE PEHJAODCGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1882E90", Offset = "0x1881890", VA = "0x181882E90")]
			get
			{
				return default(OOIMICNMAEE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22FD6C0", Offset = "0x22FC0C0", VA = "0x1822FD6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string BLFKMMKLMKG
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x915AB00", Offset = "0x9159500", VA = "0x18915AB00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x915AC30", Offset = "0x9159630", VA = "0x18915AC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
		protected static MNEBBNFFCMP.AAOBNKKKEKO OPMBPLKFHOI()
		{
			return default(MNEBBNFFCMP.AAOBNKKKEKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9153230", Offset = "0x9151C30", VA = "0x189153230")]
		public EncoderHints GetEncoderHints(MNEBBNFFCMP.AAOBNKKKEKO OCEOABGJOBL = MNEBBNFFCMP.AAOBNKKKEKO.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x91582D0", Offset = "0x9156CD0", VA = "0x1891582D0")]
		public void SetEncoderHints(EncoderHints GONHDPDLLLD, MNEBBNFFCMP.AAOBNKKKEKO OCEOABGJOBL = MNEBBNFFCMP.AAOBNKKKEKO.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void UpdateMediaGallery(string FLFADKMPOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9150C20", Offset = "0x914F620", VA = "0x189150C20", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9159610", Offset = "0x9158010", VA = "0x189159610")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x91588F0", Offset = "0x91572F0", VA = "0x1891588F0", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9154D70", Offset = "0x9153770", VA = "0x189154D70")]
		private static bool NKPIHCIKJAJ(CNAGDINACLD PMLPMAHFJMD, BGCKAHPKPAH GJEHLKGPHPJ, int ICPLDMDBMMA, string[] GBPHIFEPDLA, IGIGHCGDBHL OAOIFOAJFMB, bool AEGJJDMELBA, bool PENFIIEAMLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9157FB0", Offset = "0x91569B0", VA = "0x189157FB0")]
		public CNAGDINACLD SelectVideoCodec(bool DANPCFADKGG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9157910", Offset = "0x9156310", VA = "0x189157910")]
		public CNAGDINACLD SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x9157C80", Offset = "0x9156680", VA = "0x189157C80")]
		public HLHOAFPOKCK SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x91533A0", Offset = "0x9151DA0", VA = "0x1891533A0")]
		public static Vector2 GetRecordingResolution(int ANOHMOCFGAJ, int NJLBPEGOCCN, KJAHDKFEKHG LJLNNLHCHNA, Vector2 ALIFIHMNDMG)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9157EA0", Offset = "0x91568A0", VA = "0x189157EA0")]
		public void SelectRecordingResolution(int ANOHMOCFGAJ, int NJLBPEGOCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9155440", Offset = "0x9153E40", VA = "0x189155440", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9155680", Offset = "0x9154080", VA = "0x189155680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9155710", Offset = "0x9154110", VA = "0x189155710")]
		private void PCMDHCIAPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x91553F0", Offset = "0x9153DF0", VA = "0x1891553F0")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x91548F0", Offset = "0x91532F0", VA = "0x1891548F0")]
		protected void LPIOGOCOEAG(Texture2D JBOOEIGKOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9150BA0", Offset = "0x914F5A0", VA = "0x189150BA0")]
		protected bool APBDFIMIOHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9151C40", Offset = "0x9150640", VA = "0x189151C40")]
		protected bool EAOEAGPNPIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x91523C0", Offset = "0x9150DC0", VA = "0x1891523C0", Slot = "7")]
		public virtual void EncodePointer(IntPtr NLEDNJIMIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9153D80", Offset = "0x9152780", VA = "0x189153D80")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9153D60", Offset = "0x9152760", VA = "0x189153D60")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9153D70", Offset = "0x9152770", VA = "0x189153D70")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9153470", Offset = "0x9151E70", VA = "0x189153470")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB493A0", Offset = "0xB47DA0", VA = "0x180B493A0")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9152D50", Offset = "0x9151750", VA = "0x189152D50", Slot = "8")]
		protected virtual string GPPENEOMAIO(string PKMFLGKECPC, string KEAEOGDKPNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x91545E0", Offset = "0x9152FE0", VA = "0x1891545E0")]
		private static string LBMNNJELBAM(EEMBOAPPHBE CEFHPPHIHBI, string HEEMGKHJLID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x91518D0", Offset = "0x91502D0", VA = "0x1891518D0")]
		private static string CPDEIJMHIEI(EEMBOAPPHBE CEFHPPHIHBI, string HEEMGKHJLID, string LJJHGOFCFDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9153DE0", Offset = "0x91527E0", VA = "0x189153DE0")]
		protected static bool JKDGIPMLHDJ(string HEEMGKHJLID, string NEGNMBNIKBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9153E20", Offset = "0x9152820", VA = "0x189153E20")]
		protected void KDOCNBKBBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9152820", Offset = "0x9151220", VA = "0x189152820")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool NIGBMFECHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x91536E0", Offset = "0x91520E0", VA = "0x1891536E0")]
		private bool IFEHNIACKII()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9155B70", Offset = "0x9154570", VA = "0x189155B70", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x91577A0", Offset = "0x91561A0", VA = "0x1891577A0")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x16596C0", Offset = "0x16580C0", VA = "0x1816596C0")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9152CC0", Offset = "0x91516C0", VA = "0x189152CC0")]
		protected void GPFPFNEJHEK(LNGPEFHKNMF NJGJGHJAMKA, AGIMMEOACOE CFMLLAIPNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9158370", Offset = "0x9156D70", VA = "0x189158370")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9155930", Offset = "0x9154330", VA = "0x189155930")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9157820", Offset = "0x9156220", VA = "0x189157820")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9151AA0", Offset = "0x91504A0", VA = "0x189151AA0")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9151B30", Offset = "0x9150530", VA = "0x189151B30")]
		public static void DeleteCapture(IMHJIIKOMKA FPEFLKMPBJD, string HEEMGKHJLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9154740", Offset = "0x9153140", VA = "0x189154740")]
		protected void LCEACBIDLIP(MNEBBNFFCMP.GFABGBBNCNA DFEGNOMHEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x91589A0", Offset = "0x91573A0", VA = "0x1891589A0", Slot = "11")]
		public virtual void StopCapture(bool KOFDDHNHNJB = false, bool GPPLKIAPFOI = false, bool AKEPEHIOKNM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9154860", Offset = "0x9153260", VA = "0x189154860")]
		private static CNAOOEEEPDN.ECAMGLHIALE LOBMFCDIBFC(VideoEncoderHints GONHDPDLLLD, string POHEOOGJILJ)
		{
			return default(CNAOOEEEPDN.ECAMGLHIALE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x91551F0", Offset = "0x9153BF0", VA = "0x1891551F0")]
		private static bool OLKPCEGIEGB(string JAKIJIEGAGG, VideoEncoderHints GONHDPDLLLD, string POHEOOGJILJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9155010", Offset = "0x9153A10", VA = "0x189155010")]
		protected void NLHGPDHNKHJ(string JAKIJIEGAGG, VideoEncoderHints GONHDPDLLLD, string POHEOOGJILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x91527E0", Offset = "0x91511E0", VA = "0x1891527E0")]
		private void FOAFCCGEACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9151EC0", Offset = "0x91508C0", VA = "0x189151EC0")]
		private bool EENIKABADMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9151CB0", Offset = "0x91506B0", VA = "0x189151CB0")]
		protected bool ECJKBNHFGJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x91595B0", Offset = "0x9157FB0", VA = "0x1891595B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9154970", Offset = "0x9153370", VA = "0x189154970")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9155870", Offset = "0x9154270", VA = "0x189155870")]
		private void PPIJBMBAMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9154CD0", Offset = "0x91536D0", VA = "0x189154CD0")]
		private void NDALDFOLKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9151B00", Offset = "0x9150500", VA = "0x189151B00")]
		protected bool DLCHHECPFOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9153600", Offset = "0x9152000", VA = "0x189153600")]
		protected bool HAINCIPPMOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x91532E0", Offset = "0x9151CE0", VA = "0x1891532E0")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9151AD0", Offset = "0x91504D0", VA = "0x189151AD0")]
		protected float DDHIEJJFMDJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9151FE0", Offset = "0x91509E0", VA = "0x189151FE0")]
		protected bool EGNELJIEJLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x91514D0", Offset = "0x914FED0", VA = "0x1891514D0")]
		protected void BKNHEHANEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9153D90", Offset = "0x9152790", VA = "0x189153D90")]
		protected void JJPJKJMCPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xB87280", Offset = "0xB85C80", VA = "0x180B87280", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x91547A0", Offset = "0x91531A0", VA = "0x1891547A0")]
		protected void LDCEGJMILMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9152310", Offset = "0x9150D10", VA = "0x189152310")]
		public void EncodeAudio(NativeArray<float> AOPHCOCAFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x91521F0", Offset = "0x9150BF0", VA = "0x1891521F0")]
		public void EncodeAudio(float[] AOPHCOCAFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9155A70", Offset = "0x9154470", VA = "0x189155A70", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x91591B0", Offset = "0x9157BB0", VA = "0x1891591B0", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9151510", Offset = "0x914FF10", VA = "0x189151510")]
		protected bool CJPMFMGIBAI(int ANOHMOCFGAJ, int NJLBPEGOCCN, bool AHFLGEILDEA = false, int MGGLPOAOIFJ = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9152620", Offset = "0x9151020", VA = "0x189152620")]
		protected RenderTexture FKPLIMIDAPK(Texture ACJBIDOCIJE, bool AHFLGEILDEA = false, int MGGLPOAOIFJ = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x91521C0", Offset = "0x9150BC0", VA = "0x1891521C0")]
		protected void EHGLPHFOLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9159150", Offset = "0x9157B50", VA = "0x189159150")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9151D60", Offset = "0x9150760", VA = "0x189151D60")]
		protected int EEJHDFMJKMJ(Camera GDINMNFHIGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9153130", Offset = "0x9151B30", VA = "0x189153130")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9153480", Offset = "0x9151E80", VA = "0x189153480")]
		public static void GetResolution(OIMOAPLNLPL LLLIPMPKEGE, int ANOHMOCFGAJ, int NJLBPEGOCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9153D50", Offset = "0x9152750", VA = "0x189153D50")]
		protected static int INANMJMEJBD(int KMAFNKGMDCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x915A580", Offset = "0x9158F80", VA = "0x18915A580")]
		public CaptureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum IGIGHCGDBHL
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
public enum BNPKCPODOCL
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Video,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Audio
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CNAGDINACLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private BNPKCPODOCL IOMOENIAEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private int PKCPLKGODML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private bool NFAEBJJOGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IGIGHCGDBHL FMCPPFDKKJF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IGIGHCGDBHL EJDEMMOPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970", Slot = "6")]
		get
		{
			return default(IGIGHCGDBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JIMHOOHMMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x914BA60", Offset = "0x914A460", VA = "0x18914BA60")]
	public void BIKBLBKPFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x914BBC0", Offset = "0x914A5C0", VA = "0x18914BBC0")]
	internal CNAGDINACLD(BNPKCPODOCL CKJGEBLIPGN, int KABGMIEBEFC, string IELIBBNCJAC, IGIGHCGDBHL DLLBGMNNEMH, bool DNFAAOHHNFJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BGCKAHPKPAH : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private CNAGDINACLD[] NLJGLELPOLP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public CNAGDINACLD[] BIIOOHMIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x29A0D50", Offset = "0x299F750", VA = "0x1829A0D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x914B9F0", Offset = "0x914A3F0", VA = "0x18914B9F0")]
	internal BGCKAHPKPAH(CNAGDINACLD[] KEBFPHPKFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x914B950", Offset = "0x914A350", VA = "0x18914B950")]
	public CNAGDINACLD LDIDEBJDCKI(string IELIBBNCJAC, IGIGHCGDBHL LDIBDIFDELE = IGIGHCGDBHL.Unknown)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x914B8F0", Offset = "0x914A2F0", VA = "0x18914B8F0")]
	public CNAGDINACLD EIFDHBLPIFK(IGIGHCGDBHL DLLBGMNNEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A99D30", Offset = "0x2A98730", VA = "0x182A99D30", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GNDNLHFCBHA
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static bool CFHCFHHNOFE;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static BGCKAHPKPAH DODHGFGADGG;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static BGCKAHPKPAH MCKNDBEMNJG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public static BGCKAHPKPAH NJOLPIBLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x915BE50", Offset = "0x915A850", VA = "0x18915BE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static BGCKAHPKPAH FGPFBPFHFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x915BD50", Offset = "0x915A750", VA = "0x18915BD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x915BDB0", Offset = "0x915A7B0", VA = "0x18915BDB0")]
	private static void EINLLLHCKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x915BEB0", Offset = "0x915A8B0", VA = "0x18915BEB0")]
	private static void OLJEGKBMJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum NCMLMOLGDOH
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	AudioInput
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class HLHOAFPOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private NCMLMOLGDOH JHNPPNDABLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private int PKCPLKGODML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private string KGHHGPDHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private IGIGHCGDBHL FMCPPFDKKJF;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IGIGHCGDBHL EJDEMMOPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380", Slot = "6")]
		get
		{
			return default(IGIGHCGDBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x915C9C0", Offset = "0x915B3C0", VA = "0x18915C9C0")]
	internal HLHOAFPOKCK(NCMLMOLGDOH PBOAKFCBLOG, int KABGMIEBEFC, string IELIBBNCJAC, IGIGHCGDBHL DLLBGMNNEMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MDCJEGEMHAA : IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private HLHOAFPOKCK[] CJBCEDMFLAJ;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public HLHOAFPOKCK[] KHFAKAFNEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x29A0D50", Offset = "0x299F750", VA = "0x1829A0D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x915E500", Offset = "0x915CF00", VA = "0x18915E500")]
	internal MDCJEGEMHAA(HLHOAFPOKCK[] BEBDDCGLKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x915E4A0", Offset = "0x915CEA0", VA = "0x18915E4A0")]
	public HLHOAFPOKCK EIFDHBLPIFK(IGIGHCGDBHL DLLBGMNNEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A99D30", Offset = "0x2A98730", VA = "0x182A99D30", Slot = "4")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MCMLGNPGFFD
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private static bool CFHCFHHNOFE;

	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private static MDCJEGEMHAA JGFJBLOOOND;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public static MDCJEGEMHAA GFGFBFHGAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x915DE80", Offset = "0x915C880", VA = "0x18915DE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x915DDE0", Offset = "0x915C7E0", VA = "0x18915DDE0")]
	private static void EINLLLHCKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x915DF60", Offset = "0x915C960", VA = "0x18915DF60")]
	private static void NCEDBGOIJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LJONEGICIFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum BDICPBMJMCM
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
	private string NOENNGNJLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private int HICPONHKDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private bool OPAHIOCNHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private IMHJIIKOMKA JMHIFCNGFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CNAOOEEEPDN.ECAMGLHIALE ACBIAMEKGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ManualResetEvent CBIBNILEHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private BDICPBMJMCM ODFNDBNFIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private string POKNPEFPOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool LJKKCBBKCKP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	internal Action<LJONEGICIFF> GBDKLEPNNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x915DD00", Offset = "0x915C700", VA = "0x18915DD00")]
	internal LJONEGICIFF(IMHJIIKOMKA FPEFLKMPBJD, string HEEMGKHJLID, int NOJLBGFGHBD, bool AIJLNDHDLOB, string POHEOOGJILJ, bool IBIBHGKLFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x915D830", Offset = "0x915C230", VA = "0x18915D830")]
	internal void DJKHJCKNAJE(CNAOOEEEPDN.ECAMGLHIALE LHBCDDCDNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x915D5B0", Offset = "0x915BFB0", VA = "0x18915D5B0")]
	private bool ANAEPMDJOCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x915DB40", Offset = "0x915C540", VA = "0x18915DB40")]
	public bool MBMACENMKCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x915D850", Offset = "0x915C250", VA = "0x18915D850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CNAOOEEEPDN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct ECAMGLHIALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public bool LCDMBDHJFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public bool LJFPCODKOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public LNGPEFHKNMF BPPBBIOFBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public bool BEEEPJNCGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AGIMMEOACOE CFMLLAIPNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public bool FDIFMIELJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string LJJEPCBNNGB;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x915AD80", Offset = "0x9159780", VA = "0x18915AD80")]
		public bool LHMHDHBNFBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x915AD60", Offset = "0x9159760", VA = "0x18915AD60")]
		public bool EECCGOOECKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x915ADA0", Offset = "0x91597A0", VA = "0x18915ADA0")]
		public void MFOAKGBNBMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class KFKPJPBMGMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public uint NMAIBBDGPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public long BCAJFCGHDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public long JBCPGNDLJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public long MFOJNJCFBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public long FBODMLKEEMC;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KFKPJPBMGMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal enum MJCFFDNMIMC
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
	private sealed class BDOAFCALMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public string filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public bool keepBackup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public ECAMGLHIALE options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ManualResetEvent syncEvent;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BDOAFCALMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x914B800", Offset = "0x914A200", VA = "0x18914B800")]
		internal void IFFMENJNLPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly uint FCCAEALMJGD;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly uint CMBOINGHKCD;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly uint IHJCBBEHEKF;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly uint GBMCABCJPIJ;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly uint BONIFGKLNGJ;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly uint OKHPIGBFKGE;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly uint KOAHAFDGFGO;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly uint NDJENBIEEKF;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly uint CGBMCIFLJND;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly uint NNKFIBJOKHM;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly uint ABPAOJOGHDD;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly uint LEFIEDPHFIB;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly uint LBLDHICDNNA;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly uint AJINFHHNHLC;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly uint HOAMDMBBENM;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static readonly uint LFIKGECNIMK;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static readonly uint COPLMEFMMDH;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static readonly uint DPFNJBBADBB;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static readonly uint GIGGMPELHBB;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly uint EBHKNNFFDPA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly uint CCAEHODHMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private BinaryReader GIFBHLJLEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Stream OANJODPLIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private ECAMGLHIALE DIHGBLHABPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool LDCADOIOKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private List<KFKPJPBMGMM> EGIKMHCECGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private List<KFKPJPBMGMM> LIIHFBCKBBL;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x914D8E0", Offset = "0x914C2E0", VA = "0x18914D8E0")]
	public static ManualResetEvent FKLILMGNOFH(string JAKIJIEGAGG, bool ODJHCJJPMAP, ECAMGLHIALE ALFCEIKBPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x914DDE0", Offset = "0x914C7E0", VA = "0x18914DDE0")]
	public static bool GAFJJFOPLJI(string JAKIJIEGAGG, bool ODJHCJJPMAP, ECAMGLHIALE ALFCEIKBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x914DAB0", Offset = "0x914C4B0", VA = "0x18914DAB0")]
	public static bool GAFJJFOPLJI(string NNOLLGDBOPN, string KEAHGOGJKDL, ECAMGLHIALE ALFCEIKBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x9150AC0", Offset = "0x914F4C0", VA = "0x189150AC0")]
	public CNAOOEEEPDN(ECAMGLHIALE ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x914E3C0", Offset = "0x914CDC0", VA = "0x18914E3C0")]
	public bool IJLHGNLFHBA(Stream FGEIAGCPKNJ, Stream OGIHFAPBLBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x914F350", Offset = "0x914DD50", VA = "0x18914F350")]
	public void NJINDLCNMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x914BC20", Offset = "0x914A620", VA = "0x18914BC20")]
	private static KFKPJPBMGMM ACIMHJLENCK(uint NMAIBBDGPCD, List<KFKPJPBMGMM> HDLKGCOIGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x914D020", Offset = "0x914BA20", VA = "0x18914D020")]
	private List<KFKPJPBMGMM> DGJPBDBGJMH(KFKPJPBMGMM ECLEKFLHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x914CE70", Offset = "0x914B870", VA = "0x18914CE70")]
	private List<KFKPJPBMGMM> DGJPBDBGJMH(long MIHFPGBICFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x914E1E0", Offset = "0x914CBE0", VA = "0x18914E1E0")]
	private KFKPJPBMGMM IJFCNFNMNLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x914F440", Offset = "0x914DE40", VA = "0x18914F440")]
	private bool NJJEHENJKIG(KFKPJPBMGMM FOLEMGCPIBM, uint NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x914CBE0", Offset = "0x914B5E0", VA = "0x18914CBE0")]
	private void CDLCNPJEMFL(KFKPJPBMGMM FOLEMGCPIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x914CE00", Offset = "0x914B800", VA = "0x18914CE00")]
	private void DACMANEGALM(KFKPJPBMGMM FOLEMGCPIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x914C460", Offset = "0x914AE60", VA = "0x18914C460")]
	private void AKNKOFJPBHF(KFKPJPBMGMM FOLEMGCPIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x914F1A0", Offset = "0x914DBA0", VA = "0x18914F1A0")]
	private void MMBEHAGOEKG(long GHBCODAHGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x914C3B0", Offset = "0x914ADB0", VA = "0x18914C3B0")]
	private void AKEPOCJJCKE(long GHBCODAHGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x914BD60", Offset = "0x914A760", VA = "0x18914BD60")]
	private uint AHCKCANNIAC(KFKPJPBMGMM ECLEKFLHGOO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x914EFB0", Offset = "0x914D9B0", VA = "0x18914EFB0")]
	private bool MILNLFHCPJD(KFKPJPBMGMM CAHFLABCHMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x914D410", Offset = "0x914BE10", VA = "0x18914D410")]
	private void DNLOPGHPNJE(KFKPJPBMGMM FOLEMGCPIBM, uint HFGBICMFAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x914CC50", Offset = "0x914B650", VA = "0x18914CC50")]
	private void CPJIPBMFAKB(KFKPJPBMGMM FOLEMGCPIBM, uint HFGBICMFAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x914FD30", Offset = "0x914E730", VA = "0x18914FD30")]
	private void PBOCFHFGPLD(KFKPJPBMGMM FOLEMGCPIBM, uint HFGBICMFAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x914C580", Offset = "0x914AF80", VA = "0x18914C580")]
	private uint CADKLADDILL(KFKPJPBMGMM FOLEMGCPIBM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x914C6D0", Offset = "0x914B0D0", VA = "0x18914C6D0")]
	private uint CAOGAKHOJBN(KFKPJPBMGMM FOLEMGCPIBM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x914D610", Offset = "0x914C010", VA = "0x18914D610")]
	private static MJCFFDNMIMC DOEHJIEJHLI(LNGPEFHKNMF GDIJNLEACAN)
	{
		return default(MJCFFDNMIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x914EE30", Offset = "0x914D830", VA = "0x18914EE30")]
	private uint LAICPCKNCCJ(MJCFFDNMIMC BPPBBIOFBOH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x914ECB0", Offset = "0x914D6B0", VA = "0x18914ECB0")]
	private uint JJNOGFMDNOD(AGIMMEOACOE HDOHEPFKENN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x914D0F0", Offset = "0x914BAF0", VA = "0x18914D0F0")]
	private uint DJPLLNJFPDC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x914FB10", Offset = "0x914E510", VA = "0x18914FB10")]
	private uint PBHPNJBCJJJ(string LLCBNCGANGB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x914F5A0", Offset = "0x914DFA0", VA = "0x18914F5A0")]
	private uint NLGFIDBJFAE(AGIMMEOACOE HDOHEPFKENN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x914F9A0", Offset = "0x914E3A0", VA = "0x18914F9A0")]
	private uint NPDMEDKOGHF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x914D760", Offset = "0x914C160", VA = "0x18914D760")]
	private uint FCDBLAOJDCD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x914EC00", Offset = "0x914D600", VA = "0x18914EC00")]
	private void JABAPDLCAGN(KFKPJPBMGMM FOLEMGCPIBM, long JGOLAMDDEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x914F2B0", Offset = "0x914DCB0", VA = "0x18914F2B0")]
	private ushort NFOLOGJBOCA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x914C4E0", Offset = "0x914AEE0", VA = "0x18914C4E0")]
	private uint BMICHOCEIGD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x914D370", Offset = "0x914BD70", VA = "0x18914D370")]
	private ulong DLHDKNOFBKD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x914D630", Offset = "0x914C030", VA = "0x18914D630")]
	private void EAMGNDFPHCL(uint NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x914EEF0", Offset = "0x914D8F0", VA = "0x18914EEF0")]
	private void LMPDJGNALCF(uint KMAFNKGMDCF, bool DNHCNDOMHGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x914E130", Offset = "0x914CB30", VA = "0x18914E130")]
	private void HOICDNNDHOH(ulong KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x914D6D0", Offset = "0x914C0D0", VA = "0x18914D6D0")]
	private static uint ENJDNGFHAIK(string NMAIBBDGPCD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum CEIAEPEMNDI
{
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public enum KACMFLLIFDM
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
public enum LNGPEFHKNMF
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TopBottom,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	LeftRight
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum JOGLKOHLBBF
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
public enum AGIMMEOACOE
{
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Equirectangular360,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Equirectangular180
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public enum ILEFKEDANNF
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
public enum HHAABGKGALF
{
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Manual,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	OnStart
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum BFIGKDJNKIK
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
public enum OOIMICNMAEE
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
public enum IMHJIIKOMKA
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	VideoFile,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	ImageSequence,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	NamedPipe
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum JFCBLILFAGH
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
public enum BHJCPGPDGDE
{
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum KONKEBKFIFJ
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	Realtime,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Fixed,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	Nearest
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum IEDFIIPEGEB
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
public class OMDDABDGODI
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static string[] BJOHPBJLJAP;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static string[] GDBFNNKENIE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static string[] FHBBJDEFBND;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static string[] GOOKJAIMMCA;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x91638A0", Offset = "0x91622A0", VA = "0x1891638A0")]
	public static string[] DCMNDFOEGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x9163CA0", Offset = "0x91626A0", VA = "0x189163CA0")]
	public static RenderTextureFormat KGBPDOIBMNE(bool HMMDFLDMLHK, bool OMFJIDALAHM, bool KAJKFOKEKBB)
	{
		return default(RenderTextureFormat);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x91641B0", Offset = "0x9162BB0", VA = "0x1891641B0")]
	public static bool LPHHFJCKCBO(Camera BIMGDIDOAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x9164280", Offset = "0x9162C80", VA = "0x189164280")]
	public static Camera[] NNCMNLFHNIM(Camera BIMGDIDOAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x91647E0", Offset = "0x91631E0", VA = "0x1891647E0")]
	public static bool NNCOIDCPFNP(string HBNPFPFAICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x9163BD0", Offset = "0x91625D0", VA = "0x189163BD0")]
	public static bool JNPOKAKPOLF(string HBNPFPFAICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x91639E0", Offset = "0x91623E0", VA = "0x1891639E0")]
	public static bool JIFFMEJMBNJ(string FFKDBBKNBNB, [Out] ulong FOAICIDPMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x9163920", Offset = "0x9162320", VA = "0x189163920")]
	public static string DGFMEBCJEJA(OOIMICNMAEE JBHFIGLCFLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FPCDIFDBCDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum EBAEPEHLDFE
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		PCM16 = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Float32 = 4
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static byte[] NGGDKLNDJLA;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private static byte[] ILPCGLCCIFK;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private static byte[] PPMICANFMOK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private static byte[] EPAPMHAOBBB;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private static byte[] FNMOIMKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private static byte[] HEGNDFKGGDB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private static byte[] HMHBIHEBJMO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private const int MLEPBPHABLE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FileStream BICPAGMDFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private byte[] LDHJDMBANNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private int PKBLFHCFNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private int GBFJIJPIJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private int DEENNMBCPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private int FKMPMCNMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EBAEPEHLDFE FCCFLLDGLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private int GCJMGLECGCE;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x915BC50", Offset = "0x915A650", VA = "0x18915BC50")]
	public FPCDIFDBCDL(string HEEMGKHJLID, int MCJPLGCDCKJ, int HGCOIPKMAAD, EBAEPEHLDFE CJOONGAAMOP = EBAEPEHLDFE.Float32)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x915B010", Offset = "0x9159A10", VA = "0x18915B010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x915B800", Offset = "0x915A200", VA = "0x18915B800")]
	public void MKCKJFCBMBD(float[] BLPDDGCLNPE, int FOLDIOKKGMM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x915B1A0", Offset = "0x9159BA0", VA = "0x18915B1A0")]
	public void LCNNFAGBMLP(int KMFILMNNDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x915B090", Offset = "0x9159A90", VA = "0x18915B090")]
	private static byte[] JFBALHJLDLB(int PBOCDEMNFLD, int AJDEGEPLAEO = 2)
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
		[Cpp2IlInjected.Address(RVA = "0x9166D20", Offset = "0x9165720", VA = "0x189166D20")]
		public void RunCoroutine(IEnumerator JKNCPPOPLHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
