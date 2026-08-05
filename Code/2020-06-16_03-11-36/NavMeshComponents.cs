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
			[Cpp2IlInjected.Address(RVA = "0x3AB310", Offset = "0x3A9910", VA = "0x1803AB310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BA50", Offset = "0x2D8A050", VA = "0x182D8BA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 startPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x572560", Offset = "0x570B60", VA = "0x180572560")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BB50", Offset = "0x2D8A150", VA = "0x182D8BB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 endPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9965C0", VA = "0x180997FC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BB10", Offset = "0x2D8A110", VA = "0x182D8BB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float width
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41D600", Offset = "0x41BC00", VA = "0x18041D600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BB90", Offset = "0x2D8A190", VA = "0x182D8BB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int costModifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x446FE0", Offset = "0x4455E0", VA = "0x180446FE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BAE0", Offset = "0x2D8A0E0", VA = "0x182D8BAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool bidirectional
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x617950", Offset = "0x615F50", VA = "0x180617950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BAB0", Offset = "0x2D8A0B0", VA = "0x182D8BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool autoUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x617940", Offset = "0x615F40", VA = "0x180617940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2D8B560", Offset = "0x2D89B60", VA = "0x182D8B560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3A08B0", Offset = "0x39EEB0", VA = "0x1803A08B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BA80", Offset = "0x2D8A080", VA = "0x182D8BA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B3B0", Offset = "0x2D899B0", VA = "0x182D8B3B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B350", Offset = "0x2D89950", VA = "0x182D8B350")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B320", Offset = "0x2D89920", VA = "0x182D8B320")]
		public void UpdateLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B080", Offset = "0x2D89680", VA = "0x182D8B080")]
		private static void AddTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B430", Offset = "0x2D89A30", VA = "0x182D8B430")]
		private static void RemoveTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B560", Offset = "0x2D89B60", VA = "0x182D8B560")]
		private void SetAutoUpdate(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AE60", Offset = "0x2D89460", VA = "0x182D8AE60")]
		private void AddLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B1E0", Offset = "0x2D897E0", VA = "0x182D8B1E0")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B320", Offset = "0x2D89920", VA = "0x182D8B320")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B600", Offset = "0x2D89C00", VA = "0x182D8B600")]
		private static void UpdateTrackedInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B930", Offset = "0x2D89F30", VA = "0x182D8B930")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E2AE0", Offset = "0x4E10E0", VA = "0x1804E2AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x4E2B50", Offset = "0x4E1150", VA = "0x1804E2B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3AB440", Offset = "0x3A9A40", VA = "0x1803AB440")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3AB320", Offset = "0x3A9920", VA = "0x1803AB320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ignoreFromBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3E38E0", Offset = "0x3E1EE0", VA = "0x1803E38E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3E38F0", Offset = "0x3E1EF0", VA = "0x1803E38F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static List<NavMeshModifier> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2D8C2F0", Offset = "0x2D8A8F0", VA = "0x182D8C2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C110", Offset = "0x2D8A710", VA = "0x182D8C110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C090", Offset = "0x2D8A690", VA = "0x182D8C090")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BFE0", Offset = "0x2D8A5E0", VA = "0x182D8BFE0")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C240", Offset = "0x2D8A840", VA = "0x182D8C240")]
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
			[Cpp2IlInjected.Address(RVA = "0xAF5B80", Offset = "0xAF4180", VA = "0x180AF5B80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xFCDFE0", Offset = "0xFCC5E0", VA = "0x180FCDFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BFB0", Offset = "0x2D8A5B0", VA = "0x182D8BFB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BFD0", Offset = "0x2D8A5D0", VA = "0x182D8BFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x390F60", Offset = "0x38F560", VA = "0x180390F60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3AE0C0", Offset = "0x3AC6C0", VA = "0x1803AE0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static List<NavMeshModifierVolume> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BF50", Offset = "0x2D8A550", VA = "0x182D8BF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BCF0", Offset = "0x2D8A2F0", VA = "0x182D8BCF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BC70", Offset = "0x2D8A270", VA = "0x182D8BC70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BBC0", Offset = "0x2D8A1C0", VA = "0x182D8BBC0")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BE20", Offset = "0x2D8A420", VA = "0x182D8BE20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AB310", Offset = "0x3A9910", VA = "0x1803AB310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3AB430", Offset = "0x3A9A30", VA = "0x1803AB430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CollectObjects collectObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x3AB440", Offset = "0x3A9A40", VA = "0x1803AB440")]
			get
			{
				return default(CollectObjects);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3AB320", Offset = "0x3A9920", VA = "0x1803AB320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x46C430", Offset = "0x46AA30", VA = "0x18046C430")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x46C450", Offset = "0x46AA50", VA = "0x18046C450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x91A620", Offset = "0x918C20", VA = "0x18091A620")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x91A730", Offset = "0x918D30", VA = "0x18091A730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LayerMask layerMask
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x446FE0", Offset = "0x4455E0", VA = "0x180446FE0")]
			get
			{
				return default(LayerMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x446770", Offset = "0x444D70", VA = "0x180446770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NavMeshCollectGeometry useGeometry
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4293F0", Offset = "0x4279F0", VA = "0x1804293F0")]
			get
			{
				return default(NavMeshCollectGeometry);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x446780", Offset = "0x444D80", VA = "0x180446780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int defaultArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3A08B0", Offset = "0x39EEB0", VA = "0x1803A08B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x812D10", Offset = "0x811310", VA = "0x180812D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ignoreNavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xC5DD30", Offset = "0xC5C330", VA = "0x180C5DD30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xC5DF70", Offset = "0xC5C570", VA = "0x180C5DF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ignoreNavMeshObstacle
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB02130", Offset = "0xB00730", VA = "0x180B02130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1B1BA10", Offset = "0x1B1A010", VA = "0x181B1BA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool overrideTileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2D622F0", Offset = "0x2D608F0", VA = "0x182D622F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2D62300", Offset = "0x2D60900", VA = "0x182D62300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int tileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4A0C00", Offset = "0x49F200", VA = "0x1804A0C00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6506B0", Offset = "0x64ECB0", VA = "0x1806506B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool overrideVoxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5F1180", Offset = "0x5EF780", VA = "0x1805F1180")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x75D630", Offset = "0x75BC30", VA = "0x18075D630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float voxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x46C2B0", Offset = "0x46A8B0", VA = "0x18046C2B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2D902B0", Offset = "0x2D8E8B0", VA = "0x182D902B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool buildHeightMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4AEA70", Offset = "0x4AD070", VA = "0x1804AEA70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4ADF90", Offset = "0x4AC590", VA = "0x1804ADF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NavMeshData navMeshData
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x395370", Offset = "0x393970", VA = "0x180395370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3B4890", Offset = "0x3B2E90", VA = "0x1803B4890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static List<NavMeshSurface> activeSurfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2D90250", Offset = "0x2D8E850", VA = "0x182D90250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F680", Offset = "0x2D8DC80", VA = "0x182D8F680")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F500", Offset = "0x2D8DB00", VA = "0x182D8F500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C670", Offset = "0x2D8AC70", VA = "0x182D8C670")]
		public static void AddNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FA40", Offset = "0x2D8E040", VA = "0x182D8FA40")]
		public static void RemoveNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DDB0", Offset = "0x2D8C3B0", VA = "0x182D8DDB0")]
		public static void CollectNavMeshSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E920", Offset = "0x2D8CF20", VA = "0x182D8E920")]
		private static NavMeshBuildSource GetBuildSourceForCollider(Collider collider)
		{
			return default(NavMeshBuildSource);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EE20", Offset = "0x2D8D420", VA = "0x182D8EE20")]
		private static NavMeshBuildSourceShape GetBuildSourceShapeForCollider(Collider collider)
		{
			return default(NavMeshBuildSourceShape);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C4E0", Offset = "0x2D8AAE0", VA = "0x182D8C4E0")]
		public void AddData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FA20", Offset = "0x2D8E020", VA = "0x182D8FA20")]
		public void RemoveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E790", Offset = "0x2D8CD90", VA = "0x182D8E790")]
		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CFC0", Offset = "0x2D8B5C0", VA = "0x182D8CFC0")]
		public void BuildNavMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FE80", Offset = "0x2D8E480", VA = "0x182D8FE80")]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C410", Offset = "0x2D8AA10", VA = "0x182D8C410")]
		public void AddAsyncGeneratedNavMeshData(NavMeshData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F870", Offset = "0x2D8DE70", VA = "0x182D8F870")]
		private static void Register(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FB10", Offset = "0x2D8E110", VA = "0x182D8FB10")]
		private static void Unregister(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FC40", Offset = "0x2D8E240", VA = "0x182D8FC40")]
		private static void UpdateActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C930", Offset = "0x2D8AF30", VA = "0x182D8C930")]
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DF60", Offset = "0x2D8C560", VA = "0x182D8DF60")]
		private List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C350", Offset = "0x2D8A950", VA = "0x182D8C350")]
		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EF30", Offset = "0x2D8D530", VA = "0x182D8EF30")]
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D310", Offset = "0x2D8B910", VA = "0x182D8D310")]
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F3C0", Offset = "0x2D8D9C0", VA = "0x182D8F3C0")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FD20", Offset = "0x2D8E320", VA = "0x182D8FD20")]
		private void UpdateDataIfTransformChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D90120", Offset = "0x2D8E720", VA = "0x182D90120")]
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
