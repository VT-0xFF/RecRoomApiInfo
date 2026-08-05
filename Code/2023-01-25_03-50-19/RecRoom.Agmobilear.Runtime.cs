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
	private static List<Vector3> CPFPMANJABO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<Vector3> NONCPAKGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ARPlaneMeshVisualizer IMOOCIKFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ARPlane JNFDMCIFHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Material HFELADOBDDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float DFGCEFMGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x10998C0", Offset = "0x10988C0", VA = "0x1810998C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD74020", Offset = "0xD73020", VA = "0x180D74020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6011910", Offset = "0x6010910", VA = "0x186011910")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6011F10", Offset = "0x6010F10", VA = "0x186011F10")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6011E70", Offset = "0x6010E70", VA = "0x186011E70")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6011E40", Offset = "0x6010E40", VA = "0x186011E40")]
	private void EKCFMBCAFMM(ARPlaneBoundaryChangedEventArgs EFKHMOKMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60119D0", Offset = "0x60109D0", VA = "0x1860119D0")]
	private void CAGIHLLENPA(Mesh BACPNBLOLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1251C70", Offset = "0x1250C70", VA = "0x181251C70")]
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
	private ARFace LOIIJLCJAEP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float JLFCAMFJGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10998C0", Offset = "0x10988C0", VA = "0x1810998C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD74020", Offset = "0xD73020", VA = "0x180D74020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public SkinnedMeshRenderer FAGFENOCADF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6012070", Offset = "0x6011070", VA = "0x186012070")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60121A0", Offset = "0x60111A0", VA = "0x1860121A0")]
	private void GDCGJPJNHCJ(bool EDJPNIOAEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60124E0", Offset = "0x60114E0", VA = "0x1860124E0")]
	private void PADGNIJIJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60123E0", Offset = "0x60113E0", VA = "0x1860123E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60122F0", Offset = "0x60112F0", VA = "0x1860122F0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60120C0", Offset = "0x60110C0", VA = "0x1860120C0")]
	private void BGMMJOJDEHA(ARSessionStateChangedEventArgs EFKHMOKMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60120D0", Offset = "0x60110D0", VA = "0x1860120D0")]
	private void ELAIHJBMAJL(ARFaceUpdatedEventArgs EFKHMOKMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6012230", Offset = "0x6011230", VA = "0x186012230")]
	private void KGLBMIEGEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60125F0", Offset = "0x60115F0", VA = "0x1860125F0")]
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
	private readonly int HEMBIIKOABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly int GCFODFDALJE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int FONPDGNNFKG = 15;

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
	private ARFace OEOGOECJNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ARFaceCoefficients FMGMIFIJOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Vector2 IEDNMDMCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int IGOOGNCGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Action FaceFoundEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Action FaceLostEvent;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float[] ENHKDKFILHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6013810", Offset = "0x6012810", VA = "0x186013810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool COKMBKFPKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6014680", Offset = "0x6013680", VA = "0x186014680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool AGJJFBALNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x6012FF0", VA = "0x186013FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JFBIDHKABMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6014100", Offset = "0x6013100", VA = "0x186014100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MAIDAEGNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6014060", Offset = "0x6013060", VA = "0x186014060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private bool HAOMIGMPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6012F20", Offset = "0x6011F20", VA = "0x186012F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private bool KDPMHJMPANH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6013150", Offset = "0x6012150", VA = "0x186013150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Camera HNDIPHCFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60148E0", Offset = "0x60138E0", VA = "0x1860148E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Quaternion GAELBBGGMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6014880", Offset = "0x6013880", VA = "0x186014880")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Vector3 JDINKHNJNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6013BF0", Offset = "0x6012BF0", VA = "0x186013BF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Quaternion HBEEALCEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6013DB0", Offset = "0x6012DB0", VA = "0x186013DB0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 BMKABMMABLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6013A80", Offset = "0x6012A80", VA = "0x186013A80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Quaternion CHDOJHLNPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6013B40", Offset = "0x6012B40", VA = "0x186013B40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Quaternion AJKIDFJNLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6014260", Offset = "0x6013260", VA = "0x186014260")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Quaternion IAIDIMGDFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6014530", Offset = "0x6013530", VA = "0x186014530")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 PBJAAGBODEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60143E0", Offset = "0x60133E0", VA = "0x1860143E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Quaternion PMDMBJNHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6014770", Offset = "0x6013770", VA = "0x186014770")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 HKHJLJCKJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6014740", Offset = "0x6013740", VA = "0x186014740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 BBIJLKAPMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6013F10", Offset = "0x6012F10", VA = "0x186013F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JDGNIBOONAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6014910", Offset = "0x6013910", VA = "0x186014910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60132F0", Offset = "0x60122F0", VA = "0x1860132F0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60131F0", Offset = "0x60121F0", VA = "0x1860131F0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6013390", Offset = "0x6012390", VA = "0x186013390")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6012FF0", Offset = "0x6011FF0", VA = "0x186012FF0")]
	private void NHEEEAJEHFM(ARFacesChangedEventArgs GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6012F40", Offset = "0x6011F40", VA = "0x186012F40")]
	public static Quaternion InvertEulerXY(Quaternion EIGPDNIOAKK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6013740", Offset = "0x6012740", VA = "0x186013740")]
	public RecRoomARFaceTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JJMGGEFMPPE(List<ARPlane> HEKAIGAFACC, List<ARPlane> MNEGBOKAHIL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class RecRoomARRoomTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const float IPDNBDNFMFH = 2f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const int MFKFBEIIHEO = 50;

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
	private List<ARRaycastHit> JPECHCPPLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int IGOOGNCGPLG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AOPMLJEJFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6015140", Offset = "0x6014140", VA = "0x186015140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EAAFCJIFJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60152A0", Offset = "0x60142A0", VA = "0x1860152A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool HAOMIGMPBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6014970", Offset = "0x6013970", VA = "0x186014970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JJMGGEFMPPE LNEGLKPLANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60150A0", Offset = "0x60140A0", VA = "0x1860150A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6015200", Offset = "0x6014200", VA = "0x186015200")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6014A00", Offset = "0x6013A00", VA = "0x186014A00")]
	public ARPlane GetPlane(TrackableId HBECKGIJFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60149B0", Offset = "0x60139B0", VA = "0x1860149B0")]
	public TrackableCollection<ARPlane> GetCurrentPlanes()
	{
		return default(TrackableCollection<ARPlane>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6014BC0", Offset = "0x6013BC0", VA = "0x186014BC0")]
	public bool TryGetCameraHeight(Vector3 OOCFCLDOOBJ, Quaternion BFNIFGNPCGN, float HNFGCCMGIMJ, out float BADJPIIBOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6014B20", Offset = "0x6013B20", VA = "0x186014B20")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6014A80", Offset = "0x6013A80", VA = "0x186014A80")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6014990", Offset = "0x6013990", VA = "0x186014990")]
	private void FCKDICKCGFK(ARPlanesChangedEventArgs EFKHMOKMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6015020", Offset = "0x6014020", VA = "0x186015020")]
	public RecRoomARRoomTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class RecRoomARSession : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GPJGPAPDGJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly Camera ABJENFFCFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly float LNFDCAOJOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float CDLGHAFGFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float PBMHCDJEMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float FLMDCEKJJEL;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60127B0", Offset = "0x60117B0", VA = "0x1860127B0")]
		public GPJGPAPDGJA(Camera ABJENFFCFAK, float LNFDCAOJOJP, float CDLGHAFGFKP, float PBMHCDJEMLE, float FLMDCEKJJEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KNHNCMCJBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public KNHNCMCJBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6012EB0", Offset = "0x6011EB0", VA = "0x186012EB0")]
		internal bool <EnableBackgroundRendering>b__0(GPJGPAPDGJA d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IHCMLGJPJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IHCMLGJPJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6012810", Offset = "0x6011810", VA = "0x186012810")]
		internal bool <DisableBackgroundRendering>b__0(GPJGPAPDGJA d)
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
	private static readonly int OBAOAKGEHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<GPJGPAPDGJA> LDCJMDNKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AREnvironmentProbeManager AHBCPJCACFJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const int GHAKBIFINJF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Texture2D MLFIMMIECDF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Transform BAEOECEOFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60169B0", Offset = "0x60159B0", VA = "0x1860169B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform ICGHIIOMNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA8DC0", Offset = "0xAA7DC0", VA = "0x180AA8DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Camera HNDIPHCFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D80", Offset = "0xAA7D80", VA = "0x180AA8D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EDIDGBFIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x6012FF0", VA = "0x186013FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LAFBIDGCCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60168D0", Offset = "0x60158D0", VA = "0x1860168D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AOPMLJEJFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6016970", Offset = "0x6015970", VA = "0x186016970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Material EOHFBPGIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6946F0", Offset = "0x6936F0", VA = "0x1806946F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FKIFLLLGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60169D0", Offset = "0x60159D0", VA = "0x1860169D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6016720", Offset = "0x6015720", VA = "0x186016720")]
	public Color SampleColorFromLastVideoFrame(Vector2 JGDGBEELGJO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6016670", Offset = "0x6015670", VA = "0x186016670")]
	public void MakeContentAppearAt(Transform GODBGKOJJBB, Vector3 BJDLHGGCJAB, Quaternion COPGFLMFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6016240", Offset = "0x6015240", VA = "0x186016240")]
	public void EnableBackgroundRendering(Camera ABJENFFCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6015EF0", Offset = "0x6014EF0", VA = "0x186015EF0")]
	public void DisableBackgroundRendering(Camera ABJENFFCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60166C0", Offset = "0x60156C0", VA = "0x1860166C0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6016590", Offset = "0x6015590", VA = "0x186016590")]
	private void KCFKJAHLNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6015300", Offset = "0x6014300", VA = "0x186015300")]
	private void AIEFFCFPGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6015410", Offset = "0x6014410", VA = "0x186015410")]
	private void APDPJOKDDBK(ARCameraFrameEventArgs EFKHMOKMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6015DE0", Offset = "0x6014DE0", VA = "0x186015DE0")]
	private void DIAFFGBAJMH(Matrix4x4 GNOBNDGHGOO, out float IMOIFPAPBOF, out float EMOLPPDJDEL, out float NPJOOBGEMNN, out float EOINIDAOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6015A60", Offset = "0x6014A60", VA = "0x186015A60")]
	private void BBDOHJEFMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6016850", Offset = "0x6015850", VA = "0x186016850")]
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
		[Cpp2IlInjected.Address(RVA = "0x6011120", Offset = "0x6010120", VA = "0x186011120")]
		public AREyePose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ARFaceCoefficients : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static float[] EAMIEABAKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly float[] SmoothedFeatureMap;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6011240", Offset = "0x6010240", VA = "0x186011240")]
		public static float[] GetEditorCoefficients()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6011460", Offset = "0x6010460", VA = "0x186011460")]
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
			[Cpp2IlInjected.Address(RVA = "0x6012790", Offset = "0x6011790", VA = "0x186012790")]
			public float HADNJNMEOPN(float DCLBIIDCEBI)
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
			[Cpp2IlInjected.Address(RVA = "0x60116A0", Offset = "0x60106A0", VA = "0x1860116A0")]
			get
			{
				return default(BlendLocationRange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6011890", Offset = "0x6010890", VA = "0x186011890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60114C0", Offset = "0x60104C0", VA = "0x1860114C0")]
		private static AnimationCurve HDKKHOPDBKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xDF0520", Offset = "0xDEF520", VA = "0x180DF0520")]
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
		[Cpp2IlInjected.Address(RVA = "0x6012600", Offset = "0x6011600", VA = "0x186012600")]
		public ARMouthPose()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6012BD0", Offset = "0x6011BD0", VA = "0x186012BD0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6012880", Offset = "0x6011880", VA = "0x186012880")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
