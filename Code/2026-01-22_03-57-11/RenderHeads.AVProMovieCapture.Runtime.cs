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
		private Vector3 FTNEBYYIZBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AmbisonicOrder XUMFPLEXXZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AmbisonicChannelOrder ZYHSMCLZRND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AmbisonicNormalisation QFMUVRNMPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IntPtr SOUJUXTSJQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int SQQOPGPSTCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private float[] KZNWLILGNXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Queue<float[]> TNFBFIPEYIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Queue<float[]> PXBKHDLISQY;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD580", Offset = "0x8EBBD80", VA = "0x188EBD580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD320", Offset = "0x8EBBB20", VA = "0x188EBD320")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC7D0", Offset = "0x8EBAFD0", VA = "0x188EBC7D0")]
		internal void ILPRDDMFTSU(AmbisonicOrder a, AmbisonicChannelOrder b, AmbisonicNormalisation c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD460", Offset = "0x8EBBC60", VA = "0x188EBD460")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC9C0", Offset = "0x8EBB1C0", VA = "0x188EBC9C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD740", Offset = "0x8EBBF40", VA = "0x188EBD740")]
		private void VEQTZMJZMUK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC450", Offset = "0x8EBAC50", VA = "0x188EBC450")]
		private void AUXBVHKNFOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCD60", Offset = "0x8EBB560", VA = "0x188EBCD60")]
		private void OnAudioFilterRead(float[] samples, int channelCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCB20", Offset = "0x8EBB320", VA = "0x188EBCB20")]
		internal void OMCNUDGIMBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD700", Offset = "0x8EBBF00", VA = "0x188EBD700")]
		internal int RAQIQVDPVVH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC600", Offset = "0x8EBAE00", VA = "0x188EBC600")]
		internal void IBLQPFNVNDA(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD760", Offset = "0x8EBBF60", VA = "0x188EBD760")]
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
		private float[] PUAOLNEEEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ZNDRHXGIBUI PWHSMJGHGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<AmbisonicSource> TFPWWSFXUXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int UGNLNFCEBMI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmbisonicOrder LOPGYMLVQLX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10")]
			get
			{
				return default(AmbisonicOrder);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AmbisonicFormat WBPIBTPXOSA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB6E470", Offset = "0xB6CC70", VA = "0x180B6E470")]
			get
			{
				return default(AmbisonicFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDF50", Offset = "0x8EBC750", VA = "0x188EBDF50")]
		internal void WJFSEBFEZMH(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDD70", Offset = "0x8EBC570", VA = "0x188EBDD70")]
		internal void TZPUERNROJI(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDD60", Offset = "0x8EBC560", VA = "0x188EBDD60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDA70", Offset = "0x8EBC270", VA = "0x188EBDA70")]
		private void MTWYQLMEQPD(AmbisonicSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD850", Offset = "0x8EBC050", VA = "0x188EBD850")]
		private void HGVAWGDPPBS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE0D0", Offset = "0x8EBC8D0", VA = "0x188EBE0D0")]
		private void WWIMHTDDLSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDE50", Offset = "0x8EBC650", VA = "0x188EBDE50")]
		private void UNCRCPFCUZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDA50", Offset = "0x8EBC250", VA = "0x188EBDA50")]
		private bool MKGNQQBAXAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD880", Offset = "0x8EBC080", VA = "0x188EBD880")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8EBDB20", Offset = "0x8EBC320", VA = "0x188EBDB20")]
		private void NTFETSJEJLQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD940", Offset = "0x8EBC140", VA = "0x188EBD940")]
		internal void MIXFZMFPTKO(float[] a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE090", Offset = "0x8EBC890", VA = "0x188EBE090")]
		private void WSTXUZYTRLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE500", Offset = "0x8EBCD00", VA = "0x188EBE500")]
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
		private ZNDRHXGIBUI PWHSMJGHGFL;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE630", Offset = "0x8EBCE30", VA = "0x188EBE630")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE5F0", Offset = "0x8EBCDF0", VA = "0x188EBE5F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE5C0", Offset = "0x8EBCDC0", VA = "0x188EBE5C0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE790", Offset = "0x8EBCF90", VA = "0x188EBE790")]
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
		private Camera[] QVOYWDYCMRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int LLPTJQALUYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int WLYKKFEKVAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool POHFYIFSNKS;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Camera ZVIRVPJDCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF0B0", Offset = "0x8EBD8B0", VA = "0x188EBF0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SelectByMode BNJSZIPFDZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			get
			{
				return default(SelectByMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF100", Offset = "0x8EBD900", VA = "0x188EBF100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ScanFrequencyMode YTUGBMYKJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAD58C0", Offset = "0xAD40C0", VA = "0x180AD58C0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF0E0", Offset = "0x8EBD8E0", VA = "0x188EBF0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NQIQORQTCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCD7980", Offset = "0xCD6180", VA = "0x180CD7980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF0F0", Offset = "0x8EBD8F0", VA = "0x188EBF0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string JNREQDEMSIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF130", Offset = "0x8EBD930", VA = "0x188EBF130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string YRTWSWJNESU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8EBF110", Offset = "0x8EBD910", VA = "0x188EBF110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE7E0", Offset = "0x8EBCFE0", VA = "0x188EBE7E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEEF0", Offset = "0x8EBD6F0", VA = "0x188EBEEF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE7E0", Offset = "0x8EBCFE0", VA = "0x188EBE7E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEFE0", Offset = "0x8EBD7E0", VA = "0x188EBEFE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEDA0", Offset = "0x8EBD5A0", VA = "0x188EBEDA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE7F0", Offset = "0x8EBCFF0", VA = "0x188EBE7F0")]
		private void CRXBVXGOLIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEA00", Offset = "0x8EBD200", VA = "0x188EBEA00")]
		private void KVXENKFHIEX(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEE30", Offset = "0x8EBD630", VA = "0x188EBEE30")]
		public bool ScanForCameraChange()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEA10", Offset = "0x8EBD210", VA = "0x188EBEA10")]
		private Camera LTEYTKBMVAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEF00", Offset = "0x8EBD700", VA = "0x188EBEF00")]
		public void UpdateCameraCache(bool forceScanHiddenCameras = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8EBECA0", Offset = "0x8EBD4A0", VA = "0x188EBECA0")]
		private static Camera NZOEHDIRJMP(int a, Camera[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE8D0", Offset = "0x8EBD0D0", VA = "0x188EBE8D0")]
		private static Camera DEWHJFLSRNU(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8EBE960", Offset = "0x8EBD160", VA = "0x188EBE960")]
		private static Camera KUUEFUPSSQR(int a, Camera[] b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF000", Offset = "0x8EBD800", VA = "0x188EBF000")]
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
		private int RUSCMIYCDGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int DPBPQIVNWHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int VGAUSWLKVZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int DBRKTGFMQLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float[] IXFGOWLMKLZ;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF660", Offset = "0x8EBDE60", VA = "0x188EBF660")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF150", Offset = "0x8EBD950", VA = "0x188EBF150")]
		private void DDYPBDLLLYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF390", Offset = "0x8EBDB90", VA = "0x188EBF390")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF680", Offset = "0x8EBDE80", VA = "0x188EBF680")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF170", Offset = "0x8EBD970", VA = "0x188EBF170")]
		private float[] NDXEVKPJNFW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF720", Offset = "0x8EBDF20", VA = "0x188EBF720")]
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
		private const int RVLBPSQOFZC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float[] LJLMXVHZJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float[] RFTBVSTIOZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int SWDMIZUTFVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private GCHandle QHVOSULPPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int IJKDGYWQACQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int HOBVHLNPFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object QYVGAMGGGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool YVWLHEGDFGO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float[] HXZMNHCFLEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int VXORYGBJZZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xADCDA0", Offset = "0xADB5A0", VA = "0x180ADCDA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IntPtr CIKLIXRQONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8EC01A0", Offset = "0x8EBE9A0", VA = "0x188EC01A0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override int YWZKEYPFGMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x13E2910", Offset = "0x13E1110", VA = "0x1813E2910", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ONESJSAJLTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8EC01B0", Offset = "0x8EBE9B0", VA = "0x188EC01B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override int CMJZYWFCQIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD59440", Offset = "0xD57C40", VA = "0x180D59440", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8EBFA90", Offset = "0x8EBE290", VA = "0x188EBFA90", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD63390", Offset = "0xD61B90", VA = "0x180D63390", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0020", Offset = "0x8EBE820", VA = "0x188EC0020", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8EBFA80", Offset = "0x8EBE280", VA = "0x188EBFA80", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8EBFF70", Offset = "0x8EBE770", VA = "0x188EBFF70", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8EBFE80", Offset = "0x8EBE680", VA = "0x188EBFE80", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF730", Offset = "0x8EBDF30", VA = "0x188EBF730", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF7D0", Offset = "0x8EBDFD0", VA = "0x188EBF7D0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8EC00F0", Offset = "0x8EBE8F0", VA = "0x188EC00F0")]
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
		private int UFZNWTKIOZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool DBGNOQJSSTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private NativeArray<float> RMJDCQXNHUU;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CaptureBase RYSKUNTZKZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override int ONESJSAJLTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8EC01B0", Offset = "0x8EBE9B0", VA = "0x188EC01B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override int CMJZYWFCQIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0360", Offset = "0x8EBEB60", VA = "0x188EC0360", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0210", Offset = "0x8EBEA10", VA = "0x188EC0210")]
		private NativeArray<float> JBBYODLTTNA(int a)
		{
			return default(NativeArray<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private void FYNQNIXCMMY(NativeArray<float> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0380", Offset = "0x8EBEB80", VA = "0x188EC0380", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0490", Offset = "0x8EBEC90", VA = "0x188EC0490", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8EC01C0", Offset = "0x8EBE9C0", VA = "0x188EC01C0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8EC04F0", Offset = "0x8EBECF0", VA = "0x188EC04F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAC9E40", Offset = "0xAC8640", VA = "0x180AC9E40")]
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
		private const int RVLBPSQOFZC = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float[] LJLMXVHZJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float[] RFTBVSTIOZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int YYYXVXMUCSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int RABCTVHKGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GCHandle QHVOSULPPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int IJKDGYWQACQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool PMPKTOEJQDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int DHOYWZNZRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int HOBVHLNPFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object QYVGAMGGGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool KFDKFODTQKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool YVWLHEGDFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int ZEUAOXOUYDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int UTJKYHLRKLC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public List<OnAudioFilterReadForwarder> IFQNXBVPFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ZRVOTOSMHPA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD4E0", VA = "0x180ABECE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABE700", Offset = "0xABCF00", VA = "0x180ABE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float[] HXZMNHCFLEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int VXORYGBJZZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xACB450", Offset = "0xAC9C50", VA = "0x180ACB450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IntPtr CIKLIXRQONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8EC18E0", Offset = "0x8EC00E0", VA = "0x188EC18E0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override int YWZKEYPFGMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x128D3D0", Offset = "0x128BBD0", VA = "0x18128D3D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int ONESJSAJLTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8EC01B0", Offset = "0x8EBE9B0", VA = "0x188EC01B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override int CMJZYWFCQIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC16C90", Offset = "0xC15490", VA = "0x180C16C90", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8EC13C0", Offset = "0x8EBFBC0", VA = "0x188EC13C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0BE0", Offset = "0x8EBF3E0", VA = "0x188EC0BE0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8EC11E0", Offset = "0x8EBF9E0", VA = "0x188EC11E0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1590", Offset = "0x8EBFD90", VA = "0x188EC1590", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0BD0", Offset = "0x8EBF3D0", VA = "0x188EC0BD0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1120", Offset = "0x8EBF920", VA = "0x188EC1120", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0FD0", Offset = "0x8EBF7D0", VA = "0x188EC0FD0", Slot = "13")]
		public override IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8EC05E0", Offset = "0x8EBEDE0", VA = "0x188EC05E0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0760", Offset = "0x8EBEF60", VA = "0x188EC0760")]
		public void OnAudioFilterReadCombiner(float[] data, int channels, bool isMicrophone, int sampleRate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8EC0680", Offset = "0x8EBEE80", VA = "0x188EC0680")]
		private float[] LJUSVSVJRKQ(float[] a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1830", Offset = "0x8EC0030", VA = "0x188EC1830")]
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
		public CaptureBase RYSKUNTZKZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override int ONESJSAJLTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override int CMJZYWFCQIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8EC18F0", Offset = "0x8EC00F0", VA = "0x188EC18F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
		public override void PrepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "12")]
		public override void FlushBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public override void StartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "9")]
		public override void StopCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "10")]
		public override void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "11")]
		public override void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC9E40", Offset = "0xAC8640", VA = "0x180AC9E40")]
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
		private sealed class AHNCXYPTGXT : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CaptureFromCamera BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public AHNCXYPTGXT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8EBC040", Offset = "0x8EBA840", VA = "0x188EBC040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8EBC000", Offset = "0x8EBA800", VA = "0x188EBC000", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class SVHHEKBXFMG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CaptureFromCamera BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public SVHHEKBXFMG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0760", Offset = "0x8ECEF60", VA = "0x188ED0760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0720", Offset = "0x8ECEF20", VA = "0x188ED0720", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
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
		private RenderTexture KYZKTYKZBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private RenderTexture AXJKEDBGYGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private IntPtr KPHWJHLBEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Texture NIDRGWSSUKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Texture UGDFIORPKCP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CameraSelector YMIQOTKMTPH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6480", Offset = "0xCE4C80", VA = "0x180CE6480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE8F590", Offset = "0xE8DD90", VA = "0x180E8F590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XFSKWUJLDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCE65D0", Offset = "0xCE4DD0", VA = "0x180CE65D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCE6700", Offset = "0xCE4F00", VA = "0x180CE6700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8EC96F0", Offset = "0x8EC7EF0", VA = "0x188EC96F0")]
		public void SetCamera(Camera topCamera, bool useContributingCameras = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8EC96A0", Offset = "0x8EC7EA0", VA = "0x188EC96A0")]
		public void SetCamera(Camera topCamera, Camera[] contributingCameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8EC95C0", Offset = "0x8EC7DC0", VA = "0x188EC95C0")]
		private bool RUZFEGVGJND(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8570", Offset = "0x8EC6D70", VA = "0x188EC8570")]
		private bool ADRAVYGBJMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8A90", Offset = "0x8EC7290", VA = "0x188EC8A90")]
		private bool OIPXQGZOCFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9900", Offset = "0x8EC8100", VA = "0x188EC9900", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8A20", Offset = "0x8EC7220", VA = "0x188EC8A20")]
		[IteratorStateMachine(typeof(SVHHEKBXFMG))]
		private IEnumerator IPBWAYURCHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8EC85D0", Offset = "0x8EC6DD0", VA = "0x188EC85D0")]
		[IteratorStateMachine(typeof(AHNCXYPTGXT))]
		public IEnumerator Capture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9AD0", Offset = "0x8EC82D0", VA = "0x188EC9AD0")]
		private bool XEZRNXKAKHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8650", Offset = "0x8EC6E50", VA = "0x188EC8650")]
		private void IBGQGRQSRRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9810", Offset = "0x8EC8010", VA = "0x188EC9810", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9C10", Offset = "0x8EC8410", VA = "0x188EC9C10")]
		private void YPNICBEOEIU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E60D80", Offset = "0x1E5F580", VA = "0x181E60D80", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8BB0", Offset = "0x8EC73B0", VA = "0x188EC8BB0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8AC0", Offset = "0x8EC72C0", VA = "0x188EC8AC0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9DE0", Offset = "0x8EC85E0", VA = "0x188EC9DE0")]
		public CaptureFromCamera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8640", Offset = "0x8EC6E40", VA = "0x188EC8640")]
		[CompilerGenerated]
		[DebuggerHidden]
		private void IAGLTHRFGYB()
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
		private sealed class XTSGCURKDFX : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CaptureFromCamera360 BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public XTSGCURKDFX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0920", Offset = "0x8ECF120", VA = "0x188ED0920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8ED08E0", Offset = "0x8ECF0E0", VA = "0x188ED08E0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
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
		private RenderTexture WPTSYPJDLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RenderTexture[] OZVTQYRSDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Material WYCEKHXBBWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material XXIKEWDVQUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private RenderTexture HAVCLFWBTJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private RenderTexture IHOPFQVPOKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IntPtr KPHWJHLBEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int XWBPSKKLRZU;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CameraSelector YMIQOTKMTPH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6480", Offset = "0xCE4C80", VA = "0x180CE6480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xE8F590", Offset = "0xE8DD90", VA = "0x180E8F590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public CubemapResolution CZTBZIXKRWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x17AC2A0", Offset = "0x17AAAA0", VA = "0x1817AC2A0")]
			get
			{
				return default(CubemapResolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8520", Offset = "0x8EC6D20", VA = "0x188EC8520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CubemapDepth GGETTORZDPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8EC84D0", Offset = "0x8EC6CD0", VA = "0x188EC84D0")]
			get
			{
				return default(CubemapDepth);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8510", Offset = "0x8EC6D10", VA = "0x188EC8510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool QMESEAYDZGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCE65D0", Offset = "0xCE4DD0", VA = "0x180CE65D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCE6700", Offset = "0xCE4F00", VA = "0x180CE6700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HEHUNVJMBYL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCE65C0", Offset = "0xCE4DC0", VA = "0x180CE65C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xCE66F0", Offset = "0xCE4EF0", VA = "0x180CE66F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool XUYBIUOLIRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8EC84F0", Offset = "0x8EC6CF0", VA = "0x188EC84F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8540", Offset = "0x8EC6D40", VA = "0x188EC8540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VWARSGMRUPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8500", Offset = "0x8EC6D00", VA = "0x188EC8500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8550", Offset = "0x8EC6D50", VA = "0x188EC8550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public StereoPacking ITVSIUKHGHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2513E80", Offset = "0x2512680", VA = "0x182513E80")]
			get
			{
				return default(StereoPacking);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8560", Offset = "0x8EC6D60", VA = "0x188EC8560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float SNKTKRYXOZY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8EC84E0", Offset = "0x8EC6CE0", VA = "0x188EC84E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8EC8530", Offset = "0x8EC6D30", VA = "0x188EC8530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8420", Offset = "0x8EC6C20", VA = "0x188EC8420")]
		public CaptureFromCamera360()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8EC7B00", Offset = "0x8EC6300", VA = "0x188EC7B00")]
		private CubemapRenderMethod QLECNZPUIHF()
		{
			return default(CubemapRenderMethod);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE81CE0", Offset = "0xE804E0", VA = "0x180E81CE0")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8120", Offset = "0x8EC6920", VA = "0x188EC8120", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EC6450", Offset = "0x8EC4C50", VA = "0x188EC6450")]
		[IteratorStateMachine(typeof(XTSGCURKDFX))]
		private IEnumerator IPBWAYURCHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8EC7C10", Offset = "0x8EC6410", VA = "0x188EC7C10")]
		private void RYSKUNTZKZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8290", Offset = "0x8EC6A90", VA = "0x188EC8290")]
		private static void XUJDPGNORQR(RenderTexture a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EC5AE0", Offset = "0x8EC42E0", VA = "0x188EC5AE0")]
		private void HYUOISWOWBB(RenderTexture a, RenderTexture b, bool c, Quaternion d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EC5EF0", Offset = "0x8EC46F0", VA = "0x188EC5EF0")]
		private void IBGQGRQSRRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EC40E0", Offset = "0x8EC28E0", VA = "0x188EC40E0")]
		private void FMYGPCEDYSO(Camera a, RenderTexture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EC7B30", Offset = "0x8EC6330", VA = "0x188EC7B30")]
		private void RBQFHFLSAYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8EC6770", Offset = "0x8EC4F70", VA = "0x188EC6770", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8EC5AA0", Offset = "0x8EC42A0", VA = "0x188EC5AA0", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8EC7F40", Offset = "0x8EC6740", VA = "0x188EC7F40", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8EC64C0", Offset = "0x8EC4CC0", VA = "0x188EC64C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8ED08B0", Offset = "0x8ECF0B0", VA = "0x188ED08B0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class SVMOBQVUOXP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CaptureFromCamera360ODS BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public SVMOBQVUOXP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0840", Offset = "0x8ECF040", VA = "0x188ED0840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0800", Offset = "0x8ECF000", VA = "0x188ED0800", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Settings _settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int VBPTXQNRKTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int CRWGPNUPZUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Transform HUHICBPBJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Camera IQEOBIRBWHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Camera ZZUPIVOZTOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Camera ORFQIHPKYKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Camera YQNCKBLEDYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private RenderTexture UXCKROKCHYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IntPtr KPHWJHLBEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Material FISPTYSYIRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int STPPORPINXG;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Settings ILPRDDMFTSU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCE6480", Offset = "0xCE4C80", VA = "0x180CE6480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3FF0", Offset = "0x8EC27F0", VA = "0x188EC3FF0")]
		public CaptureFromCamera360ODS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3660", Offset = "0x8EC1E60", VA = "0x188EC3660")]
		public void SetCamera(Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3690", Offset = "0x8EC1E90", VA = "0x188EC3690", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1990", Offset = "0x8EC0190", VA = "0x188EC1990")]
		private Camera HESILTYSHMQ(Camera a, string b, float c, float d, int e, int f, float g, float h, int i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EC37C0", Offset = "0x8EC1FC0", VA = "0x188EC37C0", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1FE0", Offset = "0x8EC07E0", VA = "0x188EC1FE0")]
		[IteratorStateMachine(typeof(SVMOBQVUOXP))]
		private IEnumerator IPBWAYURCHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3390", Offset = "0x8EC1B90", VA = "0x188EC3390")]
		private void RYSKUNTZKZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EC32B0", Offset = "0x8EC1AB0", VA = "0x188EC32B0")]
		private void RBQFHFLSAYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3950", Offset = "0x8EC2150", VA = "0x188EC3950")]
		private void VIKVZVXIYTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8EC1950", Offset = "0x8EC0150", VA = "0x188EC1950", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8EC2360", Offset = "0x8EC0B60", VA = "0x188EC2360", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EC2050", Offset = "0x8EC0850", VA = "0x188EC2050")]
		private static void OBXHSAQGNSU(Camera a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8EC2120", Offset = "0x8EC0920", VA = "0x188EC2120", Slot = "6")]
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
		private sealed class ZQHBBUYVQYX : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CaptureFromScreen BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public ZQHBBUYVQYX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8ED09D0", Offset = "0x8ECF1D0", VA = "0x188ED09D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0990", Offset = "0x8ECF190", VA = "0x188ED0990", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
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
		private IntPtr KPHWJHLBEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RenderTexture AXJKEDBGYGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private CommandBuffer ICXEUBTFBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator JDBKGKQULSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool JJBYMBZLAFZ;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EMXSFPNVTEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBBB80", Offset = "0x1FBA380", VA = "0x181FBBB80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8ECA940", Offset = "0x8EC9140", VA = "0x188ECA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public MouseCursor GRMBOOHRVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xCE6550", Offset = "0xCE4D50", VA = "0x180CE6550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xE81CE0", Offset = "0xE804E0", VA = "0x180E81CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9F80", Offset = "0x8EC8780", VA = "0x188EC9F80", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA4C0", Offset = "0x8EC8CC0", VA = "0x188ECA4C0")]
		private void VFGGHDGRTRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9E40", Offset = "0x8EC8640", VA = "0x188EC9E40")]
		private void BCCRMCPIZKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA380", Offset = "0x8EC8B80", VA = "0x188ECA380", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9F10", Offset = "0x8EC8710", VA = "0x188EC9F10")]
		[IteratorStateMachine(typeof(ZQHBBUYVQYX))]
		private IEnumerator IPBWAYURCHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA490", Offset = "0x8EC8C90", VA = "0x188ECA490", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA8E0", Offset = "0x8EC90E0", VA = "0x188ECA8E0")]
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
		private sealed class ZQMHZBSTAKG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public CaptureFromTexture BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public ZQMHZBSTAKG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0B40", Offset = "0x8ECF340", VA = "0x188ED0B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0B00", Offset = "0x8ECF300", VA = "0x188ED0B00", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
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
		private Texture PJHGMHRJIQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private RenderTexture AXJKEDBGYGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		protected IntPtr KPHWJHLBEXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool WTFAPRFMJQA;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool EQAGQGVCPKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBBB80", Offset = "0x1FBA380", VA = "0x181FBBB80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8ECA940", Offset = "0x8EC9140", VA = "0x188ECA940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xE81CE0", Offset = "0xE804E0", VA = "0x180E81CE0")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB010", Offset = "0x8EC9810", VA = "0x188ECB010")]
		private bool RUZFEGVGJND(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB7C0", Offset = "0x8EC9FC0", VA = "0x188ECB7C0")]
		public void UpdateSourceTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAAB0", Offset = "0x8EC92B0", VA = "0x188ECAAB0")]
		private bool NXOJQRABZMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB620", Offset = "0x8EC9E20", VA = "0x188ECB620")]
		private bool UDZWNRMJBLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB720", Offset = "0x8EC9F20", VA = "0x188ECB720", Slot = "15")]
		public override void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAA40", Offset = "0x8EC9240", VA = "0x188ECAA40")]
		[IteratorStateMachine(typeof(ZQMHZBSTAKG))]
		private IEnumerator IPBWAYURCHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB0F0", Offset = "0x8EC98F0", VA = "0x188ECB0F0")]
		private void RYSKUNTZKZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB7D0", Offset = "0x8EC9FD0", VA = "0x188ECB7D0")]
		private void YPNICBEOEIU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAF60", Offset = "0x8EC9760", VA = "0x188ECAF60")]
		private void RBQFHFLSAYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA950", Offset = "0x8EC9150", VA = "0x188ECA950", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAB20", Offset = "0x8EC9320", VA = "0x188ECAB20", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB640", Offset = "0x8EC9E40", VA = "0x188ECB640", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB960", Offset = "0x8ECA160", VA = "0x188ECB960")]
		public CaptureFromTexture()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From WebCamTexture", 3)]
	public class CaptureFromWebCamTexture : CaptureFromTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB9C0", Offset = "0x8ECA1C0", VA = "0x188ECB9C0", Slot = "5")]
		public override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB960", Offset = "0x8ECA160", VA = "0x188ECB960")]
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
		private AudioListener GFLIURXTZUT;

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
		private static readonly string[] HJDSIWCSASX;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly float[] RJUIUGLCKWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Section DDHQTWBKRPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string[] HTCXTEEWCYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string[] WUZQGYVSQBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool[] JURJHAGSTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool[] HFEKPOHJQQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] AQOYTPKJLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private string[] MEYPUXLGNCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string[] RCWMTVMYZFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int VDHOVFNZWPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private GUIStyle OZPAYUJMIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private int VHQNPOCLACU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Vector2 URSZBUAGUGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Vector2 OUCGMHVDJIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private Vector2 ESPYAGYEARI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Vector2 BRBBBZWCWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private long PJABZQVDPPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private float ZQZSLJJLBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private float WNZOYBNRQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private uint FNJUOBAVHXV;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public CaptureBase DIISHJSHQIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IWEEJGXNWLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFA0", Offset = "0xCBE7A0", VA = "0x180CBFFA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD06E10", Offset = "0xD05610", VA = "0x180D06E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool ZYWQHJPKVSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB046C0", Offset = "0xB02EC0", VA = "0x180B046C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB045B0", Offset = "0xB02DB0", VA = "0x180B045B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD160", Offset = "0x8ECB960", VA = "0x188ECD160")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8ECF610", Offset = "0x8ECDE10", VA = "0x188ECF610")]
		private void WIQXGLTDHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8ECCC90", Offset = "0x8ECB490", VA = "0x188ECCC90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD1D0", Offset = "0x8ECB9D0", VA = "0x188ECD1D0")]
		private void TGLTPRBLXCZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8ECBB30", Offset = "0x8ECA330", VA = "0x188ECBB30")]
		private void KEJDUXRYOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8ECEFE0", Offset = "0x8ECD7E0", VA = "0x188ECEFE0")]
		private void UAGESDNMJWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8ECFF80", Offset = "0x8ECE780", VA = "0x188ECFF80")]
		private void ZMPXVQMWWMA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8ECFE30", Offset = "0x8ECE630", VA = "0x188ECFE30")]
		private void WWIMHTDDLSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8ECF390", Offset = "0x8ECDB90", VA = "0x188ECF390")]
		private void UNCRCPFCUZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8ECBA30", Offset = "0x8ECA230", VA = "0x188ECBA30")]
		private void ASWQRGEZKYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8ECBAB0", Offset = "0x8ECA2B0", VA = "0x188ECBAB0")]
		private void DIYNMATGSGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8ECFF00", Offset = "0x8ECE700", VA = "0x188ECFF00")]
		private void WYPETYUPYGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8ECF420", Offset = "0x8ECDC20", VA = "0x188ECF420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8ED0350", Offset = "0x8ECEB50", VA = "0x188ED0350")]
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
		private RenderTexture NAITESOEFRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private RenderTexture RFBKBPKCCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Material NSSECMDWMTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Material AHSSRPMEATY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int YBGILIDUUAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int DPBDEKNRJJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int ABHPRKVUXHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool MZNOCTBSYGA;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int OWSRHHLIDEK;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static int OJYSVMIQBAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		public float _bias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private float BIOZZWTDCOS;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool MEQRCYOVPAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1DAE490", Offset = "0x1DACC90", VA = "0x181DAE490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1DAE540", Offset = "0x1DACD40", VA = "0x181DAE540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int AAAWXTLUROA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAD58C0", Offset = "0xAD40C0", VA = "0x180AD58C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8EDF660", Offset = "0x8EDDE60", VA = "0x188EDF660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int SDJIGGPMLTV
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD59440", Offset = "0xD57C40", VA = "0x180D59440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public RenderTexture LELGTKPFCIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDEC90", Offset = "0x8EDD490", VA = "0x188EDEC90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF610", Offset = "0x8EDDE10", VA = "0x188EDF610")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF630", Offset = "0x8EDDE30", VA = "0x188EDF630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF380", Offset = "0x8EDDB80", VA = "0x188EDF380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8EDED80", Offset = "0x8EDD580", VA = "0x188EDED80")]
		private void ILPRDDMFTSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8EDED20", Offset = "0x8EDD520", VA = "0x188EDED20")]
		private void CXKRYIWAKYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF1A0", Offset = "0x8EDD9A0", VA = "0x188EDF1A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF3E0", Offset = "0x8EDDBE0", VA = "0x188EDF3E0")]
		public void OnNumSamplesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x843BB80", Offset = "0x843A380", VA = "0x18843BB80")]
		private static float DFCTNQBNQPD(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF0C0", Offset = "0x8EDD8C0", VA = "0x188EDF0C0")]
		private void NYARWPJKBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8EDEB70", Offset = "0x8EDD370", VA = "0x188EDEB70")]
		public void Accumulate(Texture src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF4A0", Offset = "0x8EDDCA0", VA = "0x188EDF4A0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF640", Offset = "0x8EDDE40", VA = "0x188EDF640")]
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
		private GUIContent NIJYJXCLMRH;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF870", Offset = "0x8EDE070", VA = "0x188EDF870")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF7C0", Offset = "0x8EDDFC0", VA = "0x188EDF7C0")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF670", Offset = "0x8EDDE70", VA = "0x188EDF670")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF930", Offset = "0x8EDE130", VA = "0x188EDF930")]
		public MouseCursor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OnAudioFilterReadForwarder : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Action<float[], int, bool, int> ZVPMUYHZJVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8EDF990", Offset = "0x8EDE190", VA = "0x188EDF990")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
		internal class FEHKNZETOMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private PlayableDirector VDPODGHRSTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private DirectorUpdateMode YRMANKSYADW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private bool RIKBIUANUIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private bool FWPNCBBUFMF;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
			internal FEHKNZETOMD(PlayableDirector a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB3B0", Offset = "0x8ED9BB0", VA = "0x188EDB3B0")]
			internal bool WBUDUHNZCJF(PlayableDirector a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB410", Offset = "0x8ED9C10", VA = "0x188EDB410")]
			internal void WWIMHTDDLSN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB2E0", Offset = "0x8ED9AE0", VA = "0x188EDB2E0")]
			internal void UNCRCPFCUZB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<FEHKNZETOMD> ULHKBSXLAPG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ScanFrequencyMode YTUGBMYKJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8EE1CE0", Offset = "0x8EE04E0", VA = "0x188EE1CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1380", Offset = "0x8EDFB80", VA = "0x188EE1380")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1380", Offset = "0x8EDFB80", VA = "0x188EE1380")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1470", Offset = "0x8EDFC70", VA = "0x188EE1470")]
		internal void JRBSDVRJXWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1A40", Offset = "0x8EE0240", VA = "0x188EE1A40")]
		internal void WWIMHTDDLSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1860", Offset = "0x8EE0060", VA = "0x188EE1860")]
		internal void UNCRCPFCUZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1530", Offset = "0x8EDFD30", VA = "0x188EE1530")]
		public void ScanForPlayableDirectors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1490", Offset = "0x8EDFC90", VA = "0x188EE1490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1390", Offset = "0x8EDFB90", VA = "0x188EE1390")]
		private void CRXBVXGOLIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1480", Offset = "0x8EDFC80", VA = "0x188EE1480")]
		private void KVXENKFHIEX(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1C60", Offset = "0x8EE0460", VA = "0x188EE1C60")]
		public TimelineController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class UnityAudioCapture : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual int YWZKEYPFGMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public abstract int ONESJSAJLTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public abstract int CMJZYWFCQIZ
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
		[Cpp2IlInjected.Address(RVA = "0x8EE2160", Offset = "0x8EE0960", VA = "0x188EE2160", Slot = "13")]
		public virtual IntPtr ReadData([Out] int length)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1FD0", Offset = "0x8EE07D0", VA = "0x188EE1FD0")]
		public static int GetUnityAudioChannelCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE20F0", Offset = "0x8EE08F0", VA = "0x188EE20F0")]
		private static int QDDHLBEUSUL(AudioSpeakerMode a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
		internal class AVGGYZMDXLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private VideoPlayer HDAMHBJKBFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private bool FWPNCBBUFMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private bool RIKBIUANUIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private bool NPIRZSBOROX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private double CFALNAABTLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private float UTHNCSJFFSP;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
			internal AVGGYZMDXLK(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8ED15C0", Offset = "0x8ECFDC0", VA = "0x188ED15C0")]
			internal bool WBUDUHNZCJF(VideoPlayer a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8ED1620", Offset = "0x8ECFE20", VA = "0x188ED1620")]
			internal void WWIMHTDDLSN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0C10", Offset = "0x8ECF410", VA = "0x188ED0C10")]
			internal bool ASNZFCBUNDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0E80", Offset = "0x8ECF680", VA = "0x188ED0E80")]
			internal void RJWCWSBXBQU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0DE0", Offset = "0x8ECF5E0", VA = "0x188ED0DE0")]
			private void LNCQOHYLVFI(VideoPlayer a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0CE0", Offset = "0x8ECF4E0", VA = "0x188ED0CE0")]
			private void JQAHKLDNCWH(VideoPlayer a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0C50", Offset = "0x8ECF450", VA = "0x188ED0C50")]
			internal void FSRRJZZIXNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8ED1250", Offset = "0x8ECFA50", VA = "0x188ED1250")]
			internal bool Update(float deltaTime)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8ED11C0", Offset = "0x8ECF9C0", VA = "0x188ED11C0")]
			internal void UNCRCPFCUZB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class DUSVVQZWKCF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private object VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public VideoPlayerController BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			private object RWJAFRFAPMM
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public DUSVVQZWKCF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAF80", Offset = "0x8ED9780", VA = "0x188EDAF80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAF40", Offset = "0x8ED9740", VA = "0x188EDAF40", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private ScanFrequencyMode _scanFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<AVGGYZMDXLK> KQPTTIESLUY;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public ScanFrequencyMode YTUGBMYKJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			get
			{
				return default(ScanFrequencyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8EE4090", Offset = "0x8EE2890", VA = "0x188EE4090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3300", Offset = "0x8EE1B00", VA = "0x188EE3300")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3300", Offset = "0x8EE1B00", VA = "0x188EE3300")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8EE36D0", Offset = "0x8EE1ED0", VA = "0x188EE36D0")]
		internal void JRBSDVRJXWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8EE33F0", Offset = "0x8EE1BF0", VA = "0x188EE33F0")]
		public bool CanContinue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3820", Offset = "0x8EE2020", VA = "0x188EE3820")]
		[IteratorStateMachine(typeof(DUSVVQZWKCF))]
		internal IEnumerator OODWZKXQQUD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3E60", Offset = "0x8EE2660", VA = "0x188EE3E60")]
		internal void WWIMHTDDLSN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3CD0", Offset = "0x8EE24D0", VA = "0x188EE3CD0")]
		internal void UNCRCPFCUZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3930", Offset = "0x8EE2130", VA = "0x188EE3930")]
		public void ScanForVideoPlayers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3890", Offset = "0x8EE2090", VA = "0x188EE3890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3310", Offset = "0x8EE1B10", VA = "0x188EE3310")]
		private void CRXBVXGOLIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3810", Offset = "0x8EE2010", VA = "0x188EE3810")]
		private void KVXENKFHIEX(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4010", Offset = "0x8EE2810", VA = "0x188EE4010")]
		public VideoPlayerController()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3560", Offset = "0x8EE1D60", VA = "0x188EE3560")]
		[CompilerGenerated]
		private bool ICGWSAPBCVG()
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
	public class IBXZITGUJWL
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
		public static string[] RYGZGWQNUJS;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly string[] IITVOGLZQQV;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly string[] WYCJJLPEGNQ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly string[] USNAVWZQAKB;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly string[] LYHAEKXNZNA;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly string[] NFEFZBHFLXV;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly string[] AQIXXUZAVDS;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static IntPtr XDHCQBXXNVO;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static IntPtr JSSPHKJIRDA;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private static IntPtr NJDIJABPWMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8EDD5C0", Offset = "0x8EDBDC0", VA = "0x188EDD5C0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private static IntPtr FMCMDTKGSTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8EDD6C0", Offset = "0x8EDBEC0", VA = "0x188EDD6C0")]
			get
			{
				return default(IntPtr);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB6D0", Offset = "0x8ED9ED0", VA = "0x188EDB6D0")]
		public static extern IntPtr AddAmbisonicSourceInstance(int maxCoefficients);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD9A0", Offset = "0x8EDC1A0", VA = "0x188EDD9A0")]
		public static extern void RemoveAmbisonicSourceInstance(IntPtr instance);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDC50", Offset = "0x8EDC450", VA = "0x188EDDC50")]
		public static extern void UpdateAmbisonicWeights(IntPtr instance, float azimuth, float elevation, AmbisonicOrder order, AmbisonicChannelOrder channelOrder, float[] normalisationWeights);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC010", Offset = "0x8EDA810", VA = "0x188EDC010")]
		public static extern void EncodeMonoToAmbisonic(IntPtr instance, float[] inSamples, int inSamplesOffset, int inFrameCount, int inChannelCount, float[] outSamples, int outSamplesOffset, int outSamplesLength, AmbisonicOrder order);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD320", Offset = "0x8EDBB20", VA = "0x188EDD320")]
		public static string JGIOPENLELN(PixelFormat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC310", Offset = "0x8EDAB10", VA = "0x188EDC310")]
		public static void GKJSLJLRSOB(PluginEvent a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCE80", Offset = "0x8EDB680", VA = "0x188EDCE80")]
		private static extern IntPtr GetRenderEventFunc();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCC20", Offset = "0x8EDB420", VA = "0x188EDCC20")]
		private static extern IntPtr GetFreeResourcesEventFunc();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD0B0", Offset = "0x8EDB8B0", VA = "0x188EDD0B0")]
		public static extern bool Init();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBD50", Offset = "0x8EDA550", VA = "0x188EDBD50")]
		public static extern void Deinit();

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB600", Offset = "0x8ED9E00", VA = "0x188EDB600")]
		public static string ADLUBEEGWKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBDC0", Offset = "0x8EDA5C0", VA = "0x188EDBDC0")]
		public static bool EZMRRRPKJOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCEF0", Offset = "0x8EDB6F0", VA = "0x188EDCEF0")]
		public static extern int GetVideoCodecCount();

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD1A0", Offset = "0x8EDB9A0", VA = "0x188EDD1A0")]
		public static extern bool IsConfigureVideoCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCF60", Offset = "0x8EDB760", VA = "0x188EDCF60")]
		public static extern MediaApi GetVideoCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB7D0", Offset = "0x8ED9FD0", VA = "0x188EDB7D0")]
		public static extern void ConfigureVideoCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC190", Offset = "0x8EDA990", VA = "0x188EDC190")]
		public static string GCFFZONHIPP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC580", Offset = "0x8EDAD80", VA = "0x188EDC580")]
		public static extern int GetAudioCodecCount();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD120", Offset = "0x8EDB920", VA = "0x188EDD120")]
		public static extern bool IsConfigureAudioCodecSupported(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC5F0", Offset = "0x8EDADF0", VA = "0x188EDC5F0")]
		public static extern MediaApi GetAudioCodecMediaApi(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB750", Offset = "0x8ED9F50", VA = "0x188EDB750")]
		public static extern void ConfigureAudioCodec(int codecIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBBD0", Offset = "0x8EDA3D0", VA = "0x188EDBBD0")]
		public static string DRUSNZVCQBI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC740", Offset = "0x8EDAF40", VA = "0x188EDC740")]
		public static extern int GetAudioInputDeviceCount();

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDD30", Offset = "0x8EDC530", VA = "0x188EDDD30")]
		public static string XBGKOOOBOIG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC7B0", Offset = "0x8EDAFB0", VA = "0x188EDC7B0")]
		public static extern MediaApi GetAudioInputDeviceMediaApi(int index);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD3F0", Offset = "0x8EDBBF0", VA = "0x188EDD3F0")]
		public static string[] MHZRWAYSBII(int a, int b = -1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBA70", Offset = "0x8EDA270", VA = "0x188EDBA70")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int videoCodecIndex, AudioCaptureSource audioSource, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool forceGpuFlush, VideoEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB850", Offset = "0x8EDA050", VA = "0x188EDB850")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, float frameRate, int format, bool isRealTime, bool isTopDown, int imageFormatType, bool forceGpuFlush, int startFrame, ImageEncoderHints hints);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB980", Offset = "0x8EDA180", VA = "0x188EDB980")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, float frameRate, int format, bool isTopDown, int transparencyMode, bool forceGpuFlush);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDB40", Offset = "0x8EDC340", VA = "0x188EDDB40")]
		public static extern bool Start(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD2A0", Offset = "0x8EDBAA0", VA = "0x188EDD2A0")]
		public static extern bool IsNewFrameDue(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDA20", Offset = "0x8EDC220", VA = "0x188EDDA20")]
		public static extern int SetEncodedFrameLimit(int handle, uint encodedFrameLimit);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBF80", Offset = "0x8EDA780", VA = "0x188EDBF80")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBE40", Offset = "0x8EDA640", VA = "0x188EDBE40")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8EDBEE0", Offset = "0x8EDA6E0", VA = "0x188EDBEE0")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD7C0", Offset = "0x8EDBFC0", VA = "0x188EDD7C0")]
		public static extern void Pause(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDBC0", Offset = "0x8EDC3C0", VA = "0x188EDDBC0")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD220", Offset = "0x8EDBA20", VA = "0x188EDD220")]
		public static extern bool IsFileWritingComplete(int handle);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
		public static bool QHTUTWRODLQ(int a, StringBuilder b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8EDDAB0", Offset = "0x8EDC2B0", VA = "0x188EDDAB0")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC110", Offset = "0x8EDA910", VA = "0x188EDC110")]
		public static extern void FreeRecorder(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCD10", Offset = "0x8EDB510", VA = "0x188EDCD10")]
		public static extern uint GetNumDroppedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCC90", Offset = "0x8EDB490", VA = "0x188EDCC90")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCD90", Offset = "0x8EDB590", VA = "0x188EDCD90")]
		public static extern uint GetNumEncodedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCBA0", Offset = "0x8EDB3A0", VA = "0x188EDCBA0")]
		public static extern float GetEncodedSeconds(int handle);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC900", Offset = "0x8EDB100", VA = "0x188EDC900")]
		public static extern uint GetBufferSize(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC980", Offset = "0x8EDB180", VA = "0x188EDC980")]
		public static extern uint GetBufferedFrames(int handle);

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCE10", Offset = "0x8EDB610", VA = "0x188EDCE10")]
		private static extern IntPtr GetPluginVersion();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCFE0", Offset = "0x8EDB7E0", VA = "0x188EDCFE0")]
		private static extern bool GetVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC670", Offset = "0x8EDAE70", VA = "0x188EDC670")]
		private static extern bool GetAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC830", Offset = "0x8EDB030", VA = "0x188EDC830")]
		private static extern bool GetAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCA00", Offset = "0x8EDB200", VA = "0x188EDCA00")]
		private static extern bool GetContainerFileExtensions(int videoCodecIndex, int audioCodecIndex, StringBuilder extensions, int extensionsBufferLength);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8EDCAE0", Offset = "0x8EDB2E0", VA = "0x188EDCAE0")]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, [Out] ulong lpFreeBytesAvailable, [Out] ulong lpTotalNumberOfBytes, [Out] ulong lpTotalNumberOfFreeBytes);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8EDD840", Offset = "0x8EDC040", VA = "0x188EDD840")]
		public static bool RUFVMMQMXSJ(string a, [Out] ulong b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class ROBDJXRVKAU
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
			[Cpp2IlInjected.Address(RVA = "0x8EE06A0", Offset = "0x8EDEEA0", VA = "0x188EE06A0")]
			public void PLRUCVODFAF(Vector3 a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static float[] CAGPZPCYEHQ;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static float[] QBIUSKTDSUD;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1180", Offset = "0x8EDF980", VA = "0x188EE1180")]
		public static float[] QKMAQSFKBQM(AmbisonicNormalisation a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0E70", Offset = "0x8EDF670", VA = "0x188EE0E70")]
		public static int GBQODOFJEMZ(AmbisonicOrder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1170", Offset = "0x8EDF970", VA = "0x188EE1170")]
		public static AmbisonicChannelOrder QQXDTFXNVWU(AmbisonicFormat a)
		{
			return default(AmbisonicChannelOrder);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1170", Offset = "0x8EDF970", VA = "0x188EE1170")]
		public static AmbisonicNormalisation LZJPTLWFHCP(AmbisonicFormat a)
		{
			return default(AmbisonicNormalisation);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1300", Offset = "0x8EDFB00", VA = "0x188EE1300")]
		static ROBDJXRVKAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0EA0", Offset = "0x8EDF6A0", VA = "0x188EE0EA0")]
		private static float[] HTCBQUBNCMR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1280", Offset = "0x8EDFA80", VA = "0x188EE1280")]
		private static int UCCGLEYEMQB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1220", Offset = "0x8EDFA20", VA = "0x188EE1220")]
		private static int UBMLTKQMKIA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE1200", Offset = "0x8EDFA00", VA = "0x188EE1200")]
		private static int QWYUQLKQOEK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0860", Offset = "0x8EDF060", VA = "0x188EE0860")]
		private static float BSOKPQPYUYR(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0A50", Offset = "0x8EDF250", VA = "0x188EE0A50")]
		private static float BSOKPQPYUYR(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0BC0", Offset = "0x8EDF3C0", VA = "0x188EE0BC0")]
		private static float[] DDNVBOMIJFC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class AMUCGWGTSZE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private uint PYTYRMRYYKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private uint TJRQRLFIFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private uint WFVZOGRRZMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private float JMQJNCQSULH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private uint HNYYATFYQUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private uint JBUCHEDCKQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ulong LPHPIFNIXBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int THDUBZLWZMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private AudioCaptureSource XBGLFBKBZBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int NHPFRSTBIKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int UFZNWTKIOZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float WJIYHJSRZTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int UBBGSYLAJYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int YBGILIDUUAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float MYNPRDIVVDS;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float CUBDMYTIGXE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xAFE390", Offset = "0xAFCB90", VA = "0x180AFE390")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public uint UKWFCHSPZTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public uint OPGUYBKRRJT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public uint DGMFDWQUVTN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xAB1220", Offset = "0xAAFA20", VA = "0x180AB1220")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float WQFSPVUJOSA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB05CA0", Offset = "0xB044A0", VA = "0x180B05CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1162270", Offset = "0x1160A70", VA = "0x181162270")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal uint CFSYYYGFKWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB01710", VA = "0x180B02F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal uint QXYLJKTFJUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xC81FA0", Offset = "0xC807A0", VA = "0x180C81FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AudioCaptureSource PBLAFBPIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFB170", VA = "0x180AFC970")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x143C990", Offset = "0x143B190", VA = "0x18143C990")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int QDZVHZJLRHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xADCDA0", Offset = "0xADB5A0", VA = "0x180ADCDA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB61FF0", Offset = "0xB607F0", VA = "0x180B61FF0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int XDJFWZVYJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAEE540", Offset = "0xAECD40", VA = "0x180AEE540")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAEE390", Offset = "0xAECB90", VA = "0x180AEE390")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ED0C00", Offset = "0x8ECF400", VA = "0x188ED0C00")]
		internal void OZZPYEFIQZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8ED0BB0", Offset = "0x8ECF3B0", VA = "0x188ED0BB0")]
		internal void LFQAKNCRIGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x773DB70", Offset = "0x773C370", VA = "0x18773DB70")]
		public AMUCGWGTSZE()
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
		[Cpp2IlInjected.Address(RVA = "0x8EE3290", Offset = "0x8EE1A90", VA = "0x188EE3290")]
		public VideoEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3230", Offset = "0x8EE1A30", VA = "0x188EE3230")]
		public void OBKIOIYDNVN()
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
		[Cpp2IlInjected.Address(RVA = "0x8EDEB30", Offset = "0x8EDD330", VA = "0x188EDEB30")]
		public ImageEncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EDEB10", Offset = "0x8EDD310", VA = "0x188EDEB10")]
		public void OBKIOIYDNVN()
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
		[Cpp2IlInjected.Address(RVA = "0x8EDB1D0", Offset = "0x8ED99D0", VA = "0x188EDB1D0")]
		public EncoderHints()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EDB0C0", Offset = "0x8ED98C0", VA = "0x188EDB0C0")]
		public void OBKIOIYDNVN()
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
		private const string ZENSGTYGWNL = "https://www.renderheads.com/content/docs/AVProMovieCapture/articles/download.html#editions";

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
		private const string HGAZUJFQUUC = "Captures";

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
		protected Texture2D CXMCMRXSJFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected int UENCIZOMEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected int OPVSADWXMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		protected int HNTFDBFWABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		protected int DPBDEKNRJJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		protected int ABHPRKVUXHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		protected bool PMPKTOEJQDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A5")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		protected bool YVWLHEGDFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		protected string YMWUXASHZEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		protected string WBUMWNZEGAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		protected FileInfo WQLVCRYEFUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		protected IBXZITGUJWL.PixelFormat JBMCKPSTZYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Codec QLLCTPQWYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Codec MFJWMGLJTCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CPAXXXTQFMF KHNJOHKTOVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int ZVGYJREGNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private float HWAWRPYYDXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		protected bool PQOXFZYKVIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		protected bool BVPOGYPCPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private bool AOLHLJBNPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool UIUXQCXNVBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private float NRJYCTCYHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private float YVFJBVUCYTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private float UJOHJLZACOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		protected YieldInstruction VKMEOPBBIVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private long SGFZAOSVQHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		protected Transparency BVPJYQTNQDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		protected RenderTexture TTPHXUOPHSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		protected Material KWKTVFAHILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private float HSIFSUEFWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool DXGTARZVYXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Action<ZCUFWEPNYOF> RXOZVLIHRAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Action<ZCUFWEPNYOF> BQWEBJOZPDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private List<ZCUFWEPNYOF> XCBEWVPDZHH;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static HashSet<string> BWUMJKIOAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private UnityEvent ZQOKOJFKVWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private UnityEvent YHUBASDFEXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private AMUCGWGTSZE FUKCSIDPCHR;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private static bool FOYWQIVGBSZ;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static bool GOQNXQBLLYL;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public OutputTarget ATVDVJHCSIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x152AF10", Offset = "0x1529710", VA = "0x18152AF10")]
			get
			{
				return default(OutputTarget);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x152AA90", Offset = "0x1529290", VA = "0x18152AA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public OutputPath AWAHVHMKAQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE37B90", Offset = "0xE36390", VA = "0x180E37B90")]
			get
			{
				return default(OutputPath);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1962B10", Offset = "0x1961310", VA = "0x181962B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string ZMWDWASQXQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC78E40", Offset = "0xC77640", VA = "0x180C78E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC78730", Offset = "0xC76F30", VA = "0x180C78730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string EPNNVZEWYQK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xCE65B0", Offset = "0xCE4DB0", VA = "0x180CE65B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1485950", Offset = "0x1484150", VA = "0x181485950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool NBYHTCTJHIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xCDC710", Offset = "0xCDAF10", VA = "0x180CDC710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x21CC770", Offset = "0x21CAF70", VA = "0x1821CC770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool DAHCGZEAAIR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xE15A10", Offset = "0xE14210", VA = "0x180E15A10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DE9F10", Offset = "0x1DE8710", VA = "0x181DE9F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string HPWMIHEGTBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCE6590", Offset = "0xCE4D90", VA = "0x180CE6590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x14611E0", Offset = "0x145F9E0", VA = "0x1814611E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string MJFNHPTCNYD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xC47000", Offset = "0xC45800", VA = "0x180C47000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xC45D90", Offset = "0xC44590", VA = "0x180C45D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool PQKCQPSTUBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDB8C0", VA = "0x180BDD0C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xBDADF0", Offset = "0xBD95F0", VA = "0x180BDADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int DHDWUUOHNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F41580", Offset = "0x1F3FD80", VA = "0x181F41580")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x209B330", Offset = "0x2099B30", VA = "0x18209B330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int LPDHDJOAPON
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x102EFF0", Offset = "0x102D7F0", VA = "0x18102EFF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAC30", Offset = "0x8ED9430", VA = "0x188EDAC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool REIWYPHSDBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x18F6280", Offset = "0x18F4A80", VA = "0x1818F6280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAD00", Offset = "0x8ED9500", VA = "0x188EDAD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int AURDEWWNKWT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1EDDAA0", Offset = "0x1EDC2A0", VA = "0x181EDDAA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8EDACA0", Offset = "0x8ED94A0", VA = "0x188EDACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Camera[] BWQOVYDLLGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xCE6690", Offset = "0xCE4E90", VA = "0x180CE6690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x12D78F0", Offset = "0x12D60F0", VA = "0x1812D78F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MotionBlur ROHBCYHDJQA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xDD2450", Offset = "0xDD0C50", VA = "0x180DD2450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xC47010", Offset = "0xC45810", VA = "0x180C47010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Transparency BJYTXTQFRAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2633CF0", Offset = "0x26324F0", VA = "0x182633CF0")]
			get
			{
				return default(Transparency);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static HashSet<string> SWSJBEZLXWV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAAC0", Offset = "0x8ED92C0", VA = "0x188EDAAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string PNQKKHUZHDU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xCE66A0", Offset = "0xCE4EA0", VA = "0x180CE66A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public UnityEvent DDYPBDLLLYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xCE6520", Offset = "0xCE4D20", VA = "0x180CE6520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public UnityEvent VVSETCSUKNC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xCE6560", Offset = "0xCE4D60", VA = "0x180CE6560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Action<ZCUFWEPNYOF> MLHKPIJKJSU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xCE6580", Offset = "0xCE4D80", VA = "0x180CE6580")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x13B7E10", Offset = "0x13B6610", VA = "0x1813B7E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Action<ZCUFWEPNYOF> XWKCGZSQGDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCE6540", Offset = "0xCE4D40", VA = "0x180CE6540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x13B3E50", Offset = "0x13B2650", VA = "0x1813B3E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Resolution RBFJROLSSXY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F41590", Offset = "0x1F3FD90", VA = "0x181F41590")]
			get
			{
				return default(Resolution);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8EDABE0", Offset = "0x8ED93E0", VA = "0x188EDABE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 NTDOPWOIAQF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAB10", Offset = "0x8ED9310", VA = "0x188EDAB10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2317730", Offset = "0x2315F30", VA = "0x182317730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int NTAFBGQQDLW
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xDD6970", Offset = "0xDD5170", VA = "0x180DD6970")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xDD26F0", Offset = "0xDD0EF0", VA = "0x180DD26F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool LIOCTJEFKZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x17455B0", Offset = "0x1743DB0", VA = "0x1817455B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x17457E0", Offset = "0x1743FE0", VA = "0x1817457E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool LSOHRCNMCSB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x24666D0", Offset = "0x2464ED0", VA = "0x1824666D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2466850", Offset = "0x2465050", VA = "0x182466850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public AudioCaptureSource PBLAFBPIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xB690F0", Offset = "0xB678F0", VA = "0x180B690F0")]
			get
			{
				return default(AudioCaptureSource);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x16FC440", Offset = "0x16FAC40", VA = "0x1816FC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int NOTOJWHBGTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1C1BE80", Offset = "0x1C1A680", VA = "0x181C1BE80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x241BF50", Offset = "0x241A750", VA = "0x18241BF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int BTCSLEEWKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x102F180", Offset = "0x102D980", VA = "0x18102F180")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x152AA80", Offset = "0x1529280", VA = "0x18152AA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UnityAudioCapture TBJPXUWEWYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xB30730", Offset = "0xB2EF30", VA = "0x180B30730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xE6D500", Offset = "0xE6BD00", VA = "0x180E6D500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int DGRIJOWTTGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xE6CB10", Offset = "0xE6B310", VA = "0x180E6CB10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8EDABF0", Offset = "0x8ED93F0", VA = "0x188EDABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float FUQNHYEGULU
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x13E00D0", Offset = "0x13DE8D0", VA = "0x1813E00D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAC00", Offset = "0x8ED9400", VA = "0x188EDAC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public StartTriggerMode XCPIJDITEXR
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xD59440", Offset = "0xD57C40", VA = "0x180D59440")]
			get
			{
				return default(StartTriggerMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xD596D0", Offset = "0xD57ED0", VA = "0x180D596D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public StartDelayMode UNUVOQJNVTS
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x13E2910", Offset = "0x13E1110", VA = "0x1813E2910")]
			get
			{
				return default(StartDelayMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x19D07D0", Offset = "0x19CEFD0", VA = "0x1819D07D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float LLHIQRIJHGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAFD420", Offset = "0xAFBC20", VA = "0x180AFD420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8EDACD0", Offset = "0x8ED94D0", VA = "0x188EDACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public StopMode GYPUQJCAUDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x10A2CC0", Offset = "0x10A14C0", VA = "0x1810A2CC0")]
			get
			{
				return default(StopMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1EE8C40", Offset = "0x1EE7440", VA = "0x181EE8C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int MVZQWDTYQPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xC7E4C0", Offset = "0xC7CCC0", VA = "0x180C7E4C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x8EDACE0", Offset = "0x8ED94E0", VA = "0x188EDACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public float BQKDZBSZUEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x102F170", Offset = "0x102D970", VA = "0x18102F170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8EDACF0", Offset = "0x8ED94F0", VA = "0x188EDACF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool OUTWDRYLYPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4150", Offset = "0xAB2950", VA = "0x180AB4150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public AMUCGWGTSZE AMUCGWGTSZE
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xCE6530", Offset = "0xCE4D30", VA = "0x180CE6530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string[] LHBDPYIFVGV
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4130", Offset = "0xAB2930", VA = "0x180AB4130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAD50", Offset = "0x8ED9550", VA = "0x188EDAD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string[] NTKGTXHLRGN
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAD20", Offset = "0x8ED9520", VA = "0x188EDAD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string[] ABRSQMYNTFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xABA0E0", Offset = "0xAB88E0", VA = "0x180ABA0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8EDABB0", Offset = "0x8ED93B0", VA = "0x188EDABB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string[] WVNIFXPZAGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xABA6F0", Offset = "0xAB8EF0", VA = "0x180ABA6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAB80", Offset = "0x8ED9380", VA = "0x188EDAB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int HHZXCKHWMZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2B91270", Offset = "0x2B8FA70", VA = "0x182B91270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7657350", Offset = "0x7655B50", VA = "0x187657350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FrameUpdateMode OGNHPHZNBAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xABA710", Offset = "0xAB8F10", VA = "0x180ABA710")]
			get
			{
				return default(FrameUpdateMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xABA000", Offset = "0xAB8800", VA = "0x180ABA000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DownScale HYJIUCZUYAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB08DF0", Offset = "0xB075F0", VA = "0x180B08DF0")]
			get
			{
				return default(DownScale);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xCC28E0", Offset = "0xCC10E0", VA = "0x180CC28E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 AXFTKPBILDE
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2807D60", Offset = "0x2806560", VA = "0x182807D60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x75BEE00", Offset = "0x75BD600", VA = "0x1875BEE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool ENATPKHNAIB
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB719B0", Offset = "0xB701B0", VA = "0x180B719B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB71B10", Offset = "0xB70310", VA = "0x180B71B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool TIHRWFNJOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x80C7670", Offset = "0x80C5E70", VA = "0x1880C7670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAD10", Offset = "0x8ED9510", VA = "0x188EDAD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool MPOYNYKPMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2813BC0", Offset = "0x28123C0", VA = "0x182813BC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2814100", Offset = "0x2812900", VA = "0x182814100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool SUHJRHXJBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD50C30", Offset = "0xD4F430", VA = "0x180D50C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD50C40", Offset = "0xD4F440", VA = "0x180D50C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool UGKSGDVANMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x8D90480", Offset = "0x8D8EC80", VA = "0x188D90480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8D905F0", Offset = "0x8D8EDF0", VA = "0x188D905F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TimelineController UEUVRTVPTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xB30720", Offset = "0xB2EF20", VA = "0x180B30720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xC491A0", Offset = "0xC479A0", VA = "0x180C491A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public VideoPlayerController YQCJZKXUECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xCE6460", Offset = "0xCE4C60", VA = "0x180CE6460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1484CC0", Offset = "0x14834C0", VA = "0x181484CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Codec OIFKADNSREF
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xCE66B0", Offset = "0xCE4EB0", VA = "0x180CE66B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Codec SPYAHSHBSXA
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xCE6510", Offset = "0xCE4D10", VA = "0x180CE6510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public CPAXXXTQFMF SPKNGDVYFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xCE6500", Offset = "0xCE4D00", VA = "0x180CE6500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int QTRJCMCTMWA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1299230", Offset = "0x1297A30", VA = "0x181299230")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1298B50", Offset = "0x1297350", VA = "0x181298B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int YUJGVOPUNZH
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xC6B910", Offset = "0xC6A110", VA = "0x180C6B910")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x20128A0", Offset = "0x20110A0", VA = "0x1820128A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public ImageSequenceFormat BYXTEVUWFLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x15D5770", Offset = "0x15D3F70", VA = "0x1815D5770")]
			get
			{
				return default(ImageSequenceFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x209B310", Offset = "0x2099B10", VA = "0x18209B310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public static string SUASBNQCSEU
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAB30", Offset = "0x8ED9330", VA = "0x188EDAB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8EDAC60", Offset = "0x8ED9460", VA = "0x188EDAC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0")]
		protected static IBXZITGUJWL.Platform QWFDDWZTRJL()
		{
			return default(IBXZITGUJWL.Platform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3F40", Offset = "0x8ED2740", VA = "0x188ED3F40")]
		public EncoderHints GetEncoderHints(IBXZITGUJWL.Platform platform = IBXZITGUJWL.Platform.Current)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7FD0", Offset = "0x8ED67D0", VA = "0x188ED7FD0")]
		public void SetEncoderHints(EncoderHints hints, IBXZITGUJWL.Platform platform = IBXZITGUJWL.Platform.Current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public static void UpdateMediaGallery(string videoFilePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1950", Offset = "0x8ED0150", VA = "0x188ED1950", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9DC0", Offset = "0x8ED85C0", VA = "0x188ED9DC0")]
		static CaptureBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8ED8580", Offset = "0x8ED6D80", VA = "0x188ED8580", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3330", Offset = "0x8ED1B30", VA = "0x188ED3330")]
		private static bool FXDCMOMYQSP(Codec a, PVQPSRNVZHZ b, int c, string[] d, MediaApi e, bool f, bool g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7CB0", Offset = "0x8ED64B0", VA = "0x188ED7CB0")]
		public Codec SelectVideoCodec(bool isStartingCapture = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7610", Offset = "0x8ED5E10", VA = "0x188ED7610")]
		public Codec SelectAudioCodec()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7980", Offset = "0x8ED6180", VA = "0x188ED7980")]
		public CPAXXXTQFMF SelectAudioInputDevice()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED40B0", Offset = "0x8ED28B0", VA = "0x188ED40B0")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7BA0", Offset = "0x8ED63A0", VA = "0x188ED7BA0")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8ED52B0", Offset = "0x8ED3AB0", VA = "0x188ED52B0", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8ED54E0", Offset = "0x8ED3CE0", VA = "0x188ED54E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2B10", Offset = "0x8ED1310", VA = "0x188ED2B10")]
		private void EHOZTFMYWLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8ED5260", Offset = "0x8ED3A60", VA = "0x188ED5260")]
		private void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1ED0", Offset = "0x8ED06D0", VA = "0x188ED1ED0")]
		protected void BVTEIBMVQIA(Texture2D a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8ED47E0", Offset = "0x8ED2FE0", VA = "0x188ED47E0")]
		protected bool JIMFNUZPHMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4860", Offset = "0x8ED3060", VA = "0x188ED4860")]
		protected bool KEQKSAYWPCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3030", Offset = "0x8ED1830", VA = "0x188ED3030", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4740", Offset = "0x8ED2F40", VA = "0x188ED4740")]
		public bool IsPrepared()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE40B40", Offset = "0xE3F340", VA = "0x180E40B40")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE40700", Offset = "0xE3EF00", VA = "0x180E40700")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4180", Offset = "0x8ED2980", VA = "0x188ED4180")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2214700", Offset = "0x2212F00", VA = "0x182214700")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4E50", Offset = "0x8ED3650", VA = "0x188ED4E50", Slot = "8")]
		protected virtual string NSLDTIYWKNO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED17B0", Offset = "0x8ECFFB0", VA = "0x188ED17B0")]
		private static string AQNPQDXIFPT(OutputPath a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4460", Offset = "0x8ED2C60", VA = "0x188ED4460")]
		private static string HXGHBRKEAMZ(OutputPath a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2010", Offset = "0x8ED0810", VA = "0x188ED2010")]
		protected static bool CKYTDWMQDWG(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2370", Offset = "0x8ED0B70", VA = "0x188ED2370")]
		protected void EEIEHDLPTHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8ED35D0", Offset = "0x8ED1DD0", VA = "0x188ED35D0")]
		public UnityAudioCapture FindOrCreateUnityAudioCapture(bool logWarnings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9760", Offset = "0x8ED7F60", VA = "0x188ED9760")]
		private bool ZBKDZHVNXJQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8ED57B0", Offset = "0x8ED3FB0", VA = "0x188ED57B0", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8ED73B0", Offset = "0x8ED5BB0", VA = "0x188ED73B0")]
		public void QueueStartCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE40520", Offset = "0xE3ED20", VA = "0x180E40520")]
		public bool IsStartCaptureQueued()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4750", Offset = "0x8ED2F50", VA = "0x188ED4750")]
		protected void JDSUIVSXGZV(StereoPacking a, SphericalVideoLayout b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8ED8070", Offset = "0x8ED6870", VA = "0x188ED8070")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8ED5570", Offset = "0x8ED3D70", VA = "0x188ED5570")]
		public void PauseCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8ED74F0", Offset = "0x8ED5CF0", VA = "0x188ED74F0")]
		public void ResumeCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2050", Offset = "0x8ED0850", VA = "0x188ED2050")]
		public void CancelCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2260", Offset = "0x8ED0A60", VA = "0x188ED2260")]
		public static void DeleteCapture(OutputTarget outputTarget, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3DF0", Offset = "0x8ED25F0", VA = "0x188ED3DF0")]
		protected void GKJSLJLRSOB(IBXZITGUJWL.PluginEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8ED8640", Offset = "0x8ED6E40", VA = "0x188ED8640", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false, bool ignorePendingFileWrites = false, bool deleteCapture = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8ED46B0", Offset = "0x8ED2EB0", VA = "0x188ED46B0")]
		private static XIIUPHBAXCT.Options IQCXIGPCIGH(VideoEncoderHints a, string b)
		{
			return default(XIIUPHBAXCT.Options);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8ED8E40", Offset = "0x8ED7640", VA = "0x188ED8E40")]
		private static bool UGWDSMFDMSN(string a, VideoEncoderHints b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8ED48D0", Offset = "0x8ED30D0", VA = "0x188ED48D0")]
		protected void KLRXTVCYZQZ(string a, VideoEncoderHints b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4E10", Offset = "0x8ED3610", VA = "0x188ED4E10")]
		private void MTYKZWKICDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9640", Offset = "0x8ED7E40", VA = "0x188ED9640")]
		private bool YRYPITEIBHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1700", Offset = "0x8ECFF00", VA = "0x188ED1700")]
		protected bool AGQOHSFALMS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8ED94A0", Offset = "0x8ED7CA0", VA = "0x188ED94A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4AB0", Offset = "0x8ED32B0", VA = "0x188ED4AB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7430", Offset = "0x8ED5C30", VA = "0x188ED7430")]
		private void RYWJJXKTWXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3290", Offset = "0x8ED1A90", VA = "0x188ED3290")]
		private void FVOLELPXAYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8ED75E0", Offset = "0x8ED5DE0", VA = "0x188ED75E0")]
		protected bool SWUOUWBUILR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9510", Offset = "0x8ED7D10", VA = "0x188ED9510")]
		protected bool VGHSTHHTMRC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3FF0", Offset = "0x8ED27F0", VA = "0x188ED3FF0")]
		public float GetProgress()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2C70", Offset = "0x8ED1470", VA = "0x188ED2C70")]
		protected float EJMVTHQWESS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2080", Offset = "0x8ED0880", VA = "0x188ED2080")]
		protected bool DQGKCRZHGUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4670", Offset = "0x8ED2E70", VA = "0x188ED4670")]
		protected void IKZGWSXUQAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8ED95F0", Offset = "0x8ED7DF0", VA = "0x188ED95F0")]
		protected void VWBZSLPGZJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCE6640", Offset = "0xCE4E40", VA = "0x180CE6640", Slot = "13")]
		public virtual Texture GetSideBySideTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1F50", Offset = "0x8ED0750", VA = "0x188ED1F50")]
		protected void CAQVHKIHTSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2F80", Offset = "0x8ED1780", VA = "0x188ED2F80")]
		public void EncodeAudio(NativeArray<float> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2E60", Offset = "0x8ED1660", VA = "0x188ED2E60")]
		public void EncodeAudio(float[] audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8ED56B0", Offset = "0x8ED3EB0", VA = "0x188ED56B0", Slot = "14")]
		public virtual void PreUpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8ED90A0", Offset = "0x8ED78A0", VA = "0x188ED90A0", Slot = "15")]
		public virtual void UpdateFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3A30", Offset = "0x8ED2230", VA = "0x188ED3A30")]
		protected bool GJXASVXHOKH(int a, int b, bool c = false, int d = 1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2CA0", Offset = "0x8ED14A0", VA = "0x188ED2CA0")]
		protected RenderTexture EOWKJAEGJTM(Texture a, bool b = false, int c = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8ED5230", Offset = "0x8ED3A30", VA = "0x188ED5230")]
		protected void OZZPYEFIQZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9040", Offset = "0x8ED7840", VA = "0x188ED9040")]
		public void UpdateFPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4310", Offset = "0x8ED2B10", VA = "0x188ED4310")]
		protected int HALIWKBMWEY(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3E50", Offset = "0x8ED2650", VA = "0x188ED3E50")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8ED4190", Offset = "0x8ED2990", VA = "0x188ED4190")]
		public static void GetResolution(Resolution res, int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8ED9500", Offset = "0x8ED7D00", VA = "0x188ED9500")]
		protected static int VAJVCAMDUAZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA600", Offset = "0x8ED8E00", VA = "0x188EDA600")]
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
		private CodecType JQUXQFVTBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private int TJQZQJAQYZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private string DNVIRFVNZZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool VVKGFSIIEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private MediaApi KGTPJTSHXZW;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int TTXNZPFFZFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public MediaApi MHUQOISCQPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAD58C0", Offset = "0xAD40C0", VA = "0x180AD58C0", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool WVPEHCSEROL
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB290", VA = "0x180AACA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8EDAD80", Offset = "0x8ED9580", VA = "0x188EDAD80")]
		public void FEQMLXCNDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8EDAEE0", Offset = "0x8ED96E0", VA = "0x188EDAEE0")]
		internal Codec(CodecType codecType, int index, string name, MediaApi api, bool hasConfigWindow = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class PVQPSRNVZHZ : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private Codec[] JUCCGDMPHAT;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Codec[] TKLOXFQNXGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public int UHDSQPYTSJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x255F0D0", Offset = "0x255D8D0", VA = "0x18255F0D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0630", Offset = "0x8EDEE30", VA = "0x188EE0630")]
		internal PVQPSRNVZHZ(Codec[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0590", Offset = "0x8EDED90", VA = "0x188EE0590")]
		public Codec YRHSQXPEVBM(string a, MediaApi b = MediaApi.Unknown)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0530", Offset = "0x8EDED30", VA = "0x188EE0530")]
		public Codec GCKPJVEXIHT(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x28288B0", Offset = "0x28270B0", VA = "0x1828288B0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class PIHASIZUZNM
	{
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private static bool UHONQSGOJUC;

		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private static PVQPSRNVZHZ TBEQQLWOQPO;

		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private static PVQPSRNVZHZ KMVKIRIMMBX;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public static PVQPSRNVZHZ BKVVUPJLTZT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x8EE02B0", Offset = "0x8EDEAB0", VA = "0x188EE02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public static PVQPSRNVZHZ UELZJZVLCGY
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x8EDFA20", Offset = "0x8EDE220", VA = "0x188EDFA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0300", Offset = "0x8EDEB00", VA = "0x188EE0300")]
		private static void ULNDHASSUOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EDFA70", Offset = "0x8EDE270", VA = "0x188EDFA70")]
		private static void PYUNGXAQPQI()
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
	public class CPAXXXTQFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DeviceType QRBTLFYJRSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private int TJQZQJAQYZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private string DNVIRFVNZZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MediaApi KGTPJTSHXZW;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public int TTXNZPFFZFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public MediaApi MHUQOISCQPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0", Slot = "6")]
			get
			{
				return default(MediaApi);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8ED16A0", Offset = "0x8ECFEA0", VA = "0x188ED16A0")]
		internal CPAXXXTQFMF(DeviceType a, int b, string c, MediaApi d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class RGNFSUQALQB : IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private CPAXXXTQFMF[] QTUZMTTLHKX;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public CPAXXXTQFMF[] SMLPOODDSAG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public int UHDSQPYTSJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x255F0D0", Offset = "0x255D8D0", VA = "0x18255F0D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE07F0", Offset = "0x8EDEFF0", VA = "0x188EE07F0")]
		internal RGNFSUQALQB(CPAXXXTQFMF[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE0790", Offset = "0x8EDEF90", VA = "0x188EE0790")]
		public CPAXXXTQFMF GCKPJVEXIHT(MediaApi a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x28288B0", Offset = "0x28270B0", VA = "0x1828288B0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class IITOPHCCUUI
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private static bool UHONQSGOJUC;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static RGNFSUQALQB UDSBCJHIRTL;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static RGNFSUQALQB YXEZDDTVAHS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8EDE8A0", Offset = "0x8EDD0A0", VA = "0x188EDE8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE980", Offset = "0x8EDD180", VA = "0x188EDE980")]
		private static void ULNDHASSUOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8EDE480", Offset = "0x8EDCC80", VA = "0x188EDE480")]
		private static void MFWOTAVJKJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ZCUFWEPNYOF : IDisposable
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
		private string IYNNJHZSYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private int UENCIZOMEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool MXTSAQSQMTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OutputTarget HDOIJPMTCDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private XIIUPHBAXCT.Options AILNYSCONEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ManualResetEvent WUVVLFSMNOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CompletionStatus SZYSPZZWFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private string WBUMWNZEGAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool IJHTRQVPDSP;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		internal Action<ZCUFWEPNYOF> XWKCGZSQGDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB4130", Offset = "0xAB2930", VA = "0x180AB4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB39D0", Offset = "0xAB21D0", VA = "0x180AB39D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9E00", Offset = "0x8EE8600", VA = "0x188EE9E00")]
		internal ZCUFWEPNYOF(OutputTarget a, string b, int c, bool d, string e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9DE0", Offset = "0x8EE85E0", VA = "0x188EE9DE0")]
		internal void RRZYUZYFOHI(XIIUPHBAXCT.Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE99B0", Offset = "0x8EE81B0", VA = "0x188EE99B0")]
		private bool OBPBLWWRGAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9C20", Offset = "0x8EE8420", VA = "0x188EE9C20")]
		public bool POUUFYYEXZC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE96C0", Offset = "0x8EE7EC0", VA = "0x188EE96C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class XIIUPHBAXCT
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
			[Cpp2IlInjected.Address(RVA = "0x8EDFA00", Offset = "0x8EDE200", VA = "0x188EDFA00")]
			public bool WAIJVTAJMHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8EDF9C0", Offset = "0x8EDE1C0", VA = "0x188EDF9C0")]
			public bool AAFFWUWWGSQ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8EDF9E0", Offset = "0x8EDE1E0", VA = "0x188EDF9E0")]
			public void JKMCOIGNHKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class JAXBRMBXKWM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public uint MPEPFPTIHKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public long IKTYACXCDBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public long CWIKXONOKWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public long TNQHGTPOONJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public long YSLCFYOCYYJ;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JAXBRMBXKWM()
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
		private sealed class GRBOBWIYTRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public string FTHJQDGUHNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public bool JBOKDHRLZOU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public Options SIJLCOEOURV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public ManualResetEvent GONRYYOAIDG;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public GRBOBWIYTRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x8EDB510", Offset = "0x8ED9D10", VA = "0x188EDB510")]
			internal void UMCUPBKVRLQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private static readonly uint ORMIHYIZUFU;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private static readonly uint IQRYTXVZWZJ;

		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private static readonly uint BQTALLUEIOC;

		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private static readonly uint CDMWPZQRYEZ;

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly uint KTNDSOMCCGA;

		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private static readonly uint AXHQGSJMDGV;

		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private static readonly uint DPNIGPUZAOJ;

		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private static readonly uint FHGCDPBMGEO;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private static readonly uint LNAYYMOALYG;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private static readonly uint WZBRTTJKWED;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private static readonly uint QZHAWQZWHSH;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private static readonly uint SSFRWDGZVLS;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private static readonly uint FWMTLTRCFAV;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private static readonly uint ORKHNUVASVD;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private static readonly uint HQYEZNOZFHF;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private static readonly uint ZJEMTFQMDIY;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private static readonly uint VQCGAACPSEJ;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private static readonly uint SKZMUHAAGVQ;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private static readonly uint EPHBUJBQFUY;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private static readonly uint YVUNUWWRORH;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private static readonly uint RVLFHGJXZOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BinaryReader INEUHCCGICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private Stream KOMSTYVLDBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private Options RWRKQSWHXMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private bool ZZWKVAVQFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private List<JAXBRMBXKWM> FKMSRVIQYCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private List<JAXBRMBXKWM> TFZJAOXNTLB;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE80A0", Offset = "0x8EE68A0", VA = "0x188EE80A0")]
		public static ManualResetEvent RNLMQGPPDKS(string a, bool b, Options c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4EB0", Offset = "0x8EE36B0", VA = "0x188EE4EB0")]
		public static bool CQUSRUEOUJM(string a, bool b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4BD0", Offset = "0x8EE33D0", VA = "0x188EE4BD0")]
		public static bool CQUSRUEOUJM(string a, string b, Options c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE95F0", Offset = "0x8EE7DF0", VA = "0x188EE95F0")]
		public XIIUPHBAXCT(Options a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5D20", Offset = "0x8EE4520", VA = "0x188EE5D20")]
		public bool EAZDPCFCPYU(Stream a, Stream b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE57F0", Offset = "0x8EE3FF0", VA = "0x188EE57F0")]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7C10", Offset = "0x8EE6410", VA = "0x188EE7C10")]
		private static JAXBRMBXKWM OGUNZSZMDVB(uint a, List<JAXBRMBXKWM> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE78A0", Offset = "0x8EE60A0", VA = "0x188EE78A0")]
		private List<JAXBRMBXKWM> KXDRPCNXDWV(JAXBRMBXKWM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE76A0", Offset = "0x8EE5EA0", VA = "0x188EE76A0")]
		private List<JAXBRMBXKWM> KXDRPCNXDWV(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE42B0", Offset = "0x8EE2AB0", VA = "0x188EE42B0")]
		private JAXBRMBXKWM BENSEELPBIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7D50", Offset = "0x8EE6550", VA = "0x188EE7D50")]
		private bool OKQEQLPMTZZ(JAXBRMBXKWM a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6FC0", Offset = "0x8EE57C0", VA = "0x188EE6FC0")]
		private void JWOEAIWRLDJ(JAXBRMBXKWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8940", Offset = "0x8EE7140", VA = "0x188EE8940")]
		private void YVKCNHHBTHE(JAXBRMBXKWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8730", Offset = "0x8EE6F30", VA = "0x188EE8730")]
		private void XZXVJRYZQSO(JAXBRMBXKWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7AF0", Offset = "0x8EE62F0", VA = "0x188EE7AF0")]
		private void NULFYMVCNYN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6990", Offset = "0x8EE5190", VA = "0x188EE6990")]
		private void EXHJHHRFUFT(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5210", Offset = "0x8EE3A10", VA = "0x188EE5210")]
		private uint CUPHXVXVUNB(JAXBRMBXKWM a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7EB0", Offset = "0x8EE66B0", VA = "0x188EE7EB0")]
		private bool RFZGYIRRZYV(JAXBRMBXKWM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE83B0", Offset = "0x8EE6BB0", VA = "0x188EE83B0")]
		private void XEPJDWEZHRX(JAXBRMBXKWM a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6DB0", Offset = "0x8EE55B0", VA = "0x188EE6DB0")]
		private void IPMTXAZJXHV(JAXBRMBXKWM a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE40A0", Offset = "0x8EE28A0", VA = "0x188EE40A0")]
		private void ASYNQUKUUKY(JAXBRMBXKWM a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5B70", Offset = "0x8EE4370", VA = "0x188EE5B70")]
		private uint DRDEDVJOIEP(JAXBRMBXKWM a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4680", Offset = "0x8EE2E80", VA = "0x188EE4680")]
		private uint CQKXHNDAKPG(JAXBRMBXKWM a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8390", Offset = "0x8EE6B90", VA = "0x188EE8390")]
		private static StereoMode_st3d UUKQVDJOBIC(StereoPacking a)
		{
			return default(StereoMode_st3d);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8EE85C0", Offset = "0x8EE6DC0", VA = "0x188EE85C0")]
		private uint XXRBAUYKPUQ(StereoMode_st3d a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8EE74A0", Offset = "0x8EE5CA0", VA = "0x188EE74A0")]
		private uint KSRXYZVUCOC(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7030", Offset = "0x8EE5830", VA = "0x188EE7030")]
		private uint JXOMKKXVJZG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE58D0", Offset = "0x8EE40D0", VA = "0x188EE58D0")]
		private uint DHZHRGJBPJP(string a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE4490", Offset = "0x8EE2C90", VA = "0x188EE4490")]
		private uint CKRNOLOBRYL(SphericalVideoLayout a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6A50", Offset = "0x8EE5250", VA = "0x188EE6A50")]
		private uint INBSXJKOIHI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6550", Offset = "0x8EE4D50", VA = "0x188EE6550")]
		private uint ENSTHRCHKIY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8830", Offset = "0x8EE7030", VA = "0x188EE8830")]
		private void YTTEJGABFTK(JAXBRMBXKWM a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7A80", Offset = "0x8EE6280", VA = "0x188EE7A80")]
		private ushort MROFFRAYTFW()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE89B0", Offset = "0x8EE71B0", VA = "0x188EE89B0")]
		private uint ZQDTVOJTZRM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6920", Offset = "0x8EE5120", VA = "0x188EE6920")]
		private ulong EVBFKHMANKF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7970", Offset = "0x8EE6170", VA = "0x188EE7970")]
		private void MIDUMTKIOKK(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE82F0", Offset = "0x8EE6AF0", VA = "0x188EE82F0")]
		private void SIOXBLZNCNB(uint a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE79F0", Offset = "0x8EE61F0", VA = "0x188EE79F0")]
		private void MKFZPTKZSXC(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8260", Offset = "0x8EE6A60", VA = "0x188EE8260")]
		private static uint SBAYBIEXJHT(string a)
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
		public static string[] URGVMSQKHKB;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static string[] JQGPRQCJDQN;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static string[] CKEMGEIRMJH;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static string[] FYQOITVHCKD;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2950", Offset = "0x8EE1150", VA = "0x188EE2950")]
		public static string[] OJZFVAAGSLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE29C0", Offset = "0x8EE11C0", VA = "0x188EE29C0")]
		public static RenderTextureFormat QQDIWYAZMYR(bool a, bool b, bool c)
		{
			return default(RenderTextureFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8EE28B0", Offset = "0x8EE10B0", VA = "0x188EE28B0")]
		public static bool OIPXQGZOCFR(Camera a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2170", Offset = "0x8EE0970", VA = "0x188EE2170")]
		public static Camera[] GFHFAPUVHYU(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2E10", Offset = "0x8EE1610", VA = "0x188EE2E10")]
		public static bool YEHRZSNVTZI(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2D20", Offset = "0x8EE1520", VA = "0x188EE2D20")]
		public static bool TYDXZTHBEHS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE26C0", Offset = "0x8EE0EC0", VA = "0x188EE26C0")]
		public static bool ICTFXJXCSUK(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8EE2610", Offset = "0x8EE0E10", VA = "0x188EE2610")]
		public static string GUPCSDAQPAF(ImageSequenceFormat a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class ZNDRHXGIBUI : IDisposable
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
		private static byte[] OJXHDTXTMCC;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static byte[] QPMVKFWZHZK;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private static byte[] YWOASDSYGKL;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static byte[] JTXIDERYIUA;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static byte[] DCWWFNCBFNQ;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static byte[] YCNZFWEQVJW;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static byte[] MWNLWBYCRNE;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private const int IROTJUGKONX = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private FileStream UFONQPJSWPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private byte[] XMMLSOVGRHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int TJRUDFTWTER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private int XWVFXYYWDWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int SVZBCSESMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private int DHOYWZNZRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private SampleFormat BBWMOPLAOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private int IWTJQLLMVWY;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8EEAA70", Offset = "0x8EE9270", VA = "0x188EEAA70")]
		public ZNDRHXGIBUI(string a, int b, int c, SampleFormat d = SampleFormat.Float32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9E80", Offset = "0x8EE8680", VA = "0x188EE9E80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8EE9F00", Offset = "0x8EE8700", VA = "0x188EE9F00")]
		public void EMFVRPQQLWV(float[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA1A0", Offset = "0x8EE89A0", VA = "0x188EEA1A0")]
		public void VPTQYSZYMOD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA090", Offset = "0x8EE8890", VA = "0x188EEA090")]
		private static byte[] ENCNXZMEWDU(int a, int b = 2)
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
		[Cpp2IlInjected.Address(RVA = "0x8EEAB60", Offset = "0x8EE9360", VA = "0x188EEAB60")]
		public void RunCoroutine(IEnumerator routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
