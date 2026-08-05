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
	private static List<Vector3> EDCOPHPBHII;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<Vector3> BLMHCOFHFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ARPlaneMeshVisualizer OGDEHAPPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ARPlane PLPMBBLKMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Material JNPLKINNMCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float LDFJEPBMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB8ABE0", Offset = "0xB89FE0", VA = "0x180B8ABE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFE30", Offset = "0xAAF230", VA = "0x180AAFE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4342380", Offset = "0x4341780", VA = "0x184342380")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4342970", Offset = "0x4341D70", VA = "0x184342970")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43428E0", Offset = "0x4341CE0", VA = "0x1843428E0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43428B0", Offset = "0x4341CB0", VA = "0x1843428B0")]
	private void MFMAHDNMEOL(ARPlaneBoundaryChangedEventArgs FBBJHFEFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4342400", Offset = "0x4341800", VA = "0x184342400")]
	private void EIGJHIIBPMP(Mesh MIGJNDAFACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x10A3540", Offset = "0x10A2940", VA = "0x1810A3540")]
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
	private ARFace BOAIOLAMNFH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float IJDFOHNMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB8ABE0", Offset = "0xB89FE0", VA = "0x180B8ABE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAFE30", Offset = "0xAAF230", VA = "0x180AAFE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public SkinnedMeshRenderer ONIDPJCCPII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CF0", Offset = "0x4C10F0", VA = "0x1804C1CF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E87D0", Offset = "0x4E7BD0", VA = "0x1804E87D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4342A90", Offset = "0x4341E90", VA = "0x184342A90")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4342BA0", Offset = "0x4341FA0", VA = "0x184342BA0")]
	private void HIGMCHLBHMA(bool DGEMEMDJGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4342D00", Offset = "0x4342100", VA = "0x184342D00")]
	private void NOBOABMAOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4342ED0", Offset = "0x43422D0", VA = "0x184342ED0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4342E10", Offset = "0x4342210", VA = "0x184342E10")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4342AD0", Offset = "0x4341ED0", VA = "0x184342AD0")]
	private void DOKECGMBDPE(ARSessionStateChangedEventArgs FBBJHFEFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4342C30", Offset = "0x4342030", VA = "0x184342C30")]
	private void JDICGMINJII(ARFaceUpdatedEventArgs FBBJHFEFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4342AE0", Offset = "0x4341EE0", VA = "0x184342AE0")]
	private void HCGKLFDDKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4342F90", Offset = "0x4342390", VA = "0x184342F90")]
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
	private readonly int MMEMAAMOPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly int JCLLCMODFJA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int CJECFJDOHDK = 15;

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
	private Quaternion cachedFaceRotationRelativeToARCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[SerializeField]
	[Header("Show canvas when camera is covered / no face")]
	private Animator faceDetectionInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private RectTransform detectedFaceRectTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	private Vector2 detectedFaceMovementRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ARFace OPAMBJDKDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ARFaceCoefficients GMOIIHBPBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Vector2 HIIEBDHGBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int JDGAGKCMMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Action FaceFoundEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Action FaceLostEvent;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float[] OMNHHOGLNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43443A0", Offset = "0x43437A0", VA = "0x1843443A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PMEIDIOALDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43453B0", Offset = "0x43447B0", VA = "0x1843453B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EPPKGKHNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4344D70", Offset = "0x4344170", VA = "0x184344D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MPMJACMIICH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4345250", Offset = "0x4344650", VA = "0x184345250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EALHJEHGIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4344CD0", Offset = "0x43440D0", VA = "0x184344CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private bool OLLJHLGMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4343780", Offset = "0x4342B80", VA = "0x184343780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private bool NCIAJHKFOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4343B30", Offset = "0x4342F30", VA = "0x184343B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Camera HKEOBMBNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4345470", Offset = "0x4344870", VA = "0x184345470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Quaternion JDNAIIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4344340", Offset = "0x4343740", VA = "0x184344340")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Quaternion AJCIJFNOJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4344F20", Offset = "0x4344320", VA = "0x184344F20")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 GNGIANGCPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43450D0", Offset = "0x43444D0", VA = "0x1843450D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 EBIJLDIIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4344850", Offset = "0x4343C50", VA = "0x184344850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Quaternion KLFPDENOJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4344A90", Offset = "0x4343E90", VA = "0x184344A90")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 LCENCEDENOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4344640", Offset = "0x4343A40", VA = "0x184344640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Quaternion IHGEJONCHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4344750", Offset = "0x4343B50", VA = "0x184344750")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Quaternion EBFEBNPAMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4344DE0", Offset = "0x43441E0", VA = "0x184344DE0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Quaternion PAKHBDMBBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4344E80", Offset = "0x4344280", VA = "0x184344E80")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 OILCNBDFBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4344BD0", Offset = "0x4343FD0", VA = "0x184344BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PAKIJKOMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43454A0", Offset = "0x43448A0", VA = "0x1843454A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4343CA0", Offset = "0x43430A0", VA = "0x184343CA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4343BC0", Offset = "0x4342FC0", VA = "0x184343BC0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4343D30", Offset = "0x4343130", VA = "0x184343D30")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43437B0", Offset = "0x4342BB0", VA = "0x1843437B0")]
	private void HEFHHGJEFBH(ARFacesChangedEventArgs JLOFPPFANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43439E0", Offset = "0x4342DE0", VA = "0x1843439E0")]
	public static Quaternion InvertEulerXZ(Quaternion BOOOBPLPBIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43438E0", Offset = "0x4342CE0", VA = "0x1843438E0")]
	public static Quaternion InvertEulerXY(Quaternion BOOOBPLPBIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4343AF0", Offset = "0x4342EF0", VA = "0x184343AF0")]
	public static Vector3 InvertY(Vector3 LEHHBCDENEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4344200", Offset = "0x4343600", VA = "0x184344200")]
	public RecRoomARFaceTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DNKHHJLDGBC(List<ARPlane> PNINCHGCBHI, List<ARPlane> DHLLLIIJIOK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class RecRoomARRoomTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const float OHLEEAGIPCH = 2f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const int BNMGIFMBEPI = 50;

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
	private List<ARRaycastHit> NPNGEOJNBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JDGAGKCMMAA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NGJOOOMBIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4345C70", Offset = "0x4345070", VA = "0x184345C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OJBHLFNAOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4345DD0", Offset = "0x43451D0", VA = "0x184345DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool OLLJHLGMDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4345510", Offset = "0x4344910", VA = "0x184345510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DNKHHJLDGBC CFCAPPPBNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4345BD0", Offset = "0x4344FD0", VA = "0x184345BD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4345D30", Offset = "0x4345130", VA = "0x184345D30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x43455A0", Offset = "0x43449A0", VA = "0x1843455A0")]
	public ARPlane GetPlane(TrackableId AIDIAFOLGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4345550", Offset = "0x4344950", VA = "0x184345550")]
	public TrackableCollection<ARPlane> GetCurrentPlanes()
	{
		return default(TrackableCollection<ARPlane>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4345760", Offset = "0x4344B60", VA = "0x184345760")]
	public bool TryGetCameraHeight(Vector3 JKPNCCPMCCL, Quaternion OPNCCNGDKPJ, float DNLHHMBFBOL, out float FPEMJLOHHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43456D0", Offset = "0x4344AD0", VA = "0x1843456D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4345640", Offset = "0x4344A40", VA = "0x184345640")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4345530", Offset = "0x4344930", VA = "0x184345530")]
	private void DECKPAEGBAL(ARPlanesChangedEventArgs FBBJHFEFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4345B70", Offset = "0x4344F70", VA = "0x184345B70")]
	public RecRoomARRoomTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class RecRoomARSession : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GGPLLIOEKFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly Camera BEKCFBHJHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly float AHBDAMDHLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float BBAACNPNJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float IDEHIGCOLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float BONPBLKEGON;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4343090", Offset = "0x4342490", VA = "0x184343090")]
		public GGPLLIOEKFD(Camera BEKCFBHJHPH, float AHBDAMDHLJH, float BBAACNPNJHN, float IDEHIGCOLDB, float BONPBLKEGON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MLDBNHNGKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public MLDBNHNGKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4343710", Offset = "0x4342B10", VA = "0x184343710")]
		internal bool <EnableBackgroundRendering>b__0(GGPLLIOEKFD d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KAKIIJGJOAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public KAKIIJGJOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x43430C0", Offset = "0x43424C0", VA = "0x1843430C0")]
		internal bool <DisableBackgroundRendering>b__0(GGPLLIOEKFD d)
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
	private static readonly int CBOBHDHODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<GGPLLIOEKFD> KFLNHBJJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AREnvironmentProbeManager MMCNHHGNAME;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const int DNKFADHOCLE = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Texture2D DPOAIPPHONP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Transform FKMPENAOEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4347350", Offset = "0x4346750", VA = "0x184347350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Transform FCNKCEHNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F20", Offset = "0x6E4320", VA = "0x1806E4F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Camera HKEOBMBNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EE0", Offset = "0x6E42E0", VA = "0x1806E4EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BAEGABLKCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x43472A0", Offset = "0x43466A0", VA = "0x1843472A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BEBEDFJHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4347200", Offset = "0x4346600", VA = "0x184347200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NGJOOOMBIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4347310", Offset = "0x4346710", VA = "0x184347310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Material GGEANLHIKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4E6670", Offset = "0x4E5A70", VA = "0x1804E6670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool NIFFAJIJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4347370", Offset = "0x4346770", VA = "0x184347370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4347080", Offset = "0x4346480", VA = "0x184347080")]
	public Color SampleColorFromLastVideoFrame(Vector2 FCCLNOPBEPL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4346E80", Offset = "0x4346280", VA = "0x184346E80")]
	public void MakeContentAppearAt(Transform EBJDHMJDMBK, Vector3 EGLDODICGMI, Quaternion EDEMILDFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x43467D0", Offset = "0x4345BD0", VA = "0x1843467D0")]
	public void EnableBackgroundRendering(Camera BEKCFBHJHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4346520", Offset = "0x4345920", VA = "0x184346520")]
	public void DisableBackgroundRendering(Camera BEKCFBHJHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4347020", Offset = "0x4346420", VA = "0x184347020")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4346470", Offset = "0x4345870", VA = "0x184346470")]
	private void DAPADKCOMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4346A40", Offset = "0x4345E40", VA = "0x184346A40")]
	private void KMABLBLLOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4345E30", Offset = "0x4345230", VA = "0x184345E30")]
	private void BFPFBBLNHKE(ARCameraFrameEventArgs FBBJHFEFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4346ED0", Offset = "0x43462D0", VA = "0x184346ED0")]
	private void NDJJFECKKHF(Matrix4x4 JPHPLPKFJGL, out float IOINHDNNAGJ, out float KBGLEAFDCMA, out float OHFLLOIHGJM, out float IIHHFENFNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4346B20", Offset = "0x4345F20", VA = "0x184346B20")]
	private void MNPJGCFDIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x43471A0", Offset = "0x43465A0", VA = "0x1843471A0")]
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
		[Header("Tunings (Score By Coefficient Value)")]
		[Tooltip("40-50")]
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

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4341DF0", Offset = "0x43411F0", VA = "0x184341DF0")]
		public AREyePose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ARFaceCoefficients : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static float[] HLLODGFNMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly float[] SmoothedFeatureMap;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4341E90", Offset = "0x4341290", VA = "0x184341E90")]
		public static float[] GetEditorCoefficients()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x43420E0", Offset = "0x43414E0", VA = "0x1843420E0")]
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

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4343070", Offset = "0x4342470", VA = "0x184343070")]
			public float IKPGNMIBDHO(float KCDPFNLGBCP)
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

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected static BlendLocationRange DEFAULT_RANGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4342130", Offset = "0x4341530", VA = "0x184342130")]
			get
			{
				return default(BlendLocationRange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4342300", Offset = "0x4341700", VA = "0x184342300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4342130", Offset = "0x4341530", VA = "0x184342130")]
		private static AnimationCurve FBGOCEOAEJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA74890", Offset = "0xA73C90", VA = "0x180A74890")]
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

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4342FA0", Offset = "0x43423A0", VA = "0x184342FA0")]
		public ARMouthPose()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LFOOCLJBDKO
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static byte[] MMIGALFGEBH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int KKBDIGGLOKN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int BKPLPABKLDE;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BigInteger NPDKPCMPDOD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public LFOOCLJBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4343130", Offset = "0x4342530", VA = "0x184343130")]
	private static string ELDABPJJLIE(byte[] DOIHHFGBAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4343230", Offset = "0x4342630", VA = "0x184343230")]
	public static string OCONCCINMFA(byte[] KLJMCJLFPAA, bool NGPDKIFLJKL)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
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
