using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core.Screens.MobileAR;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RequireComponent(typeof(ARPlaneMeshVisualizer), typeof(MeshRenderer), typeof(ARPlane))]
public class ARFeatheredPlaneMeshVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	[Tooltip("The width of the texture feathering (in world units).")]
	private float m_FeatheringWidth;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static List<Vector3> LDLEGAMGOID;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<Vector3> LPJMKLGJLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ARPlaneMeshVisualizer MLICINBNEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ARPlane OMIKBOPMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Material CAICLNDFOKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float HPCLIOGKBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E4180", Offset = "0x6E2F80", VA = "0x1806E4180")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C10", Offset = "0x6E2A10", VA = "0x1806E3C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x20687B0", Offset = "0x20675B0", VA = "0x1820687B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2068D80", Offset = "0x2067B80", VA = "0x182068D80")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2068CE0", Offset = "0x2067AE0", VA = "0x182068CE0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2068780", Offset = "0x2067580", VA = "0x182068780")]
	private void ANFKIABJFJP(ARPlaneBoundaryChangedEventArgs LALOFMIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2068870", Offset = "0x2067670", VA = "0x182068870")]
	private void ENKCBEJBBDP(Mesh KMIFLOHLDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2068EE0", Offset = "0x2067CE0", VA = "0x182068EE0")]
	public ARFeatheredPlaneMeshVisualizer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(ARFace))]
