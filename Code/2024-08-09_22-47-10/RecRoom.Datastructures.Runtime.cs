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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68C9C30", Offset = "0x68C9030", VA = "0x1868C9C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CCMLNNADAMF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	public CCMLNNADAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KGJNOBJGJIA, JIKEBABGBEP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KMHAFMEHDIB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x931280", Offset = "0x930680", VA = "0x180931280")]
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
		[Cpp2IlInjected.Address(RVA = "0x68CC1A0", Offset = "0x68CB5A0", VA = "0x1868CC1A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68CC160", Offset = "0x68CB560", VA = "0x1868CC160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68CC1E0", Offset = "0x68CB5E0", VA = "0x1868CC1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68CC390", Offset = "0x68CB790", VA = "0x1868CC390")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68CC300", Offset = "0x68CB700", VA = "0x1868CC300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x995C50", Offset = "0x995050", VA = "0x180995C50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x995C40", Offset = "0x995040", VA = "0x180995C40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68CC120", Offset = "0x68CB520", VA = "0x1868CC120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68CC270", Offset = "0x68CB670", VA = "0x1868CC270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68CBC50", Offset = "0x68CB050", VA = "0x1868CBC50")]
	public void CopyBounds(SavedExtents IEDCHGMDIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68CC070", Offset = "0x68CB470", VA = "0x1868CC070")]
	public void SetLocalSpaceBounds(Bounds JJGJLOGHJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC872B0", Offset = "0xC866B0", VA = "0x180C872B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68CC060", Offset = "0x68CB460", VA = "0x1868CC060")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68CBC80", Offset = "0x68CB080", VA = "0x1868CBC80")]
	private void FPIODIOFDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68CBE40", Offset = "0x68CB240", VA = "0x1868CBE40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68CB5E0", Offset = "0x68CA9E0", VA = "0x1868CB5E0")]
	public static void CalculateLocalBoundsFor(GameObject GODEJCKEDNP, [Out] Bounds JJGJLOGHJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68CB520", Offset = "0x68CA920", VA = "0x1868CB520")]
	private static void CJIDGEJEABK(Bounds EALBLGNMNKM, Color HHIGDOHOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68CC090", Offset = "0x68CB490", VA = "0x1868CC090")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10A4150", Offset = "0x10A3550", VA = "0x1810A4150")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49D8E30", Offset = "0x49D8230", VA = "0x1849D8E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public virtual void BHBOHHDGMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
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
	[CCMLNNADAMF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49D89A0", Offset = "0x49D7DA0", VA = "0x1849D89A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49D7190", Offset = "0x49D6590", VA = "0x1849D7190", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49D8D30", Offset = "0x49D8130", VA = "0x1849D8D30")]
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
	private sealed class EONOCAFFDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public EONOCAFFDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38A92C0", Offset = "0x38A86C0", VA = "0x1838A92C0")]
		internal int PMBLPEKNEBG(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[CCMLNNADAMF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38AFCD0", Offset = "0x38AF0D0", VA = "0x1838AFCD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x38AFD30", Offset = "0x38AF130", VA = "0x1838AFD30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38AFBB0", Offset = "0x38AEFB0", VA = "0x1838AFBB0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey PEDCMDADFIN]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x38AFC70", Offset = "0x38AF070", VA = "0x1838AFC70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38AFA60", Offset = "0x38AEE60", VA = "0x1838AFA60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38AF720", Offset = "0x38AEB20", VA = "0x1838AF720", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38AEB50", Offset = "0x38ADF50", VA = "0x1838AEB50", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38AEB20", Offset = "0x38ADF20", VA = "0x1838AEB20", Slot = "14")]
	protected virtual string IFAGAONDCGH(TKeyVal KMCHOKDACPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38AE9C0", Offset = "0x38ADDC0", VA = "0x1838AE9C0", Slot = "4")]
	public bool ContainsKey(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38AF8E0", Offset = "0x38AECE0", VA = "0x1838AF8E0", Slot = "5")]
	public bool TryGetValue(TKey PEDCMDADFIN, [Out] TVal OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38AEA20", Offset = "0x38ADE20", VA = "0x1838AEA20", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38AEA20", Offset = "0x38ADE20", VA = "0x1838AEA20", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38AF940", Offset = "0x38AED40", VA = "0x1838AF940")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CCMLNNADAMF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49DA030", Offset = "0x49D9430", VA = "0x1849DA030", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49D9620", Offset = "0x49D8A20", VA = "0x1849D9620", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x49D8D30", Offset = "0x49D8130", VA = "0x1849D8D30")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LGKFGIIJCHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class BAOOPJPIKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float MBOMMDAEBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T KHLHBLNGCMJ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public BAOOPJPIKLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OBAHGDGAPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public OBAHGDGAPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4668550", Offset = "0x4667950", VA = "0x184668550")]
		internal bool CPEIFFHICFE(BAOOPJPIKLB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float MECBMILHIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float PPGEJGEEMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<BAOOPJPIKLB> HGFLGDFLNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JOLEMLILPLG<BAOOPJPIKLB> MCDAJBHNEBG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DLDPMHLJEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42342F0", Offset = "0x42336F0", VA = "0x1842342F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4234360", Offset = "0x4233760", VA = "0x184234360")]
	public LGKFGIIJCHL(float HCDHKMOBEHK, float OAAJGPBIKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4233E40", Offset = "0x4233240", VA = "0x184233E40")]
	public bool HGKIPDAACKK(float DMLNLLKJOKP, T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4233920", Offset = "0x4232D20", VA = "0x184233920")]
	public IEnumerable<T> BIHHBDDDNHJ(float DMLNLLKJOKP, [Optional] float? KMDGCFPIGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42341D0", Offset = "0x42335D0", VA = "0x1842341D0")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4233C90", Offset = "0x4233090", VA = "0x184233C90")]
	private void DNNCELOLDLM(float DMLNLLKJOKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GBPCFBMPKPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct MGAJILOILIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T KHLHBLNGCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float DONCGGEOHFA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float KLFMAIHCFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> BJKKLMGFAFA;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int DDHCBMPJCAH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MGAJILOILIB[] ELFCOFFIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int JHKOOHEGOJK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MFAENJAFGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA7D5A0", Offset = "0xA7C9A0", VA = "0x180A7D5A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA9F550", Offset = "0xA9E950", VA = "0x180A9F550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8470", Offset = "0x3CF7870", VA = "0x183CF8470")]
	public GBPCFBMPKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CF84B0", Offset = "0x3CF78B0", VA = "0x183CF84B0")]
	public GBPCFBMPKPM(int CGDIEJGGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7CB0", Offset = "0x3CF70B0", VA = "0x183CF7CB0")]
	public void HINMMBAADBG(float DMLNLLKJOKP, T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7EB0", Offset = "0x3CF72B0", VA = "0x183CF7EB0")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7960", Offset = "0x3CF6D60", VA = "0x183CF7960")]
	public bool GJFJPABANAK(float BLLGDIEHKHA, float HEIOPKGEFPJ, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7FA0", Offset = "0x3CF73A0", VA = "0x183CF7FA0")]
	public bool JDFOGGNEMMB(float BLLGDIEHKHA, float HEIOPKGEFPJ, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7520", Offset = "0x3CF6920", VA = "0x183CF7520")]
	public void CEBJNFKNDDF(float BLLGDIEHKHA, float HEIOPKGEFPJ, List<T> OAAIHOHLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF83E0", Offset = "0x3CF77E0", VA = "0x183CF83E0")]
	private int PLAENALCGHF(int CCGMFHJDBDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8390", Offset = "0x3CF7790", VA = "0x183CF8390")]
	private void JNDKKKPGEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HAOOMIMGDEG();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LJOBILHMOJK(T OBEEJPGJPFD, float JILAKCNFFBM);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JDOELICNBGP(T LJHBAHCCIGM, T EFOLFMFJLOF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GAMMIMBIEHL(T LJHBAHCCIGM, T EFOLFMFJLOF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IPMNHNJCOMK : GBPCFBMPKPM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85BD60", Offset = "0x85B160", VA = "0x18085BD60", Slot = "4")]
	protected override Vector3 HAOOMIMGDEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68C85B0", Offset = "0x68C79B0", VA = "0x1868C85B0", Slot = "5")]
	protected override Vector3 LJOBILHMOJK(Vector3 OBEEJPGJPFD, float JILAKCNFFBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68C8560", Offset = "0x68C7960", VA = "0x1868C8560", Slot = "6")]
	protected override Vector3 JDOELICNBGP(Vector3 LJHBAHCCIGM, Vector3 EFOLFMFJLOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68C84E0", Offset = "0x68C78E0", VA = "0x1868C84E0", Slot = "7")]
	protected override Vector3 GAMMIMBIEHL(Vector3 LJHBAHCCIGM, Vector3 EFOLFMFJLOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68C85F0", Offset = "0x68C79F0", VA = "0x1868C85F0")]
	public IPMNHNJCOMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JPCHAFDINAP
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7290", Offset = "0x2BE6690", VA = "0x182BE7290")]
	public static GPPONICEEPM<T1, T2> IBMNHJIAJMD<T1, T2>(T1 PPPHOKLGBJD, T2 MDGBBCFGPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7330", Offset = "0x2BE6730", VA = "0x182BE7330")]
	public static LCFBAECNEGE<T1, T2, T3> IBMNHJIAJMD<T1, T2, T3>(T1 PPPHOKLGBJD, T2 MDGBBCFGPNB, T3 GIFNKCGIADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44B7FE0", Offset = "0x44B73E0", VA = "0x1844B7FE0")]
	internal static int MILKJEIOLNL(int LKPGIMPLMLP, int IOGFBPDJKIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C70790", Offset = "0x5C6FB90", VA = "0x185C70790")]
	internal static int MILKJEIOLNL(int LKPGIMPLMLP, int IOGFBPDJKIF, int JEBKJDMLGDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GPPONICEEPM<T1, T2> : IComparable<GPPONICEEPM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 PNNLFCBHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 MAMNJCPLMHL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2CA70", Offset = "0x3D2BE70", VA = "0x183D2CA70")]
	public GPPONICEEPM(T1 PPPHOKLGBJD, T2 MDGBBCFGPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2AEC0", Offset = "0x3D2A2C0", VA = "0x183D2AEC0", Slot = "4")]
	public int CompareTo(GPPONICEEPM<T1, T2> IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B2C0", Offset = "0x3D2A6C0", VA = "0x183D2B2C0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BCD0", Offset = "0x3D2B0D0", VA = "0x183D2BCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3D2C670", Offset = "0x3D2BA70", VA = "0x183D2C670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LCFBAECNEGE<T1, T2, T3> : IComparable<LCFBAECNEGE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 PNNLFCBHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 MAMNJCPLMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 NKCLCPHFOAH;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x422AF70", Offset = "0x422A370", VA = "0x18422AF70")]
	public LCFBAECNEGE(T1 PPPHOKLGBJD, T2 MDGBBCFGPNB, T3 GIFNKCGIADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x422A640", Offset = "0x4229A40", VA = "0x18422A640", Slot = "4")]
	public int CompareTo(LCFBAECNEGE<T1, T2, T3> IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x422A9F0", Offset = "0x4229DF0", VA = "0x18422A9F0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x422AC10", Offset = "0x422A010", VA = "0x18422AC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x422ACB0", Offset = "0x422A0B0", VA = "0x18422ACB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2335B20", Offset = "0x2334F20", VA = "0x182335B20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2335C10", Offset = "0x2335010", VA = "0x182335C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float NEOCJMEBDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x995C10", Offset = "0x995010", VA = "0x180995C10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C20F20", Offset = "0x4C20320", VA = "0x184C20F20")]
	public T CMPMEDMCOHL(float JILAKCNFFBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4C211B0", Offset = "0x4C205B0", VA = "0x184C211B0")]
	public T PGNKKGKOMKL(float JILAKCNFFBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HCEMMDEIPMD(T LJHBAHCCIGM, T EFOLFMFJLOF, float JILAKCNFFBM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x68C73E0", Offset = "0x68C67E0", VA = "0x1868C73E0", Slot = "4")]
	protected override float HCEMMDEIPMD(float LJHBAHCCIGM, float EFOLFMFJLOF, float JILAKCNFFBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68C7420", Offset = "0x68C6820", VA = "0x1868C7420")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xF4E1E0", Offset = "0xF4D5E0", VA = "0x180F4E1E0", Slot = "4")]
	protected override Vector3 HCEMMDEIPMD(Vector3 LJHBAHCCIGM, Vector3 EFOLFMFJLOF, float JILAKCNFFBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68CD1A0", Offset = "0x68CC5A0", VA = "0x1868CD1A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68C72E0", Offset = "0x68C66E0", VA = "0x1868C72E0", Slot = "4")]
	protected override Color HCEMMDEIPMD(Color LJHBAHCCIGM, Color EFOLFMFJLOF, float JILAKCNFFBM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68C73A0", Offset = "0x68C67A0", VA = "0x1868C73A0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JOMDMGPJJBM : HKKOKMBDMOE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68C98A0", Offset = "0x68C8CA0", VA = "0x1868C98A0")]
	public JOMDMGPJJBM(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68C9830", Offset = "0x68C8C30", VA = "0x1868C9830", Slot = "6")]
	protected override uint ICGJNJAEIFD(uint KMHAFMEHDIB, string OBEEJPGJPFD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PDKPIHLJOFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable CLHFPJDPLGI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public PDKPIHLJOFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct EFACLAAPBLO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ALHONBPPLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int MLNMFLKLLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int FCOEKOBJDMD;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37EB850", Offset = "0x37EAC50", VA = "0x1837EB850")]
	private EFACLAAPBLO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MJMPDJGCKKG, int OFMPHGPODGD, int POEPDNILLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37F43A0", Offset = "0x37F37A0", VA = "0x1837F43A0")]
	public static EFACLAAPBLO<T> DDEJLDFANAB()
	{
		return default(EFACLAAPBLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37F5360", Offset = "0x37F4760", VA = "0x1837F5360")]
	public (int, int, Task<T>) EJJLDALPDKD(int CPCCBMAHCJD, [Optional] CancellationToken GNJJGEHBGKC, double NEHLEIDGFCE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37F4870", Offset = "0x37F3C70", VA = "0x1837F4870")]
	public void DPIMHAHIOAP(int CPCCBMAHCJD, int POEPDNILLNM, [In] T LLANANCGECL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MAOEMBELNGJ
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68C9B00", Offset = "0x68C8F00", VA = "0x1868C9B00")]
	public static EFACLAAPBLO<AEFODLADDHH> DDEJLDFANAB()
	{
		return default(EFACLAAPBLO<AEFODLADDHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x68C9B50", Offset = "0x68C8F50", VA = "0x1868C9B50")]
	public static void DPIMHAHIOAP([In] this EFACLAAPBLO<AEFODLADDHH> ABPJKOBADEP, int CPCCBMAHCJD, int POEPDNILLNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class ELKKPICELGN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> ENCFBEDMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> HHLCIOOMOHB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x35B8D10", Offset = "0x35B8110", VA = "0x1835B8D10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool LMFKAPMEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> PELJIFFDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x37ED4B0", Offset = "0x37EC8B0", VA = "0x1837ED4B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> LAJDOBJNEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3833650", Offset = "0x3832A50", VA = "0x183833650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3833590", Offset = "0x3832990", VA = "0x183833590", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x38336E0", Offset = "0x3832AE0", VA = "0x1838336E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3832F70", Offset = "0x3832370", VA = "0x183832F70")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38328F0", Offset = "0x3831CF0", VA = "0x1838328F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3833370", Offset = "0x3832770", VA = "0x183833370", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3832800", Offset = "0x3831C00", VA = "0x183832800", Slot = "9")]
	public void Add(TKey PEDCMDADFIN, TVal OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38328A0", Offset = "0x3831CA0", VA = "0x1838328A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3832990", Offset = "0x3831D90", VA = "0x183832990", Slot = "8")]
	public bool ContainsKey(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38329E0", Offset = "0x3831DE0", VA = "0x1838329E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38332B0", Offset = "0x38326B0", VA = "0x1838332B0", Slot = "10")]
	public bool Remove(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38332F0", Offset = "0x38326F0", VA = "0x1838332F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3833410", Offset = "0x3832810", VA = "0x183833410", Slot = "11")]
	public bool TryGetValue(TKey PEDCMDADFIN, [Out] TVal OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3832ED0", Offset = "0x38322D0", VA = "0x183832ED0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3832A60", Offset = "0x3831E60", VA = "0x183832A60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ELFCOFFIPBP, int PAHMHEIBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38331F0", Offset = "0x38325F0", VA = "0x1838331F0")]
	public bool LPPDNPILAFJ(TVal PEDCMDADFIN, [Out] TKey OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3832AE0", Offset = "0x3831EE0", VA = "0x183832AE0")]
	private void EBLIIBIPIHE(TKey PEDCMDADFIN, TVal ELOBPEFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3833100", Offset = "0x3832500", VA = "0x183833100")]
	private void LFNEILBGDNI(TKey PEDCMDADFIN, TVal ELOBPEFBAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3832CA0", Offset = "0x38320A0", VA = "0x183832CA0")]
	private bool EPAKLDFCBDK(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3833470", Offset = "0x3832870", VA = "0x183833470")]
	public ELKKPICELGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class OCAPIOGLIDF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private OCAPIOGLIDF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x38FB060", Offset = "0x38FA460", VA = "0x1838FB060", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x38FF830", Offset = "0x38FEC30", VA = "0x1838FF830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3900650", Offset = "0x38FFA50", VA = "0x183900650")]
		public Enumerator(OCAPIOGLIDF<T> OAAIHOHLDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x38FD150", Offset = "0x38FC550", VA = "0x1838FD150", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x38FEAF0", Offset = "0x38FDEF0", VA = "0x1838FEAF0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x38FC9D0", Offset = "0x38FBDD0", VA = "0x1838FC9D0")]
		private void EMIINNEKCJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] GGJIKPNMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int OCDCDAOIAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int BPGNOEICGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int FKMAFNEMDJH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x46700A0", Offset = "0x466F4A0", VA = "0x1846700A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x466FDA0", Offset = "0x466F1A0", VA = "0x18466FDA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x466F9C0", Offset = "0x466EDC0", VA = "0x18466F9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4670C60", Offset = "0x4670060", VA = "0x184670C60")]
	public OCAPIOGLIDF(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x466F8A0", Offset = "0x466ECA0", VA = "0x18466F8A0")]
	public void HINMMBAADBG(T JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4670050", Offset = "0x466F450", VA = "0x184670050")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x466EAD0", Offset = "0x466DED0", VA = "0x18466EAD0")]
	public void CHCDNKAGIMK(int MLMABEGDEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4670810", Offset = "0x466FC10", VA = "0x184670810")]
	public void PLBMKOIGLIM(T[] ELFCOFFIPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x466EC10", Offset = "0x466E010", VA = "0x18466EC10")]
	public Enumerator GHLGIEPLNLN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4670A00", Offset = "0x466FE00", VA = "0x184670A00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4670A00", Offset = "0x466FE00", VA = "0x184670A00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x466EF10", Offset = "0x466E310", VA = "0x18466EF10")]
	private int HBHICKOPIFD(int AGAGKNBDCIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4670070", Offset = "0x466F470", VA = "0x184670070")]
	private int LIECJGCNGGF(int AGAGKNBDCIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CNPJKLKKBEN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> BCFHBEKCNJI(TRequest BNAGIPDFDCE, CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum LJAPLLHCEKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HBGCCNBNAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float GEJDBECBMMO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan IMCKMMNHBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int HHKAHCNADKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LJAPLLHCEKD JPMIBKOAIAF;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly HBGCCNBNAFJ ONJGBPHIMMM;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float DLPEIGINBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3D50F60", Offset = "0x3D50360", VA = "0x183D50F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan KADEIGDLBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D51120", Offset = "0x3D50520", VA = "0x183D51120")]
		public HBGCCNBNAFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct LFDACHPDNIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest BNAGIPDFDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken GNJJGEHBGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> HJBBEHMCLOD;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x42318A0", Offset = "0x4230CA0", VA = "0x1842318A0")]
		public LFDACHPDNIM(TRequest BNAGIPDFDCE, TaskCompletionSource<TResult> HJBBEHMCLOD, CancellationToken GNJJGEHBGKC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JANDEKABCGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CNPJKLKKBEN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4017EA0", Offset = "0x40172A0", VA = "0x184017EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4018B60", Offset = "0x4017F60", VA = "0x184018B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CAEHGMLAEMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CNPJKLKKBEN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LFDACHPDNIM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4F33F60", Offset = "0x4F33360", VA = "0x184F33F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4F35230", Offset = "0x4F34630", VA = "0x184F35230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource DFPJDNDBAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<LFDACHPDNIM> DNNJFBPINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HBGCCNBNAFJ KKFECDEIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BCFHBEKCNJI KIFDIIIIFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task ACKPNNJFDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int OKALFAFKHEH;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x503DA20", Offset = "0x503CE20", VA = "0x18503DA20")]
	public CNPJKLKKBEN(BCFHBEKCNJI KIFDIIIIFPN, [Optional] HBGCCNBNAFJ KKFECDEIIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x503C450", Offset = "0x503B850", VA = "0x18503C450")]
	public Task<TResult> FONHANDGJKJ(TRequest BNAGIPDFDCE, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x503CCC0", Offset = "0x503C0C0", VA = "0x18503CCC0")]
	private void LMMKGKHNCOL(LFDACHPDNIM LDJCFHKAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x503C670", Offset = "0x503BA70", VA = "0x18503C670")]
	[AsyncStateMachine(typeof(CNPJKLKKBEN<, >.JANDEKABCGE))]
	private Task HAKCNAKBBLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x503CE60", Offset = "0x503C260", VA = "0x18503CE60")]
	private LFDACHPDNIM OEHMEIJIBGB()
	{
		return default(LFDACHPDNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x503BE70", Offset = "0x503B270", VA = "0x18503BE70")]
	[AsyncStateMachine(typeof(CNPJKLKKBEN<, >.CAEHGMLAEMP))]
	private Task DNHIOPDAGEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x503CAE0", Offset = "0x503BEE0", VA = "0x18503CAE0")]
	private void HPEBGLBMLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x503BF60", Offset = "0x503B360", VA = "0x18503BF60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class LGCBMPCGEAF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> EGGGJKKPDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> NAGNJNKIMPK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x35B8D10", Offset = "0x35B8110", VA = "0x1835B8D10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LMFKAPMEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2891280", Offset = "0x2890680", VA = "0x182891280", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4233330", Offset = "0x4232730", VA = "0x184233330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C544F0", Offset = "0x3C538F0", VA = "0x183C544F0", Slot = "11")]
	public void Add(T OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4232960", Offset = "0x4231D60", VA = "0x184232960")]
	public bool GIDGJLJDBPM(T OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4233150", Offset = "0x4232550", VA = "0x184233150", Slot = "15")]
	public bool Remove(T OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C850", Offset = "0x3E7BC50", VA = "0x183E7C850", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3C67E60", Offset = "0x3C67260", VA = "0x183C67E60", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4232810", Offset = "0x4231C10", VA = "0x184232810", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x42328B0", Offset = "0x4231CB0", VA = "0x1842328B0", Slot = "13")]
	public bool Contains(T OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4232900", Offset = "0x4231D00", VA = "0x184232900", Slot = "14")]
	public void CopyTo(T[] ELFCOFFIPBP, int PAHMHEIBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x41EFA50", Offset = "0x41EEE50", VA = "0x1841EFA50", Slot = "6")]
	public int IndexOf(T OFMNHGBOMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4232CB0", Offset = "0x42320B0", VA = "0x184232CB0", Slot = "7")]
	public void Insert(int AGAGKNBDCIG, T OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4232DF0", Offset = "0x42321F0", VA = "0x184232DF0", Slot = "8")]
	public void RemoveAt(int AGAGKNBDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4233210", Offset = "0x4232610", VA = "0x184233210")]
	public LGCBMPCGEAF()
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
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21EB8A0", Offset = "0x21EACA0", VA = "0x1821EB8A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68CC730", Offset = "0x68CBB30", VA = "0x1868CC730")]
		public SerializedGuid([In] Guid HLKHAOEDAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x68CC450", Offset = "0x68CB850", VA = "0x1868CC450")]
		public static SerializedGuid EEOLELGLAFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x68CC6C0", Offset = "0x68CBAC0", VA = "0x1868CC6C0")]
		public static SerializedGuid PFLPJLOBMMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68CC5B0", Offset = "0x68CB9B0", VA = "0x1868CC5B0")]
		public bool OODFNLHIOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x68CC690", Offset = "0x68CBA90", VA = "0x1868CC690", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68CC610", Offset = "0x68CBA10", VA = "0x1868CC610", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x68CC4D0", Offset = "0x68CB8D0", VA = "0x1868CC4D0", Slot = "7")]
		public bool Equals(SerializedGuid IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x68CC510", Offset = "0x68CB910", VA = "0x1868CC510", Slot = "0")]
		public override bool Equals(object LALIGKIKEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68CC5A0", Offset = "0x68CB9A0", VA = "0x1868CC5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68CC420", Offset = "0x68CB820", VA = "0x1868CC420", Slot = "6")]
		public int CompareTo(SerializedGuid IEDCHGMDIML)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CPIBPOODDIF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type LEPGJAIJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string FBJCDDBDNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool DBMEKGCOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool FHICNAEPPJM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x68C7270", Offset = "0x68C6670", VA = "0x1868C7270")]
	public CPIBPOODDIF(Type GOKBAAFENJM, string BLKLAMHIOKA, bool NKJCCLBKFME = false, bool BPCLCCILHFP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DALGFCOOFMD<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct HPAFLFKEGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long HDHKPIDFJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long BHMHEKICELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int GOAMBIDCBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int IGIHICIFNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool CMIGMAFPLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string NFJMEHONODN;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1E60", Offset = "0x3DA1260", VA = "0x183DA1E60")]
		public HPAFLFKEGDI(long HDHKPIDFJKJ, int GOAMBIDCBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1E30", Offset = "0x3DA1230", VA = "0x183DA1E30")]
		public HPAFLFKEGDI(long HDHKPIDFJKJ, long BHMHEKICELN, int GOAMBIDCBLG, int IGIHICIFNLM, bool CMIGMAFPLGD, string NFJMEHONODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1D40", Offset = "0x3DA1140", VA = "0x183DA1D40")]
		public int PAOMDCGHOJK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1CC0", Offset = "0x3DA10C0", VA = "0x183DA1CC0")]
		public int BBNHDIDEIEN(int IFDMMFPKCGG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1CE0", Offset = "0x3DA10E0", VA = "0x183DA1CE0")]
		public double FOLLFGJODKE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DA1D90", Offset = "0x3DA1190", VA = "0x183DA1D90")]
		public HPAFLFKEGDI PJALOOENGMM(long BHMHEKICELN, int IGIHICIFNLM)
		{
			return default(HPAFLFKEGDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class EKHHBLIDCCH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct AFOHBMBBFBO<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EKHHBLIDCCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<EKHHBLIDCCH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private EKHHBLIDCCH <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3D64D00", Offset = "0x3D64100", VA = "0x183D64D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3D65230", Offset = "0x3D64630", VA = "0x183D65230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey IHHIJGDCGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly DALGFCOOFMD<TKey> JAHFGCAKLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly BADOKLEEAHE MMCLBKHCHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<EKHHBLIDCCH> DOHEDOPCPJI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string IEBLMECJOFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x380E9E0", Offset = "0x380DDE0", VA = "0x18380E9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<EKHHBLIDCCH> BKLBHPKCBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x380E550", Offset = "0x380D950", VA = "0x18380E550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HPAFLFKEGDI JDDGKNOOPOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x380E990", Offset = "0x380DD90", VA = "0x18380E990")]
			[CompilerGenerated]
			get
			{
				return default(HPAFLFKEGDI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x380E9B0", Offset = "0x380DDB0", VA = "0x18380E9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x380EA30", Offset = "0x380DE30", VA = "0x18380EA30")]
		internal EKHHBLIDCCH(DALGFCOOFMD<TKey> JAHFGCAKLME, TKey PEDCMDADFIN, BADOKLEEAHE MMCLBKHCHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x380E7E0", Offset = "0x380DBE0", VA = "0x18380E7E0")]
		public EKHHBLIDCCH FFNOGCEEBGB(TKey PEDCMDADFIN, [Optional] BADOKLEEAHE? FJFHGEIFLCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x29C5DA0", Offset = "0x29C51A0", VA = "0x1829C5DA0")]
		[AsyncStateMachine(typeof(AFOHBMBBFBO<>))]
		public Task<T> HDOIABLAFIG<T>(TKey PEDCMDADFIN, Func<EKHHBLIDCCH, Task<T>> IAJCFKFGJIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x380E590", Offset = "0x380D990", VA = "0x18380E590", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DFPMMAPJHPF : IEnumerable<(TKey, List<TKey>, HPAFLFKEGDI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HPAFLFKEGDI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, HPAFLFKEGDI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DALGFCOOFMD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, HPAFLFKEGDI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, HPAFLFKEGDI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x21E59E0", Offset = "0x21E4DE0", VA = "0x1821E59E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HPAFLFKEGDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x578B740", Offset = "0x578AB40", VA = "0x18578B740", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21E5AD0", Offset = "0x21E4ED0", VA = "0x1821E5AD0")]
		[DebuggerHidden]
		public DFPMMAPJHPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x39D6180", Offset = "0x39D5580", VA = "0x1839D6180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x578B280", Offset = "0x578A680", VA = "0x18578B280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x578B230", Offset = "0x578A630", VA = "0x18578B230")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x578B6F0", Offset = "0x578AAF0", VA = "0x18578B6F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x578B620", Offset = "0x578AA20", VA = "0x18578B620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HPAFLFKEGDI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3833BF0", Offset = "0x3832FF0", VA = "0x183833BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class MLDAMOMDNGF : IEnumerable<(TKey, List<TKey>, HPAFLFKEGDI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HPAFLFKEGDI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, HPAFLFKEGDI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private EKHHBLIDCCH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EKHHBLIDCCH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DALGFCOOFMD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<EKHHBLIDCCH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, HPAFLFKEGDI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, HPAFLFKEGDI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x21E59E0", Offset = "0x21E4DE0", VA = "0x1821E59E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HPAFLFKEGDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x44583C0", Offset = "0x44577C0", VA = "0x1844583C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x21E5AD0", Offset = "0x21E4ED0", VA = "0x1821E5AD0")]
		[DebuggerHidden]
		public MLDAMOMDNGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4458420", Offset = "0x4457820", VA = "0x184458420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4457A00", Offset = "0x4456E00", VA = "0x184457A00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x44579A0", Offset = "0x4456DA0", VA = "0x1844579A0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x44581D0", Offset = "0x44575D0", VA = "0x1844581D0")]
		private void OANBEGBCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4458370", Offset = "0x4457770", VA = "0x184458370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4458230", Offset = "0x4457630", VA = "0x184458230", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HPAFLFKEGDI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4458330", Offset = "0x4457730", VA = "0x184458330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, HPAFLFKEGDI, BADOKLEEAHE> ABICOIKMNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, HPAFLFKEGDI, BADOKLEEAHE> FIDPFODJBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<DALGFCOOFMD<TKey>, BADOKLEEAHE> IFFHACOFBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EKHHBLIDCCH JJLAEGNMEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool OFBHCPGMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int HGIANPFMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch EAPDIIJCEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int NFNECBJFJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string MJPDGPEKABJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EKHHBLIDCCH NLLOLIGOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string IEBLMECJOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5772FB0", Offset = "0x57723B0", VA = "0x185772FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5773010", Offset = "0x5772410", VA = "0x185773010")]
	public DALGFCOOFMD(TKey FCDPJEJFKOI, BADOKLEEAHE MMCLBKHCHDA, [Optional] int? GOAMBIDCBLG, [Optional][CanBeNull] Stopwatch EAPDIIJCEAD, [Optional] Action<TKey, HPAFLFKEGDI, BADOKLEEAHE> ABICOIKMNHB, [Optional] Action<TKey, HPAFLFKEGDI, BADOKLEEAHE> FIDPFODJBHG, [Optional] Action<DALGFCOOFMD<TKey>, BADOKLEEAHE> IFFHACOFBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5772EE0", Offset = "0x57722E0", VA = "0x185772EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5772E40", Offset = "0x5772240", VA = "0x185772E40")]
	[IteratorStateMachine(typeof(DALGFCOOFMD<>.DFPMMAPJHPF))]
	public IEnumerable<(TKey, List<TKey>, HPAFLFKEGDI)> BKGDIMEHKGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5772D60", Offset = "0x5772160", VA = "0x185772D60")]
	[IteratorStateMachine(typeof(DALGFCOOFMD<>.MLDAMOMDNGF))]
	private IEnumerable<(TKey, List<TKey>, HPAFLFKEGDI)> BKGDIMEHKGF(List<TKey> EMHGIKAPEJF, EKHHBLIDCCH GMNAONMCEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5772CE0", Offset = "0x57720E0", VA = "0x185772CE0")]
	private (long, int) AAMDFBDOBBE()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class LFFMKMNFBPK<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BDEEPPBMFIL(DALGFCOOFMD<TKey> JAHFGCAKLME);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	protected LFFMKMNFBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class JNBJGCFHJAA<TKey> : LFFMKMNFBPK<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string ODMOMFCNDAE(TKey PEDCMDADFIN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4079870", Offset = "0x4078C70", VA = "0x184079870")]
	private static string DLPGKGKLHEP(TKey PEDCMDADFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4079640", Offset = "0x4078A40", VA = "0x184079640", Slot = "4")]
	public override string BDEEPPBMFIL(DALGFCOOFMD<TKey> JAHFGCAKLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4079720", Offset = "0x4078B20", VA = "0x184079720")]
	public string BDEEPPBMFIL(DALGFCOOFMD<TKey> JAHFGCAKLME, [NotNull] ODMOMFCNDAE ICGPLBNAIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BFGONNJNIPK(DALGFCOOFMD<TKey> JAHFGCAKLME, [NotNull] ODMOMFCNDAE ICGPLBNAIND);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DFE0", Offset = "0x3E4D3E0", VA = "0x183E4DFE0")]
	protected JNBJGCFHJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FHKHOKNFBFF<TKey> : LFFMKMNFBPK<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string JDFJAHIIAJG(TKey PEDCMDADFIN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string IGLKBMDGFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double MGMEBKMEMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool GPACFOMDMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int CDPGEADJEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> EHOAAGLEONL;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F270", Offset = "0x3C1E670", VA = "0x183C1F270")]
	private static string DLPGKGKLHEP(TKey PEDCMDADFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F680", Offset = "0x3C1EA80", VA = "0x183C1F680")]
	public FHKHOKNFBFF(string IGLKBMDGFCD = "F2", double MGMEBKMEMBC = double.MaxValue, bool GPACFOMDMLJ = false, int CDPGEADJEJK = int.MaxValue, [Optional] ISet<string> EHOAAGLEONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F0B0", Offset = "0x3C1E4B0", VA = "0x183C1F0B0", Slot = "4")]
	public override Dictionary<string, string> BDEEPPBMFIL(DALGFCOOFMD<TKey> JAHFGCAKLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F190", Offset = "0x3C1E590", VA = "0x183C1F190")]
	private bool CDEDALGMHLC(string HLIIPABLKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3C1EA70", Offset = "0x3C1DE70", VA = "0x183C1EA70")]
	public Dictionary<string, string> BDEEPPBMFIL(DALGFCOOFMD<TKey> JAHFGCAKLME, JDFJAHIIAJG ICGPLBNAIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F410", Offset = "0x3C1E810", VA = "0x183C1F410")]
	private string LKCJGNABGAI(StringBuilder LIEICELABOE, List<TKey> PKHFONHNJKE, JDFJAHIIAJG ICGPLBNAIND, bool GFFPPOEGLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F2B0", Offset = "0x3C1E6B0", VA = "0x183C1F2B0")]
	private static void HPMOAOANKPK(StringBuilder LHIDKFMPBNO, string HIDOKMMMLCH, bool JKMFHONHLID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class EOOHFOEIECF<TKey> : JNBJGCFHJAA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AKJGFMDCPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ODMOMFCNDAE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static EOOHFOEIECF<TKey> CLHFPJDPLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] ABFKIMCMFMN;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x38AA530", Offset = "0x38A9930", VA = "0x1838AA530")]
	private EOOHFOEIECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x38A9480", Offset = "0x38A8880", VA = "0x1838A9480", Slot = "5")]
	protected override string BFGONNJNIPK(DALGFCOOFMD<TKey> JAHFGCAKLME, ODMOMFCNDAE ICGPLBNAIND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x38AA2F0", Offset = "0x38A96F0", VA = "0x1838AA2F0")]
	[CompilerGenerated]
	internal static string DBOKCFOIJAD(string MNHPJBPNAJP, TKey PEDCMDADFIN, AKJGFMDCPPG P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LLIPGJALFMO : DALGFCOOFMD<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CLENCHGKJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<LLIPGJALFMO, BADOKLEEAHE> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public CLENCHGKJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68C71E0", Offset = "0x68C65E0", VA = "0x1868C71E0")]
		internal void IELEDLNHBGH(DALGFCOOFMD<string> timer, BADOKLEEAHE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x68C99B0", Offset = "0x68C8DB0", VA = "0x1868C99B0")]
	public LLIPGJALFMO(BADOKLEEAHE MMCLBKHCHDA, [Optional] string JOJCPAJKEIC, [Optional] int? GOAMBIDCBLG, [Optional] Stopwatch EAPDIIJCEAD, [Optional] Action<string, HPAFLFKEGDI, BADOKLEEAHE> ABICOIKMNHB, [Optional] Action<string, HPAFLFKEGDI, BADOKLEEAHE> FIDPFODJBHG, [Optional] Action<LLIPGJALFMO, BADOKLEEAHE> IFFHACOFBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68C98F0", Offset = "0x68C8CF0", VA = "0x1868C98F0")]
	private static Action<DALGFCOOFMD<string>, BADOKLEEAHE> BJJBHFFMHBM(Action<LLIPGJALFMO, BADOKLEEAHE> PKJIBFLDCKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class CJNBOELDMEN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OEOMFHHKOBO : CJNBOELDMEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static CJNBOELDMEN CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x68C9CB0", Offset = "0x68C90B0", VA = "0x1868C9CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float EOMIFMDAGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xA7D8A0", Offset = "0xA7CCA0", VA = "0x180A7D8A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68C9DB0", Offset = "0x68C91B0", VA = "0x1868C9DB0")]
		public OEOMFHHKOBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static CJNBOELDMEN IJANECFDFOL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static CJNBOELDMEN ONJGBPHIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x68C7070", Offset = "0x68C6470", VA = "0x1868C7070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float EOMIFMDAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	protected CJNBOELDMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AAJBDCMNIBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface LEENANICOKB<T> : AAJBDCMNIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> OMHGPBOFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	PDKNJFNMHJF<T> CNIJMADGCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class MOJPJBNOGFH
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C57280", Offset = "0x2C56680", VA = "0x182C57280")]
	public static LEENANICOKB<TResource> ADHOJNNBOBO<TResource, TId>(this MOLKPPMKELD<TId, TResource> DKPFLLMGALD, TId GNBDDFJPEIA, [Optional] Func<TId, CancellationToken, Task<TResource>>? NBBIEMFABAA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KHGPHBDOIKA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class LCGDKNMAGLG<T> : PAONLMLDPBF<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override PDKNJFNMHJF<T?> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x422AFC0", Offset = "0x422A3C0", VA = "0x18422AFC0")]
		public LCGDKNMAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class LIBINLLIEMM<T> : PAONLMLDPBF<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T HMINBLBNLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? JFIHFJMLFBG;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override PDKNJFNMHJF<T> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x42365D0", Offset = "0x42359D0", VA = "0x1842365D0")]
		public LIBINLLIEMM(T MKGIJENNKIC, Action<T>? EKIBOKOLFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4236390", Offset = "0x4235790", VA = "0x184236390", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class BDIPOLGONCE<T> : PAONLMLDPBF<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override PDKNJFNMHJF<T> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4E8CBC0", Offset = "0x4E8BFC0", VA = "0x184E8CBC0")]
		public BDIPOLGONCE(Exception AGGBGAFAKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class CBFCEIALFCD<T> : PAONLMLDPBF<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct HFJFKFFPBGM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<LEENANICOKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<LEENANICOKB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3D58E90", Offset = "0x3D58290", VA = "0x183D58E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3D59870", Offset = "0x3D58C70", VA = "0x183D59870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct IMJLPOEFMAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<LEENANICOKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<LEENANICOKB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3E760D0", Offset = "0x3E754D0", VA = "0x183E760D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3E76590", Offset = "0x3E75990", VA = "0x183E76590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<LEENANICOKB<T>> LLDEONNBONB;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override PDKNJFNMHJF<T> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4F41DB0", Offset = "0x4F411B0", VA = "0x184F41DB0")]
		public CBFCEIALFCD(Task<LEENANICOKB<T>> LKENJOBMDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4F41B60", Offset = "0x4F40F60", VA = "0x184F41B60", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F41960", Offset = "0x4F40D60", VA = "0x184F41960")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CBFCEIALFCD<>.HFJFKFFPBGM))]
		internal static Task<T> ELCCCJAINJC(Task<LEENANICOKB<T>> LKENJOBMDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4F41CD0", Offset = "0x4F410D0", VA = "0x184F41CD0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CBFCEIALFCD<>.IMJLPOEFMAI))]
		internal static Task MPNCKCNGPLG(Task<LEENANICOKB<T>> LKENJOBMDDP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class HKGGCCODAJA<TIn, TOut> : PAONLMLDPBF<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct DFAPEAABLPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5789A30", Offset = "0x5788E30", VA = "0x185789A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x47D4B80", Offset = "0x47D3F80", VA = "0x1847D4B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly LEENANICOKB<TIn> HECPJHOEMGJ;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> OMHGPBOFNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override PDKNJFNMHJF<TOut> CNIJMADGCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3D83FA0", Offset = "0x3D833A0", VA = "0x183D83FA0")]
		public HKGGCCODAJA(LEENANICOKB<TIn> NIHFCCHFMAN, Func<TIn, TOut> PHADMFFIEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3D83C00", Offset = "0x3D83000", VA = "0x183D83C00", Slot = "10")]
		protected override void KCIJMIMFFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3D83E20", Offset = "0x3D83220", VA = "0x183D83E20")]
		[AsyncStateMachine(typeof(HKGGCCODAJA<, >.DFAPEAABLPB))]
		[CompilerGenerated]
		internal static Task<TOut> NKKNAFDKLNC(Task<TIn> FIOAAMBLFAL, Func<TIn, TOut> PHADMFFIEME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2C22AB0", Offset = "0x2C21EB0", VA = "0x182C22AB0")]
	public static LEENANICOKB<T> ADMHPKLFINC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2C22B30", Offset = "0x2C21F30", VA = "0x182C22B30")]
	public static LEENANICOKB<T> GDLIIONDGMM<T>(T LLANANCGECL, [Optional] Action<T>? EKIBOKOLFHK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static LEENANICOKB<T> MFFKDAFDNCI<T>(Exception AGGBGAFAKGH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static LEENANICOKB<T> LLHPBPHBHJL<T>(Task<LEENANICOKB<T>> LKENJOBMDDP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2993FE0", Offset = "0x29933E0", VA = "0x182993FE0")]
	public static LEENANICOKB<TOut> PEDBLOEBMGJ<TOut, TIn>(LEENANICOKB<TIn> EELBLNNILCF, Func<TIn, TOut> PHADMFFIEME) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class PAONLMLDPBF<T> : LEENANICOKB<T>, AAJBDCMNIBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string JAEFBPCKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly MNJBIBIKDGH KKOJGFIHBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool OFBHCPGMGBM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC56E70", Offset = "0xC56270", VA = "0x180C56E70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> OMHGPBOFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract PDKNJFNMHJF<T> CNIJMADGCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47C5E20", Offset = "0x47C5220", VA = "0x1847C5E20")]
	public PAONLMLDPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x47C5970", Offset = "0x47C4D70", VA = "0x1847C5970", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KCIJMIMFFKD();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class AAHNHJJMCHN<TTask, T> : PAONLMLDPBF<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CDECACHKLGC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CDECACHKLGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x35A6C80", Offset = "0x35A6080", VA = "0x1835A6C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x35A6F40", Offset = "0x35A6340", VA = "0x1835A6F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AAHNHJJMCHN<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public CDECACHKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5029EC0", Offset = "0x50292C0", VA = "0x185029EC0")]
		[AsyncStateMachine(typeof(AAHNHJJMCHN<, >.CDECACHKLGC.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JACCELCDMNF(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> LKENJOBMDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource CJDNALLBGNA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> OMHGPBOFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override PDKNJFNMHJF<T> CNIJMADGCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3C94F20", Offset = "0x3C94320", VA = "0x183C94F20")]
	protected AAHNHJJMCHN(TTask LKENJOBMDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3C94CD0", Offset = "0x3C940D0", VA = "0x183C94CD0", Slot = "10")]
	protected override void KCIJMIMFFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T AMLEKBCPMFG(TTask INNGIFCLJJK);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GHLAODMOCOE();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EIILLMEOMFN<T> : PAONLMLDPBF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HBLPGBNKBAE<Task<T>> KCODEADNCKP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> OMHGPBOFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3808E90", Offset = "0x3808290", VA = "0x183808E90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override PDKNJFNMHJF<T> CNIJMADGCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3808F00", Offset = "0x3808300", VA = "0x183808F00")]
	public EIILLMEOMFN(HBLPGBNKBAE<Task<T>> NJHAFPCLOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3808EE0", Offset = "0x38082E0", VA = "0x183808EE0", Slot = "10")]
	protected override void KCIJMIMFFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ONKIPBNHNFE
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName GBGOFFAICGI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> LKMPANGODIK;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68CA4A0", Offset = "0x68C98A0", VA = "0x1868CA4A0")]
	public static int KBGDAHJGEGE(this KGJNOBJGJIA GHHNLLGFLJG, IncrementalHash KMHAFMEHDIB, byte[] NFIHGKNDBPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68CA110", Offset = "0x68C9510", VA = "0x1868CA110")]
	public static bool HPCHGBOOHCL([CanBeNull] this KGJNOBJGJIA GHHNLLGFLJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x68C9E00", Offset = "0x68C9200", VA = "0x1868C9E00")]
	public static bool HPCHGBOOHCL([CanBeNull] this KGJNOBJGJIA GHHNLLGFLJG, [Out] string ODIFAFDGMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68CA170", Offset = "0x68C9570", VA = "0x1868CA170")]
	public static bool HPCHGBOOHCL([CanBeNull] this KGJNOBJGJIA GHHNLLGFLJG, IncrementalHash KMHAFMEHDIB, byte[] NFIHGKNDBPM, [Out] string ODIFAFDGMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68CA520", Offset = "0x68C9920", VA = "0x1868CA520")]
	private static bool MOOELHPKIEN(byte[] KABJIADHGHE, Span<byte> POCAFAGKGOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class PPEIBGEIIIB
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68CAE90", Offset = "0x68CA290", VA = "0x1868CAE90")]
	public static int KHDKNGDHFDG(HashAlgorithmName OKEJPBGHLFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68CAC30", Offset = "0x68CA030", VA = "0x1868CAC30")]
	public static int KBGDAHJGEGE(this JIKEBABGBEP BMMJOIBBHDD, byte[] ENNPLBGKMBP, IncrementalHash KMHAFMEHDIB, byte[] FHJMKANBFBA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface JIKEBABGBEP
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KMHAFMEHDIB);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KGJNOBJGJIA : JIKEBABGBEP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] ILLEOMKEJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] COLBKKKDGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JIBDOGBPCNF
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool GGPCKEJKMOA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> MJHMNIMEPHA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> DEGMJAMEGDB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding EBIEECEABFE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> NBPJOMMKALM;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB1F0", Offset = "0x2BDA5F0", VA = "0x182BDB1F0")]
	public static void NCIKBFAABPP<T>(this IncrementalHash JLGECJIDNGP, [CanBeNull] T CCAECJLGEFJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB2B0", Offset = "0x2BDA6B0", VA = "0x182BDB2B0")]
	public static void PEGBBDICAKE<T>(this IncrementalHash JLGECJIDNGP, [CanBeNull] T BMMJOIBBHDD) where T : JIKEBABGBEP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2BDACD0", Offset = "0x2BDA0D0", VA = "0x182BDACD0")]
	public static void LFNBCKALONJ<T>(this IncrementalHash JLGECJIDNGP, [CanBeNull] IList<T> ILIFOOAADEK) where T : JIKEBABGBEP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68C8780", Offset = "0x68C7B80", VA = "0x1868C8780")]
	private static bool ALMFMCOOIEJ([CanBeNull] JIKEBABGBEP BMMJOIBBHDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68C8AA0", Offset = "0x68C7EA0", VA = "0x1868C8AA0")]
	public static void IJHPIOBOBAA(this IncrementalHash KMHAFMEHDIB, string? ILJAHNDNFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68C88D0", Offset = "0x68C7CD0", VA = "0x1868C88D0")]
	public static void FIDCNDGFGJJ(this IncrementalHash KMHAFMEHDIB, long PMHLCGLKAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68C91F0", Offset = "0x68C85F0", VA = "0x1868C91F0")]
	public static void NLNLHKEAGEC(this IncrementalHash KMHAFMEHDIB, int HMHLEJDPHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68C93C0", Offset = "0x68C87C0", VA = "0x1868C93C0")]
	public static void PBAIDINIMFJ(this IncrementalHash KMHAFMEHDIB, short JMLCMJEMJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x68C8F10", Offset = "0x68C8310", VA = "0x1868C8F10")]
	public static void LBMHJBLHJJC(this IncrementalHash KMHAFMEHDIB, byte EIGDLKNKIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68C9020", Offset = "0x68C8420", VA = "0x1868C9020")]
	public static void LIIILEEDILK(this IncrementalHash KMHAFMEHDIB, bool NJEMPKJEDJB, bool AMLKJMPDELN = false, bool HJEGNNMHGNL = false, bool MNGPFKDELBF = false, bool ABIPCDDBHKI = false, bool NFEJHDLFLON = false, bool IOINCPAPKNE = false, bool BOBJIBIBDCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2BDA6A0", Offset = "0x2BD9AA0", VA = "0x182BDA6A0")]
	public static void BKHPEKDFICN<T>(this IncrementalHash KMHAFMEHDIB, T LOBINIIDBBA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68C9190", Offset = "0x68C8590", VA = "0x1868C9190")]
	public static void NFIIAFIOOHP(this IncrementalHash KMHAFMEHDIB, float JGLICBAENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68C8870", Offset = "0x68C7C70", VA = "0x1868C8870")]
	public static void FGDAHNBHENO(this IncrementalHash KMHAFMEHDIB, ulong FGKPJBFEIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68C8EB0", Offset = "0x68C82B0", VA = "0x1868C8EB0")]
	public static void JMLADONDFHJ(this IncrementalHash KMHAFMEHDIB, uint LIBKLFGNIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68C8810", Offset = "0x68C7C10", VA = "0x1868C8810")]
	public static void EJKNMGILEGA(this IncrementalHash KMHAFMEHDIB, ushort PECHIJFCJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x68C8650", Offset = "0x68C7A50", VA = "0x1868C8650")]
	public static void AINCLPHPAMA(this IncrementalHash KMHAFMEHDIB, Vector3 CGDHIJMGDNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NAMFPAPOHDK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68C9BD0", Offset = "0x68C8FD0", VA = "0x1868C9BD0")]
	public NAMFPAPOHDK(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class HMGDKEIFHJJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PEDDLGMFPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode ABPJKOBADEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode KOBAADDGPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CDLFIBNLEJD FBHCNLEEELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<CDLFIBNLEJD> ELIELKICHBJ;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PEDDLGMFPCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct CDLFIBNLEJD : IComparable<CDLFIBNLEJD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int OMFADEMDLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant JGMPIJNPIGO;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xEAD7B0", Offset = "0xEACBB0", VA = "0x180EAD7B0")]
		public CDLFIBNLEJD(int OMFADEMDLDL, TClaimant JGMPIJNPIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x502A2C0", Offset = "0x50296C0", VA = "0x18502A2C0")]
		public bool GGJJOIOIDNB([In] CDLFIBNLEJD IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x502A320", Offset = "0x5029720", VA = "0x18502A320")]
		public bool PHIJHIHJMFA([In] CDLFIBNLEJD IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x502A2B0", Offset = "0x50296B0", VA = "0x18502A2B0", Slot = "4")]
		public int CompareTo(CDLFIBNLEJD IEDCHGMDIML)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x502A330", Offset = "0x5029730", VA = "0x18502A330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum HNGJIHCPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FNMLOGHJDEF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public HMGDKEIFHJJ<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public FNMLOGHJDEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C38BD0", Offset = "0x3C37FD0", VA = "0x183C38BD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C38DB0", Offset = "0x3C381B0", VA = "0x183C38DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C38CB0", Offset = "0x3C380B0", VA = "0x183C38CB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x39D6C90", Offset = "0x39D6090", VA = "0x1839D6C90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly JOLEMLILPLG<PEDDLGMFPCH> DJAEINCMLHN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly JOLEMLILPLG<List<CDLFIBNLEJD>> JEHJDHDFFIL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int HAHLNGALIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> KKBNIBIADDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, PEDDLGMFPCH> EICBLDCIEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private HNGJIHCPNPC KBNNEODEGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool BHKOIIDPEHB;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EEALNLHOGOG(TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NGNPDPPMAHJ(TNode ILPFPPMNEDJ, TClaimant EDGLAFIBNJG, TClaimant NAICACIOJMN);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3D91250", Offset = "0x3D90650", VA = "0x183D91250")]
	public HMGDKEIFHJJ(HNGJIHCPNPC KBNNEODEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3D90FC0", Offset = "0x3D903C0", VA = "0x183D90FC0")]
	public void PGKBOAIMPBC(TNode ILPFPPMNEDJ, TNode DADNCNLHDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F840", Offset = "0x3D8EC40", VA = "0x183D8F840")]
	public void BBBDJIKGBIC(TClaimant JGMPIJNPIGO, TNode BFEOBKDCJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FD20", Offset = "0x3D8F120", VA = "0x183D8FD20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3D90BA0", Offset = "0x3D8FFA0", VA = "0x183D90BA0")]
	private void OEOJAJMGBAH(TClaimant JGMPIJNPIGO, TNode COHPIBJDIDH, TNode BFEOBKDCJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FCB0", Offset = "0x3D8F0B0", VA = "0x183D8FCB0")]
	private int DKCJBGLIMAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3D90C70", Offset = "0x3D90070", VA = "0x183D90C70")]
	private void PDCBGIPJOFF(TClaimant JGMPIJNPIGO, TNode NHPIHOLOEKN, TNode JCJNFDHLFJO, int LFBNCANJEOD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F770", Offset = "0x3D8EB70", VA = "0x183D8F770")]
	private void ANKGFHKBGHG(CDLFIBNLEJD CMBNOEOILIA, PEDDLGMFPCH CAHNDBICCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F9C0", Offset = "0x3D8EDC0", VA = "0x183D8F9C0")]
	private void CHEBGDFGJIF(TClaimant JGMPIJNPIGO, TNode NHPIHOLOEKN, TNode JCJNFDHLFJO, int LFBNCANJEOD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3D90020", Offset = "0x3D8F420", VA = "0x183D90020")]
	private void FMEDAJLLEBP(CDLFIBNLEJD CMBNOEOILIA, TNode ILPFPPMNEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3D90260", Offset = "0x3D8F660", VA = "0x183D90260")]
	private void HINDKPMOBGO(CDLFIBNLEJD CMBNOEOILIA, PEDDLGMFPCH CAHNDBICCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D90700", Offset = "0x3D8FB00", VA = "0x183D90700")]
	private void LDGBACCHGAJ(PEDDLGMFPCH CAHNDBICCFN, bool ECEIBGHHNPB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D90850", Offset = "0x3D8FC50", VA = "0x183D90850")]
	private void LIJGNKOLMJH(PEDDLGMFPCH CAHNDBICCFN, TNode DADNCNLHDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FF30", Offset = "0x3D8F330", VA = "0x183D8FF30")]
	[IteratorStateMachine(typeof(HMGDKEIFHJJ<, >.FNMLOGHJDEF))]
	private IEnumerable<TNode> EKKBCKIMNCE(TNode NHPIHOLOEKN, TNode JCJNFDHLFJO, bool HLDDOKCFGED = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D90150", Offset = "0x3D8F550", VA = "0x183D90150")]
	private PEDDLGMFPCH HDEJHKPOHBF(TNode ILPFPPMNEDJ, TNode KOBAADDGPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D90580", Offset = "0x3D8F980", VA = "0x183D90580")]
	private PEDDLGMFPCH IJNMBCNKFOI(TNode ILPFPPMNEDJ, TNode KOBAADDGPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D903C0", Offset = "0x3D8F7C0", VA = "0x183D903C0")]
	private void HOGNDHOKFBB(PEDDLGMFPCH CAHNDBICCFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HKKOKMBDMOE<T> : IEnumerable<HKKOKMBDMOE<T>.LOKCKGGAGBF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct LOKCKGGAGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T OBEEJPGJPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int AGAGKNBDCIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ONOBFFGCPAC : IEnumerator<LOKCKGGAGBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private HKKOKMBDMOE<T> DBKGMGAJNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int AGAGKNBDCIG;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x38B0910", Offset = "0x38AFD10", VA = "0x1838B0910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public LOKCKGGAGBF AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4737840", Offset = "0x4736C40", VA = "0x184737840", Slot = "4")]
			get
			{
				return default(LOKCKGGAGBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4737800", Offset = "0x4736C00", VA = "0x184737800")]
		public ONOBFFGCPAC(HKKOKMBDMOE<T> DBKGMGAJNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4737780", Offset = "0x4736B80", VA = "0x184737780", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39062B0", Offset = "0x39056B0", VA = "0x1839062B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7D0", Offset = "0x9FDBD0", VA = "0x1809FE7D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct PHABIPGGNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool ECHNNKFAEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T OBEEJPGJPFD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int MHCEBAHEJDJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> LOPPJKLKGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PHABIPGGNCJ[] GGCJKHHKFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int JHJGBKKLAPN;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int JKJIFEIGIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x88BB00", Offset = "0x88AF00", VA = "0x18088BB00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x88B150", Offset = "0x88A550", VA = "0x18088B150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x35B8D10", Offset = "0x35B8110", VA = "0x1835B8D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D85C60", Offset = "0x3D85060", VA = "0x183D85C60")]
	public HKKOKMBDMOE(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D85420", Offset = "0x3D84820", VA = "0x183D85420")]
	public HKKOKMBDMOE(LOKCKGGAGBF[] LLDKGIAKPKM, bool BMEFKCPOCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D845A0", Offset = "0x3D839A0", VA = "0x183D845A0")]
	public int BJGDDLNHIPD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D850C0", Offset = "0x3D844C0", VA = "0x183D850C0")]
	private int NJIFINPHOOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D84CE0", Offset = "0x3D840E0", VA = "0x183D84CE0", Slot = "6")]
	protected virtual uint ICGJNJAEIFD(uint KMHAFMEHDIB, T OBEEJPGJPFD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D852C0", Offset = "0x3D846C0", VA = "0x183D852C0")]
	public bool OCLKIGCJKGG(T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D84D00", Offset = "0x3D84100", VA = "0x183D84D00")]
	public int JHBMAKCGGPD(T OBEEJPGJPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D84E50", Offset = "0x3D84250", VA = "0x183D84E50")]
	public T MKPBMOBCOOF(int AGAGKNBDCIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D84660", Offset = "0x3D83A60", VA = "0x183D84660")]
	public bool GIDGJLJDBPM(T OBEEJPGJPFD, bool KADJIODKIKJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D849B0", Offset = "0x3D83DB0", VA = "0x183D849B0")]
	public bool GIDGJLJDBPM(T OBEEJPGJPFD, int AGAGKNBDCIG, bool KADJIODKIKJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D84C60", Offset = "0x3D84060", VA = "0x183D84C60")]
	private int HCMJOKFDPBC(int OCDCDAOIAHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D85380", Offset = "0x3D84780", VA = "0x183D85380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D85380", Offset = "0x3D84780", VA = "0x183D85380", Slot = "4")]
	private IEnumerator<LOKCKGGAGBF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JOLEMLILPLG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> JFMKLALBFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> FNKLKFBNGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int MCFGCNMDLLI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x407EC40", Offset = "0x407E040", VA = "0x18407EC40")]
	public static JOLEMLILPLG<T> FJMDNBFAEMC(int HKIABBKKICG = 0, int MCFGCNMDLLI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x407F1C0", Offset = "0x407E5C0", VA = "0x18407F1C0")]
	public static JOLEMLILPLG<T> MLPAEOEKKNJ(int HKIABBKKICG = 0, int MCFGCNMDLLI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x407F2F0", Offset = "0x407E6F0", VA = "0x18407F2F0")]
	public JOLEMLILPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x407F340", Offset = "0x407E740", VA = "0x18407F340")]
	public JOLEMLILPLG(int HKIABBKKICG, int MCFGCNMDLLI = int.MaxValue, bool NJNMPHFMCHJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x407F020", Offset = "0x407E420", VA = "0x18407F020")]
	public T MHAKCBKKDMD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x407E9F0", Offset = "0x407DDF0", VA = "0x18407E9F0")]
	public void BNLEGFFBAHJ(T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x407ED30", Offset = "0x407E130", VA = "0x18407ED30")]
	private void JCJIKFEHBJA(T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x407F2B0", Offset = "0x407E6B0", VA = "0x18407F2B0")]
	private void NIMBDDIOAIJ(T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x407EAC0", Offset = "0x407DEC0", VA = "0x18407EAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x407EE30", Offset = "0x407E230", VA = "0x18407EE30")]
	private void LDNONENPFNO(IEnumerable<T> FJJNGLOPNDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KEEKBDLDPNI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> HLFLEOMHHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T BJPPBCLLNGE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T FMKALJHDIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x417F890", Offset = "0x417EC90", VA = "0x18417F890")]
	public bool FOIJBIHDOMH(T OBEEJPGJPFD, int OMFADEMDLDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x417F750", Offset = "0x417EB50", VA = "0x18417F750")]
	public bool EIJCBENOGDI(int OMFADEMDLDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x417FB30", Offset = "0x417EF30", VA = "0x18417FB30")]
	public T IHEAIFJDCFI(int EOGJKJKLNOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x417F560", Offset = "0x417E960", VA = "0x18417F560")]
	private bool BFFIACFLGPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x417FD20", Offset = "0x417F120", VA = "0x18417FD20")]
	public bool LPPDNPILAFJ(int OMFADEMDLDL, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x417FD80", Offset = "0x417F180", VA = "0x18417FD80")]
	public KEEKBDLDPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HMLKNFFOFJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct IAFJKHKDBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T KHLHBLNGCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int CABBJMKJAGN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<IAFJKHKDBAB> GGJIKPNMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T NNAAGLJOEMO;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x35B8D10", Offset = "0x35B8110", VA = "0x1835B8D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D95550", Offset = "0x3D94950", VA = "0x183D95550")]
	public bool IMCHJPMIMGD(T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3D95400", Offset = "0x3D94800", VA = "0x183D95400")]
	public void HINMMBAADBG(T OBEEJPGJPFD, int OMFADEMDLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D958F0", Offset = "0x3D94CF0", VA = "0x183D958F0")]
	public bool LHAIFCNDDDC(T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D954B0", Offset = "0x3D948B0", VA = "0x183D954B0")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D95280", Offset = "0x3D94680", VA = "0x183D95280")]
	public T FEKHNJJGNNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D95DC0", Offset = "0x3D951C0", VA = "0x183D95DC0")]
	protected void LHKGBMJMOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D95F30", Offset = "0x3D95330", VA = "0x183D95F30")]
	public HMLKNFFOFJC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x68CB120", Offset = "0x68CA520", VA = "0x1868CB120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x68CB3F0", Offset = "0x68CA7F0", VA = "0x1868CB3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x68CB300", Offset = "0x68CA700", VA = "0x1868CB300")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x68CB070", Offset = "0x68CA470", VA = "0x1868CB070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x68CB340", Offset = "0x68CA740", VA = "0x1868CB340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x68CB250", Offset = "0x68CA650", VA = "0x1868CB250")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x68CAFE0", Offset = "0x68CA3E0", VA = "0x1868CAFE0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x499D7C0", Offset = "0x499CBC0", VA = "0x18499D7C0", Slot = "4")]
		public virtual T FACJBCNPBBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IBKKGLLGLAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, PFPPFNAKEFL> GADNAGKENLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly JOLEMLILPLG<PFPPFNAKEFL> MGCGGPFFPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool PDLDMNCFING;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PFPPFNAKEFL LPOIAKAJFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 LPFACNMKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xE04B40", Offset = "0xE03F40", VA = "0x180E04B40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1114940", Offset = "0x1113D40", VA = "0x181114940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 IHEHEPHLJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x11622C0", Offset = "0x11616C0", VA = "0x1811622C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 GIBJCDMGKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x68C7FB0", Offset = "0x68C73B0", VA = "0x1868C7FB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8541E0", Offset = "0x8535E0", VA = "0x1808541E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int JKPONKOHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x857630", Offset = "0x856A30", VA = "0x180857630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x857290", Offset = "0x856690", VA = "0x180857290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68C8420", Offset = "0x68C7820", VA = "0x1868C8420")]
	public IBKKGLLGLAH(Bounds LGOMDLPEHEL, Vector2[] PPDPEMJFCMK, int CIEMKGEPOPH, byte OCDCDAOIAHP, float LOKCJFOPKDP = 0f, [Optional] JOLEMLILPLG<PFPPFNAKEFL> MGCGGPFFPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x68C7A90", Offset = "0x68C6E90", VA = "0x1868C7A90")]
	public void EFLKABDIIPM(Bounds LGOMDLPEHEL, Vector2[] PPDPEMJFCMK, int CIEMKGEPOPH, byte OCDCDAOIAHP, float LOKCJFOPKDP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x68C8200", Offset = "0x68C7600", VA = "0x1868C8200")]
	public PFPPFNAKEFL MDFGHAMNFLP(byte AGAGKNBDCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x68C8350", Offset = "0x68C7750", VA = "0x1868C8350")]
	public void NJDHFFPFIPI(Vector3 HBGADHMDPAD, float PCAGNIGOCBO, float HMOKGEOOAAB, List<byte> DGOFNECPPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x68C7F30", Offset = "0x68C7330", VA = "0x1868C7F30")]
	public void FMDLKMPAJLP(PFPPFNAKEFL.OLKLDGJHLEO NDHJBONNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68C8260", Offset = "0x68C7660", VA = "0x1868C8260")]
	public static int NEPMJBFJDLE(Vector2[] PPDPEMJFCMK, int CIEMKGEPOPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68C7FD0", Offset = "0x68C73D0", VA = "0x1868C7FD0")]
	private PFPPFNAKEFL KHFOJIFHBCE(byte AGAGKNBDCIG, PFPPFNAKEFL.BFKBFHKDOAB JAGFGGCPMHD, PFPPFNAKEFL KOBAADDGPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x68C7680", Offset = "0x68C6A80", VA = "0x1868C7680")]
	private void DOCAAOHHJBN(PFPPFNAKEFL KOBAADDGPBN, Vector2[] PPDPEMJFCMK, int FNEFBBJEDIK, int AKONBNLMFEF, int IDAEILAAGKG, int KPLGCEEGJIM, float LOKCJFOPKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x68C7460", Offset = "0x68C6860", VA = "0x1868C7460")]
	private void CCIBLFCBBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x68C7A30", Offset = "0x68C6E30", VA = "0x1868C7A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x68C7F50", Offset = "0x68C7350", VA = "0x1868C7F50", Slot = "1")]
	~IBKKGLLGLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PFPPFNAKEFL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum BFKBFHKDOAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum OLKLDGJHLEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte PIBGEMNFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 MNKMFOOAAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 MBPNHHIKNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 NHDMFIFGEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 EOCEPFNEHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BFKBFHKDOAB CDJAAJBAAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public PFPPFNAKEFL EOCBFDAOCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<PFPPFNAKEFL> MCAFHJPNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool EMAOKCCEEFF;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x68CAC10", Offset = "0x68CA010", VA = "0x1868CAC10")]
	public PFPPFNAKEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x68CAAD0", Offset = "0x68C9ED0", VA = "0x1868CAAD0")]
	public void PFOLEMCNFJG(PFPPFNAKEFL LGDEAAPGGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	public void FMDLKMPAJLP(int ABLELOHFCHM, OLKLDGJHLEO NDHJBONNFPH, int GHOMNPIHGKK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x68CA870", Offset = "0x68C9C70", VA = "0x1868CA870")]
	public void NJDHFFPFIPI(List<byte> DGOFNECPPKK, Vector3 HBGADHMDPAD, float PCAGNIGOCBO, float HMOKGEOOAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x68CA7B0", Offset = "0x68C9BB0", VA = "0x1868CA7B0")]
	public bool JMBPINJIJNE(Vector3 LNCAKBGPDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x68CA780", Offset = "0x68C9B80", VA = "0x1868CA780")]
	public bool CLIHCHKOMFN(Vector3 LNCAKBGPDEK, float FNBGHGOHHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x68CA7E0", Offset = "0x68C9BE0", VA = "0x1868CA7E0")]
	public void MGIGIPLLEKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct ANDLBKJJJIP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> EGGGJKKPDIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool BJPFICHJEKG;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3D7BA60", Offset = "0x3D7AE60", VA = "0x183D7BA60")]
			public ANDLBKJJJIP(List<Component> EGGGJKKPDIP, bool BJPFICHJEKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B930", Offset = "0x3D7AD30", VA = "0x183D7B930")]
			public INOEKBPMEGD<T> GHLGIEPLNLN()
			{
				return default(INOEKBPMEGD<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B990", Offset = "0x3D7AD90", VA = "0x183D7B990", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B990", Offset = "0x3D7AD90", VA = "0x183D7B990", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct INOEKBPMEGD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> EGGGJKKPDIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool BJPFICHJEKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int AGAGKNBDCIG;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T AKMKAIGAIOP
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x3E7C610", Offset = "0x3E7BA10", VA = "0x183E7C610", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x3E7C5A0", Offset = "0x3E7B9A0", VA = "0x183E7C5A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C5E0", Offset = "0x3E7B9E0", VA = "0x183E7C5E0")]
			public INOEKBPMEGD(List<Component> EGGGJKKPDIP, bool BJPFICHJEKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C4E0", Offset = "0x3E7B8E0", VA = "0x183E7C4E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C4F0", Offset = "0x3E7B8F0", VA = "0x183E7C4F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x37EB200", Offset = "0x37EA600", VA = "0x1837EB200", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x68CCE40", Offset = "0x68CC240", VA = "0x1868CCE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x68CC8E0", Offset = "0x68CBCE0", VA = "0x1868CC8E0")]
		private void MGIGIPLLEKC(GameObject KNDJCJMKCJC, bool MCCPONPGBFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x68CC850", Offset = "0x68CBC50", VA = "0x1868CC850")]
		public static void MGIGIPLLEKC(GameObject KNDJCJMKCJC, ToolHierarchyCache DKPFLLMGALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x68CCDA0", Offset = "0x68CC1A0", VA = "0x1868CCDA0")]
		public void OMLAPEOACBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2E8E3A0", Offset = "0x2E8D7A0", VA = "0x182E8E3A0")]
		public void BFMHAGFPOMC<T>(Action<T> FADGJFNLBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2E8E5E0", Offset = "0x2E8D9E0", VA = "0x182E8E5E0")]
		public T DEABCOGJEOB<T>(bool BJPFICHJEKG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2E8E680", Offset = "0x2E8DA80", VA = "0x182E8E680")]
		public ANDLBKJJJIP<T> HIEMFIOPOJM<T>(bool BJPFICHJEKG = false) where T : class
		{
			return default(ANDLBKJJJIP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x68CCA50", Offset = "0x68CBE50", VA = "0x1868CCA50")]
		public List<Component> ODFJLPGCPHM(Type EPPKBKJHHHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x68CC760", Offset = "0x68CBB60", VA = "0x1868CC760", Slot = "4")]
		public bool Equals(ToolHierarchyCache PCHHOKEGOFA, ToolHierarchyCache PDEIPLKJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x68CC7E0", Offset = "0x68CBBE0", VA = "0x1868CC7E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache LALIGKIKEBM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MJJIDGDEDKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HKIABBKKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int IKCIGABGGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> KEIKLDLCOAM;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3808E90", Offset = "0x3808290", VA = "0x183808E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T DLIKKPIGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4442010", Offset = "0x4441410", VA = "0x184442010")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T NKHENPIOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4442650", Offset = "0x4441A50", VA = "0x184442650")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T AMIJENJONIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x44424E0", Offset = "0x44418E0", VA = "0x1844424E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x44426D0", Offset = "0x4441AD0", VA = "0x1844426D0")]
	public MJJIDGDEDKK(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4442320", Offset = "0x4441720", VA = "0x184442320")]
	public void HINMMBAADBG(T CNBEJBKNKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4442480", Offset = "0x4441880", VA = "0x184442480")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x44420E0", Offset = "0x44414E0", VA = "0x1844420E0")]
	public void FFOCJPGEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4441EF0", Offset = "0x44412F0", VA = "0x184441EF0")]
	public void DCEFFFDHBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x44425D0", Offset = "0x44419D0", VA = "0x1844425D0")]
	public void MMIBHHAAIMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class IBFGHMBDLEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct EEHHGPBDGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int CABBJMKJAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T KHLHBLNGCMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, EEHHGPBDGKL> HLFLEOMHHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> KEHOACKELAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T BJPPBCLLNGE;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T FMKALJHDIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B60", Offset = "0x99FF60", VA = "0x1809A0B60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3E35080", Offset = "0x3E34480", VA = "0x183E35080", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool FMMDDAKGCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3E36750", Offset = "0x3E35B50", VA = "0x183E36750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object GALFDHCIABB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x3E35580", Offset = "0x3E34980", VA = "0x183E35580")]
	public bool FOIJBIHDOMH(T OBEEJPGJPFD, object IAIFDAAIBBN, int OMFADEMDLDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3E34FA0", Offset = "0x3E343A0", VA = "0x183E34FA0")]
	public bool EIJCBENOGDI(object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3E361C0", Offset = "0x3E355C0", VA = "0x183E361C0")]
	public bool LPPDNPILAFJ(object IAIFDAAIBBN, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3833650", Offset = "0x3832A50", VA = "0x183833650")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3E33BA0", Offset = "0x3E32FA0", VA = "0x183E33BA0")]
	private bool BFFIACFLGPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3E367B0", Offset = "0x3E35BB0", VA = "0x183E367B0")]
	public IBFGHMBDLEI()
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
