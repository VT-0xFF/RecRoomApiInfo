using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Vector3 m_StartPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private Vector3 m_EndPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float m_Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private int m_CostModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool m_Bidirectional;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool m_AutoUpdatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private NavMeshLinkInstance m_LinkInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<NavMeshLink> s_Tracked;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x439DB0", Offset = "0x4387B0", VA = "0x180439DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x30E6010", Offset = "0x30E4A10", VA = "0x1830E6010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 startPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x455380", Offset = "0x453D80", VA = "0x180455380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x30E6110", Offset = "0x30E4B10", VA = "0x1830E6110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 endPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7C0", Offset = "0x9EA1C0", VA = "0x1809EB7C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x30E60D0", Offset = "0x30E4AD0", VA = "0x1830E60D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float width
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x58FC40", Offset = "0x58E640", VA = "0x18058FC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x30E6150", Offset = "0x30E4B50", VA = "0x1830E6150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int costModifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x451D80", Offset = "0x450780", VA = "0x180451D80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x30E60A0", Offset = "0x30E4AA0", VA = "0x1830E60A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool bidirectional
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6EC0", Offset = "0x7B58C0", VA = "0x1807B6EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x30E6070", Offset = "0x30E4A70", VA = "0x1830E6070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool autoUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x945350", Offset = "0x943D50", VA = "0x180945350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x30E5B40", Offset = "0x30E4540", VA = "0x1830E5B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AB0", Offset = "0x3C54B0", VA = "0x1803C6AB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x30E6040", Offset = "0x30E4A40", VA = "0x1830E6040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x30E59A0", Offset = "0x30E43A0", VA = "0x1830E59A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x30E5940", Offset = "0x30E4340", VA = "0x1830E5940")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x30E5910", Offset = "0x30E4310", VA = "0x1830E5910")]
		public void UpdateLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x30E5680", Offset = "0x30E4080", VA = "0x1830E5680")]
		private static void AddTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30E5A20", Offset = "0x30E4420", VA = "0x1830E5A20")]
		private static void RemoveTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x30E5B40", Offset = "0x30E4540", VA = "0x1830E5B40")]
		private void SetAutoUpdate(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x30E5460", Offset = "0x30E3E60", VA = "0x1830E5460")]
		private void AddLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x30E57D0", Offset = "0x30E41D0", VA = "0x1830E57D0")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x30E5910", Offset = "0x30E4310", VA = "0x1830E5910")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30E5BE0", Offset = "0x30E45E0", VA = "0x1830E5BE0")]
		private static void UpdateTrackedInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x30E5EF0", Offset = "0x30E48F0", VA = "0x1830E5EF0")]
		public NavMeshLink()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private bool m_OverrideArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private bool m_IgnoreFromBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly List<NavMeshModifier> s_NavMeshModifiers;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool overrideArea
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x43B190", Offset = "0x439B90", VA = "0x18043B190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x43B550", Offset = "0x439F50", VA = "0x18043B550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x45FDC0", Offset = "0x45E7C0", VA = "0x18045FDC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x45FDF0", Offset = "0x45E7F0", VA = "0x18045FDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ignoreFromBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x43FB20", Offset = "0x43E520", VA = "0x18043FB20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x454F00", Offset = "0x453900", VA = "0x180454F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static List<NavMeshModifier> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x30E6870", Offset = "0x30E5270", VA = "0x1830E6870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x30E6690", Offset = "0x30E5090", VA = "0x1830E6690")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30E6610", Offset = "0x30E5010", VA = "0x1830E6610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x30E6560", Offset = "0x30E4F60", VA = "0x1830E6560")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x30E67C0", Offset = "0x30E51C0", VA = "0x1830E67C0")]
		public NavMeshModifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7C47E0", Offset = "0x7C31E0", VA = "0x1807C47E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4820", Offset = "0x7C3220", VA = "0x1807C4820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4050", Offset = "0x7C2A50", VA = "0x1807C4050")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C4800", Offset = "0x7C3200", VA = "0x1807C4800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3B4E50", Offset = "0x3B3850", VA = "0x1803B4E50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x479060", Offset = "0x477A60", VA = "0x180479060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static List<NavMeshModifierVolume> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x30E6500", Offset = "0x30E4F00", VA = "0x1830E6500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x30E62B0", Offset = "0x30E4CB0", VA = "0x1830E62B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30E6230", Offset = "0x30E4C30", VA = "0x1830E6230")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x30E6180", Offset = "0x30E4B80", VA = "0x1830E6180")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x30E63E0", Offset = "0x30E4DE0", VA = "0x1830E63E0")]
		public NavMeshModifierVolume()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum CollectObjects
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Volume,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Children
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[ExecuteAlways]
	[DefaultExecutionOrder(-102)]
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private CollectObjects m_CollectObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private LayerMask m_LayerMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private int m_DefaultArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private bool m_IgnoreNavMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private bool m_IgnoreNavMeshObstacle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private bool m_OverrideTileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private int m_TileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private bool m_OverrideVoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float m_VoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private bool m_BuildHeightMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[FormerlySerializedAs("m_BakedNavMeshData")]
		private NavMeshData m_NavMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NavMeshDataInstance m_NavMeshDataInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly List<NavMeshSurface> s_NavMeshSurfaces;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<GameObject, NavMeshBuildSource[]> objectsToNavMeshBuildSources;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x439DB0", Offset = "0x4387B0", VA = "0x180439DB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x449A70", Offset = "0x448470", VA = "0x180449A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CollectObjects collectObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x45FDC0", Offset = "0x45E7C0", VA = "0x18045FDC0")]
			get
			{
				return default(CollectObjects);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x45FDF0", Offset = "0x45E7F0", VA = "0x18045FDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6CCAE0", Offset = "0x6CB4E0", VA = "0x1806CCAE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6CCA80", Offset = "0x6CB480", VA = "0x1806CCA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA54570", Offset = "0xA52F70", VA = "0x180A54570")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA54680", Offset = "0xA53080", VA = "0x180A54680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LayerMask layerMask
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x451D80", Offset = "0x450780", VA = "0x180451D80")]
			get
			{
				return default(LayerMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x519320", Offset = "0x517D20", VA = "0x180519320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NavMeshCollectGeometry useGeometry
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D30D0", Offset = "0x3D1AD0", VA = "0x1803D30D0")]
			get
			{
				return default(NavMeshCollectGeometry);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x519480", Offset = "0x517E80", VA = "0x180519480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int defaultArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C6AB0", Offset = "0x3C54B0", VA = "0x1803C6AB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43A390", Offset = "0x438D90", VA = "0x18043A390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ignoreNavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAABAC0", Offset = "0xAAA4C0", VA = "0x180AABAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAABAF0", Offset = "0xAAA4F0", VA = "0x180AABAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ignoreNavMeshObstacle
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB880C0", Offset = "0xB86AC0", VA = "0x180B880C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xBCE2E0", Offset = "0xBCCCE0", VA = "0x180BCE2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool overrideTileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xFD6850", Offset = "0xFD5250", VA = "0x180FD6850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xFD6950", Offset = "0xFD5350", VA = "0x180FD6950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int tileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x43A3E0", Offset = "0x438DE0", VA = "0x18043A3E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x43A3B0", Offset = "0x438DB0", VA = "0x18043A3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool overrideVoxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x647D50", Offset = "0x646750", VA = "0x180647D50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x647D40", Offset = "0x646740", VA = "0x180647D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float voxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A2FD0", Offset = "0x6A19D0", VA = "0x1806A2FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC2AFC0", Offset = "0xC299C0", VA = "0x180C2AFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool buildHeightMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4FC120", Offset = "0x4FAB20", VA = "0x1804FC120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4FB300", Offset = "0x4F9D00", VA = "0x1804FB300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NavMeshData navMeshData
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3B9C40", Offset = "0x3B8640", VA = "0x1803B9C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3C7A70", Offset = "0x3C6470", VA = "0x1803C7A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static List<NavMeshSurface> activeSurfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x30EA710", Offset = "0x30E9110", VA = "0x1830EA710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x30E9B80", Offset = "0x30E8580", VA = "0x1830E9B80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x30E9A10", Offset = "0x30E8410", VA = "0x1830E9A10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x30E6BF0", Offset = "0x30E55F0", VA = "0x1830E6BF0")]
		public static void AddNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x30E9F20", Offset = "0x30E8920", VA = "0x1830E9F20")]
		public static void RemoveNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x30E8300", Offset = "0x30E6D00", VA = "0x1830E8300")]
		public static void CollectNavMeshSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x30E8E30", Offset = "0x30E7830", VA = "0x1830E8E30")]
		private static NavMeshBuildSource GetBuildSourceForCollider(Collider collider)
		{
			return default(NavMeshBuildSource);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x30E9330", Offset = "0x30E7D30", VA = "0x1830E9330")]
		private static NavMeshBuildSourceShape GetBuildSourceShapeForCollider(Collider collider)
		{
			return default(NavMeshBuildSourceShape);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x30E6A60", Offset = "0x30E5460", VA = "0x1830E6A60")]
		public void AddData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30E9F00", Offset = "0x30E8900", VA = "0x1830E9F00")]
		public void RemoveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30E8CA0", Offset = "0x30E76A0", VA = "0x1830E8CA0")]
		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x30E7520", Offset = "0x30E5F20", VA = "0x1830E7520")]
		public void BuildNavMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x30EA340", Offset = "0x30E8D40", VA = "0x1830EA340")]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x30E6990", Offset = "0x30E5390", VA = "0x1830E6990")]
		public void AddAsyncGeneratedNavMeshData(NavMeshData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x30E9D60", Offset = "0x30E8760", VA = "0x1830E9D60")]
		private static void Register(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x30E9FF0", Offset = "0x30E89F0", VA = "0x1830E9FF0")]
		private static void Unregister(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x30EA110", Offset = "0x30E8B10", VA = "0x1830EA110")]
		private static void UpdateActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x30E6EB0", Offset = "0x30E58B0", VA = "0x1830E6EB0")]
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x30E8490", Offset = "0x30E6E90", VA = "0x1830E8490")]
		private List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x30E68D0", Offset = "0x30E52D0", VA = "0x1830E68D0")]
		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x30E9440", Offset = "0x30E7E40", VA = "0x1830E9440")]
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x30E7870", Offset = "0x30E6270", VA = "0x1830E7870")]
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x30E98D0", Offset = "0x30E82D0", VA = "0x1830E98D0")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x30EA1E0", Offset = "0x30E8BE0", VA = "0x1830EA1E0")]
		private void UpdateDataIfTransformChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x30EA5E0", Offset = "0x30E8FE0", VA = "0x1830EA5E0")]
		public NavMeshSurface()
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
