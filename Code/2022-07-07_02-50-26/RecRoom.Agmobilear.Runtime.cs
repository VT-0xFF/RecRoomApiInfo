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
	private static List<Vector3> NDCOCKKKBAE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static List<Vector3> NDHCHKOANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ARPlaneMeshVisualizer KLFKIAGACIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private ARPlane DDHKPLBHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Material JIPDJBGGJFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float EDGJLJBJJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xF17C60", Offset = "0xF16E60", VA = "0x180F17C60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xDBB350", Offset = "0xDBA550", VA = "0x180DBB350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51456A0", Offset = "0x51448A0", VA = "0x1851456A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5145CB0", Offset = "0x5144EB0", VA = "0x185145CB0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5145C20", Offset = "0x5144E20", VA = "0x185145C20")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5145740", Offset = "0x5144940", VA = "0x185145740")]
	private void CKGJCHFNBDC(ARPlaneBoundaryChangedEventArgs GGAHCHBPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5145770", Offset = "0x5144970", VA = "0x185145770")]
	private void FEHCNPKOBCF(Mesh KFPLOEFPOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x16AF240", Offset = "0x16AE440", VA = "0x1816AF240")]
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
	private ARFace DNKPHCHAOLG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float ONLGODIKIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF17C60", Offset = "0xF16E60", VA = "0x180F17C60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDBB350", Offset = "0xDBA550", VA = "0x180DBB350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public SkinnedMeshRenderer BPLCCNKCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D70", Offset = "0x5B3F70", VA = "0x1805B4D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5145DE0", Offset = "0x5144FE0", VA = "0x185145DE0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5145F00", Offset = "0x5145100", VA = "0x185145F00")]
	private void JGPNAAFNFMO(bool MDEHHALCGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5145FA0", Offset = "0x51451A0", VA = "0x185145FA0")]
	private void NCOIDNJIAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5146230", Offset = "0x5145430", VA = "0x185146230")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5146170", Offset = "0x5145370", VA = "0x185146170")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5145F90", Offset = "0x5145190", VA = "0x185145F90")]
	private void LHEPGLGNGNH(ARSessionStateChangedEventArgs GGAHCHBPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5145E30", Offset = "0x5145030", VA = "0x185145E30")]
	private void BNBHPDINGJP(ARFaceUpdatedEventArgs GGAHCHBPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51460B0", Offset = "0x51452B0", VA = "0x1851460B0")]
	private void OPLKDEOOBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51462F0", Offset = "0x51454F0", VA = "0x1851462F0")]
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
	private readonly int ICDLNCFJJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly int ANLKHCKOOHA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int IFGHJLIGBEO = 15;

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
	private ARFace HFFCEDGEICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ARFaceCoefficients KFABFJEKOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Vector2 BDIFIKBCAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int JBNICJFEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Action FaceFoundEvent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Action FaceLostEvent;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float[] DEBMDGHPEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5147650", Offset = "0x5146850", VA = "0x185147650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BLNNOGIFBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5148620", Offset = "0x5147820", VA = "0x185148620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DNAAHDBBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5147FF0", Offset = "0x51471F0", VA = "0x185147FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LEEGIOABAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5148100", Offset = "0x5147300", VA = "0x185148100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool POKELGHDDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5148060", Offset = "0x5147260", VA = "0x185148060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private bool IGOPPAHIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5146D70", Offset = "0x5145F70", VA = "0x185146D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private bool NOEAGBFFELL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5146BE0", Offset = "0x5145DE0", VA = "0x185146BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Camera DMPLMFEHALN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5148810", Offset = "0x5147A10", VA = "0x185148810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Quaternion POGENNBKOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51487B0", Offset = "0x51479B0", VA = "0x1851487B0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Vector3 GPCOEICMAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5147B00", Offset = "0x5146D00", VA = "0x185147B00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Quaternion CJLGKJDLOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5147D40", Offset = "0x5146F40", VA = "0x185147D40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 CDFHLBLCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51478F0", Offset = "0x5146AF0", VA = "0x1851478F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Quaternion NADHJMLLHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5147A00", Offset = "0x5146C00", VA = "0x185147A00")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Quaternion JBDEPLCHLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5148260", Offset = "0x5147460", VA = "0x185148260")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Quaternion MHBPJKMEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5148550", Offset = "0x5147750", VA = "0x185148550")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 DGLFNIJAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x51483C0", Offset = "0x51475C0", VA = "0x1851483C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Quaternion KBLKLJCKHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5148710", Offset = "0x5147910", VA = "0x185148710")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 KCGFDMNCHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x51486E0", Offset = "0x51478E0", VA = "0x1851486E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 OCHAKKFKDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5147EF0", Offset = "0x51470F0", VA = "0x185147EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HFMBFLKAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5148840", Offset = "0x5147A40", VA = "0x185148840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5146FC0", Offset = "0x51461C0", VA = "0x185146FC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5146EE0", Offset = "0x51460E0", VA = "0x185146EE0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5147050", Offset = "0x5146250", VA = "0x185147050")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5146D90", Offset = "0x5145F90", VA = "0x185146D90")]
	private void OKMCCEKOMNI(ARFacesChangedEventArgs ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5146C70", Offset = "0x5145E70", VA = "0x185146C70")]
	public static Quaternion InvertEulerXY(Quaternion EOMKAGCDDCE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5147520", Offset = "0x5146720", VA = "0x185147520")]
	public RecRoomARFaceTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LFEKKGELCJG(List<ARPlane> CEKFEPOPFAG, List<ARPlane> AEMLHEBCDEC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class RecRoomARRoomTracking : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const float EMBAKNJFAID = 2f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const int MLIDDCJHHFK = 50;

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
	private List<ARRaycastHit> KGKFMCIIPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JBNICJFEJBK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CPHDMGPIDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5149010", Offset = "0x5148210", VA = "0x185149010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JCFNDHBJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5149170", Offset = "0x5148370", VA = "0x185149170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IGOPPAHIIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x51489B0", Offset = "0x5147BB0", VA = "0x1851489B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LFEKKGELCJG APCBJLHIJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5148F70", Offset = "0x5148170", VA = "0x185148F70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x51490D0", Offset = "0x51482D0", VA = "0x1851490D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5148910", Offset = "0x5147B10", VA = "0x185148910")]
	public ARPlane GetPlane(TrackableId LAJPJGFFGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51488C0", Offset = "0x5147AC0", VA = "0x1851488C0")]
	public TrackableCollection<ARPlane> GetCurrentPlanes()
	{
		return default(TrackableCollection<ARPlane>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5148AF0", Offset = "0x5147CF0", VA = "0x185148AF0")]
	public bool TryGetCameraHeight(Vector3 FNHCBOIABNE, Quaternion NGMPODFHEIH, float CFIFCAEIOLL, out float OKDFLDFMONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5148A60", Offset = "0x5147C60", VA = "0x185148A60")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51489D0", Offset = "0x5147BD0", VA = "0x1851489D0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51488A0", Offset = "0x5147AA0", VA = "0x1851488A0")]
	private void DABIAINHGGP(ARPlanesChangedEventArgs GGAHCHBPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5148F00", Offset = "0x5148100", VA = "0x185148F00")]
	public RecRoomARRoomTracking()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class RecRoomARSession : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct EIDKPCJBDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly Camera BHFABKKIGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly float DIFECFJIEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float AEOKCDJPJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float MEBMHIAFMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float DDEJOHKDDPG;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x51464B0", Offset = "0x51456B0", VA = "0x1851464B0")]
		public EIDKPCJBDPL(Camera BHFABKKIGAB, float DIFECFJIEGM, float AEOKCDJPJHJ, float MEBMHIAFMPO, float DDEJOHKDDPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ENNLNDJCDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ENNLNDJCDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5146510", Offset = "0x5145710", VA = "0x185146510")]
		internal bool <EnableBackgroundRendering>b__0(EIDKPCJBDPL d)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PNHJJMDMDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Camera camera;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public PNHJJMDMDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5146B70", Offset = "0x5145D70", VA = "0x185146B70")]
		internal bool <DisableBackgroundRendering>b__0(EIDKPCJBDPL d)
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
	private static readonly int KHJMBBCNOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<EIDKPCJBDPL> HEACNMHFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AREnvironmentProbeManager JHBGHDJDINF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const int OCOPEOCMJNJ = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Texture2D LGOGMFDPJFN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Transform LOPJPLAKFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x514A710", Offset = "0x5149910", VA = "0x18514A710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform NDNJLNOFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA60", Offset = "0x8BAC60", VA = "0x1808BBA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Camera DMPLMFEHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA20", Offset = "0x8BAC20", VA = "0x1808BBA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OBJKGCFEJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5147FF0", Offset = "0x51471F0", VA = "0x185147FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IEDCJMBPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x514A630", Offset = "0x5149830", VA = "0x18514A630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CPHDMGPIDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x514A6D0", Offset = "0x51498D0", VA = "0x18514A6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Material DJIKNDLACAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool DKCGLEBKHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x514A730", Offset = "0x5149930", VA = "0x18514A730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x514A4A0", Offset = "0x51496A0", VA = "0x18514A4A0")]
	public Color SampleColorFromLastVideoFrame(Vector2 AANADHCAOPA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5149810", Offset = "0x5148A10", VA = "0x185149810")]
	public void MakeContentAppearAt(Transform BPBOMDNECAJ, Vector3 OCBLLLHNFHB, Quaternion HFIOOBADEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5149490", Offset = "0x5148690", VA = "0x185149490")]
	public void EnableBackgroundRendering(Camera BHFABKKIGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51491D0", Offset = "0x51483D0", VA = "0x1851491D0")]
	public void DisableBackgroundRendering(Camera BHFABKKIGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5149860", Offset = "0x5148A60", VA = "0x185149860")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5149760", Offset = "0x5148960", VA = "0x185149760")]
	private void GNEDBMBJBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x514A3C0", Offset = "0x51495C0", VA = "0x18514A3C0")]
	private void POBKCCGNOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51498C0", Offset = "0x5148AC0", VA = "0x1851498C0")]
	private void PIJGKEBNEPH(ARCameraFrameEventArgs GGAHCHBPKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5149F00", Offset = "0x5149100", VA = "0x185149F00")]
	private void PJGBMAJBNEM(Matrix4x4 PKOFKGLMBCH, out float NCEBIGNAFEL, out float PLFANCPGPAJ, out float KLLLCCOELJH, out float MJGNLNKAPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x514A050", Offset = "0x5149250", VA = "0x18514A050")]
	private void PNAEEOKMKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x514A5C0", Offset = "0x51497C0", VA = "0x18514A5C0")]
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

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5144EA0", Offset = "0x51440A0", VA = "0x185144EA0")]
		public AREyePose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ARFaceCoefficients : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static float[] EEGAGNLIKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly float[] SmoothedFeatureMap;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5144FC0", Offset = "0x51441C0", VA = "0x185144FC0")]
		public static float[] GetEditorCoefficients()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5145210", Offset = "0x5144410", VA = "0x185145210")]
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
			[Cpp2IlInjected.Address(RVA = "0x5146490", Offset = "0x5145690", VA = "0x185146490")]
			public float NLPCEEEOLFJ(float DFPLGEDMECK)
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
			[Cpp2IlInjected.Address(RVA = "0x5145440", Offset = "0x5144640", VA = "0x185145440")]
			get
			{
				return default(BlendLocationRange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Sprite Sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5145620", Offset = "0x5144820", VA = "0x185145620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5145270", Offset = "0x5144470", VA = "0x185145270")]
		private static AnimationCurve LBPMJDGEGMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD5FE50", Offset = "0xD5F050", VA = "0x180D5FE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5146300", Offset = "0x5145500", VA = "0x185146300")]
		public ARMouthPose()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51468B0", Offset = "0x5145AB0", VA = "0x1851468B0")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5146580", Offset = "0x5145780", VA = "0x185146580")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
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

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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
