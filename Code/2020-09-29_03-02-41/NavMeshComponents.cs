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
			[Cpp2IlInjected.Address(RVA = "0x4170B0", Offset = "0x4164B0", VA = "0x1804170B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCCD0", Offset = "0x2FFC0D0", VA = "0x182FFCCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 startPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x452460", Offset = "0x451860", VA = "0x180452460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCDD0", Offset = "0x2FFC1D0", VA = "0x182FFCDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 endPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xEA6880", Offset = "0xEA5C80", VA = "0x180EA6880")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCD90", Offset = "0x2FFC190", VA = "0x182FFCD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float width
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41E510", Offset = "0x41D910", VA = "0x18041E510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCE10", Offset = "0x2FFC210", VA = "0x182FFCE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int costModifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4120D0", Offset = "0x4114D0", VA = "0x1804120D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCD60", Offset = "0x2FFC160", VA = "0x182FFCD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool bidirectional
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x63F410", Offset = "0x63E810", VA = "0x18063F410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCD30", Offset = "0x2FFC130", VA = "0x182FFCD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool autoUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7B3060", Offset = "0x7B2460", VA = "0x1807B3060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2FFC800", Offset = "0x2FFBC00", VA = "0x182FFC800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3C1990", Offset = "0x3C0D90", VA = "0x1803C1990")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2FFCD00", Offset = "0x2FFC100", VA = "0x182FFCD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC660", Offset = "0x2FFBA60", VA = "0x182FFC660")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC600", Offset = "0x2FFBA00", VA = "0x182FFC600")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC5D0", Offset = "0x2FFB9D0", VA = "0x182FFC5D0")]
		public void UpdateLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC340", Offset = "0x2FFB740", VA = "0x182FFC340")]
		private static void AddTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC6E0", Offset = "0x2FFBAE0", VA = "0x182FFC6E0")]
		private static void RemoveTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC800", Offset = "0x2FFBC00", VA = "0x182FFC800")]
		private void SetAutoUpdate(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC120", Offset = "0x2FFB520", VA = "0x182FFC120")]
		private void AddLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC490", Offset = "0x2FFB890", VA = "0x182FFC490")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC5D0", Offset = "0x2FFB9D0", VA = "0x182FFC5D0")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC8A0", Offset = "0x2FFBCA0", VA = "0x182FFC8A0")]
		private static void UpdateTrackedInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2FFCBB0", Offset = "0x2FFBFB0", VA = "0x182FFCBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x417DC0", Offset = "0x4171C0", VA = "0x180417DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x417DB0", Offset = "0x4171B0", VA = "0x180417DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x45DD40", Offset = "0x45D140", VA = "0x18045DD40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x45DD60", Offset = "0x45D160", VA = "0x18045DD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ignoreFromBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x451D00", Offset = "0x451100", VA = "0x180451D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x451ED0", Offset = "0x4512D0", VA = "0x180451ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static List<NavMeshModifier> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2FFD530", Offset = "0x2FFC930", VA = "0x182FFD530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD350", Offset = "0x2FFC750", VA = "0x182FFD350")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD2D0", Offset = "0x2FFC6D0", VA = "0x182FFD2D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD220", Offset = "0x2FFC620", VA = "0x182FFD220")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD480", Offset = "0x2FFC880", VA = "0x182FFD480")]
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
			[Cpp2IlInjected.Address(RVA = "0x64E1A0", Offset = "0x64D5A0", VA = "0x18064E1A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x64E1E0", Offset = "0x64D5E0", VA = "0x18064E1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x64DA10", Offset = "0x64CE10", VA = "0x18064DA10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64E1C0", Offset = "0x64D5C0", VA = "0x18064E1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3B18D0", Offset = "0x3B0CD0", VA = "0x1803B18D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x424DF0", Offset = "0x4241F0", VA = "0x180424DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static List<NavMeshModifierVolume> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2FFD1C0", Offset = "0x2FFC5C0", VA = "0x182FFD1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2FFCF70", Offset = "0x2FFC370", VA = "0x182FFCF70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2FFCEF0", Offset = "0x2FFC2F0", VA = "0x182FFCEF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2FFCE40", Offset = "0x2FFC240", VA = "0x182FFCE40")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD0A0", Offset = "0x2FFC4A0", VA = "0x182FFD0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4170B0", Offset = "0x4164B0", VA = "0x1804170B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x417D20", Offset = "0x417120", VA = "0x180417D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CollectObjects collectObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x45DD40", Offset = "0x45D140", VA = "0x18045DD40")]
			get
			{
				return default(CollectObjects);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x45DD60", Offset = "0x45D160", VA = "0x18045DD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x516BF0", Offset = "0x515FF0", VA = "0x180516BF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x516B80", Offset = "0x515F80", VA = "0x180516B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA505A0", Offset = "0xA4F9A0", VA = "0x180A505A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA506B0", Offset = "0xA4FAB0", VA = "0x180A506B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LayerMask layerMask
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4120D0", Offset = "0x4114D0", VA = "0x1804120D0")]
			get
			{
				return default(LayerMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5FB400", Offset = "0x5FA800", VA = "0x1805FB400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NavMeshCollectGeometry useGeometry
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x439AB0", Offset = "0x438EB0", VA = "0x180439AB0")]
			get
			{
				return default(NavMeshCollectGeometry);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5FB560", Offset = "0x5FA960", VA = "0x1805FB560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int defaultArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C1990", Offset = "0x3C0D90", VA = "0x1803C1990")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4999D0", Offset = "0x498DD0", VA = "0x1804999D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ignoreNavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACE2A0", Offset = "0xACD6A0", VA = "0x180ACE2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xACE3E0", Offset = "0xACD7E0", VA = "0x180ACE3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ignoreNavMeshObstacle
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xACE400", Offset = "0xACD800", VA = "0x180ACE400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xACE500", Offset = "0xACD900", VA = "0x180ACE500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool overrideTileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1769280", Offset = "0x1768680", VA = "0x181769280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2FE3E80", Offset = "0x2FE3280", VA = "0x182FE3E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int tileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x42AEC0", Offset = "0x42A2C0", VA = "0x18042AEC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x45A8C0", Offset = "0x459CC0", VA = "0x18045A8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool overrideVoxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA2ACF0", Offset = "0xA2A0F0", VA = "0x180A2ACF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7FB630", Offset = "0x7FAA30", VA = "0x1807FB630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float voxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6169F0", Offset = "0x615DF0", VA = "0x1806169F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3001430", Offset = "0x3000830", VA = "0x183001430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool buildHeightMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4B3C90", Offset = "0x4B3090", VA = "0x1804B3C90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4B3140", Offset = "0x4B2540", VA = "0x1804B3140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NavMeshData navMeshData
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3B6560", Offset = "0x3B5960", VA = "0x1803B6560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x40B8B0", Offset = "0x40ACB0", VA = "0x18040B8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static List<NavMeshSurface> activeSurfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x30013D0", Offset = "0x30007D0", VA = "0x1830013D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3000840", Offset = "0x2FFFC40", VA = "0x183000840")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x30006D0", Offset = "0x2FFFAD0", VA = "0x1830006D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD8B0", Offset = "0x2FFCCB0", VA = "0x182FFD8B0")]
		public static void AddNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3000BE0", Offset = "0x2FFFFE0", VA = "0x183000BE0")]
		public static void RemoveNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2FFEFC0", Offset = "0x2FFE3C0", VA = "0x182FFEFC0")]
		public static void CollectNavMeshSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2FFFAF0", Offset = "0x2FFEEF0", VA = "0x182FFFAF0")]
		private static NavMeshBuildSource GetBuildSourceForCollider(Collider collider)
		{
			return default(NavMeshBuildSource);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2FFFFF0", Offset = "0x2FFF3F0", VA = "0x182FFFFF0")]
		private static NavMeshBuildSourceShape GetBuildSourceShapeForCollider(Collider collider)
		{
			return default(NavMeshBuildSourceShape);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD720", Offset = "0x2FFCB20", VA = "0x182FFD720")]
		public void AddData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3000BC0", Offset = "0x2FFFFC0", VA = "0x183000BC0")]
		public void RemoveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2FFF960", Offset = "0x2FFED60", VA = "0x182FFF960")]
		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2FFE1E0", Offset = "0x2FFD5E0", VA = "0x182FFE1E0")]
		public void BuildNavMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3001000", Offset = "0x3000400", VA = "0x183001000")]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD650", Offset = "0x2FFCA50", VA = "0x182FFD650")]
		public void AddAsyncGeneratedNavMeshData(NavMeshData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3000A20", Offset = "0x2FFFE20", VA = "0x183000A20")]
		private static void Register(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3000CB0", Offset = "0x30000B0", VA = "0x183000CB0")]
		private static void Unregister(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3000DD0", Offset = "0x30001D0", VA = "0x183000DD0")]
		private static void UpdateActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2FFDB70", Offset = "0x2FFCF70", VA = "0x182FFDB70")]
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2FFF150", Offset = "0x2FFE550", VA = "0x182FFF150")]
		private List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD590", Offset = "0x2FFC990", VA = "0x182FFD590")]
		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3000100", Offset = "0x2FFF500", VA = "0x183000100")]
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2FFE530", Offset = "0x2FFD930", VA = "0x182FFE530")]
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3000590", Offset = "0x2FFF990", VA = "0x183000590")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3000EA0", Offset = "0x30002A0", VA = "0x183000EA0")]
		private void UpdateDataIfTransformChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x30012A0", Offset = "0x30006A0", VA = "0x1830012A0")]
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