public class ARKitBlendShapeVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private float m_CoefficientScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ARFace PMMLGBPOJKA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float JNKFKHNBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4180", Offset = "0x6E2F80", VA = "0x1806E4180")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C10", Offset = "0x6E2A10", VA = "0x1806E3C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public SkinnedMeshRenderer FLEMOFJENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2068EF0", Offset = "0x2067CF0", VA = "0x182068EF0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20691E0", Offset = "0x2067FE0", VA = "0x1820691E0")]
	private void KBENNLMIBIN(bool OHEOJBCEEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20690D0", Offset = "0x2067ED0", VA = "0x1820690D0")]
	private void FIPGGFFNHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2069370", Offset = "0x2068170", VA = "0x182069370")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2069280", Offset = "0x2068080", VA = "0x182069280")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2069270", Offset = "0x2068070", VA = "0x182069270")]
	private void MNHEAKLHOAJ(ARSessionStateChangedEventArgs LALOFMIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2068F40", Offset = "0x2067D40", VA = "0x182068F40")]
	private void BDACNPOIOJA(ARFaceUpdatedEventArgs LALOFMIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2069010", Offset = "0x2067E10", VA = "0x182069010")]
	private void DELPJONIMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2069470", Offset = "0x2068270", VA = "0x182069470")]
	public ARKitBlendShapeVisualizer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class RecRoomARFaceTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly Quaternion BASE_SELFIE_ROTATION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly int GCLBMNINELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly int PJBHCDEFDDA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int MBOMOGOCHLF = 15;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private ARFaceManager faceManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private RecRoomARSession arSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Header("Default values (used until a face is found)")]
	private Vector3 cachedFacePositionRelativeToARCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[SerializeField]
	private Vector3 cachedFaceRotationRelativeToARCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[SerializeField]
	[Header("Show canvas when camera is covered / no face")]
	private Animator faceDetectionInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private RectTransform detectedFaceRectTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	private Vector2 detectedFaceMovementRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ARFace CPJDLGHCEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ARFaceCoefficients HCLAHCEDCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Vector2 GLJCGAGHAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int NGDLLFJMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Action FaceFoundEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Action FaceLostEvent;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float[] IMEPDFLPGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x206A690", Offset = "0x2069490", VA = "0x18206A690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LHFLFJACJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x206B500", Offset = "0x206A300", VA = "0x18206B500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HEEIJKAACMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x206AE70", Offset = "0x2069C70", VA = "0x18206AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LCGFEGHCAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x206AF80", Offset = "0x2069D80", VA = "0x18206AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GLBDJLADNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x206AEE0", Offset = "0x2069CE0", VA = "0x18206AEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private bool FIALLOMCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2069F00", Offset = "0x2068D00", VA = "0x182069F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private bool BODNLNMGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2069FD0", Offset = "0x2068DD0", VA = "0x182069FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Camera ILDLHLPDNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x206B760", Offset = "0x206A560", VA = "0x18206B760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Quaternion AOKPIEPEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x206B700", Offset = "0x206A500", VA = "0x18206B700")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Vector3 HOPBLEIFMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x206AA70", Offset = "0x2069870", VA = "0x18206AA70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Quaternion MHAMPDKACJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x206AC30", Offset = "0x2069A30", VA = "0x18206AC30")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 BCMLAFJELFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x206A900", Offset = "0x2069700", VA = "0x18206A900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Quaternion NLFJKHAKBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x206A9C0", Offset = "0x20697C0", VA = "0x18206A9C0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Quaternion KFKACGIEAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x206B0E0", Offset = "0x2069EE0", VA = "0x18206B0E0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Quaternion MOMHMIGEHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x206B3B0", Offset = "0x206A1B0", VA = "0x18206B3B0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 CPGBNCHOCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x206B260", Offset = "0x206A060", VA = "0x18206B260")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Quaternion JIHDFBMKOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x206B5F0", Offset = "0x206A3F0", VA = "0x18206B5F0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 FHNEIFBLLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x206B5C0", Offset = "0x206A3C0", VA = "0x18206B5C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 DLLIILHLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x206AD90", Offset = "0x2069B90", VA = "0x18206AD90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MINIIKFNBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x206B790", Offset = "0x206A590", VA = "0x18206B790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x206A170", Offset = "0x2068F70", VA = "0x18206A170")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x206A070", Offset = "0x2068E70", VA = "0x18206A070")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x206A210", Offset = "0x2069010", VA = "0x18206A210")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2069DA0", Offset = "0x2068BA0", VA = "0x182069DA0")]
	private void CAIOONGCHHP(ARFacesChangedEventArgs LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2069F20", Offset = "0x2068D20", VA = "0x182069F20")]
	public static Quaternion InvertEulerXY(Quaternion BHCPPAMLLMB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x206A5C0", Offset = "0x20693C0", VA = "0x18206A5C0")]
	public RecRoomARFaceTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FDOEDOBBPNH(List<ARPlane> FDOKMEBEIMH, List<ARPlane> IMKFFGEFIEP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class RecRoomARRoomTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const float PIGOCIEALNN = 2f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const int KMJGLECMJAL = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[SerializeField]
	private ARPlaneManager planeManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[SerializeField]
	private ARRaycastManager raycastManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<ARRaycastHit> GKEKBHPFMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int NGDLLFJMILB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PBMFMEKFEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x206BFC0", Offset = "0x206ADC0", VA = "0x18206BFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GHELOENAMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x206C120", Offset = "0x206AF20", VA = "0x18206C120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool FIALLOMCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x206B7F0", Offset = "0x206A5F0", VA = "0x18206B7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FDOEDOBBPNH LDJKEALFBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x206BF20", Offset = "0x206AD20", VA = "0x18206BF20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x206C080", Offset = "0x206AE80", VA = "0x18206C080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x206B880", Offset = "0x206A680", VA = "0x18206B880")]
	public ARPlane GetPlane(TrackableId CDDHPAEOPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x206B830", Offset = "0x206A630", VA = "0x18206B830")]
	public TrackableCollection<ARPlane> GetCurrentPlanes()
	{
		return default(TrackableCollection<ARPlane>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x206BA40", Offset = "0x206A840", VA = "0x18206BA40")]
	public bool TryGetCameraHeight(Vector3 JGNPIDFPJGJ, Quaternion INPBHOLMAAM, float MJLFGBDKGBK, out float GLHLMLIHLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x206B9A0", Offset = "0x206A7A0", VA = "0x18206B9A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x206B900", Offset = "0x206A700", VA = "0x18206B900")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x206B810", Offset = "0x206A610", VA = "0x18206B810")]
	private void FGLKJIOMMIP(ARPlanesChangedEventArgs LALOFMIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x206BEA0", Offset = "0x206ACA0", VA = "0x18206BEA0")]
	public RecRoomARRoomTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class RecRoomARSession : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct CLCEHFJMJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly Camera JGGPGHMADLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly float JJGEAJAMHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float JILCLMKBCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float LOFGPMDJFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float BGPILDPCDHG;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x20696A0", Offset = "0x20684A0", VA = "0x1820696A0")]
		public CLCEHFJMJIN(Camera JGGPGHMADLC, float JJGEAJAMHOA, float JILCLMKBCLO, float LOFGPMDJFAA, float BGPILDPCDHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EHHLHICNHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public EHHLHICNHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2069700", Offset = "0x2068500", VA = "0x182069700")]
		internal bool <EnableBackgroundRendering>b__0(CLCEHFJMJIN d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BDMDGBOGEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public BDMDGBOGEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2069610", Offset = "0x2068410", VA = "0x182069610")]
		internal bool <DisableBackgroundRendering>b__0(CLCEHFJMJIN d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool SimulateARInEditor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	private ARSession arSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	private ARSessionOrigin arSessionOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	private ARCameraManager arCameraManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	private Material arCameraBackgroundMaterial;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly int MFBJMLGGGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<CLCEHFJMJIN> OHALMEPNIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AREnvironmentProbeManager IOCOBPPLNCC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const int HFOKKJOHDDF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Texture2D EJGPLGINKOG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Transform BOMPPHIEGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x206D830", Offset = "0x206C630", VA = "0x18206D830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform LKNADGMEGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x18A2A60", Offset = "0x18A1860", VA = "0x1818A2A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Camera ILDLHLPDNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xABA9E0", Offset = "0xAB97E0", VA = "0x180ABA9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KJMIDJIKDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x206AE70", Offset = "0x2069C70", VA = "0x18206AE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NABJKLDJNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x206D750", Offset = "0x206C550", VA = "0x18206D750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PBMFMEKFEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x206D7F0", Offset = "0x206C5F0", VA = "0x18206D7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Material JPCAAGAPCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OCHCAAJCFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x206D850", Offset = "0x206C650", VA = "0x18206D850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x206D5A0", Offset = "0x206C3A0", VA = "0x18206D5A0")]
	public Color SampleColorFromLastVideoFrame(Vector2 BINEOPMJDPL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x206D4F0", Offset = "0x206C2F0", VA = "0x18206D4F0")]
	public void MakeContentAppearAt(Transform NIBIDOOFIBC, Vector3 FKCOIEPPFIP, Quaternion IHNCCKHLIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x206CD10", Offset = "0x206BB10", VA = "0x18206CD10")]
	public void EnableBackgroundRendering(Camera JGGPGHMADLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x206C8E0", Offset = "0x206B6E0", VA = "0x18206C8E0")]
	public void DisableBackgroundRendering(Camera JGGPGHMADLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x206D540", Offset = "0x206C340", VA = "0x18206D540")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x206CC30", Offset = "0x206BA30", VA = "0x18206CC30")]
	private void EEFDHAMENJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x206D060", Offset = "0x206BE60", VA = "0x18206D060")]
	private void HKGKHBNGMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x206C290", Offset = "0x206B090", VA = "0x18206C290")]
	private void CPGDMAMPBOL(ARCameraFrameEventArgs LALOFMIKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x206C180", Offset = "0x206AF80", VA = "0x18206C180")]
	private void CMCAFHGJAID(Matrix4x4 AIHEEMEIIPJ, out float PEIDLBBMNID, out float CJFCMBPPPGM, out float FLIBKEEBPLN, out float HOMELHJLEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x206D170", Offset = "0x206BF70", VA = "0x18206D170")]
	private void LPICIJHKOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x206D6D0", Offset = "0x206C4D0", VA = "0x18206D6D0")]
	public RecRoomARSession()
	{
	}
}
namespace RecRoom.Core.Screens.MobileAR
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CreateAssetMenu]
	public class AREyePose : ARFacialFeaturePose
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Space]
		public AREyePose RequiredPairing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Space]
		[Tooltip("40-50")]
		[Header("Tunings (Score By Coefficient Value)")]
		public BlendLocationRange EyeWide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("30-50 big smile, 30-40 squint, 75-90 almost shut")]
		public BlendLocationRange EyeBlink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("15-20 smile, 30-50 squint")]
		public BlendLocationRange EyeSquint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("20 small smile, 45 big smile")]
		public BlendLocationRange CheekSquint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Space]
		[Tooltip("70 looking at screen down nose")]
		public BlendLocationRange EyeLookDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("around 60")]
		public BlendLocationRange EyeLookIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("around 60")]
		public BlendLocationRange EyeLookOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("around 30")]
		public BlendLocationRange EyeLookUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Space]
		[Tooltip("30-49 inner, up to 70 full face squint")]
		public BlendLocationRange BrowDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("75-90")]
		public BlendLocationRange BrowInnerUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("around 75")]
		public BlendLocationRange BrowOuterUp;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2067F90", Offset = "0x2066D90", VA = "0x182067F90")]
		public AREyePose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ARFaceCoefficients : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static float[] EGEADGOMMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly float[] SmoothedFeatureMap;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x20680B0", Offset = "0x2066EB0", VA = "0x1820680B0")]
		public static float[] GetEditorCoefficients()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x20682D0", Offset = "0x20670D0", VA = "0x1820682D0")]
		public ARFaceCoefficients()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class ARFacialFeaturePose : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct BlendLocationRange
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public AnimationCurve scoreByValue;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2069680", Offset = "0x2068480", VA = "0x182069680")]
			public float BGEEAJBDNHM(float GEENAHHOJAE)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Header("For Mobile AR Package (should be 'Missing' in Rec Room)")]
		public Sprite editorBackupSprite;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected static BlendLocationRange DEFAULT_RANGE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2068510", Offset = "0x2067310", VA = "0x182068510")]
			get
			{
				return default(BlendLocationRange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2068700", Offset = "0x2067500", VA = "0x182068700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2068330", Offset = "0x2067130", VA = "0x182068330")]
		private static AnimationCurve MDAKAEJEEFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x71DC30", Offset = "0x71CA30", VA = "0x18071DC30")]
		protected ARFacialFeaturePose()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CreateAssetMenu]
	public class ARMouthPose : ARFacialFeaturePose
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Space]
		[Header("Tunings (Score By Coefficient Value)")]
		public BlendLocationRange JawOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BlendLocationRange MouthClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Space]
		public BlendLocationRange MouthFunnel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BlendLocationRange MouthPucker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Space]
		public BlendLocationRange MouthSmile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public BlendLocationRange MouthFrown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Space]
		public BlendLocationRange MouthDimple;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public BlendLocationRange MouthRollLower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BlendLocationRange MouthRollUpper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BlendLocationRange MouthShrugLower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BlendLocationRange MouthShrugUpper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Space]
		public BlendLocationRange MouthLowerDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BlendLocationRange MouthUpperUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Space]
		public BlendLocationRange CheekPuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BlendLocationRange TongueOut;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2069480", Offset = "0x2068280", VA = "0x182069480")]
		public ARMouthPose()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2069AC0", Offset = "0x20688C0", VA = "0x182069AC0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2069770", Offset = "0x2068570", VA = "0x182069770")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
