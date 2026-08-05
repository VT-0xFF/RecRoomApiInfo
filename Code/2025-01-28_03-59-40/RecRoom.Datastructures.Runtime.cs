using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71EC910", Offset = "0x71EBB10", VA = "0x1871EC910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OHJOCEHMOIF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	public OHJOCEHMOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, DOIPHNFBKJF, ADECOEAHAJC, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IBBAMBJMMGK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71EDCA0", Offset = "0x71ECEA0", VA = "0x1871EDCA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71EDC60", Offset = "0x71ECE60", VA = "0x1871EDC60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71EDCE0", Offset = "0x71ECEE0", VA = "0x1871EDCE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71EDE90", Offset = "0x71ED090", VA = "0x1871EDE90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71EDE00", Offset = "0x71ED000", VA = "0x1871EDE00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD59F40", Offset = "0xD59140", VA = "0x180D59F40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBCFDE0", Offset = "0xBCEFE0", VA = "0x180BCFDE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71EDC20", Offset = "0x71ECE20", VA = "0x1871EDC20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71EDD70", Offset = "0x71ECF70", VA = "0x1871EDD70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71ED6C0", Offset = "0x71EC8C0", VA = "0x1871ED6C0")]
	public void CopyBounds(SavedExtents JAINJPLCLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71EDB70", Offset = "0x71ECD70", VA = "0x1871EDB70")]
	public void SetLocalSpaceBounds(Bounds JIOPAONNJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11C9930", Offset = "0x11C8B30", VA = "0x1811C9930")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71EDAA0", Offset = "0x71ECCA0", VA = "0x1871EDAA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71ED6F0", Offset = "0x71EC8F0", VA = "0x1871ED6F0")]
	private void LJMAGNLCNGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71ED8A0", Offset = "0x71ECAA0", VA = "0x1871ED8A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71ED050", Offset = "0x71EC250", VA = "0x1871ED050")]
	public static void CalculateLocalBoundsFor(GameObject GBMEGJCINPI, [Out] Bounds JIOPAONNJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71EDAB0", Offset = "0x71ECCB0", VA = "0x1871EDAB0")]
	private static void PADGNGKIEDO(Bounds NHCGDJCFKIC, Color FDEJAKKFLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71EDB90", Offset = "0x71ECD90", VA = "0x1871EDB90")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1648860", Offset = "0x1647A60", VA = "0x181648860")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x514B380", Offset = "0x514A580", VA = "0x18514B380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public virtual void KKNPLPEELHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	[OHJOCEHMOIF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x514AEF0", Offset = "0x514A0F0", VA = "0x18514AEF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5149AC0", Offset = "0x5148CC0", VA = "0x185149AC0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x514B2A0", Offset = "0x514A4A0", VA = "0x18514B2A0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FOPDGPOHHPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FOPDGPOHHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x42F8140", Offset = "0x42F7340", VA = "0x1842F8140")]
		internal int KEALNABDMLN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[OHJOCEHMOIF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AD30", Offset = "0x3F69F30", VA = "0x183F6AD30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AD90", Offset = "0x3F69F90", VA = "0x183F6AD90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AC10", Offset = "0x3F69E10", VA = "0x183F6AC10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OFPBICPHALF]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3F6ACD0", Offset = "0x3F69ED0", VA = "0x183F6ACD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AAC0", Offset = "0x3F69CC0", VA = "0x183F6AAC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A760", Offset = "0x3F69960", VA = "0x183F6A760", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F69B20", Offset = "0x3F68D20", VA = "0x183F69B20", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F699F0", Offset = "0x3F68BF0", VA = "0x183F699F0", Slot = "14")]
	protected virtual string CCNBHPLALEC(TKeyVal LPECGLGCPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F69A20", Offset = "0x3F68C20", VA = "0x183F69A20", Slot = "4")]
	public bool ContainsKey(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A940", Offset = "0x3F69B40", VA = "0x183F6A940", Slot = "5")]
	public bool TryGetValue(TKey OFPBICPHALF, [Out] TVal OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F69A80", Offset = "0x3F68C80", VA = "0x183F69A80", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F69A80", Offset = "0x3F68C80", VA = "0x183F69A80", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3F6A9A0", Offset = "0x3F69BA0", VA = "0x183F6A9A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[OHJOCEHMOIF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x514CD30", Offset = "0x514BF30", VA = "0x18514CD30")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x514C570", Offset = "0x514B770", VA = "0x18514C570", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x514BB20", Offset = "0x514AD20", VA = "0x18514BB20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PINDDKBOBBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class GAIIAPLMABB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float OJKGGFPJAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T ELOFPHHKCIM;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GAIIAPLMABB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LEOIKDIHFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LEOIKDIHFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x49DE460", Offset = "0x49DD660", VA = "0x1849DE460")]
		internal bool DIAHDHCMEOL(GAIIAPLMABB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float GPFKAOBIAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float ENEEJALIHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<GAIIAPLMABB> MLFDEGEMIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IJCHBBENNEN<GAIIAPLMABB> HLAJAIJNLAH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EOMKPALDMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B780", Offset = "0x4F3A980", VA = "0x184F3B780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4F3BB80", Offset = "0x4F3AD80", VA = "0x184F3BB80")]
	public PINDDKBOBBL(float CNPANCHHJLN, float LIHAKDCNNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B9B0", Offset = "0x4F3ABB0", VA = "0x184F3B9B0")]
	public bool OFPABIMMILM(float EFKOIGNGJGD, T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3AE80", Offset = "0x4F3A080", VA = "0x184F3AE80")]
	public IEnumerable<T> DPALHJCPIJJ(float EFKOIGNGJGD, [Optional] float? CFHGEBKNPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F3ADD0", Offset = "0x4F39FD0", VA = "0x184F3ADD0")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4F3B560", Offset = "0x4F3A760", VA = "0x184F3B560")]
	private void EIHNGLBHAAI(float EFKOIGNGJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DJLBJECHNGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PPLNIHMMDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public T ELOFPHHKCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float ENHODIJEFJC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static float AFLCLIOMHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private List<T> JDJDFALELJI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const int LLAGODLKPBB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private PPLNIHMMDPL[] HCOCCGHLKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int LBBGELJELJB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float LGBDIFBHIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9F70", VA = "0x180AAAD70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAFC9B0", Offset = "0xAFBBB0", VA = "0x180AFC9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T DLELEKMDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x607AAA0", Offset = "0x6079CA0", VA = "0x18607AAA0")]
	public DJLBJECHNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x607A970", Offset = "0x6079B70", VA = "0x18607A970")]
	public DJLBJECHNGM(int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6079BF0", Offset = "0x6078DF0", VA = "0x186079BF0")]
	public void CKLHJOINNOK(float EFKOIGNGJGD, T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6079F90", Offset = "0x6079190", VA = "0x186079F90")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x607A340", Offset = "0x6079540", VA = "0x18607A340")]
	public bool LDEAMJGKKCC(float JBNMAIOGPDO, float OJBLECJIKID, [Out] T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6079800", Offset = "0x6078A00", VA = "0x186079800")]
	public bool BAIHKGCAFDM(float JBNMAIOGPDO, float OJBLECJIKID, [Out] T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x607A5E0", Offset = "0x60797E0", VA = "0x18607A5E0")]
	public void LJGMBONFCKN(float JBNMAIOGPDO, float OJBLECJIKID, List<T> HJDGEKDMIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6079E70", Offset = "0x6079070", VA = "0x186079E70")]
	private int DACCGKINFLB(int JDPEOHLFJMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x607A590", Offset = "0x6079790", VA = "0x18607A590")]
	private void LJCOIKIAEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIFBAHOCNHF();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LLNDLGHLHKF(T OMEFCJCOLII, float EBJDGDIMGBD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DHILLHKJBPM(T FBCBJPMNPEK, T HHDMEFHBCOI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OLJJAHBNPEM(T FBCBJPMNPEK, T HHDMEFHBCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FCMIMGLIGAE : DJLBJECHNGM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9039E0", Offset = "0x902BE0", VA = "0x1809039E0", Slot = "4")]
	protected override Vector3 LIFBAHOCNHF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71EB260", Offset = "0x71EA460", VA = "0x1871EB260", Slot = "5")]
	protected override Vector3 LLNDLGHLHKF(Vector3 OMEFCJCOLII, float EBJDGDIMGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71EB210", Offset = "0x71EA410", VA = "0x1871EB210", Slot = "6")]
	protected override Vector3 DHILLHKJBPM(Vector3 FBCBJPMNPEK, Vector3 HHDMEFHBCOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71EB2A0", Offset = "0x71EA4A0", VA = "0x1871EB2A0", Slot = "7")]
	protected override Vector3 OLJJAHBNPEM(Vector3 FBCBJPMNPEK, Vector3 HHDMEFHBCOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71EB320", Offset = "0x71EA520", VA = "0x1871EB320")]
	public FCMIMGLIGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NNNAFFLIMKO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x33F7860", Offset = "0x33F6A60", VA = "0x1833F7860")]
	public static OLFIBPOGDEP<T1, T2> LHPCDDMHIBB<T1, T2>(T1 LBKBAEDMNHA, T2 EKKDMDNHJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x33F7900", Offset = "0x33F6B00", VA = "0x1833F7900")]
	public static NIDBDMPBKFP<T1, T2, T3> LHPCDDMHIBB<T1, T2, T3>(T1 LBKBAEDMNHA, T2 EKKDMDNHJAK, T3 GNIPJALGGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4C551D0", Offset = "0x4C543D0", VA = "0x184C551D0")]
	internal static int BOJLABPENDB(int CJPHKHNDNOD, int OEDGOIIHEKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x650C5A0", Offset = "0x650B7A0", VA = "0x18650C5A0")]
	internal static int BOJLABPENDB(int CJPHKHNDNOD, int OEDGOIIHEKF, int PPOFLFCBGOA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OLFIBPOGDEP<T1, T2> : IComparable<OLFIBPOGDEP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T1 CNOIJOPAKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T2 CBBJLLJFKOD;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B350", Offset = "0x4E3A550", VA = "0x184E3B350")]
	public OLFIBPOGDEP(T1 LBKBAEDMNHA, T2 EKKDMDNHJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E39800", Offset = "0x4E38A00", VA = "0x184E39800", Slot = "4")]
	public int CompareTo(OLFIBPOGDEP<T1, T2> JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A3B0", Offset = "0x4E395B0", VA = "0x184E3A3B0", Slot = "0")]
	public override bool Equals(object JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A8D0", Offset = "0x4E39AD0", VA = "0x184E3A8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AF00", Offset = "0x4E3A100", VA = "0x184E3AF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NIDBDMPBKFP<T1, T2, T3> : IComparable<NIDBDMPBKFP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T1 CNOIJOPAKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T2 CBBJLLJFKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T3 JLNEKBMCLFL;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4C80070", Offset = "0x4C7F270", VA = "0x184C80070")]
	public NIDBDMPBKFP(T1 LBKBAEDMNHA, T2 EKKDMDNHJAK, T3 GNIPJALGGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F700", Offset = "0x4C7E900", VA = "0x184C7F700", Slot = "4")]
	public int CompareTo(NIDBDMPBKFP<T1, T2, T3> JAINJPLCLDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4C7FAD0", Offset = "0x4C7ECD0", VA = "0x184C7FAD0", Slot = "0")]
	public override bool Equals(object JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4C7FC80", Offset = "0x4C7EE80", VA = "0x184C7FC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C7FEC0", Offset = "0x4C7F0C0", VA = "0x184C7FEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AnimationCurve DAINCOGIBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T BKGLJCPOEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x10A1F60", Offset = "0x10A1160", VA = "0x1810A1F60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T DBFNDNMILBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28AA050", Offset = "0x28A9250", VA = "0x1828AA050")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28A9FA0", Offset = "0x28A91A0", VA = "0x1828A9FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float NDFBMJPEJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA2CD0", Offset = "0xAA1ED0", VA = "0x180AA2CD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x53A0A40", Offset = "0x539FC40", VA = "0x1853A0A40")]
	public T HLOPAIACMKF(float EBJDGDIMGBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x53A0650", Offset = "0x539F850", VA = "0x1853A0650")]
	public T HBAAIBJCKAI(float EBJDGDIMGBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CGEDJAKNDDD(T FBCBJPMNPEK, T HHDMEFHBCOI, float EBJDGDIMGBD);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71EB4F0", Offset = "0x71EA6F0", VA = "0x1871EB4F0", Slot = "4")]
	protected override float CGEDJAKNDDD(float FBCBJPMNPEK, float HHDMEFHBCOI, float EBJDGDIMGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71EB530", Offset = "0x71EA730", VA = "0x1871EB530")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x14C5590", Offset = "0x14C4790", VA = "0x1814C5590", Slot = "4")]
	protected override Vector3 CGEDJAKNDDD(Vector3 FBCBJPMNPEK, Vector3 HHDMEFHBCOI, float EBJDGDIMGBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71EECA0", Offset = "0x71EDEA0", VA = "0x1871EECA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71E9BA0", Offset = "0x71E8DA0", VA = "0x1871E9BA0", Slot = "4")]
	protected override Color CGEDJAKNDDD(Color FBCBJPMNPEK, Color HHDMEFHBCOI, float EBJDGDIMGBD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71E9C60", Offset = "0x71E8E60", VA = "0x1871E9C60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PCPEMHEOIOG : JGPGOGEPBFP<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71ECAC0", Offset = "0x71EBCC0", VA = "0x1871ECAC0")]
	public PCPEMHEOIOG(int EKPEFEBPGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71ECA50", Offset = "0x71EBC50", VA = "0x1871ECA50", Slot = "6")]
	protected override uint PEKMHAOMBKH(uint IBBAMBJMMGK, string OMEFCJCOLII)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EPOPLEOGEOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IDisposable CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public EPOPLEOGEOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CLNCFKIOCMF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FINGPCMFMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OFALHJFHPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int CAHNCMILOKE;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x43FA5F0", Offset = "0x43F97F0", VA = "0x1843FA5F0")]
	private CLNCFKIOCMF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PFJFPCLKCJA, int MPEAPIIGEBE, int JKNLDJANAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x58831D0", Offset = "0x58823D0", VA = "0x1858831D0")]
	public static CLNCFKIOCMF<T> PAJOIGLPBMN()
	{
		return default(CLNCFKIOCMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5882AB0", Offset = "0x5881CB0", VA = "0x185882AB0")]
	public (int, int, Task<T>) IAOMEFBNNKG(int NEKLIKCEFAN, [Optional] CancellationToken BGEKICMONBE, double KIPBHBAMJHE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x58834E0", Offset = "0x58826E0", VA = "0x1858834E0")]
	public void POKGFKBOBLE(int NEKLIKCEFAN, int JKNLDJANAJD, [In] T NJFLHCEDIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EPJKACAHODF
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x71EB0C0", Offset = "0x71EA2C0", VA = "0x1871EB0C0")]
	public static CLNCFKIOCMF<HEGEDEFNLEJ> PAJOIGLPBMN()
	{
		return default(CLNCFKIOCMF<HEGEDEFNLEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71EB110", Offset = "0x71EA310", VA = "0x1871EB110")]
	public static void POKGFKBOBLE([In] this CLNCFKIOCMF<HEGEDEFNLEJ> MLNFAKCEGNM, int NEKLIKCEFAN, int JKNLDJANAJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class HKDBNICBMGP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TVal> NMAINNKJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<TVal, TKey> MNGMPIHLGOE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NPIFBDLIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TKey> KEMNOMLLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x44E23C0", Offset = "0x44E15C0", VA = "0x1844E23C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICollection<TVal> CLGPBIGPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x44E2410", Offset = "0x44E1610", VA = "0x1844E2410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TVal FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x44E2360", Offset = "0x44E1560", VA = "0x1844E2360", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x44E2460", Offset = "0x44E1660", VA = "0x1844E2460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TKey FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x44E1E60", Offset = "0x44E1060", VA = "0x1844E1E60")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44E1880", Offset = "0x44E0A80", VA = "0x1844E1880", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44E2140", Offset = "0x44E1340", VA = "0x1844E2140", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44E1750", Offset = "0x44E0950", VA = "0x1844E1750", Slot = "9")]
	public void Add(TKey OFPBICPHALF, TVal OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44E17E0", Offset = "0x44E09E0", VA = "0x1844E17E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x44E1920", Offset = "0x44E0B20", VA = "0x1844E1920", Slot = "8")]
	public bool ContainsKey(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44E1970", Offset = "0x44E0B70", VA = "0x1844E1970", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x44E2080", Offset = "0x44E1280", VA = "0x1844E2080", Slot = "10")]
	public bool Remove(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x44E20C0", Offset = "0x44E12C0", VA = "0x1844E20C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44E21E0", Offset = "0x44E13E0", VA = "0x1844E21E0", Slot = "11")]
	public bool TryGetValue(TKey OFPBICPHALF, [Out] TVal OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44E1D60", Offset = "0x44E0F60", VA = "0x1844E1D60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44E19F0", Offset = "0x44E0BF0", VA = "0x1844E19F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HCOCCGHLKNN, int BKDPKOGEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44E1CA0", Offset = "0x44E0EA0", VA = "0x1844E1CA0")]
	public bool EKHOHBPCPIG(TVal OFPBICPHALF, [Out] TKey OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x44E1EC0", Offset = "0x44E10C0", VA = "0x1844E1EC0")]
	private void KFDOKLGDIDM(TKey OFPBICPHALF, TVal IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44E1590", Offset = "0x44E0790", VA = "0x1844E1590")]
	private void ALFHELBEPHE(TKey OFPBICPHALF, TVal IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44E1B80", Offset = "0x44E0D80", VA = "0x1844E1B80")]
	private bool DMNAJEFBKOC(TKey OFPBICPHALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x44E2240", Offset = "0x44E1440", VA = "0x1844E2240")]
	public HKDBNICBMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class IKGPMJOPCDF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IKGPMJOPCDF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1079EF0", Offset = "0x10790F0", VA = "0x181079EF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3FC29A0", Offset = "0x3FC1BA0", VA = "0x183FC29A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3BC0", Offset = "0x3FC2DC0", VA = "0x183FC3BC0")]
		public Enumerator(IKGPMJOPCDF<T> HJDGEKDMIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1E00", Offset = "0x3FC1000", VA = "0x183FC1E00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3FC28C0", Offset = "0x3FC1AC0", VA = "0x183FC28C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3FC15A0", Offset = "0x3FC07A0", VA = "0x183FC15A0")]
		private void CFENNHOFFOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T[] ACLAAGJGPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int EINJGMILBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int OIOHBDOPJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LNKNPHKNIOF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x464D6D0", Offset = "0x464C8D0", VA = "0x18464D6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x464D2B0", Offset = "0x464C4B0", VA = "0x18464D2B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x464D460", Offset = "0x464C660", VA = "0x18464D460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x464DAC0", Offset = "0x464CCC0", VA = "0x18464DAC0")]
	public IKGPMJOPCDF(int EKPEFEBPGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x464C340", Offset = "0x464B540", VA = "0x18464C340")]
	public void CKLHJOINNOK(T EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x464C640", Offset = "0x464B840", VA = "0x18464C640")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x464D710", Offset = "0x464C910", VA = "0x18464D710")]
	public void OCIGCOEACNP(int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x464CBF0", Offset = "0x464BDF0", VA = "0x18464CBF0")]
	public void JIEDMHOMGFJ(T[] HCOCCGHLKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x464C660", Offset = "0x464B860", VA = "0x18464C660")]
	public Enumerator EMKBHPPGLAN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x464D8A0", Offset = "0x464CAA0", VA = "0x18464D8A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x464D8A0", Offset = "0x464CAA0", VA = "0x18464D8A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x464BDF0", Offset = "0x464AFF0", VA = "0x18464BDF0")]
	private int AOFELAAIALD(int CPLNODNGKGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x464C770", Offset = "0x464B970", VA = "0x18464C770")]
	private int HJAMDLAAMEI(int CPLNODNGKGB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EDPGFCJPADC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> IKPBCIPMKDB(TRequest JLBJPEIMAMB, CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum IBKAEEJMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class OHNOJOAPIFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const float KHMADPMMIMP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TimeSpan BENHGGCABHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int AMNHDDGGMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IBKAEEJMDFH HPOBOPEGHPO;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly OHNOJOAPIFM MIAJNEPFAEF;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float OAJABMLCFDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4DBE4B0", Offset = "0x4DBD6B0", VA = "0x184DBE4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public TimeSpan MFFDLCOFOIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4DBE590", Offset = "0x4DBD790", VA = "0x184DBE590")]
		public OHNOJOAPIFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct GFGBDJAKHCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly TRequest JLBJPEIMAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly CancellationToken BGEKICMONBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly TaskCompletionSource<TResult> KMMCBIMAJCM;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x43F0D50", Offset = "0x43EFF50", VA = "0x1843F0D50")]
		public GFGBDJAKHCE(TRequest JLBJPEIMAMB, TaskCompletionSource<TResult> KMMCBIMAJCM, CancellationToken BGEKICMONBE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct ENNFMBEPGPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EDPGFCJPADC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F287F0", Offset = "0x3F279F0", VA = "0x183F287F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F28C50", Offset = "0x3F27E50", VA = "0x183F28C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct GHBKJPBHKLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EDPGFCJPADC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private GFGBDJAKHCE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4438E40", Offset = "0x4438040", VA = "0x184438E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x443A130", Offset = "0x4439330", VA = "0x18443A130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CancellationTokenSource ONCPFHJGBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<GFGBDJAKHCE> DDEDCNDBAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OHNOJOAPIFM PLLFOLDIBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly IKPBCIPMKDB PFFMIEFIEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Task NMJAJJDNOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int OOLFKNJCEAM;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2A00", Offset = "0x3EF1C00", VA = "0x183EF2A00")]
	public EDPGFCJPADC(IKPBCIPMKDB PFFMIEFIEPP, [Optional] OHNOJOAPIFM PLLFOLDIBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0EE0", Offset = "0x3EF00E0", VA = "0x183EF0EE0")]
	public Task<TResult> CMBOGEBIIOP(TRequest JLBJPEIMAMB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2460", Offset = "0x3EF1660", VA = "0x183EF2460")]
	private void LKOFCABJIEB(GFGBDJAKHCE HNLLCLEDGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1670", Offset = "0x3EF0870", VA = "0x183EF1670")]
	[AsyncStateMachine(typeof(EDPGFCJPADC<, >.ENNFMBEPGPO))]
	private Task IDMKDFJMFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1BC0", Offset = "0x3EF0DC0", VA = "0x183EF1BC0")]
	private GFGBDJAKHCE LIPFFKCEDBL()
	{
		return default(GFGBDJAKHCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1AD0", Offset = "0x3EF0CD0", VA = "0x183EF1AD0")]
	[AsyncStateMachine(typeof(EDPGFCJPADC<, >.GHBKJPBHKLE))]
	private Task KLMBNEJFBLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1330", Offset = "0x3EF0530", VA = "0x183EF1330")]
	private void DGEKMFLMKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1630", Offset = "0x3EF0830", VA = "0x183EF1630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EIHKNNAJBLF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly List<T> AFNGOKKOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HashSet<T> BENHDGBCKCO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NPIFBDLIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T FJMFIOCLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x32BFBC0", Offset = "0x32BEDC0", VA = "0x1832BFBC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F18110", Offset = "0x3F17310", VA = "0x183F18110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3F17480", Offset = "0x3F16680", VA = "0x183F17480", Slot = "11")]
	public void Add(T OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3F17710", Offset = "0x3F16910", VA = "0x183F17710")]
	public bool DHIPFGPMMGA(T OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3F17EF0", Offset = "0x3F170F0", VA = "0x183F17EF0", Slot = "15")]
	public bool Remove(T OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3F17810", Offset = "0x3F16A10", VA = "0x183F17810", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3F17FB0", Offset = "0x3F171B0", VA = "0x183F17FB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3F174C0", Offset = "0x3F166C0", VA = "0x183F174C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F17560", Offset = "0x3F16760", VA = "0x183F17560", Slot = "13")]
	public bool Contains(T OCLIEIADJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3F175B0", Offset = "0x3F167B0", VA = "0x183F175B0", Slot = "14")]
	public void CopyTo(T[] HCOCCGHLKNN, int BKDPKOGEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3F178A0", Offset = "0x3F16AA0", VA = "0x183F178A0", Slot = "6")]
	public int IndexOf(T OCLIEIADJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3F17A50", Offset = "0x3F16C50", VA = "0x183F17A50", Slot = "7")]
	public void Insert(int CPLNODNGKGB, T OCLIEIADJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3F17B90", Offset = "0x3F16D90", VA = "0x183F17B90", Slot = "8")]
	public void RemoveAt(int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3F17FF0", Offset = "0x3F171F0", VA = "0x183F17FF0")]
	public EIHKNNAJBLF()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x271D120", Offset = "0x271C320", VA = "0x18271D120")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x71EE230", Offset = "0x71ED430", VA = "0x1871EE230")]
		public SerializedGuid([In] Guid IBPGMNEANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x71EDF20", Offset = "0x71ED120", VA = "0x1871EDF20")]
		public static SerializedGuid ADBICMLDKMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x71EE0B0", Offset = "0x71ED2B0", VA = "0x1871EE0B0")]
		public static SerializedGuid NHHEKDOKCAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x71EE1D0", Offset = "0x71ED3D0", VA = "0x1871EE1D0")]
		public bool PHKHHDPEMAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x71EE1A0", Offset = "0x71ED3A0", VA = "0x1871EE1A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x71EE120", Offset = "0x71ED320", VA = "0x1871EE120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x71EDFD0", Offset = "0x71ED1D0", VA = "0x1871EDFD0", Slot = "7")]
		public bool Equals(SerializedGuid JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x71EE010", Offset = "0x71ED210", VA = "0x1871EE010", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x71EE0A0", Offset = "0x71ED2A0", VA = "0x1871EE0A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x71EDFA0", Offset = "0x71ED1A0", VA = "0x1871EDFA0", Slot = "6")]
		public int CompareTo(SerializedGuid JAINJPLCLDO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GBHMGPMIEAD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly Type BJHKGOIOLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly string FELOIAENLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool DDAAMFJCFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool DGBLFIMOAIH;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x71EB570", Offset = "0x71EA770", VA = "0x1871EB570")]
	public GBHMGPMIEAD(Type NKKBJBPCIMB, string EKEIPHPDIOG, bool CBKJIBGKDDB = false, bool BMHCNNNGHBI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EKKGOIIBGNN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct OIGKGBPODHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long EEBAFEHMMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly long PALFOKOCMKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int MDCLHMNOONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly int APJBAGNBDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool FGNEDFNGICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly string ECBJGACOFAM;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFF80", Offset = "0x4DBF180", VA = "0x184DBFF80")]
		public OIGKGBPODHP(long EEBAFEHMMKD, int MDCLHMNOONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFFF0", Offset = "0x4DBF1F0", VA = "0x184DBFFF0")]
		public OIGKGBPODHP(long EEBAFEHMMKD, long PALFOKOCMKB, int MDCLHMNOONP, int APJBAGNBDAB, bool FGNEDFNGICK, string ECBJGACOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFF30", Offset = "0x4DBF130", VA = "0x184DBFF30")]
		public int NKMIKCFEBFL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFE10", Offset = "0x4DBF010", VA = "0x184DBFE10")]
		public int AEBINENIBAM(int ECFFJOIANNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFE30", Offset = "0x4DBF030", VA = "0x184DBFE30")]
		public double BALFPJJMOPM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFE90", Offset = "0x4DBF090", VA = "0x184DBFE90")]
		public OIGKGBPODHP BDJIDGKDAFF(long PALFOKOCMKB, int APJBAGNBDAB)
		{
			return default(OIGKGBPODHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class KJLMKGNBAOG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct HJJNFPAPGKI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public KJLMKGNBAOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Func<KJLMKGNBAOG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private KJLMKGNBAOG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x44E0F60", Offset = "0x44E0160", VA = "0x1844E0F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x44E1490", Offset = "0x44E0690", VA = "0x1844E1490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly TKey CHCLNDNNNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly EKKGOIIBGNN<TKey> FBHOIGDCPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly KJMCEDJMPPA MOKKIOIDAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<KJLMKGNBAOG> JKDEKFPHPLN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string IFHOHMHJNIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x49442D0", Offset = "0x49434D0", VA = "0x1849442D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IEnumerable<KJLMKGNBAOG> ICEEGCEHMMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x4944740", Offset = "0x4943940", VA = "0x184944740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public OIGKGBPODHP FFIFJIABIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4944320", Offset = "0x4943520", VA = "0x184944320")]
			[CompilerGenerated]
			get
			{
				return default(OIGKGBPODHP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4944780", Offset = "0x4943980", VA = "0x184944780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x49447B0", Offset = "0x49439B0", VA = "0x1849447B0")]
		internal KJLMKGNBAOG(EKKGOIIBGNN<TKey> FBHOIGDCPGK, TKey OFPBICPHALF, KJMCEDJMPPA MOKKIOIDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4944590", Offset = "0x4943790", VA = "0x184944590")]
		public KJLMKGNBAOG IDOMFBHCEDJ(TKey OFPBICPHALF, [Optional] KJMCEDJMPPA? CNKLPAIADAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3412E20", Offset = "0x3412020", VA = "0x183412E20")]
		[AsyncStateMachine(typeof(HJJNFPAPGKI<>))]
		public Task<T> EPANLJINFGK<T>(TKey OFPBICPHALF, Func<KJLMKGNBAOG, Task<T>> LGBMMKDPNBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4944340", Offset = "0x4943540", VA = "0x184944340", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KOJPHCOHGPO : IEnumerable<(TKey, List<TKey>, OIGKGBPODHP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OIGKGBPODHP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private (TKey key, List<TKey> path, OIGKGBPODHP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EKKGOIIBGNN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IEnumerator<(TKey key, List<TKey> path, OIGKGBPODHP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private (TKey, List<TKey>, OIGKGBPODHP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2737B00", Offset = "0x2736D00", VA = "0x182737B00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OIGKGBPODHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4956840", Offset = "0x4955A40", VA = "0x184956840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2737BF0", Offset = "0x2736DF0", VA = "0x182737BF0")]
		[DebuggerHidden]
		public KOJPHCOHGPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x42F7C00", Offset = "0x42F6E00", VA = "0x1842F7C00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4956380", Offset = "0x4955580", VA = "0x184956380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4956330", Offset = "0x4955530", VA = "0x184956330")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x49567F0", Offset = "0x49559F0", VA = "0x1849567F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4956720", Offset = "0x4955920", VA = "0x184956720", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OIGKGBPODHP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x43067D0", Offset = "0x43059D0", VA = "0x1843067D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class EGEDCNKGGHF : IEnumerable<(TKey, List<TKey>, OIGKGBPODHP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OIGKGBPODHP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private (TKey key, List<TKey> path, OIGKGBPODHP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KJLMKGNBAOG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KJLMKGNBAOG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public EKKGOIIBGNN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<KJLMKGNBAOG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private IEnumerator<(TKey key, List<TKey> path, OIGKGBPODHP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private (TKey, List<TKey>, OIGKGBPODHP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2737B00", Offset = "0x2736D00", VA = "0x182737B00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OIGKGBPODHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3EFEA40", Offset = "0x3EFDC40", VA = "0x183EFEA40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2737BF0", Offset = "0x2736DF0", VA = "0x182737BF0")]
		[DebuggerHidden]
		public EGEDCNKGGHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEAA0", Offset = "0x3EFDCA0", VA = "0x183EFEAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE0F0", Offset = "0x3EFD2F0", VA = "0x183EFE0F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE090", Offset = "0x3EFD290", VA = "0x183EFE090")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE030", Offset = "0x3EFD230", VA = "0x183EFE030")]
		private void JELILPGANHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE9F0", Offset = "0x3EFDBF0", VA = "0x183EFE9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE8B0", Offset = "0x3EFDAB0", VA = "0x183EFE8B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OIGKGBPODHP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE9B0", Offset = "0x3EFDBB0", VA = "0x183EFE9B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, OIGKGBPODHP, KJMCEDJMPPA> BMFEMKAIACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<TKey, OIGKGBPODHP, KJMCEDJMPPA> OPFNAAKDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Action<EKKGOIIBGNN<TKey>, KJMCEDJMPPA> HENPMPEHEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KJLMKGNBAOG IFCGIOKHCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool CLAMDNBMMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int EFEFHCOIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Stopwatch BCPENEKNLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly int LGIBAMLFIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string ONJPAJILABJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KJLMKGNBAOG EEBHMOOLHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[NotNull]
	public string IFHOHMHJNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F870", Offset = "0x3F1EA70", VA = "0x183F1F870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FBA0", Offset = "0x3F1EDA0", VA = "0x183F1FBA0")]
	public EKKGOIIBGNN(TKey LPLIDCCIBLI, KJMCEDJMPPA MOKKIOIDAGN, [Optional] int? MDCLHMNOONP, [Optional][CanBeNull] Stopwatch BCPENEKNLHN, [Optional] Action<TKey, OIGKGBPODHP, KJMCEDJMPPA> BMFEMKAIACO, [Optional] Action<TKey, OIGKGBPODHP, KJMCEDJMPPA> OPFNAAKDGDE, [Optional] Action<EKKGOIIBGNN<TKey>, KJMCEDJMPPA> HENPMPEHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F8D0", Offset = "0x3F1EAD0", VA = "0x183F1F8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FB00", Offset = "0x3F1ED00", VA = "0x183F1FB00")]
	[IteratorStateMachine(typeof(EKKGOIIBGNN<>.KOJPHCOHGPO))]
	public IEnumerable<(TKey, List<TKey>, OIGKGBPODHP)> MKKPGKEHAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F1FA20", Offset = "0x3F1EC20", VA = "0x183F1FA20")]
	[IteratorStateMachine(typeof(EKKGOIIBGNN<>.EGEDCNKGGHF))]
	private IEnumerable<(TKey, List<TKey>, OIGKGBPODHP)> MKKPGKEHAEB(List<TKey> BIIHNEHMDOI, KJLMKGNBAOG JGAOFMKNFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F9A0", Offset = "0x3F1EBA0", VA = "0x183F1F9A0")]
	private (long, int) KAFLLJIHEKK()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class JDEOBOIDHGI<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PBMNOFINHBJ(EKKGOIIBGNN<TKey> FBHOIGDCPGK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected JDEOBOIDHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class AIBPHCKHABG<TKey> : JDEOBOIDHGI<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string OFFNCODFNOC(TKey OFPBICPHALF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x452A7C0", Offset = "0x45299C0", VA = "0x18452A7C0")]
	private static string FKDBLECBBBN(TKey OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x452A950", Offset = "0x4529B50", VA = "0x18452A950", Slot = "4")]
	public override string PBMNOFINHBJ(EKKGOIIBGNN<TKey> FBHOIGDCPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x452A800", Offset = "0x4529A00", VA = "0x18452A800")]
	public string PBMNOFINHBJ(EKKGOIIBGNN<TKey> FBHOIGDCPGK, [NotNull] OFFNCODFNOC APFOKKMBMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string JMGPFGCDPJP(EKKGOIIBGNN<TKey> FBHOIGDCPGK, [NotNull] OFFNCODFNOC APFOKKMBMHJ);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3F22090", Offset = "0x3F21290", VA = "0x183F22090")]
	protected AIBPHCKHABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class PNKKLOKFMII<TKey> : JDEOBOIDHGI<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string EIECKCANFKJ(TKey OFPBICPHALF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly string DMNABJNBBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly double FALHJDLAHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly bool JGMLFHMDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int OMIPIKLDEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ISet<string> IFDIALOCOBL;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4F43040", Offset = "0x4F42240", VA = "0x184F43040")]
	private static string FKDBLECBBBN(TKey OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4F437A0", Offset = "0x4F429A0", VA = "0x184F437A0")]
	public PNKKLOKFMII(string DMNABJNBBFJ = "F2", double FALHJDLAHLF = double.MaxValue, bool JGMLFHMDIDI = false, int OMIPIKLDEPK = int.MaxValue, [Optional] ISet<string> IFDIALOCOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4F436C0", Offset = "0x4F428C0", VA = "0x184F436C0", Slot = "4")]
	public override Dictionary<string, string> PBMNOFINHBJ(EKKGOIIBGNN<TKey> FBHOIGDCPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4F42D00", Offset = "0x4F41F00", VA = "0x184F42D00")]
	private bool EPIEMFBLGNF(string FBBEOFENAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4F43080", Offset = "0x4F42280", VA = "0x184F43080")]
	public Dictionary<string, string> PBMNOFINHBJ(EKKGOIIBGNN<TKey> FBHOIGDCPGK, EIECKCANFKJ APFOKKMBMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4F42DD0", Offset = "0x4F41FD0", VA = "0x184F42DD0")]
	private string FIKBNOMFHBO(StringBuilder FBOMDHIHMEF, List<TKey> LCGBAJIDPFK, EIECKCANFKJ APFOKKMBMHJ, bool EBPCECHANLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4F42BA0", Offset = "0x4F41DA0", VA = "0x184F42BA0")]
	private static void CJLECKKFOAI(StringBuilder GCJDHBLADMC, string CDFKBFKNNAN, bool NLOPNFPKBFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PFMLCOBGNLG<TKey> : AIBPHCKHABG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NCPPCHMCNJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OFFNCODFNOC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static PFMLCOBGNLG<TKey> CLACNPDFIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly string[] CDGFPMGLCPF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4F2F650", Offset = "0x4F2E850", VA = "0x184F2F650")]
	private PFMLCOBGNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4F2E600", Offset = "0x4F2D800", VA = "0x184F2E600", Slot = "5")]
	protected override string JMGPFGCDPJP(EKKGOIIBGNN<TKey> FBHOIGDCPGK, OFFNCODFNOC APFOKKMBMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4F2F410", Offset = "0x4F2E610", VA = "0x184F2F410")]
	[CompilerGenerated]
	internal static string PDNJFPGKAFH(string LMBBPHDBFEE, TKey OFPBICPHALF, NCPPCHMCNJJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class ADCNOMJJEIK : EKKGOIIBGNN<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GHMAOPLNIFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action<ADCNOMJJEIK, KJMCEDJMPPA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GHMAOPLNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x71EB5E0", Offset = "0x71EA7E0", VA = "0x1871EB5E0")]
		internal void IOJBAGLKKEG(EKKGOIIBGNN<string> timer, KJMCEDJMPPA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x71E8780", Offset = "0x71E7980", VA = "0x1871E8780")]
	public ADCNOMJJEIK(KJMCEDJMPPA MOKKIOIDAGN, [Optional] string LHOGHAOILAK, [Optional] int? MDCLHMNOONP, [Optional] Stopwatch BCPENEKNLHN, [Optional] Action<string, OIGKGBPODHP, KJMCEDJMPPA> BMFEMKAIACO, [Optional] Action<string, OIGKGBPODHP, KJMCEDJMPPA> OPFNAAKDGDE, [Optional] Action<ADCNOMJJEIK, KJMCEDJMPPA> HENPMPEHEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x71E86C0", Offset = "0x71E78C0", VA = "0x1871E86C0")]
	private static Action<EKKGOIIBGNN<string>, KJMCEDJMPPA> KOCFLGFAGMD(Action<ADCNOMJJEIK, KJMCEDJMPPA> FOCHKIPOIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class FNFNOPDDHDF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class NHGFHDFJAJK : FNFNOPDDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static FNFNOPDDHDF CLACNPDFIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x71EBA10", Offset = "0x71EAC10", VA = "0x1871EBA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override float JJNPDNNCLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xFE8860", Offset = "0xFE7A60", VA = "0x180FE8860", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x71EBB10", Offset = "0x71EAD10", VA = "0x1871EBB10")]
		public NHGFHDFJAJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static FNFNOPDDHDF IKPONCBNANO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static FNFNOPDDHDF MIAJNEPFAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x71EB380", Offset = "0x71EA580", VA = "0x1871EB380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public abstract float JJNPDNNCLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected FNFNOPDDHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ACEDPKMPOHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PDBMJMIDPNE<T> : ACEDPKMPOHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> PAMDOONHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	OABBPFFKNOC<T> NAOHIMNAEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HHLLPFBOJAA
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x328DF20", Offset = "0x328D120", VA = "0x18328DF20")]
	public static PDBMJMIDPNE<TResource> MAOGDOKHHMI<TResource, TId>(this HKFPDOELIAM<TId, TResource> CGDDNKJHMOL, TId BEHEHKFONGA, [Optional] Func<TId, CancellationToken, Task<TResource>>? GDKHEMBNCJB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BEFLNOOKNGB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class FLAPMPKLIGN<T> : ECADBOELABN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T?> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override OABBPFFKNOC<T?> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x42F09C0", Offset = "0x42EFBC0", VA = "0x1842F09C0")]
		public FLAPMPKLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class FILNIEBLOJH<T> : ECADBOELABN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly T JDIPCALIIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Action<T>? MBHIAFGOHBE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override OABBPFFKNOC<T> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x42ED940", Offset = "0x42ECB40", VA = "0x1842ED940")]
		public FILNIEBLOJH(T DAFFFIIHPKE, Action<T>? CNNPIFMDOGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x42ED750", Offset = "0x42EC950", VA = "0x1842ED750", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class NGIBPCDJEPD<T> : ECADBOELABN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override OABBPFFKNOC<T> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4C79020", Offset = "0x4C78220", VA = "0x184C79020")]
		public NGIBPCDJEPD(Exception BAFKJPEEDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class GNKHIPJILKA<T> : ECADBOELABN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct OIDECBFHLNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public Task<PDBMJMIDPNE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<PDBMJMIDPNE<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4DBF750", Offset = "0x4DBE950", VA = "0x184DBF750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4DBFC50", Offset = "0x4DBEE50", VA = "0x184DBFC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct NKONNNGKILF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public Task<PDBMJMIDPNE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<PDBMJMIDPNE<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4C89C70", Offset = "0x4C88E70", VA = "0x184C89C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x4C8A0D0", Offset = "0x4C892D0", VA = "0x184C8A0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Task<PDBMJMIDPNE<T>> MHIOODEPACA;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override OABBPFFKNOC<T> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x445D940", Offset = "0x445CB40", VA = "0x18445D940")]
		public GNKHIPJILKA(Task<PDBMJMIDPNE<T>> JPPEAAIELKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x445D5D0", Offset = "0x445C7D0", VA = "0x18445D5D0", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x445D7D0", Offset = "0x445C9D0", VA = "0x18445D7D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(GNKHIPJILKA<>.OIDECBFHLNH))]
		internal static Task<T> NCCIGOPAHDG(Task<PDBMJMIDPNE<T>> JPPEAAIELKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x445D460", Offset = "0x445C660", VA = "0x18445D460")]
		[AsyncStateMachine(typeof(GNKHIPJILKA<>.NKONNNGKILF))]
		[CompilerGenerated]
		internal static Task DHDGBAIFKAC(Task<PDBMJMIDPNE<T>> JPPEAAIELKB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class CDHIHPKJJCH<TIn, TOut> : ECADBOELABN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct PNKMLCCKGNC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4F43B60", Offset = "0x4F42D60", VA = "0x184F43B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3EE8A20", Offset = "0x3EE7C20", VA = "0x183EE8A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly PDBMJMIDPNE<TIn> PJMMDELEMBO;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<TOut> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override OABBPFFKNOC<TOut> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x56E8320", Offset = "0x56E7520", VA = "0x1856E8320")]
		public CDHIHPKJJCH(PDBMJMIDPNE<TIn> ECLLDEJHKLC, Func<TIn, TOut> FPPMJMCEBBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x56E7FD0", Offset = "0x56E71D0", VA = "0x1856E7FD0", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x56E81A0", Offset = "0x56E73A0", VA = "0x1856E81A0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CDHIHPKJJCH<, >.PNKMLCCKGNC))]
		internal static Task<TOut> KOMNOIAFLPB(Task<TIn> EDCCDJHLGOJ, Func<TIn, TOut> FPPMJMCEBBA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x304E560", Offset = "0x304D760", VA = "0x18304E560")]
	public static PDBMJMIDPNE<T> GNFCEACADKD<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x304E5E0", Offset = "0x304D7E0", VA = "0x18304E5E0")]
	public static PDBMJMIDPNE<T> HDHDACAIPJO<T>(T NJFLHCEDIDN, [Optional] Action<T>? CNNPIFMDOGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static PDBMJMIDPNE<T> CCOHPBDPKNP<T>(Exception BAFKJPEEDJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static PDBMJMIDPNE<T> OMJBBEHEEMB<T>(Task<PDBMJMIDPNE<T>> JPPEAAIELKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x304C770", Offset = "0x304B970", VA = "0x18304C770")]
	public static PDBMJMIDPNE<TOut> JICGKLMMHCG<TOut, TIn>(PDBMJMIDPNE<TIn> AINDMPLBNFF, Func<TIn, TOut> FPPMJMCEBBA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class ECADBOELABN<T> : PDBMJMIDPNE<T>, ACEDPKMPOHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly string ENGPGOMMKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly ADFPDBNKNIO BGBIJFDFMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool CLAMDNBMMAC;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB24E20", Offset = "0xB24020", VA = "0x180B24E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract Task<T> PAMDOONHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract OABBPFFKNOC<T> NAOHIMNAEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6DB0", Offset = "0x3EE5FB0", VA = "0x183EE6DB0")]
	public ECADBOELABN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6AF0", Offset = "0x3EE5CF0", VA = "0x183EE6AF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KIPPFLOHBFI();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class MIPACLKIBMJ<TTask, T> : ECADBOELABN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EGFBEKDEHPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public EGFBEKDEHPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3C238B0", Offset = "0x3C22AB0", VA = "0x183C238B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3C23E00", Offset = "0x3C23000", VA = "0x183C23E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public MIPACLKIBMJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EGFBEKDEHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEC20", Offset = "0x3EFDE20", VA = "0x183EFEC20")]
		[AsyncStateMachine(typeof(MIPACLKIBMJ<, >.EGFBEKDEHPH.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JMIILHKCDKM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Task<T> JPPEAAIELKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	protected readonly CancellationTokenSource BCFACPBIPCL;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override Task<T> PAMDOONHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public override OABBPFFKNOC<T> NAOHIMNAEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4BFBC70", Offset = "0x4BFAE70", VA = "0x184BFBC70")]
	protected MIPACLKIBMJ(TTask JPPEAAIELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFBC20", Offset = "0x4BFAE20", VA = "0x184BFBC20", Slot = "10")]
	protected override void KIPPFLOHBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T BECGBOBPKIP(TTask GPJKMKGIEBN);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DBEDJLLOLAG();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BHAPFKIEDHI<T> : ECADBOELABN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly HLPAFEMDGAE<Task<T>> NAJABKCEMJP;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public override Task<T> PAMDOONHJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x445BFD0", Offset = "0x445B1D0", VA = "0x18445BFD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override OABBPFFKNOC<T> NAOHIMNAEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5648340", Offset = "0x5647540", VA = "0x185648340")]
	public BHAPFKIEDHI(HLPAFEMDGAE<Task<T>> MDHMMMEFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5648320", Offset = "0x5647520", VA = "0x185648320", Slot = "10")]
	protected override void KIPPFLOHBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class NMFKLEJKLOK
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static readonly HashAlgorithmName GELHAEMODBO;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ThreadLocal<IncrementalHash> NOCCJCCMLLH;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x71EC0A0", Offset = "0x71EB2A0", VA = "0x1871EC0A0")]
	public static int LDDJPDHEGBA(this DOIPHNFBKJF FDPDMACCNNB, IncrementalHash IBBAMBJMMGK, byte[] NOGLPCLFIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x71EC120", Offset = "0x71EB320", VA = "0x1871EC120")]
	public static bool NFEGCPMMBIK([CanBeNull] this DOIPHNFBKJF FDPDMACCNNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x71EC4B0", Offset = "0x71EB6B0", VA = "0x1871EC4B0")]
	public static bool NFEGCPMMBIK([CanBeNull] this DOIPHNFBKJF FDPDMACCNNB, [Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x71EC180", Offset = "0x71EB380", VA = "0x1871EC180")]
	public static bool NFEGCPMMBIK([CanBeNull] this DOIPHNFBKJF FDPDMACCNNB, IncrementalHash IBBAMBJMMGK, byte[] NOGLPCLFIDH, [Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x71EC010", Offset = "0x71EB210", VA = "0x1871EC010")]
	private static bool CBBPJDGIOOK(byte[] CFAPKAJBKKB, Span<byte> BOMJOBCAENP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class DBNJGPLGMIP
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x71E9CA0", Offset = "0x71E8EA0", VA = "0x1871E9CA0")]
	public static int ADABCDPPBAL(HashAlgorithmName PLIIMBLAEFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x71E9DF0", Offset = "0x71E8FF0", VA = "0x1871E9DF0")]
	public static int LDDJPDHEGBA(this ADECOEAHAJC BPMBJIGPHBB, byte[] IPOGCDAOLMI, IncrementalHash IBBAMBJMMGK, byte[] KJACHMEAEJC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface ADECOEAHAJC
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IBBAMBJMMGK);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DOIPHNFBKJF : ADECOEAHAJC
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[CanBeNull]
	byte[] CMOIEHDFFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[CanBeNull]
	byte[] CDDLBMNNFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class AGJIMACGKEP
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static bool PPLLNONLLCO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<byte> ACNOHOHNCHP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly ArrayPool<char> LJHANOJJEEM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly Encoding BADBOBPCMDO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly ThreadLocal<Encoder> BNBMKAJFGHF;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x39ED2F0", Offset = "0x39EC4F0", VA = "0x1839ED2F0")]
	public static void MNOLKGEILEC<T>(this IncrementalHash PGGGNLLGIAC, [CanBeNull] T DMLGABHGKII) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x39EC710", Offset = "0x39EB910", VA = "0x1839EC710")]
	public static void FIAFIBIBHGF<T>(this IncrementalHash PGGGNLLGIAC, [CanBeNull] T BPMBJIGPHBB) where T : ADECOEAHAJC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x39EC7A0", Offset = "0x39EB9A0", VA = "0x1839EC7A0")]
	public static void KDEICOMJGAN<T>(this IncrementalHash PGGGNLLGIAC, [CanBeNull] IList<T> NHHLGGEABHJ) where T : ADECOEAHAJC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x71E9780", Offset = "0x71E8980", VA = "0x1871E9780")]
	private static bool PLONAJPDILF([CanBeNull] ADECOEAHAJC BPMBJIGPHBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x71E9130", Offset = "0x71E8330", VA = "0x1871E9130")]
	public static void MAAJHCKIIBN(this IncrementalHash IBBAMBJMMGK, string? HJEBCGENJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x71E8C20", Offset = "0x71E7E20", VA = "0x1871E8C20")]
	public static void KLNDCMOLCEO(this IncrementalHash IBBAMBJMMGK, long DCOFAMANDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x71E8A50", Offset = "0x71E7C50", VA = "0x1871E8A50")]
	public static void IKLAPIDDIHC(this IncrementalHash IBBAMBJMMGK, int HPCHIMLBENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x71E8DF0", Offset = "0x71E7FF0", VA = "0x1871E8DF0")]
	public static void KPBHDAHKKMO(this IncrementalHash IBBAMBJMMGK, short PDHCCJIABLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x71E9540", Offset = "0x71E8740", VA = "0x1871E9540")]
	public static void MJBGIAOANBN(this IncrementalHash IBBAMBJMMGK, byte LIMGDPFEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x71E8FC0", Offset = "0x71E81C0", VA = "0x1871E8FC0")]
	public static void LGFANMOABCJ(this IncrementalHash IBBAMBJMMGK, bool EKJHCBIDNDF, bool LJAJJPOFJMP = false, bool KGADGINFIDG = false, bool OKJNADKKBGF = false, bool EGHJPAPEKFI = false, bool GEDINOCDAAA = false, bool MLOJDJAIKNK = false, bool EAOCDCAHOFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x39ECCC0", Offset = "0x39EBEC0", VA = "0x1839ECCC0")]
	public static void LKHFGPMDHII<T>(this IncrementalHash IBBAMBJMMGK, T NEBBNLAKKGH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x71E89F0", Offset = "0x71E7BF0", VA = "0x1871E89F0")]
	public static void IHDCBEJFCME(this IncrementalHash IBBAMBJMMGK, float HHFBDOKMIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x71E8930", Offset = "0x71E7B30", VA = "0x1871E8930")]
	public static void CBICHEPBOPM(this IncrementalHash IBBAMBJMMGK, ulong MJCBLOEPMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x71E88D0", Offset = "0x71E7AD0", VA = "0x1871E88D0")]
	public static void ADKKLEIHAIO(this IncrementalHash IBBAMBJMMGK, uint ECLJIDOGJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x71E8990", Offset = "0x71E7B90", VA = "0x1871E8990")]
	public static void CJLCBPKFLFI(this IncrementalHash IBBAMBJMMGK, ushort LBLEFMNAOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x71E9650", Offset = "0x71E8850", VA = "0x1871E9650")]
	public static void NBHAODINOAL(this IncrementalHash IBBAMBJMMGK, Vector3 NJLMFJJMGAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HEHICGCPJBK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x71EB670", Offset = "0x71EA870", VA = "0x1871EB670")]
	public HEHICGCPJBK(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class JNCIPADPCMH
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void CMCCKMIGNJK(ushort JOEBEHCLDMB, ushort NEPNBIOGAJM, ushort KCHFIOIPCDO, ushort OMHHGKFPGJH);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void KJCIFIDOMLK(ushort IFDBDFFADLB, ushort FHBMOKECHAG);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void JOHLGOABAMD();

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const ushort IFNONBDCMDH = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected JNCIPADPCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class CCMBKCKLCIO<T> : JNCIPADPCMH where T : CCMBKCKLCIO<T>.KNOHICDLDHP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface KNOHICDLDHP
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		KJCIFIDOMLK FIMEHMCOGNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		KJCIFIDOMLK LIAIACLBKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		JOHLGOABAMD HGHNMCEBCAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Dictionary<uint, T> INPJCBFGPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private JOHLGOABAMD IELDNEMDIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private JOHLGOABAMD CBPPPBIDPHM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LKOBKGMFDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8F0", Offset = "0x8F9AF0", VA = "0x1808FA8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public ushort MBLHEHKMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x56E3F30", Offset = "0x56E3130", VA = "0x1856E3F30")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x56E3F10", Offset = "0x56E3110", VA = "0x1856E3F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public ushort AMALGBIOOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x56E3F50", Offset = "0x56E3150", VA = "0x1856E3F50")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x56E3F40", Offset = "0x56E3140", VA = "0x1856E3F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public ushort OODOAGBICEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xC70C90", Offset = "0xC6FE90", VA = "0x180C70C90")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xC70DD0", Offset = "0xC6FFD0", VA = "0x180C70DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ushort CLBPGHJBMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x56E37B0", Offset = "0x56E29B0", VA = "0x1856E37B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x56E2F10", Offset = "0x56E2110", VA = "0x1856E2F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected bool NDCPLJLMFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x15415B0", Offset = "0x15407B0", VA = "0x1815415B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected bool ICMGPLDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D13820", Offset = "0x1D12A20", VA = "0x181D13820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CMCCKMIGNJK MBNMMCNLCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x56E3F70", Offset = "0x56E3170", VA = "0x1856E3F70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x56E3830", Offset = "0x56E2A30", VA = "0x1856E3830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x56E3990", Offset = "0x56E2B90", VA = "0x1856E3990")]
	private T IFKCFKGNPKO(ushort MHFOMEMKECL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x56E38D0", Offset = "0x56E2AD0", VA = "0x1856E38D0")]
	private T IBFGGOJMABK(ushort MHFOMEMKECL, ushort EKDCIOOGJCG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x56E2F20", Offset = "0x56E2120", VA = "0x1856E2F20")]
	protected T BCCBPCGMAHB(uint APHAGCOOICH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x56E4010", Offset = "0x56E3210", VA = "0x1856E4010")]
	protected CCMBKCKLCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x56E3DC0", Offset = "0x56E2FC0", VA = "0x1856E3DC0")]
	public void JMJEBHDLGKD(ushort CANBCCLLHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x56E3E00", Offset = "0x56E3000", VA = "0x1856E3E00")]
	public void JMJEBHDLGKD(ushort CANBCCLLHDE, ushort LIBPFMNKIHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x56E3CB0", Offset = "0x56E2EB0", VA = "0x1856E3CB0", Slot = "4")]
	protected virtual void JMJEBHDLGKD(uint MEMPJOLEANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x56E2F80", Offset = "0x56E2180", VA = "0x1856E2F80")]
	protected void DEIHHCLMDJA(uint MEMPJOLEANJ, uint JHBPCBGALDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x56E3E60", Offset = "0x56E3060", VA = "0x1856E3E60")]
	protected void KLOONHFBKBN(ushort MHFOMEMKECL, ushort EKDCIOOGJCG, T ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x56E37D0", Offset = "0x56E29D0", VA = "0x1856E37D0")]
	private void FCBDKAGAGEG(uint APHAGCOOICH, T ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x56E3A40", Offset = "0x56E2C40", VA = "0x1856E3A40")]
	protected void JBNCKFODJJG(float NIMHBLEHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x56E3F60", Offset = "0x56E3160", VA = "0x1856E3F60")]
	protected uint OAKBAEBPGOP(ushort MHFOMEMKECL, ushort EKDCIOOGJCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x56E37C0", Offset = "0x56E29C0", VA = "0x1856E37C0")]
	protected ushort DOJFHPODMBK(uint ECDNJKDBFPG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x56E3F20", Offset = "0x56E3120", VA = "0x1856E3F20")]
	protected ushort MAIPIOFALDI(uint ECDNJKDBFPG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class KKBOPNALNGI : CCMBKCKLCIO<KKBOPNALNGI.HONNKKKPAOB>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class HONNKKKPAOB : KNOHICDLDHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public KJCIFIDOMLK FIMEHMCOGNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public KJCIFIDOMLK LIAIACLBKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public JOHLGOABAMD HGHNMCEBCAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8F5490", Offset = "0x8F4690", VA = "0x1808F5490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HONNKKKPAOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x71EB8F0", Offset = "0x71EAAF0", VA = "0x1871EB8F0")]
	public void PBBADMKPFJG(ushort ODICDJELNIK, KJCIFIDOMLK IDDCPLMBLCI, KJCIFIDOMLK OHKIOFLICLG, JOHLGOABAMD PKHCMMLPOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x71EB810", Offset = "0x71EAA10", VA = "0x1871EB810")]
	public void PBBADMKPFJG(ushort MHFOMEMKECL, ushort EKDCIOOGJCG, KJCIFIDOMLK IDDCPLMBLCI, KJCIFIDOMLK OHKIOFLICLG, JOHLGOABAMD PKHCMMLPOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x71EB7C0", Offset = "0x71EA9C0", VA = "0x1871EB7C0")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x71EB9D0", Offset = "0x71EABD0", VA = "0x1871EB9D0")]
	protected KKBOPNALNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class OGDOLKOFLFD : KKBOPNALNGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool HMFIONFEFOF;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xB35480", Offset = "0xB34680", VA = "0x180B35480")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x71EC990", Offset = "0x71EBB90", VA = "0x1871EC990")]
	public void GGPOBANFNOP(ushort OFEFMHNOLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x71EC9F0", Offset = "0x71EBBF0", VA = "0x1871EC9F0")]
	public void GGPOBANFNOP(ushort OFEFMHNOLNO, ushort GLCMHCPKAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x71EB9D0", Offset = "0x71EABD0", VA = "0x1871EB9D0")]
	public OGDOLKOFLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FGAOCBKAGAH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class CGEJAKIBJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode MLNFAKCEGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode DBEHKFODEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public DDNIHCFHOON EMDADMPPCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public List<DDNIHCFHOON> MIMBJILNILG;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CGEJAKIBJNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct DDNIHCFHOON : IComparable<DDNIHCFHOON>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int ENGJFBPJMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public TClaimant MHIOJANJJPO;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x140D3B0", Offset = "0x140C5B0", VA = "0x18140D3B0")]
		public DDNIHCFHOON(int ENGJFBPJMAC, TClaimant MHIOJANJJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60555E0", Offset = "0x60547E0", VA = "0x1860555E0")]
		public bool IGBCOMIHBMM([In] DDNIHCFHOON JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6055640", Offset = "0x6054840", VA = "0x186055640")]
		public bool PBCBEOJEMAD([In] DDNIHCFHOON JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60555D0", Offset = "0x60547D0", VA = "0x1860555D0", Slot = "4")]
		public int CompareTo(DDNIHCFHOON JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6055650", Offset = "0x6054850", VA = "0x186055650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum BPAMMLFEKGH
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NPLECDFHFFO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FGAOCBKAGAH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public NPLECDFHFFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE280", Offset = "0x4CAD480", VA = "0x184CAE280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE460", Offset = "0x4CAD660", VA = "0x184CAE460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4CAE360", Offset = "0x4CAD560", VA = "0x184CAE360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4312390", Offset = "0x4311590", VA = "0x184312390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IJCHBBENNEN<CGEJAKIBJNK> PINGNHONGII;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly IJCHBBENNEN<List<DDNIHCFHOON>> PNACNOABJCH;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static int KHEIFIBFKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TClaimant, TNode> BMDOJPOBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	internal readonly Dictionary<TNode, CGEJAKIBJNK> JDHIBIHFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BPAMMLFEKGH EKEGOHBHLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PMNHNJKCDDE(TNode NGCBLOEDNKL);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void IIJLPJPDNJJ(TNode NGCBLOEDNKL, TClaimant DKEGJEDAIMH, TClaimant MFHKADGEIJK);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x42E4620", Offset = "0x42E3820", VA = "0x1842E4620")]
	public FGAOCBKAGAH(BPAMMLFEKGH EKEGOHBHLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x42E3600", Offset = "0x42E2800", VA = "0x1842E3600")]
	public void HBCBNBBOGAP(TNode NGCBLOEDNKL, TNode BCPOGOCDLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x42E2C30", Offset = "0x42E1E30", VA = "0x1842E2C30")]
	public void DAOBOPJLHJD(TClaimant MHIOJANJJPO, TNode PFHHACIMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x42E2E80", Offset = "0x42E2080", VA = "0x1842E2E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x42E2DB0", Offset = "0x42E1FB0", VA = "0x1842E2DB0")]
	private void DNNGKFOMJPK(TClaimant MHIOJANJJPO, TNode HIDJFCEGEMD, TNode PFHHACIMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x42E36C0", Offset = "0x42E28C0", VA = "0x1842E36C0")]
	private int HOPCBLNMPCM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x42E31F0", Offset = "0x42E23F0", VA = "0x1842E31F0")]
	private void GDGDNOIKGEL(TClaimant MHIOJANJJPO, TNode IGFLIKMPPBK, TNode FNIOOAHGDGJ, int AJBJHOPFKML = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x42E3530", Offset = "0x42E2730", VA = "0x1842E3530")]
	private void HANNLCEHLIG(DDNIHCFHOON DBLFDFKPEFO, CGEJAKIBJNK HLMPJHIDIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x42E4170", Offset = "0x42E3370", VA = "0x1842E4170")]
	private void PDPOGPCKLJK(TClaimant MHIOJANJJPO, TNode IGFLIKMPPBK, TNode FNIOOAHGDGJ, int AJBJHOPFKML = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x42E3EF0", Offset = "0x42E30F0", VA = "0x1842E3EF0")]
	private void OODOPJLDEAG(DDNIHCFHOON DBLFDFKPEFO, TNode NGCBLOEDNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x42E3090", Offset = "0x42E2290", VA = "0x1842E3090")]
	private void FCPJODKACNP(DDNIHCFHOON DBLFDFKPEFO, CGEJAKIBJNK HLMPJHIDIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x42E4020", Offset = "0x42E3220", VA = "0x1842E4020")]
	private void PDGEDNAAPBK(CGEJAKIBJNK HLMPJHIDIOP, bool LKENDFKGKAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x42E38F0", Offset = "0x42E2AF0", VA = "0x1842E38F0")]
	private void LKFHAOLMECB(CGEJAKIBJNK HLMPJHIDIOP, TNode BCPOGOCDLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x42E2B40", Offset = "0x42E1D40", VA = "0x1842E2B40")]
	[IteratorStateMachine(typeof(FGAOCBKAGAH<, >.NPLECDFHFFO))]
	private IEnumerable<TNode> CIMLGCGLANI(TNode IGFLIKMPPBK, TNode FNIOOAHGDGJ, bool BMPGADNFNCJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x42E3DE0", Offset = "0x42E2FE0", VA = "0x1842E3DE0")]
	private CGEJAKIBJNK NEDGAAEDKPG(TNode NGCBLOEDNKL, TNode DBEHKFODEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x42E3C60", Offset = "0x42E2E60", VA = "0x1842E3C60")]
	private CGEJAKIBJNK LMHFFEONDKP(TNode NGCBLOEDNKL, TNode DBEHKFODEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x42E3730", Offset = "0x42E2930", VA = "0x1842E3730")]
	private void JIMGNPAIAAJ(CGEJAKIBJNK HLMPJHIDIOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JGPGOGEPBFP<T> : IEnumerable<JGPGOGEPBFP<T>.FGMPCKOLMKN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct FGMPCKOLMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public T OMEFCJCOLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int CPLNODNGKGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PPPKAPKPLIC : IEnumerator<FGMPCKOLMKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private JGPGOGEPBFP<T> FICGKNGGGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int CPLNODNGKGB;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3F6B250", Offset = "0x3F6A450", VA = "0x183F6B250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public FGMPCKOLMKN AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4F5DF20", Offset = "0x4F5D120", VA = "0x184F5DF20", Slot = "4")]
			get
			{
				return default(FGMPCKOLMKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4F5DEE0", Offset = "0x4F5D0E0", VA = "0x184F5DEE0")]
		public PPPKAPKPLIC(JGPGOGEPBFP<T> FICGKNGGGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4F5DDE0", Offset = "0x4F5CFE0", VA = "0x184F5DDE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3FC57F0", Offset = "0x3FC49F0", VA = "0x183FC57F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xF73BA0", Offset = "0xF72DA0", VA = "0x180F73BA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct GNENFBAEMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool BLJGHONEKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public T OMEFCJCOLII;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int GFGNNIGNDGN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<T, int> NNBCPMKBHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GNENFBAEMPH[] HBKOJEAMLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int JJFIHELNEJE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int MMPAJFLKJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x932BE0", Offset = "0x931DE0", VA = "0x180932BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x482C3A0", Offset = "0x482B5A0", VA = "0x18482C3A0")]
	public JGPGOGEPBFP(int EKPEFEBPGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x482BF80", Offset = "0x482B180", VA = "0x18482BF80")]
	public JGPGOGEPBFP(FGMPCKOLMKN[] DDNPIHHMCJL, bool FOJMMHPJLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x482B7E0", Offset = "0x482A9E0", VA = "0x18482B7E0")]
	public int HOGACOJFIMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x482B3B0", Offset = "0x482A5B0", VA = "0x18482B3B0")]
	private int HHODKBFLMOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x482BA60", Offset = "0x482AC60", VA = "0x18482BA60", Slot = "6")]
	protected virtual uint PEKMHAOMBKH(uint IBBAMBJMMGK, T OMEFCJCOLII)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x482B900", Offset = "0x482AB00", VA = "0x18482B900")]
	public bool IGDELPJLDKB(T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x482B960", Offset = "0x482AB60", VA = "0x18482B960")]
	public int IHHCAMCDFKN(T OMEFCJCOLII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x482B340", Offset = "0x482A540", VA = "0x18482B340")]
	public T DPBEJMJKOAG(int CPLNODNGKGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x482AD40", Offset = "0x4829F40", VA = "0x18482AD40")]
	public bool DHIPFGPMMGA(T OMEFCJCOLII, bool GGIMECAHNFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x482ADA0", Offset = "0x4829FA0", VA = "0x18482ADA0")]
	public bool DHIPFGPMMGA(T OMEFCJCOLII, int CPLNODNGKGB, bool GGIMECAHNFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x482ACF0", Offset = "0x4829EF0", VA = "0x18482ACF0")]
	private int AEEHKILKNBI(int EINJGMILBKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x482BAB0", Offset = "0x482ACB0", VA = "0x18482BAB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x482BAB0", Offset = "0x482ACB0", VA = "0x18482BAB0", Slot = "4")]
	private IEnumerator<FGMPCKOLMKN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IJCHBBENNEN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly Stack<T> NEOIHHDGEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<T> CBBFOJBGJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly int JEHOPPGHJDH;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x46474C0", Offset = "0x46466C0", VA = "0x1846474C0")]
	public static IJCHBBENNEN<T> DCGGEEEOACF(int EKPEFEBPGMB = 0, int JEHOPPGHJDH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4647C00", Offset = "0x4646E00", VA = "0x184647C00")]
	public static IJCHBBENNEN<T> JBOKOFKKEAI(int EKPEFEBPGMB = 0, int JEHOPPGHJDH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4647E10", Offset = "0x4647010", VA = "0x184647E10")]
	public IJCHBBENNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4647E60", Offset = "0x4647060", VA = "0x184647E60")]
	public IJCHBBENNEN(int EKPEFEBPGMB, int JEHOPPGHJDH = int.MaxValue, bool GJLMGLMKCKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4647840", Offset = "0x4646A40", VA = "0x184647840")]
	public T HFPCILCLDOM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4647D30", Offset = "0x4646F30", VA = "0x184647D30")]
	public void OIHANPNKAFH(T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4647740", Offset = "0x4646940", VA = "0x184647740")]
	private void EMGLKAGELEC(T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4647CF0", Offset = "0x4646EF0", VA = "0x184647CF0")]
	private void JGDJPHOJGOF(T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x46475B0", Offset = "0x46467B0", VA = "0x1846475B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4647A10", Offset = "0x4646C10", VA = "0x184647A10")]
	private void IGOIEIEDDPH(IEnumerable<T> CJALOAIIOIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JOGMBKFLFKO<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Dictionary<int, T> IMCKAINIGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private T ODLHKAFDCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public virtual T GCMLLJPNPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x484B2C0", Offset = "0x484A4C0", VA = "0x18484B2C0")]
	public bool FBBOPGKJCKB(T OMEFCJCOLII, int ENGJFBPJMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x484BA30", Offset = "0x484AC30", VA = "0x18484BA30")]
	public bool OPEPHGNFMMF(int ENGJFBPJMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x484B630", Offset = "0x484A830", VA = "0x18484B630")]
	public T HJMCMGMEJIK(int JOPMJOGONJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x484B8F0", Offset = "0x484AAF0", VA = "0x18484B8F0")]
	private bool KPPKDIPHMID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x484B260", Offset = "0x484A460", VA = "0x18484B260")]
	public bool EKHOHBPCPIG(int ENGJFBPJMAC, [Out] T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x484BAD0", Offset = "0x484ACD0", VA = "0x18484BAD0")]
	public JOGMBKFLFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DPDELAFMOFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct DKLOGGAMINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public T ELOFPHHKCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int JIAAJMHFFBM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	protected readonly List<DKLOGGAMINB> ACLAAGJGPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private T FAKJLKOJKIG;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x608A610", Offset = "0x6089810", VA = "0x18608A610")]
	public bool NDFFHEILIJK(T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6089F40", Offset = "0x6089140", VA = "0x186089F40")]
	public void CKLHJOINNOK(T OMEFCJCOLII, int ENGJFBPJMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x608A2F0", Offset = "0x60894F0", VA = "0x18608A2F0")]
	public bool GMODDBABBFK(T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x608A0D0", Offset = "0x60892D0", VA = "0x18608A0D0")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x608A4E0", Offset = "0x60896E0", VA = "0x18608A4E0")]
	public T LPANHAJMHAH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6089DC0", Offset = "0x6088FC0", VA = "0x186089DC0")]
	protected void CFEOLHFKNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x608AA00", Offset = "0x6089C00", VA = "0x18608AA00")]
	public DPDELAFMOFD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x71ECC50", Offset = "0x71EBE50", VA = "0x1871ECC50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x71ECF20", Offset = "0x71EC120", VA = "0x1871ECF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x71ECE30", Offset = "0x71EC030", VA = "0x1871ECE30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x71ECBA0", Offset = "0x71EBDA0", VA = "0x1871ECBA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x71ECE70", Offset = "0x71EC070", VA = "0x1871ECE70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x71ECD80", Offset = "0x71EBF80", VA = "0x1871ECD80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x71ECB10", Offset = "0x71EBD10", VA = "0x1871ECB10")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5103CE0", Offset = "0x5102EE0", VA = "0x185103CE0", Slot = "4")]
		public virtual T OIECFKJDKED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EGDENHMBDGL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private Dictionary<byte, NKKPOJNLKCM> ANKCPIMGGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly IJCHBBENNEN<NKKPOJNLKCM> HBKIKLHBILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool DDJMCFHLAII;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public NKKPOJNLKCM KKCGGDMGLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector2 ANPDFPEIHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x1384600", Offset = "0x1383800", VA = "0x181384600")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xB32D50", Offset = "0xB31F50", VA = "0x180B32D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Vector2 OILGLMMEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FAB0", VA = "0x180B508B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 EMDEKLMMEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x71EAEA0", Offset = "0x71EA0A0", VA = "0x1871EAEA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8FA2F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int IBEIGECMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6F0", Offset = "0x8FC8F0", VA = "0x1808FD6F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8E0", Offset = "0x8FCAE0", VA = "0x1808FD8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x71EB000", Offset = "0x71EA200", VA = "0x1871EB000")]
	public EGDENHMBDGL(Bounds DNDDNMJMGDF, Vector2[] GBLMMFFMHHB, int ILNNAIAFHOC, byte EINJGMILBKO, float ONLJOKKIDLJ = 0f, [Optional] IJCHBBENNEN<NKKPOJNLKCM> HBKIKLHBILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x71EAA10", Offset = "0x71E9C10", VA = "0x1871EAA10")]
	public void HJONCOJAHHJ(Bounds DNDDNMJMGDF, Vector2[] GBLMMFFMHHB, int ILNNAIAFHOC, byte EINJGMILBKO, float ONLJOKKIDLJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x71EAFA0", Offset = "0x71EA1A0", VA = "0x1871EAFA0")]
	public NKKPOJNLKCM NLAOFFMCPLE(byte CPLNODNGKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x71EA410", Offset = "0x71E9610", VA = "0x1871EA410")]
	public void BPIKLIHDNIN(Vector3 FCKJMOMOHAE, float PMEMNLMJMFI, float CBGEIBIJMFK, List<byte> FBCEAACCIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x71EA540", Offset = "0x71E9740", VA = "0x1871EA540")]
	public void EKIJIGAMCOE(NKKPOJNLKCM.PHHICCJIPNP HAHHAOJGIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x71EAEC0", Offset = "0x71EA0C0", VA = "0x1871EAEC0")]
	public static int KCABCAKGFEG(Vector2[] GBLMMFFMHHB, int ILNNAIAFHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x71EA780", Offset = "0x71E9980", VA = "0x1871EA780")]
	private NKKPOJNLKCM FMILMEANBDA(byte CPLNODNGKGB, NKKPOJNLKCM.EPLHCDKCMDJ AHOLONDOFGJ, NKKPOJNLKCM DBEHKFODEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x71EA050", Offset = "0x71E9250", VA = "0x1871EA050")]
	private void BBDLDMOHPKE(NKKPOJNLKCM DBEHKFODEEL, Vector2[] GBLMMFFMHHB, int EEDICJKMEPE, int IPKKAGGFLAP, int OPICBHIEIEN, int JOJCDLCGHNN, float ONLJOKKIDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x71EA560", Offset = "0x71E9760", VA = "0x1871EA560")]
	private void FMEMIFOLHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x71EA4E0", Offset = "0x71E96E0", VA = "0x1871EA4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x71EA9B0", Offset = "0x71E9BB0", VA = "0x1871EA9B0", Slot = "1")]
	~EGDENHMBDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class NKKPOJNLKCM
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum EPLHCDKCMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum PHHICCJIPNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte JFJOAOHHOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 CLDNNMBKBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 ININOACGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 PDOKFBNINIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 DFOIJEMOHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public EPLHCDKCMDJ JNAFELAMEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NKKPOJNLKCM ACBBFNLKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public List<NKKPOJNLKCM> MPEMPAMKMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool IDMAOFIEEKG;

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x71EBFF0", Offset = "0x71EB1F0", VA = "0x1871EBFF0")]
	public NKKPOJNLKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x71EBE20", Offset = "0x71EB020", VA = "0x1871EBE20")]
	public void FHJIJLKPAKP(NKKPOJNLKCM KGPDHHGDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	public void EKIJIGAMCOE(int ALFHALIEIPF, PHHICCJIPNP HAHHAOJGIIC, int CDDAGCDHNBH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x71EBB90", Offset = "0x71EAD90", VA = "0x1871EBB90")]
	public void BPIKLIHDNIN(List<byte> FBCEAACCIDC, Vector3 FCKJMOMOHAE, float PMEMNLMJMFI, float CBGEIBIJMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x71EBDF0", Offset = "0x71EAFF0", VA = "0x1871EBDF0")]
	public bool CHPKJJAMCDJ(Vector3 NGCBFLBKHCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x71EBB60", Offset = "0x71EAD60", VA = "0x1871EBB60")]
	public bool AKFANKIOLLK(Vector3 NGCBFLBKHCA, float DBIMMKDBEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x71EBF60", Offset = "0x71EB160", VA = "0x1871EBF60")]
	public void GGPOBANFNOP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public struct NGOIPNGLIBM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly List<Component> AFNGOKKOBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly bool GJIKCMPNKBP;

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1532D30", Offset = "0x1531F30", VA = "0x181532D30")]
			public NGOIPNGLIBM(List<Component> AFNGOKKOBOC, bool GJIKCMPNKBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x4C7A570", Offset = "0x4C79770", VA = "0x184C7A570")]
			public MKIKDDDKCOF<T> EMKBHPPGLAN()
			{
				return default(MKIKDDDKCOF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x4C7A5D0", Offset = "0x4C797D0", VA = "0x184C7A5D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x4C7A5D0", Offset = "0x4C797D0", VA = "0x184C7A5D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct MKIKDDDKCOF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly List<Component> AFNGOKKOBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private readonly bool GJIKCMPNKBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private int CPLNODNGKGB;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T AJGNMEAPLII
			{
				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x4BFF390", Offset = "0x4BFE590", VA = "0x184BFF390", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x4BFF320", Offset = "0x4BFE520", VA = "0x184BFF320", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x4BFF360", Offset = "0x4BFE560", VA = "0x184BFF360")]
			public MKIKDDDKCOF(List<Component> AFNGOKKOBOC, bool GJIKCMPNKBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x4BFF260", Offset = "0x4BFE460", VA = "0x184BFF260", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x4BFF270", Offset = "0x4BFE470", VA = "0x184BFF270", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x3FB3860", Offset = "0x3FB2A60", VA = "0x183FB3860", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x71EE940", Offset = "0x71EDB40", VA = "0x1871EE940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x71EE6D0", Offset = "0x71ED8D0", VA = "0x1871EE6D0")]
		private void GGPOBANFNOP(GameObject NDKEGGFHGCM, bool DCOODACAFGM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x71EE640", Offset = "0x71ED840", VA = "0x1871EE640")]
		public static void GGPOBANFNOP(GameObject NDKEGGFHGCM, ToolHierarchyCache CGDDNKJHMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x71EE5B0", Offset = "0x71ED7B0", VA = "0x1871EE5B0")]
		public void DCMILGHOAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x35F2F30", Offset = "0x35F2130", VA = "0x1835F2F30")]
		public void APFPKLNEIFC<T>(Action<T> KOMGLJOLBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x35F3170", Offset = "0x35F2370", VA = "0x1835F3170")]
		public T DGJANADJFMP<T>(bool GJIKCMPNKBP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x35F3210", Offset = "0x35F2410", VA = "0x1835F3210")]
		public NGOIPNGLIBM<T> DOJNKHHHMHC<T>(bool GJIKCMPNKBP = false) where T : class
		{
			return default(NGOIPNGLIBM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x71EE260", Offset = "0x71ED460", VA = "0x1871EE260")]
		public List<Component> BKAFDKOOFND(Type MDOOANEGCAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x71EE5C0", Offset = "0x71ED7C0", VA = "0x1871EE5C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KIEMJAMMNPB, ToolHierarchyCache IIOFLMMOEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x71EE840", Offset = "0x71EDA40", VA = "0x1871EE840", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LCACGJDNDHA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HLMJICDENMI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int EKPEFEBPGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private int CNKJGBADPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private List<T> NLCINFOCCID;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x445BFD0", Offset = "0x445B1D0", VA = "0x18445BFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T KKNAFBJAICO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x44E9E10", Offset = "0x44E9010", VA = "0x1844E9E10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T NPMKIFIIKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x44EA440", Offset = "0x44E9640", VA = "0x1844EA440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T BFMPMMPEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x44EA350", Offset = "0x44E9550", VA = "0x1844EA350")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x44EA530", Offset = "0x44E9730", VA = "0x1844EA530")]
	public HLMJICDENMI(int EKPEFEBPGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x44EA0F0", Offset = "0x44E92F0", VA = "0x1844EA0F0")]
	public void CKLHJOINNOK(T CJJPHFBPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x44EA250", Offset = "0x44E9450", VA = "0x1844EA250")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x44E9D20", Offset = "0x44E8F20", VA = "0x1844E9D20")]
	public void BBGGHOGHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x44E9CC0", Offset = "0x44E8EC0", VA = "0x1844E9CC0")]
	public void AHIHJMLIJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x44EA340", Offset = "0x44E9540", VA = "0x1844EA340")]
	public void NHHEGDFDJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x44EA2B0", Offset = "0x44E94B0", VA = "0x1844EA2B0")]
	public List<T> HIJGEOPJKDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class JLLOEEHENEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct PEJPAAHMNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public int JIAAJMHFFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public T ELOFPHHKCIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Dictionary<object, PEJPAAHMNJE> IMCKAINIGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly EqualityComparer<T> OKCHLJDPOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private T ODLHKAFDCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T GCMLLJPNPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xBBC050", Offset = "0xBBB250", VA = "0x180BBC050", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4834B70", Offset = "0x4833D70", VA = "0x184834B70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool ABDPCEPPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4833480", Offset = "0x4832680", VA = "0x184833480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object PBNCFADMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x48344E0", Offset = "0x48336E0", VA = "0x1848344E0")]
	public bool FBBOPGKJCKB(T OMEFCJCOLII, object BCOHKLCJCPM, int ENGJFBPJMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4837940", Offset = "0x4836B40", VA = "0x184837940")]
	public bool OPEPHGNFMMF(object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4833C00", Offset = "0x4832E00", VA = "0x184833C00")]
	public bool EKHOHBPCPIG(object BCOHKLCJCPM, [Out] T OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x44E2410", Offset = "0x44E1610", VA = "0x1844E2410")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4835BC0", Offset = "0x4834DC0", VA = "0x184835BC0")]
	private bool KPPKDIPHMID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4837A00", Offset = "0x4836C00", VA = "0x184837A00")]
	public JLLOEEHENEE()
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
