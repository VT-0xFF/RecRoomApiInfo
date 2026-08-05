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
	private static List<Vector3> EEFACOPHBHN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<Vector3> CNLKCKPDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ARPlaneMeshVisualizer AGBDGFPEAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ARPlane FFPOLALPCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Material CLFKMIHMHPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float AHHLNKGAAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C0", Offset = "0x6F9CC0", VA = "0x1806FB6C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6E0", Offset = "0x6F9CE0", VA = "0x1806FB6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31338C0", Offset = "0x3131EC0", VA = "0x1831338C0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3133EA0", Offset = "0x31324A0", VA = "0x183133EA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3133E10", Offset = "0x3132410", VA = "0x183133E10")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3133F30", Offset = "0x3132530", VA = "0x183133F30")]
	private void PNNGHFNAEGF(ARPlaneBoundaryChangedEventArgs LIGBOOGGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3133960", Offset = "0x3131F60", VA = "0x183133960")]
	private void OGAEGBKCMLD(Mesh NLKJHCLIEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x573120", Offset = "0x571720", VA = "0x180573120")]
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
	private ARFace ENEPODIGEAO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float LAAKAPEJNMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C0", Offset = "0x6F9CC0", VA = "0x1806FB6C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6E0", Offset = "0x6F9CE0", VA = "0x1806FB6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public SkinnedMeshRenderer KMAPFOKOJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3134000", Offset = "0x3132600", VA = "0x183134000")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3134110", Offset = "0x3132710", VA = "0x183134110")]
	private void IOMPDODPCOB(bool EPCKBCBHFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3134270", Offset = "0x3132870", VA = "0x183134270")]
	private void MHLFNGNAMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3134450", Offset = "0x3132A50", VA = "0x183134450")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3134390", Offset = "0x3132990", VA = "0x183134390")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3134380", Offset = "0x3132980", VA = "0x183134380")]
	private void NCKIFBGGHLE(ARSessionStateChangedEventArgs LIGBOOGGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x31341A0", Offset = "0x31327A0", VA = "0x1831341A0")]
	private void JLLINBCMKDC(ARFaceUpdatedEventArgs LIGBOOGGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3134050", Offset = "0x3132650", VA = "0x183134050")]
	private void GBEBPHPMKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3134510", Offset = "0x3132B10", VA = "0x183134510")]
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
	private readonly int NPNPADJFIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly int BBGDNKKCIOO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AABDEEOIHFL = 15;

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
	private ARFace AEAKDMOLODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ARFaceCoefficients AKJMALFGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Vector2 ICOPMOLNFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int FMKNACMKHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Action FaceFoundEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Action FaceLostEvent;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float[] ANJNBIMOOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3135A40", Offset = "0x3134040", VA = "0x183135A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MCFEOIONPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3136A50", Offset = "0x3135050", VA = "0x183136A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FNNMDONGDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3136410", Offset = "0x3134A10", VA = "0x183136410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BLHLPHJKDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x31368F0", Offset = "0x3134EF0", VA = "0x1831368F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PGNKPCEMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3136370", Offset = "0x3134970", VA = "0x183136370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private bool PJKEABOPFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3134FE0", Offset = "0x31335E0", VA = "0x183134FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private bool OPIIOPCPNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3134E00", Offset = "0x3133400", VA = "0x183134E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Camera LFAEGKMNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3136B10", Offset = "0x3135110", VA = "0x183136B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Quaternion IDFEANPJNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x31359E0", Offset = "0x3133FE0", VA = "0x1831359E0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Quaternion CGPIGMGIJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x31365C0", Offset = "0x3134BC0", VA = "0x1831365C0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 FILJKHHPFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3136770", Offset = "0x3134D70", VA = "0x183136770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 PGCNKGFMOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3135EF0", Offset = "0x31344F0", VA = "0x183135EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Quaternion LGJJGCCHAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3136130", Offset = "0x3134730", VA = "0x183136130")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 DMCPJHFCPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3135CE0", Offset = "0x31342E0", VA = "0x183135CE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Quaternion LMONNKHOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3135DF0", Offset = "0x31343F0", VA = "0x183135DF0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Quaternion DMGNHKANPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3136480", Offset = "0x3134A80", VA = "0x183136480")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Quaternion JPHFFFFBICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3136520", Offset = "0x3134B20", VA = "0x183136520")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 PDHBFPHHDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3136270", Offset = "0x3134870", VA = "0x183136270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EMINKCNFDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3136B40", Offset = "0x3135140", VA = "0x183136B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3135340", Offset = "0x3133940", VA = "0x183135340")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3135260", Offset = "0x3133860", VA = "0x183135260")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x31353D0", Offset = "0x31339D0", VA = "0x1831353D0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3134E90", Offset = "0x3133490", VA = "0x183134E90")]
	private void BNEMJMBOGDJ(ARFacesChangedEventArgs KFIBIDDJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3135110", Offset = "0x3133710", VA = "0x183135110")]
	public static Quaternion InvertEulerXZ(Quaternion AKDPAMPILOF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3135010", Offset = "0x3133610", VA = "0x183135010")]
	public static Quaternion InvertEulerXY(Quaternion AKDPAMPILOF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3135220", Offset = "0x3133820", VA = "0x183135220")]
	public static Vector3 InvertY(Vector3 AIOIIBBMMDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x31358A0", Offset = "0x3133EA0", VA = "0x1831358A0")]
	public RecRoomARFaceTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FHBICPMILMP(List<ARPlane> KPADOAOLMPF, List<ARPlane> AAGKBGMIBMK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class RecRoomARRoomTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const float GOEJFIKOIHA = 2f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const int BCHIIDMOIIJ = 50;

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
	private List<ARRaycastHit> LLLHCEMLMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FMKNACMKHHL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EHAHHLPMHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3137320", Offset = "0x3135920", VA = "0x183137320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MHOBDHHAGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3137480", Offset = "0x3135A80", VA = "0x183137480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PJKEABOPFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3136BD0", Offset = "0x31351D0", VA = "0x183136BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FHBICPMILMP DKPPNFFJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3137280", Offset = "0x3135880", VA = "0x183137280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x31373E0", Offset = "0x31359E0", VA = "0x1831373E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3136C40", Offset = "0x3135240", VA = "0x183136C40")]
	public ARPlane GetPlane(TrackableId ENNCOIINFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3136BF0", Offset = "0x31351F0", VA = "0x183136BF0")]
	public TrackableCollection<ARPlane> GetCurrentPlanes()
	{
		return default(TrackableCollection<ARPlane>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3136E00", Offset = "0x3135400", VA = "0x183136E00")]
	public bool TryGetCameraHeight(Vector3 PIFJHCEELPN, Quaternion NFLEFGOLLCP, float JOGKPJGCCFD, out float BADJLOPAGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3136D70", Offset = "0x3135370", VA = "0x183136D70")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3136CE0", Offset = "0x31352E0", VA = "0x183136CE0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3136BB0", Offset = "0x31351B0", VA = "0x183136BB0")]
	private void BMJENFPKJKN(ARPlanesChangedEventArgs LIGBOOGGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3137210", Offset = "0x3135810", VA = "0x183137210")]
	public RecRoomARRoomTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class RecRoomARSession : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MFHEDKCHALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly Camera OONJMIECOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly float FHJLDGNCCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float CMEAOPFJMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float PJKGDGEEFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float LEICALGHDDD;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3134D30", Offset = "0x3133330", VA = "0x183134D30")]
		public MFHEDKCHALP(Camera OONJMIECOOE, float FHJLDGNCCAC, float CMEAOPFJMGA, float PJKGDGEEFAP, float LEICALGHDDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PNPFGDIGOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public PNPFGDIGOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3134D90", Offset = "0x3133390", VA = "0x183134D90")]
		internal bool <EnableBackgroundRendering>b__0(MFHEDKCHALP d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HIJOIFLLJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public HIJOIFLLJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3134CC0", Offset = "0x31332C0", VA = "0x183134CC0")]
		internal bool <DisableBackgroundRendering>b__0(MFHEDKCHALP d)
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
	private static readonly int JADFHDHAJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<MFHEDKCHALP> OFCDDDIFBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AREnvironmentProbeManager IEIOBBHKAFA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const int LJLELHKIKBA = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Texture2D ACBCLLLDDNF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Transform LOGFNGBHBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3138A90", Offset = "0x3137090", VA = "0x183138A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Transform BKLADMKGHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x13AEBF0", Offset = "0x13AD1F0", VA = "0x1813AEBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Camera LFAEGKMNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x13AEBB0", Offset = "0x13AD1B0", VA = "0x1813AEBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool IOCHBHAOFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x31389E0", Offset = "0x3136FE0", VA = "0x1831389E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IGPJDFKGOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3138940", Offset = "0x3136F40", VA = "0x183138940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EHAHHLPMHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3138A50", Offset = "0x3137050", VA = "0x183138A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Material GOFMIJDLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool MLGGOHGCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3138AB0", Offset = "0x31370B0", VA = "0x183138AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31387B0", Offset = "0x3136DB0", VA = "0x1831387B0")]
	public Color SampleColorFromLastVideoFrame(Vector2 FHJDBOMIBMH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3138390", Offset = "0x3136990", VA = "0x183138390")]
	public void MakeContentAppearAt(Transform MMNLMLIGEGC, Vector3 PEHAFHMGPHB, Quaternion AIOLOGBMHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3137850", Offset = "0x3135E50", VA = "0x183137850")]
	public void EnableBackgroundRendering(Camera OONJMIECOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31374E0", Offset = "0x3135AE0", VA = "0x1831374E0")]
	public void DisableBackgroundRendering(Camera OONJMIECOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3138750", Offset = "0x3136D50", VA = "0x183138750")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x31377A0", Offset = "0x3135DA0", VA = "0x1831377A0")]
	private void EDMGLKINDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31382B0", Offset = "0x31368B0", VA = "0x1831382B0")]
	private void LFLHLBGAOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3137B20", Offset = "0x3136120", VA = "0x183137B20")]
	private void FDNFPCKFCLL(ARCameraFrameEventArgs LIGBOOGGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3138160", Offset = "0x3136760", VA = "0x183138160")]
	private void FPGMGJMACEL(Matrix4x4 MBJCHKEJFHL, out float ALHPAMKILKG, out float FLODFCNPOOH, out float KHBFABPGHID, out float GJNOGEFJIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31383E0", Offset = "0x31369E0", VA = "0x1831383E0")]
	private void OPOJBHFILBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x31388D0", Offset = "0x3136ED0", VA = "0x1831388D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x31330C0", Offset = "0x31316C0", VA = "0x1831330C0")]
		public AREyePose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ARFaceCoefficients : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static float[] CNJDLAHPGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly float[] SmoothedFeatureMap;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x31331E0", Offset = "0x31317E0", VA = "0x1831331E0")]
		public static float[] GetEditorCoefficients()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3133430", Offset = "0x3131A30", VA = "0x183133430")]
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
			[Cpp2IlInjected.Address(RVA = "0x31346B0", Offset = "0x3132CB0", VA = "0x1831346B0")]
			public float BOFJLOFJPMC(float IDOIHONIPMB)
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
			[Cpp2IlInjected.Address(RVA = "0x3133660", Offset = "0x3131C60", VA = "0x183133660")]
			get
			{
				return default(BlendLocationRange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3133840", Offset = "0x3131E40", VA = "0x183133840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3133490", Offset = "0x3131A90", VA = "0x183133490")]
		private static AnimationCurve EJBAKIEOCGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x58C160", Offset = "0x58A760", VA = "0x18058C160")]
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
		[Cpp2IlInjected.Address(RVA = "0x3134520", Offset = "0x3132B20", VA = "0x183134520")]
		public ARMouthPose()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x31346D0", Offset = "0x3132CD0", VA = "0x1831346D0")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31347D0", Offset = "0x3132DD0", VA = "0x1831347D0")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
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
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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
