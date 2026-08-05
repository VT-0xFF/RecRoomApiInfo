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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DBFA10", Offset = "0x6DBE410", VA = "0x186DBFA10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EBDCPFNMPGD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	public EBDCPFNMPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KEBKKMHIABP, FDBNGHAJHBO, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CGIDNBEMCAI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
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
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0F60", Offset = "0x6DBF960", VA = "0x186DC0F60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0F20", Offset = "0x6DBF920", VA = "0x186DC0F20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0FA0", Offset = "0x6DBF9A0", VA = "0x186DC0FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1150", Offset = "0x6DBFB50", VA = "0x186DC1150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DC10C0", Offset = "0x6DBFAC0", VA = "0x186DC10C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA37C0", Offset = "0xAA21C0", VA = "0x180AA37C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBF02D0", Offset = "0xBEECD0", VA = "0x180BF02D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DC0EE0", Offset = "0x6DBF8E0", VA = "0x186DC0EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1030", Offset = "0x6DBFA30", VA = "0x186DC1030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0B30", Offset = "0x6DBF530", VA = "0x186DC0B30")]
	public void CopyBounds(SavedExtents GDOGPMPJPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0E30", Offset = "0x6DBF830", VA = "0x186DC0E30")]
	public void SetLocalSpaceBounds(Bounds AGLGMOFAPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xED8590", Offset = "0xED6F90", VA = "0x180ED8590")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0E20", Offset = "0x6DBF820", VA = "0x186DC0E20")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0340", Offset = "0x6DBED40", VA = "0x186DC0340")]
	private void ALLNBIOONOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0C20", Offset = "0x6DBF620", VA = "0x186DC0C20")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC04F0", Offset = "0x6DBEEF0", VA = "0x186DC04F0")]
	public static void CalculateLocalBoundsFor(GameObject NJFNKLJIFDE, [Out] Bounds AGLGMOFAPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0B60", Offset = "0x6DBF560", VA = "0x186DC0B60")]
	private static void EJHFMGOGLNF(Bounds FDDPOELCNDG, Color CLNPLAGFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0E50", Offset = "0x6DBF850", VA = "0x186DC0E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x132CAC0", Offset = "0x132B4C0", VA = "0x18132CAC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D82410", Offset = "0x4D80E10", VA = "0x184D82410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public virtual void LKKBIPLOFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
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
	[EBDCPFNMPGD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D81F20", Offset = "0x4D80920", VA = "0x184D81F20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D80540", Offset = "0x4D7EF40", VA = "0x184D80540", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D82300", Offset = "0x4D80D00", VA = "0x184D82300")]
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
	private sealed class MBLEHCGAFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MBLEHCGAFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4875870", Offset = "0x4874270", VA = "0x184875870")]
		internal int GKACDOKICJP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[EBDCPFNMPGD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0480", Offset = "0x3BAEE80", VA = "0x183BB0480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BB04E0", Offset = "0x3BAEEE0", VA = "0x183BB04E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0350", Offset = "0x3BAED50", VA = "0x183BB0350", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey PNABAFEIDND]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0410", Offset = "0x3BAEE10", VA = "0x183BB0410", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB01F0", Offset = "0x3BAEBF0", VA = "0x183BB01F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFE70", Offset = "0x3BAE870", VA = "0x183BAFE70", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF1E0", Offset = "0x3BADBE0", VA = "0x183BAF1E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF150", Offset = "0x3BADB50", VA = "0x183BAF150", Slot = "14")]
	protected virtual string JBIGBNIDGPC(TKeyVal JKAAPOECKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF040", Offset = "0x3BADA40", VA = "0x183BAF040", Slot = "4")]
	public bool ContainsKey(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0060", Offset = "0x3BAEA60", VA = "0x183BB0060", Slot = "5")]
	public bool TryGetValue(TKey PNABAFEIDND, [Out] TVal PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF0A0", Offset = "0x3BADAA0", VA = "0x183BAF0A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF0A0", Offset = "0x3BADAA0", VA = "0x183BAF0A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB00C0", Offset = "0x3BAEAC0", VA = "0x183BB00C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B8EA60", Offset = "0x3B8D460", VA = "0x183B8EA60")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[EBDCPFNMPGD]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D83EC0", Offset = "0x4D828C0", VA = "0x184D83EC0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D836B0", Offset = "0x4D820B0", VA = "0x184D836B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D82BF0", Offset = "0x4D815F0", VA = "0x184D82BF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PFCCPKPIOBM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class CBHKMIDEKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float NDOBNBIBGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T IPHIEALFCML;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CBHKMIDEKAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JHENIJHPDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JHENIJHPDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4432EB0", Offset = "0x44318B0", VA = "0x184432EB0")]
		internal bool MFGKCEEDBAC(CBHKMIDEKAG sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float MGFOGJPGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float CDLDDEPDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<CBHKMIDEKAG> OBHGNFFPFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private LEAINFFOANC<CBHKMIDEKAG> HDKHHGEHFCO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EFGHGCKHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4B694F0", Offset = "0x4B67EF0", VA = "0x184B694F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B695D0", Offset = "0x4B67FD0", VA = "0x184B695D0")]
	public PFCCPKPIOBM(float LBLDOICPKJE, float AKPMNPICKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B68BC0", Offset = "0x4B675C0", VA = "0x184B68BC0")]
	public bool GFFBJPFPLDD(float FADJNLBACEO, T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4B68DB0", Offset = "0x4B677B0", VA = "0x184B68DB0")]
	public IEnumerable<T> JGGGNLPFJNB(float FADJNLBACEO, [Optional] float? LGIIOJFEKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B68760", Offset = "0x4B67160", VA = "0x184B68760")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B68820", Offset = "0x4B67220", VA = "0x184B68820")]
	private void DFFFMFGNMCA(float FADJNLBACEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class HLOBDNKJGHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JCOAFLHOLKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T IPHIEALFCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float GNMHNBCLFIF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float JPOMOPILMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> ILELHCAEEJF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int HPCLGCJCBHN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JCOAFLHOLKD[] LOCJOHPCANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int MEGFENPPIHM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float PMFOACCBPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCEB7D0", Offset = "0xCEA1D0", VA = "0x180CEB7D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD0AD40", Offset = "0xD09740", VA = "0x180D0AD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4191360", Offset = "0x418FD60", VA = "0x184191360")]
	public HLOBDNKJGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4191220", Offset = "0x418FC20", VA = "0x184191220")]
	public HLOBDNKJGHH(int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4191070", Offset = "0x418FA70", VA = "0x184191070")]
	public void NOEGDDICEDP(float FADJNLBACEO, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41900F0", Offset = "0x418EAF0", VA = "0x1841900F0")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x41905D0", Offset = "0x418EFD0", VA = "0x1841905D0")]
	public bool HCPLKEKNKND(float HKBMMFLELAH, float CGOLOAPELPB, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4190A60", Offset = "0x418F460", VA = "0x184190A60")]
	public bool KGBEIPDICOA(float HKBMMFLELAH, float CGOLOAPELPB, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4190DE0", Offset = "0x418F7E0", VA = "0x184190DE0")]
	public void LOFNIKNOIDI(float HKBMMFLELAH, float CGOLOAPELPB, List<T> GNKEDFJBDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41902D0", Offset = "0x418ECD0", VA = "0x1841902D0")]
	private int GIHFICLNAIJ(int MOFHOOKIIMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4191180", Offset = "0x418FB80", VA = "0x184191180")]
	private void PGIFBFAEFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PNJKJAJKEMP();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LNDKEGEMBFL(T PKCLPFEIPFH, float FOFGABNNIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T AMAKAFEMKBG(T GPBGMCKGICE, T PGFJAECCPCN);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LAJOPINDFFB(T GPBGMCKGICE, T PGFJAECCPCN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PIDHNFCMKAC : HLOBDNKJGHH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BC880", Offset = "0x8BB280", VA = "0x1808BC880", Slot = "4")]
	protected override Vector3 PNJKJAJKEMP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFD70", Offset = "0x6DBE770", VA = "0x186DBFD70", Slot = "5")]
	protected override Vector3 LNDKEGEMBFL(Vector3 PKCLPFEIPFH, float FOFGABNNIOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFCA0", Offset = "0x6DBE6A0", VA = "0x186DBFCA0", Slot = "6")]
	protected override Vector3 AMAKAFEMKBG(Vector3 GPBGMCKGICE, Vector3 PGFJAECCPCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFCF0", Offset = "0x6DBE6F0", VA = "0x186DBFCF0", Slot = "7")]
	protected override Vector3 LAJOPINDFFB(Vector3 GPBGMCKGICE, Vector3 PGFJAECCPCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFDB0", Offset = "0x6DBE7B0", VA = "0x186DBFDB0")]
	public PIDHNFCMKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CGHFKNJHIFC
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2CE96F0", Offset = "0x2CE80F0", VA = "0x182CE96F0")]
	public static HKJFMLEDOGG<T1, T2> LNCAGMGJJFK<T1, T2>(T1 MFPABBOKLMG, T2 FHOFBFKDDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9790", Offset = "0x2CE8190", VA = "0x182CE9790")]
	public static JMELHPFDNPE<T1, T2, T3> LNCAGMGJJFK<T1, T2, T3>(T1 MFPABBOKLMG, T2 FHOFBFKDDBG, T3 EJBBPHLNOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x48F79B0", Offset = "0x48F63B0", VA = "0x1848F79B0")]
	internal static int APJAOPJIMBN(int MMKNNBILOGK, int COEFOGFBGGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x612B710", Offset = "0x612A110", VA = "0x18612B710")]
	internal static int APJAOPJIMBN(int MMKNNBILOGK, int COEFOGFBGGE, int ALCNCDFDIJA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HKJFMLEDOGG<T1, T2> : IComparable<HKJFMLEDOGG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 NGCNDBAAIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 CEEDPHOGFLF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4189340", Offset = "0x4187D40", VA = "0x184189340")]
	public HKJFMLEDOGG(T1 MFPABBOKLMG, T2 FHOFBFKDDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4187680", Offset = "0x4186080", VA = "0x184187680", Slot = "4")]
	public int CompareTo(HKJFMLEDOGG<T1, T2> GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4188020", Offset = "0x4186A20", VA = "0x184188020", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4188780", Offset = "0x4187180", VA = "0x184188780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4188E40", Offset = "0x4187840", VA = "0x184188E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JMELHPFDNPE<T1, T2, T3> : IComparable<JMELHPFDNPE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 NGCNDBAAIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 CEEDPHOGFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 IGPCOOCIEJL;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4443B00", Offset = "0x4442500", VA = "0x184443B00")]
	public JMELHPFDNPE(T1 MFPABBOKLMG, T2 FHOFBFKDDBG, T3 EJBBPHLNOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4443160", Offset = "0x4441B60", VA = "0x184443160", Slot = "4")]
	public int CompareTo(JMELHPFDNPE<T1, T2, T3> GDOGPMPJPOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4443420", Offset = "0x4441E20", VA = "0x184443420", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4443700", Offset = "0x4442100", VA = "0x184443700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4443830", Offset = "0x4442230", VA = "0x184443830", Slot = "3")]
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
	public T IPHIEALFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x25FC9B0", Offset = "0x25FB3B0", VA = "0x1825FC9B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x25FCA60", Offset = "0x25FB460", VA = "0x1825FCA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float NAGNECOMKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5A00", VA = "0x180AA7000")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1110", Offset = "0x4FDFB10", VA = "0x184FE1110")]
	public T HHAPDCLEMOI(float FOFGABNNIOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1570", Offset = "0x4FDFF70", VA = "0x184FE1570")]
	public T MJOIGCEIPDE(float FOFGABNNIOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LOHGOFLGLAH(T GPBGMCKGICE, T PGFJAECCPCN, float FOFGABNNIOJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC850", Offset = "0x6DBB250", VA = "0x186DBC850", Slot = "4")]
	protected override float LOHGOFLGLAH(float GPBGMCKGICE, float PGFJAECCPCN, float FOFGABNNIOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC890", Offset = "0x6DBB290", VA = "0x186DBC890")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x11C0D80", Offset = "0x11BF780", VA = "0x1811C0D80", Slot = "4")]
	protected override Vector3 LOHGOFLGLAH(Vector3 GPBGMCKGICE, Vector3 PGFJAECCPCN, float FOFGABNNIOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1F20", Offset = "0x6DC0920", VA = "0x186DC1F20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC240", Offset = "0x6DBAC40", VA = "0x186DBC240", Slot = "4")]
	protected override Color LOHGOFLGLAH(Color GPBGMCKGICE, Color PGFJAECCPCN, float FOFGABNNIOJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC300", Offset = "0x6DBAD00", VA = "0x186DBC300")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LGNGLBCNDND : KFGNECBGPDI<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF8C0", Offset = "0x6DBE2C0", VA = "0x186DBF8C0")]
	public LGNGLBCNDND(int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF850", Offset = "0x6DBE250", VA = "0x186DBF850", Slot = "6")]
	protected override uint POACLFBBFJM(uint CGIDNBEMCAI, string PKCLPFEIPFH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GLCDMHNOAEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable JOLICDCBKGF;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GLCDMHNOAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FENNPENKKFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DMBDBNOJJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int EDJPFKFLCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int HIPJAFPKPLA;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F85130", Offset = "0x3F83B30", VA = "0x183F85130")]
	private FENNPENKKFD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GHOMMNCLIOK, int AJBMHDMDFBC, int GBCHABBLBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F82AC0", Offset = "0x3F814C0", VA = "0x183F82AC0")]
	public static FENNPENKKFD<T> AELHPDENENI()
	{
		return default(FENNPENKKFD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F84270", Offset = "0x3F82C70", VA = "0x183F84270")]
	public (int, int, Task<T>) KLBDDFNCDEN(int ECMIGICIFIJ, [Optional] CancellationToken PPLDCJFFMEP, double FPEHIEEJIAO = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F82DF0", Offset = "0x3F817F0", VA = "0x183F82DF0")]
	public void AFPKHCDDGNB(int ECMIGICIFIJ, int GBCHABBLBPK, [In] T KIBAOEBFCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KNMCBCJMCJA
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF780", Offset = "0x6DBE180", VA = "0x186DBF780")]
	public static FENNPENKKFD<NEDLODCHJKB> AELHPDENENI()
	{
		return default(FENNPENKKFD<NEDLODCHJKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF7D0", Offset = "0x6DBE1D0", VA = "0x186DBF7D0")]
	public static void AFPKHCDDGNB([In] this FENNPENKKFD<NEDLODCHJKB> PCBICLOONMH, int ECMIGICIFIJ, int GBCHABBLBPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class PLDKLKELDFK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> NCJDNHEKMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> MMODGPGDPPP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x38E2640", Offset = "0x38E1040", VA = "0x1838E2640", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HICONDDLJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> AFBAEIKCDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B90A40", Offset = "0x3B8F440", VA = "0x183B90A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> BINFFJONHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B8ECF0", Offset = "0x3B8D6F0", VA = "0x183B8ECF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4B82260", Offset = "0x4B80C60", VA = "0x184B82260", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4B822D0", Offset = "0x4B80CD0", VA = "0x184B822D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4B81B70", Offset = "0x4B80570", VA = "0x184B81B70")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B81760", Offset = "0x4B80160", VA = "0x184B81760", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B82080", Offset = "0x4B80A80", VA = "0x184B82080", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4B814F0", Offset = "0x4B7FEF0", VA = "0x184B814F0", Slot = "9")]
	public void Add(TKey PNABAFEIDND, TVal PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4B814A0", Offset = "0x4B7FEA0", VA = "0x184B814A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B90110", Offset = "0x3B8EB10", VA = "0x183B90110", Slot = "8")]
	public bool ContainsKey(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4B81810", Offset = "0x4B80210", VA = "0x184B81810", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4B81FB0", Offset = "0x4B809B0", VA = "0x184B81FB0", Slot = "10")]
	public bool Remove(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4B81FF0", Offset = "0x4B809F0", VA = "0x184B81FF0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4B820D0", Offset = "0x4B80AD0", VA = "0x184B820D0", Slot = "11")]
	public bool TryGetValue(TKey PNABAFEIDND, [Out] TVal PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4B81C30", Offset = "0x4B80630", VA = "0x184B81C30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4B81890", Offset = "0x4B80290", VA = "0x184B81890", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LOCJOHPCANM, int FBPHGCDJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4B81CD0", Offset = "0x4B806D0", VA = "0x184B81CD0")]
	public bool HPCEHODMPGB(TVal PNABAFEIDND, [Out] TKey PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4B81580", Offset = "0x4B7FF80", VA = "0x184B81580")]
	private void COJLNALDMGA(TKey PNABAFEIDND, TVal JBKDPHAINMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4B81E70", Offset = "0x4B80870", VA = "0x184B81E70")]
	private void LDPPMAHEOOB(TKey PNABAFEIDND, TVal JBKDPHAINMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4B81A40", Offset = "0x4B80440", VA = "0x184B81A40")]
	private bool ENJDOMGEIDK(TKey PNABAFEIDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B82130", Offset = "0x4B80B30", VA = "0x184B82130")]
	public PLDKLKELDFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class KDAJJFDAMOG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private KDAJJFDAMOG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3BF9F50", Offset = "0x3BF8950", VA = "0x183BF9F50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3C016A0", Offset = "0x3C000A0", VA = "0x183C016A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C032E0", Offset = "0x3C01CE0", VA = "0x183C032E0")]
		public Enumerator(KDAJJFDAMOG<T> GNKEDFJBDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFE80", Offset = "0x3BFE880", VA = "0x183BFFE80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C00F60", Offset = "0x3BFF960", VA = "0x183C00F60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BFEB40", Offset = "0x3BFD540", VA = "0x183BFEB40")]
		private void DEFCEOPDIHE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] BMIMFCBHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int FMCLGEDFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int GDEMOKEEMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int OCMGGEGAGNJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x451BA60", Offset = "0x451A460", VA = "0x18451BA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x451BC50", Offset = "0x451A650", VA = "0x18451BC50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x451CF70", Offset = "0x451B970", VA = "0x18451CF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x451D320", Offset = "0x451BD20", VA = "0x18451D320")]
	public KDAJJFDAMOG(int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x451C970", Offset = "0x451B370", VA = "0x18451C970")]
	public void NOEGDDICEDP(T FOFGABNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x451BA40", Offset = "0x451A440", VA = "0x18451BA40")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x451BAA0", Offset = "0x451A4A0", VA = "0x18451BAA0")]
	public void EMMBJMBPJLI(int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x451B610", Offset = "0x451A010", VA = "0x18451B610")]
	public void BOMDBJNELMK(T[] LOCJOHPCANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x451B9C0", Offset = "0x451A3C0", VA = "0x18451B9C0")]
	public Enumerator CBLJDKEPCGL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x451D0B0", Offset = "0x451BAB0", VA = "0x18451D0B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x451D0B0", Offset = "0x451BAB0", VA = "0x18451D0B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x451C3D0", Offset = "0x451ADD0", VA = "0x18451C3D0")]
	private int NKIIEFLPOCM(int GCBONJOGHCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x451BEA0", Offset = "0x451A8A0", VA = "0x18451BEA0")]
	private int IBHBNIDPANL(int GCBONJOGHCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PIIGHBDKEIF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> OCKHKNBECHM(TRequest PGCEOMNLPAE, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum NCJMHCONKIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NHHLLGGNDEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float NIHJLCDKMKK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan LLGCHHJIDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int HIIFOCOKEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NCJMHCONKIA PACNBCFJIBM;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly NHHLLGGNDEB JCFGJMCEKAD;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float MKGBAEPNBHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x493F020", Offset = "0x493DA20", VA = "0x18493F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan JEFHBHIIDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x493F090", Offset = "0x493DA90", VA = "0x18493F090")]
		public NHHLLGGNDEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct DMFLCPOFAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest PGCEOMNLPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken PPLDCJFFMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> CEEEEOELLLH;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B450", Offset = "0x5C89E50", VA = "0x185C8B450")]
		public DMFLCPOFAJN(TRequest PGCEOMNLPAE, TaskCompletionSource<TResult> CEEEEOELLLH, CancellationToken PPLDCJFFMEP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HMALKPIJMGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PIIGHBDKEIF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4191E10", Offset = "0x4190810", VA = "0x184191E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x41926F0", Offset = "0x41910F0", VA = "0x1841926F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct MOKMIGGNHKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PIIGHBDKEIF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DMFLCPOFAJN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x48C8060", Offset = "0x48C6A60", VA = "0x1848C8060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x48C86D0", Offset = "0x48C70D0", VA = "0x1848C86D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource PENMLNDFBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<DMFLCPOFAJN> NFGNMPNKLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NHHLLGGNDEB LIGLDIEDMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OCKHKNBECHM HJPIIKHELHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task MMLOAEBFOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int DFGNGCEJGFO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4B71210", Offset = "0x4B6FC10", VA = "0x184B71210")]
	public PIIGHBDKEIF(OCKHKNBECHM HJPIIKHELHC, [Optional] NHHLLGGNDEB LIGLDIEDMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4B70BF0", Offset = "0x4B6F5F0", VA = "0x184B70BF0")]
	public Task<TResult> CPLHGDLEOHF(TRequest PGCEOMNLPAE, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4B71030", Offset = "0x4B6FA30", VA = "0x184B71030")]
	private void KEPONFEJMGF(DMFLCPOFAJN EKCJKIGIMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4B70F60", Offset = "0x4B6F960", VA = "0x184B70F60")]
	[AsyncStateMachine(typeof(PIIGHBDKEIF<, >.HMALKPIJMGH))]
	private Task IOHGAEPFMKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4B70900", Offset = "0x4B6F300", VA = "0x184B70900")]
	private DMFLCPOFAJN AKLMOGNMOPE()
	{
		return default(DMFLCPOFAJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4B70E70", Offset = "0x4B6F870", VA = "0x184B70E70")]
	[AsyncStateMachine(typeof(PIIGHBDKEIF<, >.MOKMIGGNHKC))]
	private Task GPPLAJBNAEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4B71100", Offset = "0x4B6FB00", VA = "0x184B71100")]
	private void LLPHBMKGNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4B70E30", Offset = "0x4B6F830", VA = "0x184B70E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class BOHLPAODGHH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> HIOONLIPGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> INBBAEJKMJN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38E2640", Offset = "0x38E1040", VA = "0x1838E2640", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HICONDDLJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D895D0", Offset = "0x2D87FD0", VA = "0x182D895D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x52A33D0", Offset = "0x52A1DD0", VA = "0x1852A33D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x404E740", Offset = "0x404D140", VA = "0x18404E740", Slot = "11")]
	public void Add(T GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x52A2920", Offset = "0x52A1320", VA = "0x1852A2920")]
	public bool BPAIIGKEBOM(T GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x52A31D0", Offset = "0x52A1BD0", VA = "0x1852A31D0", Slot = "15")]
	public bool Remove(T GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4955FF0", Offset = "0x49549F0", VA = "0x184955FF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4063B30", Offset = "0x4062530", VA = "0x184063B30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x52A2A30", Offset = "0x52A1430", VA = "0x1852A2A30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x52A2AE0", Offset = "0x52A14E0", VA = "0x1852A2AE0", Slot = "13")]
	public bool Contains(T GNDKBENMBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x52A2B40", Offset = "0x52A1540", VA = "0x1852A2B40", Slot = "14")]
	public void CopyTo(T[] LOCJOHPCANM, int FBPHGCDJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4629DF0", Offset = "0x46287F0", VA = "0x184629DF0", Slot = "6")]
	public int IndexOf(T GNDKBENMBLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x52A2BA0", Offset = "0x52A15A0", VA = "0x1852A2BA0", Slot = "7")]
	public void Insert(int GCBONJOGHCD, T GNDKBENMBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x52A2FA0", Offset = "0x52A19A0", VA = "0x1852A2FA0", Slot = "8")]
	public void RemoveAt(int GCBONJOGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x52A32A0", Offset = "0x52A1CA0", VA = "0x1852A32A0")]
	public BOHLPAODGHH()
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
			[Cpp2IlInjected.Address(RVA = "0x2484340", Offset = "0x2482D40", VA = "0x182484340")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC14F0", Offset = "0x6DBFEF0", VA = "0x186DC14F0")]
		public SerializedGuid([In] Guid MMGMNLELLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC11E0", Offset = "0x6DBFBE0", VA = "0x186DC11E0")]
		public static SerializedGuid CDLBKGPOFII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DC13D0", Offset = "0x6DBFDD0", VA = "0x186DC13D0")]
		public static SerializedGuid HDBHADMCLKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1290", Offset = "0x6DBFC90", VA = "0x186DC1290")]
		public bool EFLKLBKLPDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6DC14C0", Offset = "0x6DBFEC0", VA = "0x186DC14C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1440", Offset = "0x6DBFE40", VA = "0x186DC1440", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6DC12F0", Offset = "0x6DBFCF0", VA = "0x186DC12F0", Slot = "7")]
		public bool Equals(SerializedGuid GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1330", Offset = "0x6DBFD30", VA = "0x186DC1330", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DC13C0", Offset = "0x6DBFDC0", VA = "0x186DC13C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1260", Offset = "0x6DBFC60", VA = "0x186DC1260", Slot = "6")]
		public int CompareTo(SerializedGuid GDOGPMPJPOO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EBHDFGKEJHP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type KLEAJMFIAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string DCJNILJNOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool ODDMFICLNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool LHCPNPGDGAM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC7E0", Offset = "0x6DBB1E0", VA = "0x186DBC7E0")]
	public EBHDFGKEJHP(Type NNAPGPJEMFB, string CFGJILINFFH, bool OOLOMBNBMEA = false, bool ONCGIIOHGKJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FILMNPNNHPJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct DGMABNGDGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long HAJMNDGLBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long DIIFMNKJGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int DDHDABHMOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int NHIJEGOIJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool IIFGEFHANNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string FDONKAGHFMO;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5C84160", Offset = "0x5C82B60", VA = "0x185C84160")]
		public DGMABNGDGHA(long HAJMNDGLBCP, int DDHDABHMOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5C84130", Offset = "0x5C82B30", VA = "0x185C84130")]
		public DGMABNGDGHA(long HAJMNDGLBCP, long DIIFMNKJGNH, int DDHDABHMOKE, int NHIJEGOIJMJ, bool IIFGEFHANNI, string FDONKAGHFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5C840E0", Offset = "0x5C82AE0", VA = "0x185C840E0")]
		public int NFENKHCFGJE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C84060", Offset = "0x5C82A60", VA = "0x185C84060")]
		public int FMMHLFJLNOE(int EDELCNDCKPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5C84080", Offset = "0x5C82A80", VA = "0x185C84080")]
		public double GMNFCBHCLGO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5C83FC0", Offset = "0x5C829C0", VA = "0x185C83FC0")]
		public DGMABNGDGHA EBGOABOENLM(long DIIFMNKJGNH, int NHIJEGOIJMJ)
		{
			return default(DGMABNGDGHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class EEFAEMIIABD : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct PMGEIMLHELL<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EEFAEMIIABD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<EEFAEMIIABD, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private EEFAEMIIABD <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4B84790", Offset = "0x4B83190", VA = "0x184B84790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x40B1F90", Offset = "0x40B0990", VA = "0x1840B1F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey HPAJNDJICEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly FILMNPNNHPJ<TKey> PILOCADBFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly KLEHBGEJMBN DAKGLLFOGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<EEFAEMIIABD> NAIMADHPPKD;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string GEFOPIAPMGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B75CB0", Offset = "0x3B746B0", VA = "0x183B75CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<EEFAEMIIABD> POJDHIBGFPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3B75C20", Offset = "0x3B74620", VA = "0x183B75C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public DGMABNGDGHA CINFMECNCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3B75C60", Offset = "0x3B74660", VA = "0x183B75C60")]
			[CompilerGenerated]
			get
			{
				return default(DGMABNGDGHA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3B75C80", Offset = "0x3B74680", VA = "0x183B75C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B75D10", Offset = "0x3B74710", VA = "0x183B75D10")]
		internal EEFAEMIIABD(FILMNPNNHPJ<TKey> PILOCADBFFI, TKey PNABAFEIDND, KLEHBGEJMBN DAKGLLFOGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B75800", Offset = "0x3B74200", VA = "0x183B75800")]
		public EEFAEMIIABD AHEPLFBFJOD(TKey PNABAFEIDND, [Optional] KLEHBGEJMBN? EKNGLBNAPJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D4B0", Offset = "0x2E1BEB0", VA = "0x182E1D4B0")]
		[AsyncStateMachine(typeof(PMGEIMLHELL<>))]
		public Task<T> JHFKEFMCAJK<T>(TKey PNABAFEIDND, Func<EEFAEMIIABD, Task<T>> KAMLMGFPOBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B759C0", Offset = "0x3B743C0", VA = "0x183B759C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NDGICPKMLJK : IEnumerable<(TKey, List<TKey>, DGMABNGDGHA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DGMABNGDGHA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, DGMABNGDGHA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FILMNPNNHPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, DGMABNGDGHA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, DGMABNGDGHA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x247A500", Offset = "0x2478F00", VA = "0x18247A500", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DGMABNGDGHA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4915610", Offset = "0x4914010", VA = "0x184915610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x247A5F0", Offset = "0x2478FF0", VA = "0x18247A5F0")]
		[DebuggerHidden]
		public NDGICPKMLJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3B65B90", Offset = "0x3B64590", VA = "0x183B65B90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4915130", Offset = "0x4913B30", VA = "0x184915130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x49150E0", Offset = "0x4913AE0", VA = "0x1849150E0")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x49155C0", Offset = "0x4913FC0", VA = "0x1849155C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x49154E0", Offset = "0x4913EE0", VA = "0x1849154E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DGMABNGDGHA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3B842B0", Offset = "0x3B82CB0", VA = "0x183B842B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CNCGGCKICLD : IEnumerable<(TKey, List<TKey>, DGMABNGDGHA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DGMABNGDGHA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, DGMABNGDGHA timerEntry) <>2__current;

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
		private EEFAEMIIABD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EEFAEMIIABD <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FILMNPNNHPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<EEFAEMIIABD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, DGMABNGDGHA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, DGMABNGDGHA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x247A500", Offset = "0x2478F00", VA = "0x18247A500", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DGMABNGDGHA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x56F8CA0", Offset = "0x56F76A0", VA = "0x1856F8CA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x247A5F0", Offset = "0x2478FF0", VA = "0x18247A5F0")]
		[DebuggerHidden]
		public CNCGGCKICLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x56F8D00", Offset = "0x56F7700", VA = "0x1856F8D00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x56F8300", Offset = "0x56F6D00", VA = "0x1856F8300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x56F82A0", Offset = "0x56F6CA0", VA = "0x1856F82A0")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x56F8AF0", Offset = "0x56F74F0", VA = "0x1856F8AF0")]
		private void OKCPBNJHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x56F8C50", Offset = "0x56F7650", VA = "0x1856F8C50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x56F8B50", Offset = "0x56F7550", VA = "0x1856F8B50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DGMABNGDGHA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4D97E10", Offset = "0x4D96810", VA = "0x184D97E10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, DGMABNGDGHA, KLEHBGEJMBN> DLJADIPBOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, DGMABNGDGHA, KLEHBGEJMBN> BAGPKIFINJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<FILMNPNNHPJ<TKey>, KLEHBGEJMBN> OIJPLLGPABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EEFAEMIIABD FOADOLFNHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool IFCFLPBDAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BEBAIPCEACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch CIMMCNDNOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int MLPOFICPBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string PBAEOBEMJOC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EEFAEMIIABD NJOGFEFMMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string GEFOPIAPMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FB2BF0", Offset = "0x3FB15F0", VA = "0x183FB2BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2C50", Offset = "0x3FB1650", VA = "0x183FB2C50")]
	public FILMNPNNHPJ(TKey DBBKMCOCHDK, KLEHBGEJMBN DAKGLLFOGCM, [Optional] int? DDHDABHMOKE, [Optional][CanBeNull] Stopwatch CIMMCNDNOFJ, [Optional] Action<TKey, DGMABNGDGHA, KLEHBGEJMBN> DLJADIPBOAI, [Optional] Action<TKey, DGMABNGDGHA, KLEHBGEJMBN> BAGPKIFINJE, [Optional] Action<FILMNPNNHPJ<TKey>, KLEHBGEJMBN> OIJPLLGPABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3FB28F0", Offset = "0x3FB12F0", VA = "0x183FB28F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2AC0", Offset = "0x3FB14C0", VA = "0x183FB2AC0")]
	[IteratorStateMachine(typeof(FILMNPNNHPJ<>.NDGICPKMLJK))]
	public IEnumerable<(TKey, List<TKey>, DGMABNGDGHA)> GECCKEGEFCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3FB29D0", Offset = "0x3FB13D0", VA = "0x183FB29D0")]
	[IteratorStateMachine(typeof(FILMNPNNHPJ<>.CNCGGCKICLD))]
	private IEnumerable<(TKey, List<TKey>, DGMABNGDGHA)> GECCKEGEFCB(List<TKey> MHHANLDHFOC, EEFAEMIIABD MBOLAEMDCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2B70", Offset = "0x3FB1570", VA = "0x183FB2B70")]
	private (long, int) JLOJCBAOJNM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class HFHBKHPCGHE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut ADMBKAKLOGJ(FILMNPNNHPJ<TKey> PILOCADBFFI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected HFHBKHPCGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class BFDNJJOCPBL<TKey> : HFHBKHPCGHE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string DFEBFMGGHLN(TKey PNABAFEIDND);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5279470", Offset = "0x5277E70", VA = "0x185279470")]
	private static string MIOONKLAKGF(TKey PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5279380", Offset = "0x5277D80", VA = "0x185279380", Slot = "4")]
	public override string ADMBKAKLOGJ(FILMNPNNHPJ<TKey> PILOCADBFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5279220", Offset = "0x5277C20", VA = "0x185279220")]
	public string ADMBKAKLOGJ(FILMNPNNHPJ<TKey> PILOCADBFFI, [NotNull] DFEBFMGGHLN GAKJOLCLECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string HNAEPCBHNML(FILMNPNNHPJ<TKey> PILOCADBFFI, [NotNull] DFEBFMGGHLN GAKJOLCLECO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x426C0B0", Offset = "0x426AAB0", VA = "0x18426C0B0")]
	protected BFDNJJOCPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FHAMKJHEDDP<TKey> : HFHBKHPCGHE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string GHAJDGDMOJP(TKey PNABAFEIDND);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string MMHOLDEIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double HNJFMJENPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool CIGGBFPIGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int MJBCOFMGLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> FHICFOMGLML;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3F991E0", Offset = "0x3F97BE0", VA = "0x183F991E0")]
	private static string MIOONKLAKGF(TKey PNABAFEIDND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3F99220", Offset = "0x3F97C20", VA = "0x183F99220")]
	public FHAMKJHEDDP(string MMHOLDEIGKB = "F2", double HNJFMJENPHH = double.MaxValue, bool CIGGBFPIGPD = false, int MJBCOFMGLKA = int.MaxValue, [Optional] ISet<string> FHICFOMGLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3F98C30", Offset = "0x3F97630", VA = "0x183F98C30", Slot = "4")]
	public override Dictionary<string, string> ADMBKAKLOGJ(FILMNPNNHPJ<TKey> PILOCADBFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3F98D20", Offset = "0x3F97720", VA = "0x183F98D20")]
	private bool FEEGLBJBGIF(string MAHHCBPLAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3F985E0", Offset = "0x3F96FE0", VA = "0x183F985E0")]
	public Dictionary<string, string> ADMBKAKLOGJ(FILMNPNNHPJ<TKey> PILOCADBFFI, GHAJDGDMOJP GAKJOLCLECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3F98F60", Offset = "0x3F97960", VA = "0x183F98F60")]
	private string JAKINNLKBCH(StringBuilder LMLJOMAENFL, List<TKey> GCPDLEHJLBA, GHAJDGDMOJP GAKJOLCLECO, bool JCFFKCBKPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3F98E00", Offset = "0x3F97800", VA = "0x183F98E00")]
	private static void HJKECFGNGJP(StringBuilder ENIFOJIJCKP, string CEBKCOHDKKG, bool KOJJMLEOGAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AFJPINAHLKI<TKey> : BFDNJJOCPBL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JFNPMDPJDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DFEBFMGGHLN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static AFJPINAHLKI<TKey> JOLICDCBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] CMOOIEBMCDG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x40B06D0", Offset = "0x40AF0D0", VA = "0x1840B06D0")]
	private AFJPINAHLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x40AF740", Offset = "0x40AE140", VA = "0x1840AF740", Slot = "5")]
	protected override string HNAEPCBHNML(FILMNPNNHPJ<TKey> PILOCADBFFI, DFEBFMGGHLN GAKJOLCLECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x40AF630", Offset = "0x40AE030", VA = "0x1840AF630")]
	[CompilerGenerated]
	internal static string DGHMDNJKOAM(string JPBBBKIJCNM, TKey PNABAFEIDND, JFNPMDPJDFM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class ABAMEOFADCD : FILMNPNNHPJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GOPFBPNCLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<ABAMEOFADCD, KLEHBGEJMBN> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GOPFBPNCLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD230", Offset = "0x6DBBC30", VA = "0x186DBD230")]
		internal void CBFOAGAHAMG(FILMNPNNHPJ<string> timer, KLEHBGEJMBN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBAF0", Offset = "0x6DBA4F0", VA = "0x186DBBAF0")]
	public ABAMEOFADCD(KLEHBGEJMBN DAKGLLFOGCM, [Optional] string EJHFDGLHAHO, [Optional] int? DDHDABHMOKE, [Optional] Stopwatch CIMMCNDNOFJ, [Optional] Action<string, DGMABNGDGHA, KLEHBGEJMBN> DLJADIPBOAI, [Optional] Action<string, DGMABNGDGHA, KLEHBGEJMBN> BAGPKIFINJE, [Optional] Action<ABAMEOFADCD, KLEHBGEJMBN> OIJPLLGPABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBA30", Offset = "0x6DBA430", VA = "0x186DBBA30")]
	private static Action<FILMNPNNHPJ<string>, KLEHBGEJMBN> CKHBHNKLLNE(Action<ABAMEOFADCD, KLEHBGEJMBN> HFJNADOBPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class JNECHGHOIPD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class KCHCECKBEFC : JNECHGHOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static JNECHGHOIPD JOLICDCBKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6DBF640", Offset = "0x6DBE040", VA = "0x186DBF640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float DOEJPNCNEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xCEB8D0", Offset = "0xCEA2D0", VA = "0x180CEB8D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6DBF730", Offset = "0x6DBE130", VA = "0x186DBF730")]
		public KCHCECKBEFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static JNECHGHOIPD GNNNLLCOKIH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static JNECHGHOIPD JCFGJMCEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE330", Offset = "0x6DBCD30", VA = "0x186DBE330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float DOEJPNCNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected JNECHGHOIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LOKHDAHPDJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FFCGNKADKHD<T> : LOKHDAHPDJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> FKKJDMMKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	BJOGDIODDMJ<T> PGNIBKFPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FJBBBIGCCFF
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2EE0FD0", Offset = "0x2EDF9D0", VA = "0x182EE0FD0")]
	public static FFCGNKADKHD<TResource> DJDEDIPKPOP<TResource, TId>(this CKEFNLJAEID<TId, TResource> CAMFPBAFKPB, TId CMEADPACGME, [Optional] Func<TId, CancellationToken, Task<TResource>>? KIDHEKMHEGH) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AMLPEGAEAAA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class ENOMBFDEFNN<T> : IFDKEOABGPN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override BJOGDIODDMJ<T?> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EAA0", Offset = "0x3B8D4A0", VA = "0x183B8EAA0")]
		public ENOMBFDEFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class ENLDDIOFMEG<T> : IFDKEOABGPN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T IPIDKLKPLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? JCHIJAIHCDN;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override BJOGDIODDMJ<T> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3B8BC80", Offset = "0x3B8A680", VA = "0x183B8BC80")]
		public ENLDDIOFMEG(T CMNJBOIHGOI, Action<T>? FKEFGHMOLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3B8BC20", Offset = "0x3B8A620", VA = "0x183B8BC20", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class HIPKHJMINDI<T> : IFDKEOABGPN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override BJOGDIODDMJ<T> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x417D340", Offset = "0x417BD40", VA = "0x18417D340")]
		public HIPKHJMINDI(Exception PGCLCKNIGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class JHDNKGFIBAB<T> : IFDKEOABGPN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct IMOJJDEEHAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<FFCGNKADKHD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<FFCGNKADKHD<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x425BE90", Offset = "0x425A890", VA = "0x18425BE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x425C3D0", Offset = "0x425ADD0", VA = "0x18425C3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct MGACOIHCJLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<FFCGNKADKHD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<FFCGNKADKHD<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x48B0D00", Offset = "0x48AF700", VA = "0x1848B0D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x48B0FA0", Offset = "0x48AF9A0", VA = "0x1848B0FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<FFCGNKADKHD<T>> LNHDEOGGCOI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override BJOGDIODDMJ<T> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4432D00", Offset = "0x4431700", VA = "0x184432D00")]
		public JHDNKGFIBAB(Task<FFCGNKADKHD<T>> LPAAFOGOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4432790", Offset = "0x4431190", VA = "0x184432790", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4432B80", Offset = "0x4431580", VA = "0x184432B80")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(JHDNKGFIBAB<>.IMOJJDEEHAN))]
		internal static Task<T> JOOOMBMEMGC(Task<FFCGNKADKHD<T>> LPAAFOGOHKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4432910", Offset = "0x4431310", VA = "0x184432910")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(JHDNKGFIBAB<>.MGACOIHCJLH))]
		internal static Task JLGOAANHDMM(Task<FFCGNKADKHD<T>> LPAAFOGOHKE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class NFCEGJOLLLP<TIn, TOut> : IFDKEOABGPN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct MGMJPAEMNGA : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x48B7C10", Offset = "0x48B6610", VA = "0x1848B7C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x465F290", Offset = "0x465DC90", VA = "0x18465F290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly FFCGNKADKHD<TIn> JNDAFLPFPLC;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> FKKJDMMKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override BJOGDIODDMJ<TOut> PGNIBKFPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x493BD50", Offset = "0x493A750", VA = "0x18493BD50")]
		public NFCEGJOLLLP(FFCGNKADKHD<TIn> COGBCJDNFHB, Func<TIn, TOut> GEKEJHJHMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x493B9E0", Offset = "0x493A3E0", VA = "0x18493B9E0", Slot = "10")]
		protected override void DBGDDHAMGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x493BA30", Offset = "0x493A430", VA = "0x18493BA30")]
		[AsyncStateMachine(typeof(NFCEGJOLLLP<, >.MGMJPAEMNGA))]
		[CompilerGenerated]
		internal static Task<TOut> LDBCPNCGONM(Task<TIn> GDGIBOIDLDJ, Func<TIn, TOut> GEKEJHJHMKB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x35C7E50", Offset = "0x35C6850", VA = "0x1835C7E50")]
	public static FFCGNKADKHD<T> BDDJBNJILLK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x35C7ED0", Offset = "0x35C68D0", VA = "0x1835C7ED0")]
	public static FFCGNKADKHD<T> EDEMAHMMCGP<T>(T KIBAOEBFCJF, [Optional] Action<T>? FKEFGHMOLDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static FFCGNKADKHD<T> CABMBIBIKGP<T>(Exception PGCLCKNIGGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static FFCGNKADKHD<T> EOBLBBJFBIH<T>(Task<FFCGNKADKHD<T>> LPAAFOGOHKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE98F0", Offset = "0x2CE82F0", VA = "0x182CE98F0")]
	public static FFCGNKADKHD<TOut> DNOKGDKBFAA<TOut, TIn>(FFCGNKADKHD<TIn> DFEBEONMKNH, Func<TIn, TOut> GEKEJHJHMKB) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class IFDKEOABGPN<T> : FFCGNKADKHD<T>, LOKHDAHPDJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string JEEOJDJPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EEJADCHMHJL LCLLNKHBIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool IFCFLPBDAAE;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xEB7490", Offset = "0xEB5E90", VA = "0x180EB7490", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> FKKJDMMKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract BJOGDIODDMJ<T> PGNIBKFPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x424A2F0", Offset = "0x4248CF0", VA = "0x18424A2F0")]
	public IFDKEOABGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x424A030", Offset = "0x4248A30", VA = "0x18424A030", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DBGDDHAMGHG();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class MBIIHFDODNO<TTask, T> : IFDKEOABGPN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HJLDEFCDAGN
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
			public HJLDEFCDAGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x38D0BB0", Offset = "0x38CF5B0", VA = "0x1838D0BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x38D1120", Offset = "0x38CFB20", VA = "0x1838D1120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MBIIHFDODNO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HJLDEFCDAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4183F50", Offset = "0x4182950", VA = "0x184183F50")]
		[AsyncStateMachine(typeof(MBIIHFDODNO<, >.HJLDEFCDAGN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OALBONLBBDN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> LPAAFOGOHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource KPJNJINNMPF;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> FKKJDMMKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override BJOGDIODDMJ<T> PGNIBKFPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4874550", Offset = "0x4872F50", VA = "0x184874550")]
	protected MBIIHFDODNO(TTask LPAAFOGOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4874500", Offset = "0x4872F00", VA = "0x184874500", Slot = "10")]
	protected override void DBGDDHAMGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T EOCJMLKEBNI(TTask BIJAKIMJMLF);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void HNMKLBOBHKN();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GOCKOOOPMCM<T> : IFDKEOABGPN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CCFPOCKCODD<Task<T>> ADMLDHJECJJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> FKKJDMMKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x410A050", Offset = "0x4108A50", VA = "0x18410A050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override BJOGDIODDMJ<T> PGNIBKFPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x411E550", Offset = "0x411CF50", VA = "0x18411E550")]
	public GOCKOOOPMCM(CCFPOCKCODD<Task<T>> GDPGGNIOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x411E530", Offset = "0x411CF30", VA = "0x18411E530", Slot = "10")]
	protected override void DBGDDHAMGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class GEFCHEPJHAK
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName KGDAJHCCIMB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> DNDHGFDBOMB;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC960", Offset = "0x6DBB360", VA = "0x186DBC960")]
	public static int OFHMFAIPGHO(this KEBKKMHIABP NBJCKODNFJL, IncrementalHash CGIDNBEMCAI, byte[] LALBHPKEJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCD10", Offset = "0x6DBB710", VA = "0x186DBCD10")]
	public static bool PBAAOMIFCDI([CanBeNull] this KEBKKMHIABP NBJCKODNFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6DBCD70", Offset = "0x6DBB770", VA = "0x186DBCD70")]
	public static bool PBAAOMIFCDI([CanBeNull] this KEBKKMHIABP NBJCKODNFJL, [Out] string BHAOKKINJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC9E0", Offset = "0x6DBB3E0", VA = "0x186DBC9E0")]
	public static bool PBAAOMIFCDI([CanBeNull] this KEBKKMHIABP NBJCKODNFJL, IncrementalHash CGIDNBEMCAI, byte[] LALBHPKEJLB, [Out] string BHAOKKINJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC8D0", Offset = "0x6DBB2D0", VA = "0x186DBC8D0")]
	private static bool KOODJALJEBB(byte[] OIFLPEKPGGC, Span<byte> MFOHBEKHHKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class DFKBECILPGH
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC340", Offset = "0x6DBAD40", VA = "0x186DBC340")]
	public static int DJBGPLINPOH(HashAlgorithmName IIFBOFIEJEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC490", Offset = "0x6DBAE90", VA = "0x186DBC490")]
	public static int OFHMFAIPGHO(this FDBNGHAJHBO LNJHDEAHLIJ, byte[] HNKIFGCPBFI, IncrementalHash CGIDNBEMCAI, byte[] BKLGIGNMMOI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface FDBNGHAJHBO
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CGIDNBEMCAI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KEBKKMHIABP : FDBNGHAJHBO
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] NHMJPEAGIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] KFADJBOKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JPNLIFHMLPI
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool MPEFCMGBCEN;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> DKGFOCMLNFM;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> KPEEIPFIFEI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding DKJPFJAOKFC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> BBHHKFEOCEH;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E2C0", Offset = "0x2F4CCC0", VA = "0x182F4E2C0")]
	public static void NKGCICPGGJI<T>(this IncrementalHash OBKELIEEGJI, [CanBeNull] T LHCHHCODKCC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D6E0", Offset = "0x2F4C0E0", VA = "0x182F4D6E0")]
	public static void FJCHCAGCEDE<T>(this IncrementalHash OBKELIEEGJI, [CanBeNull] T LNJHDEAHLIJ) where T : FDBNGHAJHBO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D770", Offset = "0x2F4C170", VA = "0x182F4D770")]
	public static void HGBOEKFPMPG<T>(this IncrementalHash OBKELIEEGJI, [CanBeNull] IList<T> FKNHHKODOAN) where T : FDBNGHAJHBO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF330", Offset = "0x6DBDD30", VA = "0x186DBF330")]
	private static bool OPDJGKALAHP([CanBeNull] FDBNGHAJHBO LNJHDEAHLIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE8B0", Offset = "0x6DBD2B0", VA = "0x186DBE8B0")]
	public static void HOHLGFLBBGB(this IncrementalHash CGIDNBEMCAI, string? JIOHCALLCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEDC0", Offset = "0x6DBD7C0", VA = "0x186DBEDC0")]
	public static void IPJNAJGMPAA(this IncrementalHash CGIDNBEMCAI, long FNIALDLNNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEFF0", Offset = "0x6DBD9F0", VA = "0x186DBEFF0")]
	public static void JJPNHLLJKOL(this IncrementalHash CGIDNBEMCAI, int FHIDNHJPGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE680", Offset = "0x6DBD080", VA = "0x186DBE680")]
	public static void HEHJNLPEKOC(this IncrementalHash CGIDNBEMCAI, short DBIPGBIIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6DBECB0", Offset = "0x6DBD6B0", VA = "0x186DBECB0")]
	public static void ICBNEBFPCMG(this IncrementalHash CGIDNBEMCAI, byte OKKOOPPNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF1C0", Offset = "0x6DBDBC0", VA = "0x186DBF1C0")]
	public static void OJABEGBBPOC(this IncrementalHash CGIDNBEMCAI, bool MFDCJNCLBFM, bool DICHJFOJBOI = false, bool MBIBLLLMMLE = false, bool OBEPLHFGDIE = false, bool OBLLFMFPHDB = false, bool GNOBMNCCJFK = false, bool KKOLBMEEHMI = false, bool EINLGFEEOIH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DC90", Offset = "0x2F4C690", VA = "0x182F4DC90")]
	public static void MLCCEIMCJMI<T>(this IncrementalHash CGIDNBEMCAI, T COJJJGIBKEK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEF90", Offset = "0x6DBD990", VA = "0x186DBEF90")]
	public static void JCLGKJAEDEE(this IncrementalHash CGIDNBEMCAI, float DMPGKBMMLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE850", Offset = "0x6DBD250", VA = "0x186DBE850")]
	public static void HLNLJCKHMLG(this IncrementalHash CGIDNBEMCAI, ulong IJIJFKLJBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE4F0", Offset = "0x6DBCEF0", VA = "0x186DBE4F0")]
	public static void CJHBDILGLFN(this IncrementalHash CGIDNBEMCAI, uint GOANNPKDCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE490", Offset = "0x6DBCE90", VA = "0x186DBE490")]
	public static void BFFBDEFIHCF(this IncrementalHash CGIDNBEMCAI, ushort CMFFNHIOLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE550", Offset = "0x6DBCF50", VA = "0x186DBE550")]
	public static void GNEPFDHCILG(this IncrementalHash CGIDNBEMCAI, Vector3 NIFDBDMLMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class ANHKJEAEKPC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBC40", Offset = "0x6DBA640", VA = "0x186DBBC40")]
	public ANHKJEAEKPC(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class ONDCEGCCNNG
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void EADKCHHIIKM(ushort PMHILOJLENH, ushort KAKJNGIOELH, ushort AHBIGHJKDJH, ushort HNELHIIKOEA);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void BIPHLLEPNPL(ushort CFPCFHKFFGM, ushort MAKGIBMFJCA);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void LJAELEJDHBG();

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const ushort OOICOHEFFOB = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected ONDCEGCCNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class BMJHONLGMOJ<T> : ONDCEGCCNNG where T : BMJHONLGMOJ<T>.HEAGIDMOCFB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface HEAGIDMOCFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		BIPHLLEPNPL NHAADNEDHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		BIPHLLEPNPL JMLNLEAPGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		LJAELEJDHBG PAIKEIENEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<uint, T> EJAHECDKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private LJAELEJDHBG JHMMMHKHFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private LJAELEJDHBG OJBLDAIGBDI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool JAGOEHAFAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B6BA0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public ushort GFHDPKGBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x529E260", Offset = "0x529CC60", VA = "0x18529E260")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x529E0F0", Offset = "0x529CAF0", VA = "0x18529E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public ushort JMKHDEGKHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x529DF80", Offset = "0x529C980", VA = "0x18529DF80")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x529E100", Offset = "0x529CB00", VA = "0x18529E100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public ushort NOKHJOBCGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x97E920", Offset = "0x97D320", VA = "0x18097E920")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x97EAC0", Offset = "0x97D4C0", VA = "0x18097EAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public ushort JKHAPONAKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x529E250", Offset = "0x529CC50", VA = "0x18529E250")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x529DCE0", Offset = "0x529C6E0", VA = "0x18529DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected bool PNNHAIGCCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x123F6E0", Offset = "0x123E0E0", VA = "0x18123F6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	protected bool GNPJNHAEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xD6F8C0", Offset = "0xD6E2C0", VA = "0x180D6F8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EADKCHHIIKM BBJANBIOEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x529DC40", Offset = "0x529C640", VA = "0x18529DC40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x529DF90", Offset = "0x529C990", VA = "0x18529DF90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x529E120", Offset = "0x529CB20", VA = "0x18529E120")]
	private T LDEFBJIMDBG(ushort OJKIDIIKEEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x529D950", Offset = "0x529C350", VA = "0x18529D950")]
	private T ABAKEMEPCFD(ushort OJKIDIIKEEH, ushort DCDHJKNOKBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x529E1E0", Offset = "0x529CBE0", VA = "0x18529E1E0")]
	protected T LDMMLEOIJJO(uint PBCEHMFMOON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x529EB10", Offset = "0x529D510", VA = "0x18529EB10")]
	protected BMJHONLGMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x529DA20", Offset = "0x529C420", VA = "0x18529DA20")]
	public void DJPPCODPFCE(ushort GMAFFHDGOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x529DA60", Offset = "0x529C460", VA = "0x18529DA60")]
	public void DJPPCODPFCE(ushort GMAFFHDGOFJ, ushort JFMJEHHLAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x529DAC0", Offset = "0x529C4C0", VA = "0x18529DAC0", Slot = "4")]
	protected virtual void DJPPCODPFCE(uint GDDJGIIDKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x529E270", Offset = "0x529CC70", VA = "0x18529E270")]
	protected void OLPNCCJMGMM(uint GDDJGIIDKPH, uint HJOBCLCCCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x529E040", Offset = "0x529CA40", VA = "0x18529E040")]
	protected void JAGDPNIKMKM(ushort OJKIDIIKEEH, ushort DCDHJKNOKBM, T DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x529DBE0", Offset = "0x529C5E0", VA = "0x18529DBE0")]
	private void DOMKDFLOOKH(uint PBCEHMFMOON, T DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x529DCF0", Offset = "0x529C6F0", VA = "0x18529DCF0")]
	protected void FGOGIMHDHCH(float OFFHKGFMEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x529E240", Offset = "0x529CC40", VA = "0x18529E240")]
	protected uint LEMFHJJEKKK(ushort OJKIDIIKEEH, ushort DCDHJKNOKBM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x529E030", Offset = "0x529CA30", VA = "0x18529E030")]
	protected ushort ILKCAIJBNDI(uint JFIICBKNKCL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x529E110", Offset = "0x529CB10", VA = "0x18529E110")]
	protected ushort KMAJOHODKIP(uint JFIICBKNKCL)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class PEEEODOMIBL : BMJHONLGMOJ<PEEEODOMIBL.IDOEFEADLOO>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class IDOEFEADLOO : HEAGIDMOCFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public BIPHLLEPNPL NHAADNEDHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public BIPHLLEPNPL JMLNLEAPGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public LJAELEJDHBG PAIKEIENEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IDOEFEADLOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFA90", Offset = "0x6DBE490", VA = "0x186DBFA90")]
	public void HBFJONLPKPM(ushort FHHFFKKPGBH, BIPHLLEPNPL DJGLIHHMGIH, BIPHLLEPNPL LAPMMFDGIPD, LJAELEJDHBG GFOJKPNBPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFB70", Offset = "0x6DBE570", VA = "0x186DBFB70")]
	public void HBFJONLPKPM(ushort OJKIDIIKEEH, ushort DCDHJKNOKBM, BIPHLLEPNPL DJGLIHHMGIH, BIPHLLEPNPL LAPMMFDGIPD, LJAELEJDHBG GFOJKPNBPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFC50", Offset = "0x6DBE650", VA = "0x186DBFC50")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF9D0", Offset = "0x6DBE3D0", VA = "0x186DBF9D0")]
	protected PEEEODOMIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class NFMINIFFNGH : PEEEODOMIBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool BMNAODEOODN;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool NPNEBPFKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x935D30", Offset = "0x934730", VA = "0x180935D30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9D8A20", Offset = "0x9D7420", VA = "0x1809D8A20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF970", Offset = "0x6DBE370", VA = "0x186DBF970")]
	public void GCHKJEOLKFE(ushort GCIIEAFKCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF910", Offset = "0x6DBE310", VA = "0x186DBF910")]
	public void GCHKJEOLKFE(ushort GCIIEAFKCOB, ushort CCKGPNCDDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF9D0", Offset = "0x6DBE3D0", VA = "0x186DBF9D0")]
	public NFMINIFFNGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class MHCDMJGAMGH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class GLDAEBKLACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TNode PCBICLOONMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode NNFBEGDDJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BMOEHEMILPH MIPAHIFMGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<BMOEHEMILPH> NIEGMMFMGJK;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GLDAEBKLACO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct BMOEHEMILPH : IComparable<BMOEHEMILPH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int OFKEGOMNGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public TClaimant BIKLPJBOLKC;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1116530", Offset = "0x1114F30", VA = "0x181116530")]
		public BMOEHEMILPH(int OFKEGOMNGIE, TClaimant BIKLPJBOLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x529ED30", Offset = "0x529D730", VA = "0x18529ED30")]
		public bool KOBMPDEINLE([In] BMOEHEMILPH GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x529ED20", Offset = "0x529D720", VA = "0x18529ED20")]
		public bool DPEMNDBDIAO([In] BMOEHEMILPH GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x529ED10", Offset = "0x529D710", VA = "0x18529ED10", Slot = "4")]
		public int CompareTo(BMOEHEMILPH GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x529ED90", Offset = "0x529D790", VA = "0x18529ED90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum HECEPAIJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class PALDEBMNALJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MHCDMJGAMGH<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public PALDEBMNALJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4B4D990", Offset = "0x4B4C390", VA = "0x184B4D990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4B4DB70", Offset = "0x4B4C570", VA = "0x184B4DB70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B4DA70", Offset = "0x4B4C470", VA = "0x184B4DA70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B65B00", Offset = "0x3B64500", VA = "0x183B65B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly LEAINFFOANC<GLDAEBKLACO> AKPINAPMMNN;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly LEAINFFOANC<List<BMOEHEMILPH>> CCDMJKBLIBC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static int HGKFMKIEEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal readonly Dictionary<TClaimant, TNode> DDEABLIEDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TNode, GLDAEBKLACO> OMBIHLGKCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private HECEPAIJDNJ JNPKLGGOLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode LFKDBJINFIN(TNode OFGAFPGJIKO);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AIGGIPAGIKB(TNode OFGAFPGJIKO, TClaimant IBDIFBIGFPK, TClaimant NFFLBKCLGHG);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x48BA4D0", Offset = "0x48B8ED0", VA = "0x1848BA4D0")]
	public MHCDMJGAMGH(HECEPAIJDNJ JNPKLGGOLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x48B9320", Offset = "0x48B7D20", VA = "0x1848B9320")]
	public void FOOFJCNNCMI(TNode OFGAFPGJIKO, TNode AOBPGDDFDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x48BA080", Offset = "0x48B8A80", VA = "0x1848BA080")]
	public void ONJNIBIJLHL(TClaimant BIKLPJBOLKC, TNode PNDAEJJKBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x48B8C30", Offset = "0x48B7630", VA = "0x1848B8C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x48BA220", Offset = "0x48B8C20", VA = "0x1848BA220")]
	private void PPBIBNDIOLD(TClaimant BIKLPJBOLKC, TNode NMLPGCMMCPM, TNode PNDAEJJKBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x48B88C0", Offset = "0x48B72C0", VA = "0x1848B88C0")]
	private int BINHPMIFPHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x48B9750", Offset = "0x48B8150", VA = "0x1848B9750")]
	private void LGAGBAMJJJB(TClaimant BIKLPJBOLKC, TNode LFOBNGIGCAF, TNode DMBNIEOCDAD, int EGABNNNKKCA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x48B9E40", Offset = "0x48B8840", VA = "0x1848B9E40")]
	private void MMBKEAOJHIB(BMOEHEMILPH CLIOOEJKBMM, GLDAEBKLACO KENDFLINCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x48B9020", Offset = "0x48B7A20", VA = "0x1848B9020")]
	private void FMCFGNFFLGI(TClaimant BIKLPJBOLKC, TNode LFOBNGIGCAF, TNode DMBNIEOCDAD, int EGABNNNKKCA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x48B9610", Offset = "0x48B8010", VA = "0x1848B9610")]
	private void KNFIHECPEPH(BMOEHEMILPH CLIOOEJKBMM, TNode OFGAFPGJIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x48B8AC0", Offset = "0x48B74C0", VA = "0x1848B8AC0")]
	private void DMDGPCGNICC(BMOEHEMILPH CLIOOEJKBMM, GLDAEBKLACO KENDFLINCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x48B9F20", Offset = "0x48B8920", VA = "0x1848B9F20")]
	private void NMHDHPGHIGA(GLDAEBKLACO KENDFLINCBC, bool EODJIGHIDCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x48B9AB0", Offset = "0x48B84B0", VA = "0x1848B9AB0")]
	private void MHMBIBPOBAE(GLDAEBKLACO KENDFLINCBC, TNode AOBPGDDFDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x48B9510", Offset = "0x48B7F10", VA = "0x1848B9510")]
	[IteratorStateMachine(typeof(MHCDMJGAMGH<, >.PALDEBMNALJ))]
	private IEnumerable<TNode> JNFHAODAAFG(TNode LFOBNGIGCAF, TNode DMBNIEOCDAD, bool OOAGOOADLPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x48B93F0", Offset = "0x48B7DF0", VA = "0x1848B93F0")]
	private GLDAEBKLACO IIIBDGKEPHB(TNode OFGAFPGJIKO, TNode NNFBEGDDJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x48B8930", Offset = "0x48B7330", VA = "0x1848B8930")]
	private GLDAEBKLACO CPJCDDLIDKN(TNode OFGAFPGJIKO, TNode NNFBEGDDJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x48B8E50", Offset = "0x48B7850", VA = "0x1848B8E50")]
	private void EDOPCHGBBDA(GLDAEBKLACO KENDFLINCBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class KFGNECBGPDI<T> : IEnumerable<KFGNECBGPDI<T>.PNGEBADHADA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PNGEBADHADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public T PKCLPFEIPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int GCBONJOGHCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class DLIHJMHDEGB : IEnumerator<PNGEBADHADA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private KFGNECBGPDI<T> GBCGAMNIJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int GCBONJOGHCD;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x3BB3B00", Offset = "0x3BB2500", VA = "0x183BB3B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public PNGEBADHADA MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x5C89500", Offset = "0x5C87F00", VA = "0x185C89500", Slot = "4")]
			get
			{
				return default(PNGEBADHADA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C894C0", Offset = "0x5C87EC0", VA = "0x185C894C0")]
		public DLIHJMHDEGB(KFGNECBGPDI<T> GBCGAMNIJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5C89440", Offset = "0x5C87E40", VA = "0x185C89440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C08390", Offset = "0x3C06D90", VA = "0x183C08390", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC796A0", Offset = "0xC780A0", VA = "0x180C796A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct HEPEGNIACLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool OELILGMJMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public T PKCLPFEIPFH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private const int PMBNKCMICKP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly Dictionary<T, int> HNEFLLEMLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private HEPEGNIACLC[] JKONLHHDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int GJMALKJOOLI;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int GMAOOCPCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8ED140", Offset = "0x8EBB40", VA = "0x1808ED140")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8ECDB0", Offset = "0x8EB7B0", VA = "0x1808ECDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x38E2640", Offset = "0x38E1040", VA = "0x1838E2640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4549420", Offset = "0x4547E20", VA = "0x184549420")]
	public KFGNECBGPDI(int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4549510", Offset = "0x4547F10", VA = "0x184549510")]
	public KFGNECBGPDI(PNGEBADHADA[] IFIHOBKGFNI, bool PGKAMCKNALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4548770", Offset = "0x4547170", VA = "0x184548770")]
	public int HAPLENAAIMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4548A60", Offset = "0x4547460", VA = "0x184548A60")]
	private int PCBLFBNBCNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4548F00", Offset = "0x4547900", VA = "0x184548F00", Slot = "6")]
	protected virtual uint POACLFBBFJM(uint CGIDNBEMCAI, T PKCLPFEIPFH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4548840", Offset = "0x4547240", VA = "0x184548840")]
	public bool JCEGJEJOMAE(T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x45480F0", Offset = "0x4546AF0", VA = "0x1845480F0")]
	public int AAKMCPMBEBP(T PKCLPFEIPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x45489A0", Offset = "0x45473A0", VA = "0x1845489A0")]
	public T OIEOOCJCCMO(int GCBONJOGHCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x45483F0", Offset = "0x4546DF0", VA = "0x1845483F0")]
	public bool BPAIIGKEBOM(T PKCLPFEIPFH, bool DGNBCMMBFHK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4548180", Offset = "0x4546B80", VA = "0x184548180")]
	public bool BPAIIGKEBOM(T PKCLPFEIPFH, int GCBONJOGHCD, bool DGNBCMMBFHK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4548950", Offset = "0x4547350", VA = "0x184548950")]
	private int KPHHJHLBMPN(int FMCLGEDFPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4548F30", Offset = "0x4547930", VA = "0x184548F30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4548F30", Offset = "0x4547930", VA = "0x184548F30", Slot = "4")]
	private IEnumerator<PNGEBADHADA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LEAINFFOANC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly Stack<T> POHKLOIJGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly List<T> DBNMCPDFMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly int BHKOHAEGGGE;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x465F940", Offset = "0x465E340", VA = "0x18465F940")]
	public static LEAINFFOANC<T> KKEAACEDGCJ(int LFENHKJMLMG = 0, int BHKOHAEGGGE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x465F330", Offset = "0x465DD30", VA = "0x18465F330")]
	public static LEAINFFOANC<T> DBHIGGONCDN(int LFENHKJMLMG = 0, int BHKOHAEGGGE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x465FF80", Offset = "0x465E980", VA = "0x18465FF80")]
	public LEAINFFOANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x465FD60", Offset = "0x465E760", VA = "0x18465FD60")]
	public LEAINFFOANC(int LFENHKJMLMG, int BHKOHAEGGGE = int.MaxValue, bool OCELGFOAHJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x465FA40", Offset = "0x465E440", VA = "0x18465FA40")]
	public T MCHGAPKLKOF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x465FC20", Offset = "0x465E620", VA = "0x18465FC20")]
	public void MMBLFJNKGED(T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x465F840", Offset = "0x465E240", VA = "0x18465F840")]
	private void IFHOGLFJDFM(T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x465FD10", Offset = "0x465E710", VA = "0x18465FD10")]
	private void OPEBMDIHOAM(T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x465F430", Offset = "0x465DE30", VA = "0x18465F430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x465F5C0", Offset = "0x465DFC0", VA = "0x18465F5C0")]
	private void GPIKMPMCAHI(IEnumerable<T> KJCKFFGBDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BNMKCLGBLOB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Dictionary<int, T> ANMHHNMKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T DEKMFNJNEPJ;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public virtual T LLAPKIGPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x52A13F0", Offset = "0x529FDF0", VA = "0x1852A13F0")]
	public bool IMKENKPFHBD(T PKCLPFEIPFH, int OFKEGOMNGIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x52A12E0", Offset = "0x529FCE0", VA = "0x1852A12E0")]
	public bool FMABBGOMMKF(int OFKEGOMNGIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x52A19A0", Offset = "0x52A03A0", VA = "0x1852A19A0")]
	public T KACOFHLBCPM(int CNNGLCDALEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x52A1550", Offset = "0x529FF50", VA = "0x1852A1550")]
	private bool JAIMCEGPNAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x52A1390", Offset = "0x529FD90", VA = "0x1852A1390")]
	public bool HPCEHODMPGB(int OFKEGOMNGIE, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x52A1BC0", Offset = "0x52A05C0", VA = "0x1852A1BC0")]
	public BNMKCLGBLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class INNOAKJBICB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct DKLIHFGBGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T IPHIEALFCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int NIPGNMFIFME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	protected readonly List<DKLIHFGBGIG> BMIMFCBHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private T GPKAGCJJGHB;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x38E2640", Offset = "0x38E1040", VA = "0x1838E2640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4265F20", Offset = "0x4264920", VA = "0x184265F20")]
	public bool OIBNNKGDJBI(T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4265E60", Offset = "0x4264860", VA = "0x184265E60")]
	public void NOEGDDICEDP(T PKCLPFEIPFH, int OFKEGOMNGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4266320", Offset = "0x4264D20", VA = "0x184266320")]
	public bool PJOABDGMIKH(T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4265870", Offset = "0x4264270", VA = "0x184265870")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x42659B0", Offset = "0x42643B0", VA = "0x1842659B0")]
	public T EKCGHNFDLEP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4265BF0", Offset = "0x42645F0", VA = "0x184265BF0")]
	protected void IJFNPLILCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x42666C0", Offset = "0x42650C0", VA = "0x1842666C0")]
	public INNOAKJBICB()
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
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x6DBFF40", Offset = "0x6DBE940", VA = "0x186DBFF40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x6DC0210", Offset = "0x6DBEC10", VA = "0x186DC0210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x6DC0120", Offset = "0x6DBEB20", VA = "0x186DC0120")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6DBFE90", Offset = "0x6DBE890", VA = "0x186DBFE90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x6DC0160", Offset = "0x6DBEB60", VA = "0x186DC0160")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x6DC0070", Offset = "0x6DBEA70", VA = "0x186DC0070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6DBFE10", Offset = "0x6DBE810", VA = "0x186DBFE10")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4D45880", Offset = "0x4D44280", VA = "0x184D45880", Slot = "4")]
		public virtual T FAOPAFPPLBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HLKGKNDACNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Dictionary<byte, BPIGAGECDKB> JOBDAPACEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly LEAINFFOANC<BPIGAGECDKB> PDCANIDKCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool HEELGPFKHBC;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BPIGAGECDKB KEACDEPPLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 ODPLBDPNLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1085FF0", Offset = "0x10849F0", VA = "0x181085FF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x13920B0", Offset = "0x1390AB0", VA = "0x1813920B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private Vector2 JLJLNBKOPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA001E0", Offset = "0x9FEBE0", VA = "0x180A001E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector2 NIKNOCCGBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE230", Offset = "0x6DBCC30", VA = "0x186DBE230")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0210", Offset = "0x8AEC10", VA = "0x1808B0210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int CKMMKCMKHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD570", Offset = "0x8ABF70", VA = "0x1808AD570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD760", Offset = "0x8AC160", VA = "0x1808AD760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE270", Offset = "0x6DBCC70", VA = "0x186DBE270")]
	public HLKGKNDACNM(Bounds IJOAIGPIGAD, Vector2[] ILPHBONLMNH, int LIMDBEDMLCN, byte FMCLGEDFPEP, float EGFLFFDAGCD = 0f, [Optional] LEAINFFOANC<BPIGAGECDKB> PDCANIDKCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD6E0", Offset = "0x6DBC0E0", VA = "0x186DBD6E0")]
	public void HAJPNEPHHLF(Bounds IJOAIGPIGAD, Vector2[] ILPHBONLMNH, int LIMDBEDMLCN, byte FMCLGEDFPEP, float EGFLFFDAGCD = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD620", Offset = "0x6DBC020", VA = "0x186DBD620")]
	public BPIGAGECDKB FHALOBECBDK(byte GCBONJOGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD2C0", Offset = "0x6DBBCC0", VA = "0x186DBD2C0")]
	public void BFMIBMJFOMN(Vector3 PCPIJKGKPCE, float CEPLKNPDDDB, float GKCOCGPGNDB, List<byte> AAEAAONCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE250", Offset = "0x6DBCC50", VA = "0x186DBE250")]
	public void PLEMKMGHODL(BPIGAGECDKB.MFDGOFGAOKA JCOFBGIAPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDB70", Offset = "0x6DBC570", VA = "0x186DBDB70")]
	public static int LCNKEMHJBAH(Vector2[] ILPHBONLMNH, int LIMDBEDMLCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD390", Offset = "0x6DBBD90", VA = "0x186DBD390")]
	private BPIGAGECDKB CEKMHCJDECP(byte GCBONJOGHCD, BPIGAGECDKB.AAPHKEEKNOB PICPHOPKEIL, BPIGAGECDKB NNFBEGDDJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDC50", Offset = "0x6DBC650", VA = "0x186DBDC50")]
	private void LEEBCCJIALA(BPIGAGECDKB NNFBEGDDJKL, Vector2[] ILPHBONLMNH, int GLNAFLAMLLO, int PCADJNPDAFE, int OILAOHADECG, int ACMCILEKEBE, float EGFLFFDAGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE010", Offset = "0x6DBCA10", VA = "0x186DBE010")]
	private void MHLBPNGKDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD5C0", Offset = "0x6DBBFC0", VA = "0x186DBD5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD680", Offset = "0x6DBC080", VA = "0x186DBD680", Slot = "1")]
	~HLKGKNDACNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class BPIGAGECDKB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum AAPHKEEKNOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum MFDGOFGAOKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte PGOLDFNFDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 DAEGAMLNCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 HOGPONPHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 PINFAMBDNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 KPBLNJFJHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public AAPHKEEKNOB JNIOPNJMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public BPIGAGECDKB NBMBHAFDNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public List<BPIGAGECDKB> BGFIAHAGFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool JMFMNIMENJB;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC220", Offset = "0x6DBAC20", VA = "0x186DBC220")]
	public BPIGAGECDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC0B0", Offset = "0x6DBAAB0", VA = "0x186DBC0B0")]
	public void IMLJIONIHGH(BPIGAGECDKB FHMNKMMPPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	public void PLEMKMGHODL(int KAIHFOIADAP, MFDGOFGAOKA JCOFBGIAPCH, int BBLLECPFLID = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBD90", Offset = "0x6DBA790", VA = "0x186DBBD90")]
	public void BFMIBMJFOMN(List<byte> AAEAAONCDDP, Vector3 PCPIJKGKPCE, float CEPLKNPDDDB, float GKCOCGPGNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBFF0", Offset = "0x6DBA9F0", VA = "0x186DBBFF0")]
	public bool DFCNKGMMPFJ(Vector3 MODBPDPODDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC1F0", Offset = "0x6DBABF0", VA = "0x186DBC1F0")]
	public bool KIKCHMJLDMJ(Vector3 MODBPDPODDG, float FKHMMJOIADJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC020", Offset = "0x6DBAA20", VA = "0x186DBC020")]
	public void GCHKJEOLKFE()
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
		public struct DCKFHJIDIKH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private readonly List<Component> HIOONLIPGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly bool BAIMMGEKILE;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1239B30", Offset = "0x1238530", VA = "0x181239B30")]
			public DCKFHJIDIKH(List<Component> HIOONLIPGID, bool BAIMMGEKILE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5C76D50", Offset = "0x5C75750", VA = "0x185C76D50")]
			public LDEBKACKKJL<T> CBLJDKEPCGL()
			{
				return default(LDEBKACKKJL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5C76DC0", Offset = "0x5C757C0", VA = "0x185C76DC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x5C76DC0", Offset = "0x5C757C0", VA = "0x185C76DC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct LDEBKACKKJL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly List<Component> HIOONLIPGID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly bool BAIMMGEKILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private int GCBONJOGHCD;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public T MKGDHLFFCEG
			{
				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x465B660", Offset = "0x465A060", VA = "0x18465B660", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x465B5F0", Offset = "0x4659FF0", VA = "0x18465B5F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x465B630", Offset = "0x465A030", VA = "0x18465B630")]
			public LDEBKACKKJL(List<Component> HIOONLIPGID, bool BAIMMGEKILE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x465B530", Offset = "0x4659F30", VA = "0x18465B530", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x465B540", Offset = "0x4659F40", VA = "0x18465B540", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x3BFA010", Offset = "0x3BF8A10", VA = "0x183BFA010", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x6DC1C00", Offset = "0x6DC0600", VA = "0x186DC1C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1630", Offset = "0x6DC0030", VA = "0x186DC1630")]
		private void GCHKJEOLKFE(GameObject KKGOMHMPOAA, bool DEDPJAGPBOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6DC15A0", Offset = "0x6DBFFA0", VA = "0x186DC15A0")]
		public static void GCHKJEOLKFE(GameObject KKGOMHMPOAA, ToolHierarchyCache CAMFPBAFKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1B60", Offset = "0x6DC0560", VA = "0x186DC1B60")]
		public void NOMFBABEPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x320D760", Offset = "0x320C160", VA = "0x18320D760")]
		public void JBPJKINHDPM<T>(Action<T> EFFBNJEBEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x320D6C0", Offset = "0x320C0C0", VA = "0x18320D6C0")]
		public T CPPCNGBJMPI<T>(bool BAIMMGEKILE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x320D9A0", Offset = "0x320C3A0", VA = "0x18320D9A0")]
		public DCKFHJIDIKH<T> LLCGGKKGDBJ<T>(bool BAIMMGEKILE = false) where T : class
		{
			return default(DCKFHJIDIKH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1810", Offset = "0x6DC0210", VA = "0x186DC1810")]
		public List<Component> INEDCKNMFBF(Type BKKHBFLPOHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6DC1520", Offset = "0x6DBFF20", VA = "0x186DC1520", Slot = "4")]
		public bool Equals(ToolHierarchyCache PMBJFHIMJKC, ToolHierarchyCache HBABDGBANAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6DC17A0", Offset = "0x6DC01A0", VA = "0x186DC17A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BBNKFKDCOLP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class GIDPOJEJLGA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int LFENHKJMLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int NEILCFHAFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<T> IMBCPMLJKOM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x410A050", Offset = "0x4108A50", VA = "0x18410A050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public T CKLAOGMBBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x410A380", Offset = "0x4108D80", VA = "0x18410A380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public T IIGDEINBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x410A190", Offset = "0x4108B90", VA = "0x18410A190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public T OFLPECHKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x410A8C0", Offset = "0x41092C0", VA = "0x18410A8C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x410A940", Offset = "0x4109340", VA = "0x18410A940")]
	public GIDPOJEJLGA(int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x410A570", Offset = "0x4108F70", VA = "0x18410A570")]
	public void NOEGDDICEDP(T MFAEBMNFDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4109FF0", Offset = "0x41089F0", VA = "0x184109FF0")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x410A470", Offset = "0x4108E70", VA = "0x18410A470")]
	public void MMJCENKOBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x410A0B0", Offset = "0x4108AB0", VA = "0x18410A0B0")]
	public void IBBLGKCPCPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x410A460", Offset = "0x4108E60", VA = "0x18410A460")]
	public void LNKCMPPDOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x410A210", Offset = "0x4108C10", VA = "0x18410A210")]
	public List<T> JGLHJCCHHCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class FLHAJBLKMDB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct BJPJEJCCKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int NIPGNMFIFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public T IPHIEALFCML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Dictionary<object, BJPJEJCCKKP> ANMHHNMKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly EqualityComparer<T> FEAJKMEJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private T DEKMFNJNEPJ;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public virtual T LLAPKIGPKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9C84B0", Offset = "0x9C6EB0", VA = "0x1809C84B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3FC31E0", Offset = "0x3FC1BE0", VA = "0x183FC31E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool ACLKAEHDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3FBEB20", Offset = "0x3FBD520", VA = "0x183FBEB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public object OAPAKMGONHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0070", Offset = "0x3FBEA70", VA = "0x183FC0070")]
	public bool IMKENKPFHBD(T PKCLPFEIPFH, object AICEIDIHFDO, int OFKEGOMNGIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3FBEB80", Offset = "0x3FBD580", VA = "0x183FBEB80")]
	public bool FMABBGOMMKF(object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3FBECD0", Offset = "0x3FBD6D0", VA = "0x183FBECD0")]
	public bool HPCEHODMPGB(object AICEIDIHFDO, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3B8ECF0", Offset = "0x3B8D6F0", VA = "0x183B8ECF0")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1DD0", Offset = "0x3FC07D0", VA = "0x183FC1DD0")]
	private bool JAIMCEGPNAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC32A0", Offset = "0x3FC1CA0", VA = "0x183FC32A0")]
	public FLHAJBLKMDB()
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
